namespace DC_Tools
{
    partial class MAINMENU
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MAINMENU));
            btnExit = new Button();
            btnFILES_TOOLS = new Button();
            btnAbout = new Button();
            btnPDF_TOOLS = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(79, 260);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(99, 33);
            btnExit.TabIndex = 0;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnFILES_TOOLS
            // 
            btnFILES_TOOLS.Location = new Point(79, 114);
            btnFILES_TOOLS.Name = "btnFILES_TOOLS";
            btnFILES_TOOLS.Size = new Size(99, 33);
            btnFILES_TOOLS.TabIndex = 1;
            btnFILES_TOOLS.Text = "FILE TOOLS";
            btnFILES_TOOLS.UseVisualStyleBackColor = true;
            btnFILES_TOOLS.Click += btnFILES_TOOLS_Click_1;
            // 
            // btnAbout
            // 
            btnAbout.Location = new Point(79, 192);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(99, 33);
            btnAbout.TabIndex = 3;
            btnAbout.Text = "ABOUT";
            btnAbout.UseVisualStyleBackColor = true;
            btnAbout.Click += btnAbout_Click_1;
            // 
            // btnPDF_TOOLS
            // 
            btnPDF_TOOLS.Location = new Point(79, 153);
            btnPDF_TOOLS.Name = "btnPDF_TOOLS";
            btnPDF_TOOLS.Size = new Size(99, 33);
            btnPDF_TOOLS.TabIndex = 2;
            btnPDF_TOOLS.Text = "PDF TOOLS";
            btnPDF_TOOLS.UseVisualStyleBackColor = true;
            btnPDF_TOOLS.Click += btnPDF_TOOLS_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // MAINMENU
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(261, 322);
            Controls.Add(pictureBox1);
            Controls.Add(btnAbout);
            Controls.Add(btnPDF_TOOLS);
            Controls.Add(btnFILES_TOOLS);
            Controls.Add(btnExit);
            Font = new Font("Segoe UI", 8.25F);
            MaximizeBox = false;
            Name = "MAINMENU";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExit;
        private Button btnFILES_TOOLS;
        private Button btnAbout;
        private Button btnPDF_TOOLS;
        private PictureBox pictureBox1;
    }
}
