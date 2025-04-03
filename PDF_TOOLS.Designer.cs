namespace DC_Tools
{
    partial class PDF_TOOLS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDF_TOOLS));
            pictureBox2 = new PictureBox();
            EXIT = new Button();
            SPLIT_PDF = new Button();
            MERGE_PDF = new Button();
            TO_MAIN_MENU = new Button();
            btnOpenFolder = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(21, 21);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(219, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // EXIT
            // 
            EXIT.Location = new Point(72, 342);
            EXIT.Name = "EXIT";
            EXIT.Size = new Size(116, 42);
            EXIT.TabIndex = 14;
            EXIT.Text = "EXIT";
            EXIT.UseVisualStyleBackColor = true;
            EXIT.Click += EXIT_Click;
            // 
            // SPLIT_PDF
            // 
            SPLIT_PDF.Location = new Point(72, 221);
            SPLIT_PDF.Name = "SPLIT_PDF";
            SPLIT_PDF.Size = new Size(116, 42);
            SPLIT_PDF.TabIndex = 13;
            SPLIT_PDF.Text = "SPLIT PDF";
            SPLIT_PDF.UseVisualStyleBackColor = true;
            SPLIT_PDF.Click += SPLIT_PDF_Click;
            // 
            // MERGE_PDF
            // 
            MERGE_PDF.Location = new Point(72, 173);
            MERGE_PDF.Name = "MERGE_PDF";
            MERGE_PDF.Size = new Size(116, 42);
            MERGE_PDF.TabIndex = 12;
            MERGE_PDF.Text = "MERGE PDF";
            MERGE_PDF.UseVisualStyleBackColor = true;
            MERGE_PDF.Click += MERGE_PDF_Click;
            // 
            // TO_MAIN_MENU
            // 
            TO_MAIN_MENU.Location = new Point(72, 125);
            TO_MAIN_MENU.Name = "TO_MAIN_MENU";
            TO_MAIN_MENU.Size = new Size(116, 42);
            TO_MAIN_MENU.TabIndex = 11;
            TO_MAIN_MENU.Text = "MAIN MENU";
            TO_MAIN_MENU.UseVisualStyleBackColor = true;
            TO_MAIN_MENU.Click += TO_MAIN_MENU_Click;
            // 
            // btnOpenFolder
            // 
            btnOpenFolder.Location = new Point(72, 269);
            btnOpenFolder.Name = "btnOpenFolder";
            btnOpenFolder.Size = new Size(116, 42);
            btnOpenFolder.TabIndex = 16;
            btnOpenFolder.Text = "OPEN FOLDER";
            btnOpenFolder.UseVisualStyleBackColor = true;
            btnOpenFolder.Click += btnOpenFolder_Click;
            // 
            // PDF_TOOLS
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(261, 417);
            ControlBox = false;
            Controls.Add(btnOpenFolder);
            Controls.Add(pictureBox2);
            Controls.Add(EXIT);
            Controls.Add(SPLIT_PDF);
            Controls.Add(MERGE_PDF);
            Controls.Add(TO_MAIN_MENU);
            Font = new Font("Segoe UI", 8.25F);
            MaximizeBox = false;
            Name = "PDF_TOOLS";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Button EXIT;
        private Button SPLIT_PDF;
        private Button MERGE_PDF;
        private Button TO_MAIN_MENU;
        private Button btnOpenFolder;
    }
}