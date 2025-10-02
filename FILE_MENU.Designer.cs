namespace DC_Tools
{
    partial class FILE_MENU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FILE_MENU));
            pictureBox1 = new PictureBox();
            btnMAKE_FOLDER = new Button();
            btnFILES_TOOLS = new Button();
            btnExit1 = new Button();
            btnMoveFiles = new Button();
            btnMainMenu = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(21, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // btnMAKE_FOLDER
            // 
            btnMAKE_FOLDER.Location = new Point(76, 225);
            btnMAKE_FOLDER.Name = "btnMAKE_FOLDER";
            btnMAKE_FOLDER.Size = new Size(108, 33);
            btnMAKE_FOLDER.TabIndex = 7;
            btnMAKE_FOLDER.Text = "CREATE FOLDER";
            btnMAKE_FOLDER.UseVisualStyleBackColor = true;
            btnMAKE_FOLDER.Click += btnMAKE_FOLDER_Click;
            // 
            // btnFILES_TOOLS
            // 
            btnFILES_TOOLS.Location = new Point(76, 147);
            btnFILES_TOOLS.Name = "btnFILES_TOOLS";
            btnFILES_TOOLS.Size = new Size(108, 33);
            btnFILES_TOOLS.TabIndex = 6;
            btnFILES_TOOLS.Text = "COPY FILES";
            btnFILES_TOOLS.UseVisualStyleBackColor = true;
            btnFILES_TOOLS.Click += btnFILES_TOOLS_Click;
            // 
            // btnExit1
            // 
            btnExit1.Location = new Point(76, 279);
            btnExit1.Name = "btnExit1";
            btnExit1.Size = new Size(108, 33);
            btnExit1.TabIndex = 5;
            btnExit1.Text = "EXIT";
            btnExit1.UseVisualStyleBackColor = true;
            btnExit1.Click += btnExit1_Click;
            // 
            // btnMoveFiles
            // 
            btnMoveFiles.Location = new Point(76, 186);
            btnMoveFiles.Name = "btnMoveFiles";
            btnMoveFiles.Size = new Size(108, 33);
            btnMoveFiles.TabIndex = 10;
            btnMoveFiles.Text = "MOVE FILES";
            btnMoveFiles.UseVisualStyleBackColor = true;
            btnMoveFiles.Click += btnMoveFiles_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(76, 104);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(108, 37);
            btnMainMenu.TabIndex = 28;
            btnMainMenu.Text = "MAIN MENU";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // FILE_MENU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(261, 340);
            Controls.Add(btnMainMenu);
            Controls.Add(btnMoveFiles);
            Controls.Add(pictureBox1);
            Controls.Add(btnMAKE_FOLDER);
            Controls.Add(btnFILES_TOOLS);
            Controls.Add(btnExit1);
            Name = "FILE_MENU";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FILE_MENU";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnMAKE_FOLDER;
        private Button btnFILES_TOOLS;
        private Button btnExit1;
        private Button btnMoveFiles;
        private Button btnMainMenu;
    }
}