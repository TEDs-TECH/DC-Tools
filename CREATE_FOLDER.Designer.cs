namespace DC_Tools
{
    partial class CREATE_FOLDER
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CREATE_FOLDER));
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvCreateFolder = new DataGridView();
            btnOpenDestinationFolder = new Button();
            pictureBox2 = new PictureBox();
            btnExit = new Button();
            btnCreateFolder = new Button();
            btnPaste = new Button();
            btnMainMenu = new Button();
            btnClear = new Button();
            OriginalFile = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            FolderName = new DataGridViewTextBoxColumn();
            FolderLink = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCreateFolder).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvCreateFolder
            // 
            dgvCreateFolder.AllowUserToDeleteRows = false;
            dgvCreateFolder.AllowUserToResizeColumns = false;
            dgvCreateFolder.AllowUserToResizeRows = false;
            dgvCreateFolder.BackgroundColor = Color.FromArgb(212, 241, 244);
            dgvCreateFolder.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvCreateFolder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvCreateFolder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCreateFolder.Columns.AddRange(new DataGridViewColumn[] { OriginalFile, Status, FolderName, FolderLink });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.25F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvCreateFolder.DefaultCellStyle = dataGridViewCellStyle3;
            dgvCreateFolder.EnableHeadersVisualStyles = false;
            dgvCreateFolder.ImeMode = ImeMode.Disable;
            dgvCreateFolder.Location = new Point(228, 12);
            dgvCreateFolder.Name = "dgvCreateFolder";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvCreateFolder.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvCreateFolder.ScrollBars = ScrollBars.Vertical;
            dgvCreateFolder.Size = new Size(644, 426);
            dgvCreateFolder.TabIndex = 33;
            // 
            // btnOpenDestinationFolder
            // 
            btnOpenDestinationFolder.Location = new Point(60, 243);
            btnOpenDestinationFolder.Name = "btnOpenDestinationFolder";
            btnOpenDestinationFolder.Size = new Size(103, 37);
            btnOpenDestinationFolder.TabIndex = 32;
            btnOpenDestinationFolder.Text = "OPEN FOLDER";
            btnOpenDestinationFolder.UseVisualStyleBackColor = true;
            btnOpenDestinationFolder.Click += btnOpenDestinationFolder_Click;
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
            btnExit.Click += btnExit_Click;
            // 
            // btnCreateFolder
            // 
            btnCreateFolder.Location = new Point(60, 200);
            btnCreateFolder.Name = "btnCreateFolder";
            btnCreateFolder.Size = new Size(103, 37);
            btnCreateFolder.TabIndex = 29;
            btnCreateFolder.Text = "GENERATE";
            btnCreateFolder.UseVisualStyleBackColor = true;
            btnCreateFolder.Click += btnCreateFolder_Click;
            // 
            // btnPaste
            // 
            btnPaste.Location = new Point(60, 157);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(103, 37);
            btnPaste.TabIndex = 28;
            btnPaste.Text = "PASTE";
            btnPaste.UseVisualStyleBackColor = true;
            btnPaste.Click += btnPaste_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(60, 114);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(103, 37);
            btnMainMenu.TabIndex = 27;
            btnMainMenu.Text = "MAIN MENU";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(60, 286);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 37);
            btnClear.TabIndex = 34;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // OriginalFile
            // 
            OriginalFile.HeaderText = "FOLDER NAME";
            OriginalFile.Name = "OriginalFile";
            OriginalFile.Resizable = DataGridViewTriState.False;
            OriginalFile.Width = 200;
            // 
            // Status
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Status.DefaultCellStyle = dataGridViewCellStyle2;
            Status.HeaderText = "STATUS";
            Status.MaxInputLength = 10;
            Status.Name = "Status";
            Status.Resizable = DataGridViewTriState.False;
            Status.SortMode = DataGridViewColumnSortMode.Programmatic;
            // 
            // FolderName
            // 
            FolderName.HeaderText = "FOLDER NAME";
            FolderName.Name = "FolderName";
            FolderName.Visible = false;
            // 
            // FolderLink
            // 
            FolderLink.HeaderText = "FOLDER PATH";
            FolderLink.Name = "FolderLink";
            FolderLink.Width = 300;
            // 
            // CREATE_FOLDER
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 450);
            Controls.Add(dgvCreateFolder);
            Controls.Add(btnOpenDestinationFolder);
            Controls.Add(pictureBox2);
            Controls.Add(btnExit);
            Controls.Add(btnCreateFolder);
            Controls.Add(btnPaste);
            Controls.Add(btnMainMenu);
            Controls.Add(btnClear);
            Name = "CREATE_FOLDER";
            Text = "CREATE_FOLDER";
            ((System.ComponentModel.ISupportInitialize)dgvCreateFolder).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCreateFolder;
        private Button btnOpenDestinationFolder;
        private PictureBox pictureBox2;
        private Button btnExit;
        private Button btnCreateFolder;
        private Button btnPaste;
        private Button btnMainMenu;
        private Button btnClear;
        private DataGridViewTextBoxColumn OriginalFile;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn FolderName;
        private DataGridViewTextBoxColumn FolderLink;
    }
}