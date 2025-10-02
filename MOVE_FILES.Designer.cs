namespace DC_Tools
{
    partial class MOVE_FILES
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MOVE_FILES));
            dgvFileSystem = new DataGridView();
            OriginalFile = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            FilewithExtension = new DataGridViewTextBoxColumn();
            btnOpenDestinationFolder = new Button();
            pictureBox2 = new PictureBox();
            btnExit = new Button();
            btnMoveFiles = new Button();
            btnPaste = new Button();
            btnMainMenu = new Button();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            txtExtension = new TextBox();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvFileSystem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvFileSystem
            // 
            dgvFileSystem.AllowUserToDeleteRows = false;
            dgvFileSystem.AllowUserToResizeColumns = false;
            dgvFileSystem.AllowUserToResizeRows = false;
            dgvFileSystem.BackgroundColor = Color.FromArgb(212, 241, 244);
            dgvFileSystem.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvFileSystem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvFileSystem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFileSystem.Columns.AddRange(new DataGridViewColumn[] { OriginalFile, Status, FilewithExtension });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvFileSystem.DefaultCellStyle = dataGridViewCellStyle2;
            dgvFileSystem.EnableHeadersVisualStyles = false;
            dgvFileSystem.ImeMode = ImeMode.Disable;
            dgvFileSystem.Location = new Point(228, 41);
            dgvFileSystem.Name = "dgvFileSystem";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvFileSystem.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvFileSystem.ScrollBars = ScrollBars.Vertical;
            dgvFileSystem.Size = new Size(644, 397);
            dgvFileSystem.TabIndex = 33;
            // 
            // OriginalFile
            // 
            OriginalFile.HeaderText = "FILE NAME";
            OriginalFile.Name = "OriginalFile";
            OriginalFile.Resizable = DataGridViewTriState.False;
            OriginalFile.Width = 200;
            // 
            // Status
            // 
            Status.HeaderText = "STATUS";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Resizable = DataGridViewTriState.False;
            Status.Width = 150;
            // 
            // FilewithExtension
            // 
            FilewithExtension.HeaderText = "Filename With Extention";
            FilewithExtension.Name = "FilewithExtension";
            FilewithExtension.Width = 250;
            // 
            // btnOpenDestinationFolder
            // 
            btnOpenDestinationFolder.Location = new Point(60, 243);
            btnOpenDestinationFolder.Name = "btnOpenDestinationFolder";
            btnOpenDestinationFolder.Size = new Size(103, 37);
            btnOpenDestinationFolder.TabIndex = 32;
            btnOpenDestinationFolder.Text = "OPEN FOLDER";
            btnOpenDestinationFolder.UseVisualStyleBackColor = true;
            btnOpenDestinationFolder.Click += btnOpenDestinationFolder_Click_1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 31;
            pictureBox2.TabStop = false;
            // 
            // btnExit
            // 
            btnExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExit.BackColor = Color.WhiteSmoke;
            btnExit.Location = new Point(60, 375);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(103, 37);
            btnExit.TabIndex = 30;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click_1;
            // 
            // btnMoveFiles
            // 
            btnMoveFiles.Location = new Point(60, 200);
            btnMoveFiles.Name = "btnMoveFiles";
            btnMoveFiles.Size = new Size(103, 37);
            btnMoveFiles.TabIndex = 29;
            btnMoveFiles.Text = "MOVE FILES";
            btnMoveFiles.UseVisualStyleBackColor = true;
            btnMoveFiles.Click += btnMoveFiles_Click;
            // 
            // btnPaste
            // 
            btnPaste.Location = new Point(60, 157);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(103, 37);
            btnPaste.TabIndex = 28;
            btnPaste.Text = "PASTE";
            btnPaste.UseVisualStyleBackColor = true;
            btnPaste.Click += btnPaste_Click_1;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(60, 114);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(103, 37);
            btnMainMenu.TabIndex = 27;
            btnMainMenu.Text = "MAIN MENU";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click_1;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(444, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(428, 23);
            progressBar1.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(247, 15);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 36;
            label1.Text = "INPUT EXTENTION NAME ";
            // 
            // txtExtension
            // 
            txtExtension.Location = new Point(397, 12);
            txtExtension.Name = "txtExtension";
            txtExtension.Size = new Size(41, 23);
            txtExtension.TabIndex = 35;
            txtExtension.Text = "PDF";
            txtExtension.TextAlign = HorizontalAlignment.Center;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(60, 286);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 37);
            btnClear.TabIndex = 34;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click_1;
            // 
            // MOVE_FILES
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 450);
            Controls.Add(dgvFileSystem);
            Controls.Add(btnOpenDestinationFolder);
            Controls.Add(pictureBox2);
            Controls.Add(btnExit);
            Controls.Add(btnMoveFiles);
            Controls.Add(btnPaste);
            Controls.Add(btnMainMenu);
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(txtExtension);
            Controls.Add(btnClear);
            Name = "MOVE_FILES";
            Text = "MOVE FILES";
            ((System.ComponentModel.ISupportInitialize)dgvFileSystem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvFileSystem;
        private DataGridViewTextBoxColumn OriginalFile;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn FilewithExtension;
        private Button btnOpenDestinationFolder;
        private PictureBox pictureBox2;
        private Button btnExit;
        private Button btnMoveFiles;
        private Button btnPaste;
        private Button btnMainMenu;
        private ProgressBar progressBar1;
        private Label label1;
        private TextBox txtExtension;
        private Button btnClear;
    }
}