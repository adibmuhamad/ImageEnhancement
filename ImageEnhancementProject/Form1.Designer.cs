namespace ImageEnhancementProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourceImg = new System.Windows.Forms.PictureBox();
            this.resultImg = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.offsetTracker = new System.Windows.Forms.TrackBar();
            this.txtOffsetValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.Label();
            this.txtColorDepth = new System.Windows.Forms.Label();
            this.txtShiftValue = new System.Windows.Forms.Label();
            this.shiftTracker = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.inputAmpli = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.copyOfImage = new System.Windows.Forms.GroupBox();
            this.copyOfImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sourceImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftTracker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAmpli)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.copyOfImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copyOfImg)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceImg
            // 
            this.sourceImg.Location = new System.Drawing.Point(10, 21);
            this.sourceImg.Name = "sourceImg";
            this.sourceImg.Size = new System.Drawing.Size(276, 229);
            this.sourceImg.TabIndex = 0;
            this.sourceImg.TabStop = false;
            // 
            // resultImg
            // 
            this.resultImg.Location = new System.Drawing.Point(11, 21);
            this.resultImg.Name = "resultImg";
            this.resultImg.Size = new System.Drawing.Size(276, 229);
            this.resultImg.TabIndex = 1;
            this.resultImg.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(26, 290);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(101, 23);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Load Image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(359, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Offset";
            // 
            // offsetTracker
            // 
            this.offsetTracker.Location = new System.Drawing.Point(400, 290);
            this.offsetTracker.Maximum = 100;
            this.offsetTracker.Minimum = -100;
            this.offsetTracker.Name = "offsetTracker";
            this.offsetTracker.Size = new System.Drawing.Size(214, 45);
            this.offsetTracker.SmallChange = 5;
            this.offsetTracker.TabIndex = 4;
            this.offsetTracker.Scroll += new System.EventHandler(this.offsetTracker_Scroll);
            this.offsetTracker.ValueChanged += new System.EventHandler(this.offset);
            // 
            // txtOffsetValue
            // 
            this.txtOffsetValue.AutoSize = true;
            this.txtOffsetValue.Location = new System.Drawing.Point(615, 295);
            this.txtOffsetValue.Name = "txtOffsetValue";
            this.txtOffsetValue.Size = new System.Drawing.Size(13, 13);
            this.txtOffsetValue.TabIndex = 5;
            this.txtOffsetValue.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Color Depth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Height";
            // 
            // txtWidth
            // 
            this.txtWidth.AutoSize = true;
            this.txtWidth.Location = new System.Drawing.Point(94, 334);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(0, 13);
            this.txtWidth.TabIndex = 9;
            // 
            // txtHeight
            // 
            this.txtHeight.AutoSize = true;
            this.txtHeight.Location = new System.Drawing.Point(94, 357);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(0, 13);
            this.txtHeight.TabIndex = 10;
            // 
            // txtColorDepth
            // 
            this.txtColorDepth.AutoSize = true;
            this.txtColorDepth.Location = new System.Drawing.Point(94, 379);
            this.txtColorDepth.Name = "txtColorDepth";
            this.txtColorDepth.Size = new System.Drawing.Size(0, 13);
            this.txtColorDepth.TabIndex = 11;
            // 
            // txtShiftValue
            // 
            this.txtShiftValue.AutoSize = true;
            this.txtShiftValue.Location = new System.Drawing.Point(615, 340);
            this.txtShiftValue.Name = "txtShiftValue";
            this.txtShiftValue.Size = new System.Drawing.Size(13, 13);
            this.txtShiftValue.TabIndex = 14;
            this.txtShiftValue.Text = "0";
            // 
            // shiftTracker
            // 
            this.shiftTracker.Location = new System.Drawing.Point(400, 335);
            this.shiftTracker.Maximum = 255;
            this.shiftTracker.Minimum = -255;
            this.shiftTracker.Name = "shiftTracker";
            this.shiftTracker.Size = new System.Drawing.Size(214, 45);
            this.shiftTracker.TabIndex = 13;
            this.shiftTracker.Scroll += new System.EventHandler(this.shiftTracker_Scroll);
            this.shiftTracker.ValueChanged += new System.EventHandler(this.shift);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Shift";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(663, 292);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Amplification";
            // 
            // inputAmpli
            // 
            this.inputAmpli.DecimalPlaces = 1;
            this.inputAmpli.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.inputAmpli.Location = new System.Drawing.Point(752, 290);
            this.inputAmpli.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.inputAmpli.Name = "inputAmpli";
            this.inputAmpli.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inputAmpli.Size = new System.Drawing.Size(120, 20);
            this.inputAmpli.TabIndex = 21;
            this.inputAmpli.ValueChanged += new System.EventHandler(this.amplification);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(158, 290);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sourceImg);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 261);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Original Image";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.resultImg);
            this.groupBox2.Location = new System.Drawing.Point(657, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 261);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result Image";
            // 
            // copyOfImage
            // 
            this.copyOfImage.Controls.Add(this.copyOfImg);
            this.copyOfImage.Location = new System.Drawing.Point(343, 12);
            this.copyOfImage.Name = "copyOfImage";
            this.copyOfImage.Size = new System.Drawing.Size(296, 261);
            this.copyOfImage.TabIndex = 25;
            this.copyOfImage.TabStop = false;
            this.copyOfImage.Text = "Copy of Image";
            // 
            // copyOfImg
            // 
            this.copyOfImg.Location = new System.Drawing.Point(11, 21);
            this.copyOfImg.Name = "copyOfImg";
            this.copyOfImg.Size = new System.Drawing.Size(276, 229);
            this.copyOfImg.TabIndex = 1;
            this.copyOfImg.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 416);
            this.Controls.Add(this.copyOfImage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.inputAmpli);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtShiftValue);
            this.Controls.Add(this.shiftTracker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtColorDepth);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOffsetValue);
            this.Controls.Add(this.offsetTracker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpen);
            this.Name = "Form1";
            this.Text = "Image Enhancement";
            ((System.ComponentModel.ISupportInitialize)(this.sourceImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.offsetTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shiftTracker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputAmpli)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.copyOfImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.copyOfImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sourceImg;
        private System.Windows.Forms.PictureBox resultImg;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar offsetTracker;
        private System.Windows.Forms.Label txtOffsetValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtWidth;
        private System.Windows.Forms.Label txtHeight;
        private System.Windows.Forms.Label txtColorDepth;
        private System.Windows.Forms.Label txtShiftValue;
        private System.Windows.Forms.TrackBar shiftTracker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown inputAmpli;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox copyOfImage;
        private System.Windows.Forms.PictureBox copyOfImg;
    }
}

