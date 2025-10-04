namespace DC_Tools
{
    partial class FILE_TOOLS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FILE_TOOLS));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox2 = new PictureBox();
            btnExit = new Button();
            btnCopyFiles = new Button();
            btnPaste = new Button();
            btnMainMenu = new Button();
            dgvFileSystem = new DataGridView();
            OriginalFile = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            FilewithExtension = new DataGridViewTextBoxColumn();
            btnClear = new Button();
            txtExtension = new TextBox();
            label1 = new Label();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFileSystem).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 20;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnExit
            // 
            btnExit.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExit.BackColor = Color.WhiteSmoke;
            btnExit.Location = new Point(54, 375);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(103, 37);
            btnExit.TabIndex = 19;
            btnExit.Text = "EXIT";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnCopyFiles
            // 
            btnCopyFiles.Location = new Point(54, 204);
            btnCopyFiles.Name = "btnCopyFiles";
            btnCopyFiles.Size = new Size(103, 37);
            btnCopyFiles.TabIndex = 18;
            btnCopyFiles.Text = "COPY";
            btnCopyFiles.UseVisualStyleBackColor = true;
            btnCopyFiles.Click += btnCopyFiles_Click;
            // 
            // btnPaste
            // 
            btnPaste.Location = new Point(54, 161);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(103, 37);
            btnPaste.TabIndex = 17;
            btnPaste.Text = "PASTE";
            btnPaste.UseVisualStyleBackColor = true;
            btnPaste.Click += btnPaste_Click;
            // 
            // btnMainMenu
            // 
            btnMainMenu.Location = new Point(54, 118);
            btnMainMenu.Name = "btnMainMenu";
            btnMainMenu.Size = new Size(103, 37);
            btnMainMenu.TabIndex = 16;
            btnMainMenu.Text = "MAIN MENU";
            btnMainMenu.UseVisualStyleBackColor = true;
            btnMainMenu.Click += btnMainMenu_Click;
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
            dgvFileSystem.Location = new Point(227, 12);
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
            dgvFileSystem.TabIndex = 22;
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
            // btnClear
            // 
            btnClear.Location = new Point(54, 247);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 37);
            btnClear.TabIndex = 23;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtExtension
            // 
            txtExtension.Location = new Point(377, 415);
            txtExtension.Name = "txtExtension";
            txtExtension.Size = new Size(41, 23);
            txtExtension.TabIndex = 24;
            txtExtension.Text = "PDF";
            txtExtension.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(227, 418);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 25;
            label1.Text = "INPUT EXTENTION NAME ";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(424, 415);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(447, 23);
            progressBar1.TabIndex = 26;
            // 
            // FILE_TOOLS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 450);
            ControlBox = false;
            Controls.Add(progressBar1);
            Controls.Add(label1);
            Controls.Add(txtExtension);
            Controls.Add(btnClear);
            Controls.Add(dgvFileSystem);
            Controls.Add(pictureBox2);
            Controls.Add(btnExit);
            Controls.Add(btnCopyFiles);
            Controls.Add(btnPaste);
            Controls.Add(btnMainMenu);
            Name = "FILE_TOOLS";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFileSystem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Button btnExit;
        private Button btnCopyFiles;
        private Button btnPaste;
        private Button btnMainMenu;
        private DataGridView dgvFileSystem;
        private Button btnClear;
        private TextBox txtExtension;
        private Label label1;
        private DataGridViewTextBoxColumn OriginalFile;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn FilewithExtension;
        private ProgressBar progressBar1;
    }
}