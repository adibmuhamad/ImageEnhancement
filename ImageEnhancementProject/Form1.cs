using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;


/*
Step ;
    1.	Copy original image into a buffered image
    2.	Offset the original image
    3.	Subtract original image with vertically shifted buffered image
    4.	Multiply the resulted image with an amplification factor
*/

namespace ImageEnhancementProject
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        Bitmap img;

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //Get image from computer
            OpenFileDialog ofile = new OpenFileDialog();
            ofile.Filter = "Image File (*.bmp,*.jpg)|*.bmp;*.jpg";

            if (DialogResult.OK == ofile.ShowDialog())
            {
                System.IO.FileInfo file = new System.IO.FileInfo(ofile.FileName);
                //in C#, System.Drawing.Bitmap is the closest one to BufferedImage
                img = new Bitmap(ofile.FileName);

                //Display image to PictureBox
                this.sourceImg.Image = img;
                sourceImg.SizeMode = PictureBoxSizeMode.StretchImage;
                this.copyOfImg.Image = img;
                copyOfImg.SizeMode = PictureBoxSizeMode.StretchImage;
                this.resultImg.Image = img;
                resultImg.SizeMode = PictureBoxSizeMode.StretchImage;

                //Display source image (known image dimension)
                this.txtWidth.Text = img.Width.ToString();
                this.txtHeight.Text = img.Height.ToString();
                this.txtColorDepth.Text = Image.GetPixelFormatSize(img.PixelFormat).ToString();

            }
        }
               
        private void offsetTracker_Scroll(object sender, EventArgs e)
        {
            txtOffsetValue.Text = offsetTracker.Value.ToString();
        }

        private void shiftTracker_Scroll(object sender, EventArgs e)
        {
            txtShiftValue.Text = shiftTracker.Value.ToString();
            
        }
         
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Create a new save file dialog object
            SaveFileDialog sfd = new SaveFileDialog(); 
            sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            // Store it in by default format
            ImageFormat format = ImageFormat.Jpeg;
            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string ext = Path.GetExtension(sfd.FileName);
                switch (ext)
                {
                    case ".jpg":
                        format = ImageFormat.Jpeg;
                        break;
                    case ".bmp":
                        format = ImageFormat.Bmp;
                        break;
                }
                resultImg.Image.Save(sfd.FileName, format);
            }
        }

        private void offset(object sender, EventArgs e)
        {
            if (img != null)
            {

                //Offset intensity of the source image (positive: increase intensity, negative: decrease)
                float offsetValue = offsetTracker.Value;
                // Get direct access to bitmap data
                BitmapData sourceData = img.LockBits(new Rectangle(0, 0,
                                            img.Width, img.Height),
                                            ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
                byte[] pixelBuffer = new byte[sourceData.Stride * sourceData.Height];

                //Copies data from an unmanaged memory pointer to a managed array
                Marshal.Copy(sourceData.Scan0, pixelBuffer, 0, pixelBuffer.Length);

                img.UnlockBits(sourceData);

                //Calculate contrast level
                double contrastLevel = Math.Pow((100.0 + offsetValue) / 100.0, 2);

                double blue = 0;
                double green = 0;
                double red = 0;

                for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
                {
                    blue = ((((pixelBuffer[k] / 255.0) - 0.5) *
                               contrastLevel) + 0.5) * 255.0;

                    green = ((((pixelBuffer[k + 1] / 255.0) - 0.5) *
                                contrastLevel) + 0.5) * 255.0;

                    red = ((((pixelBuffer[k + 2] / 255.0) - 0.5) *
                               contrastLevel) + 0.5) * 255.0;

                    if (blue > 255)
                    { blue = 255; }
                    else if (blue < 0)
                    { blue = 0; }

                    if (green > 255)
                    { green = 255; }
                    else if (green < 0)
                    { green = 0; }

                    if (red > 255)
                    { red = 255; }
                    else if (red < 0)
                    { red = 0; }

                    pixelBuffer[k] = (byte)blue;
                    pixelBuffer[k + 1] = (byte)green;
                    pixelBuffer[k + 2] = (byte)red;
                }

                Bitmap resultBitmap = new Bitmap(img.Width, img.Height);

                BitmapData resultData = resultBitmap.LockBits(new Rectangle(0, 0,
                                            resultBitmap.Width, resultBitmap.Height),
                                            ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);

                // Copy the values back to the bitmap
                Marshal.Copy(pixelBuffer, 0, resultData.Scan0, pixelBuffer.Length);
                //Release image bits
                resultBitmap.UnlockBits(resultData);

                // Display the result
                sourceImg.Image = resultBitmap;
                resultImg.Image = resultBitmap;
            }
           
        }

        private void shift(object sender, EventArgs e)
        {
            if (img != null)
            {
                //Shift: vertical direction (positive: shift up, negative: shift down)
                int shiftValue = shiftTracker.Value;

                Bitmap shiftedImage = (Bitmap)sourceImg.Image;

                Bitmap shifted = shiftedFunction((Bitmap)copyOfImg.Image, shiftValue);


                // Make a difference image.
                int width = Math.Min(shiftedImage.Width, shifted.Width);
                int height = Math.Min(shiftedImage.Height, shifted.Height);

                // Get the differences.
                int[,] diffs = new int[width, height];
                int max_diff = 0;
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        // Calculate the pixels' difference.
                        Color color1 = shiftedImage.GetPixel(x, y);
                        Color color2 = shifted.GetPixel(x, y);
                        diffs[x, y] = (int)(
                            Math.Abs(color1.R - color2.R) +
                            Math.Abs(color1.G - color2.G) +
                            Math.Abs(color1.B - color2.B));
                        if (diffs[x, y] > max_diff)
                            max_diff = diffs[x, y];
                    }
                }
                //max_diff = 255;

                //Subtract original image with vertically shifted bitmap (Copy of Image)
                Bitmap subtractImage = new Bitmap(width, height);
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        int clr = 255 - (int)(255.0 / max_diff * diffs[x, y]);
                        subtractImage.SetPixel(x, y, Color.FromArgb(clr, clr, clr));
                    }
                }

                // Display the result
                resultImg.Image = subtractImage;
            }
            
        }

        private Bitmap shiftedFunction(Bitmap image, int shiftValue)
        {
            Bitmap shifted = new Bitmap(image.Width, image.Height);
            Graphics G = Graphics.FromImage(shifted);
            //Re-draw image by shifting vertical
            G.DrawImage(image, 0, shiftValue);
            G.Dispose();

            copyOfImg.Image = shifted;
            return shifted;
        }

        private void amplification(object sender, EventArgs e)
        {
            if (img != null)
            {
                //Multiplied image by amplification factor called high boost filter. Result of high boost filter is image sharpener
                decimal ampliValue = inputAmpli.Value;

                Bitmap multiplyImage = (Bitmap)resultImg.Image;

                int width = multiplyImage.Width;
                int height = multiplyImage.Height;

                double[,] mask = new double[,]
                                 { { 255, 255, 255, },
                               { 255,  9, 255, },
                               { 255, 255, 255, }, };

                if (mask.GetLength(0) != mask.GetLength(1))
                {
                    throw new Exception("Mask dimensions must be same");
                }
                // Create sharpening filter
                int filterSize = mask.GetLength(0);

                double[,] filter = (double[,])mask.Clone();

                int channels = sizeof(byte);
                double bias = 0.0; // 1.0 - amplification factor;
                double factor = decimal.ToDouble(inputAmpli.Value); //amplification factor

                byte[,] result = new byte[multiplyImage.Width, multiplyImage.Height];

                // Lock image bits for read/write
                BitmapData bitmapData = multiplyImage.LockBits(new System.Drawing.Rectangle(0, 0, width, height),
                                                            ImageLockMode.ReadWrite,
                                                            System.Drawing.Imaging.PixelFormat.Format8bppIndexed);

                // Declare an array to hold the bytes of the bitmap
                int memorySize = bitmapData.Stride * height;
                byte[] memory = new byte[memorySize];

                // Copy the RGB values into the local array
                Marshal.Copy(bitmapData.Scan0, memory, 0, memorySize);

                int pixel;
                // Fill the color array with the new sharpened color values

                for (int y = 0; y < height; y++)
                {
                    for (int x = 0; x < width; x++)
                    {
                        double grayShade = 0.0;

                        for (int filterY = 0; filterY < filterSize; filterY++)
                        {
                            for (int filterX = 0; filterX < filterSize; filterX++)
                            {
                                int imageX = (x - filterSize / 2 + filterX + width) % width;
                                int imageY = (y - filterSize / 2 + filterY + height) % height;

                                pixel = imageY * bitmapData.Stride + channels * imageX;
                                grayShade += memory[pixel] * filter[filterX, filterY];
                            }

                            int newPixel = Math.Min(Math.Max((int)(factor * grayShade + bias), 0), 255);

                            result[x, y] = (byte)newPixel;
                        }
                    }
                }

                // Update the image with the sharpened pixels
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        pixel = y * bitmapData.Stride + channels * x;

                        memory[pixel] = result[x, y];
                    }
                }

                // Copy the values back to the bitmap
                Marshal.Copy(memory, 0, bitmapData.Scan0, memorySize);

                // Release image bits
                multiplyImage.UnlockBits(bitmapData);
                //Display image
                resultImg.Image = multiplyImage;

            }
        }
    }
}
