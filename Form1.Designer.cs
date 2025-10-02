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
            btnPDF_TOOLS = new Button();
            pictureBox1 = new PictureBox();
            btn_Others = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(76, 272);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(99, 33);
            btnExit.TabIndex = 0;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnFILES_TOOLS
            // 
            btnFILES_TOOLS.Location = new Point(76, 117);
            btnFILES_TOOLS.Name = "btnFILES_TOOLS";
            btnFILES_TOOLS.Size = new Size(99, 33);
            btnFILES_TOOLS.TabIndex = 1;
            btnFILES_TOOLS.Text = "FILE TOOLS";
            btnFILES_TOOLS.UseVisualStyleBackColor = true;
            btnFILES_TOOLS.Click += btnFILES_TOOLS_Click_1;
            // 
            // btnPDF_TOOLS
            // 
            btnPDF_TOOLS.Location = new Point(76, 156);
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btn_Others
            // 
            btn_Others.Location = new Point(76, 195);
            btn_Others.Name = "btn_Others";
            btn_Others.Size = new Size(99, 33);
            btn_Others.TabIndex = 7;
            btn_Others.Text = "OTHERS";
            btn_Others.UseVisualStyleBackColor = true;
            btn_Others.Click += btn_Others_Click;
            // 
            // MAINMENU
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(262, 364);
            Controls.Add(btnPDF_TOOLS);
            Controls.Add(btnFILES_TOOLS);
            Controls.Add(btn_Others);
            Controls.Add(pictureBox1);
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
        private Button btnPDF_TOOLS;
        private PictureBox pictureBox1;
        private Button btn_Others;
    }
}
