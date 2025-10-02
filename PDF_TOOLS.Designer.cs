namespace DC_Tools
{
    partial class PDF_TOOLS
    {

        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PDF_TOOLS));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            pictureBox2 = new PictureBox();
            EXIT = new Button();
            SPLIT_PDF = new Button();
            btnSelectMergeFiles = new Button();
            TO_MAIN_MENU = new Button();
            dgvPdfTools = new DataGridView();
            PDFprogressBar = new ProgressBar();
            btnMergeOrdered = new Button();
            FileName = new DataGridViewTextBoxColumn();
            Order = new DataGridViewTextBoxColumn();
            FullPath = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPdfTools).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 80);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // EXIT
            // 
            EXIT.Location = new Point(54, 375);
            EXIT.Name = "EXIT";
            EXIT.Size = new Size(103, 37);
            EXIT.TabIndex = 14;
            EXIT.Text = "EXIT";
            EXIT.UseVisualStyleBackColor = true;
            EXIT.Click += EXIT_Click;
            // 
            // SPLIT_PDF
            // 
            SPLIT_PDF.Location = new Point(54, 247);
            SPLIT_PDF.Name = "SPLIT_PDF";
            SPLIT_PDF.Size = new Size(103, 37);
            SPLIT_PDF.TabIndex = 13;
            SPLIT_PDF.Text = "SPLIT PDF";
            SPLIT_PDF.UseVisualStyleBackColor = true;
            SPLIT_PDF.Click += SPLIT_PDF_Click;
            // 
            // btnSelectMergeFiles
            // 
            btnSelectMergeFiles.Location = new Point(54, 161);
            btnSelectMergeFiles.Name = "btnSelectMergeFiles";
            btnSelectMergeFiles.Size = new Size(103, 37);
            btnSelectMergeFiles.TabIndex = 12;
            btnSelectMergeFiles.Text = "SELECT MERGE FILES";
            btnSelectMergeFiles.UseVisualStyleBackColor = true;
            btnSelectMergeFiles.Click += MERGE_PDF_Click;
            // 
            // TO_MAIN_MENU
            // 
            TO_MAIN_MENU.Location = new Point(54, 118);
            TO_MAIN_MENU.Name = "TO_MAIN_MENU";
            TO_MAIN_MENU.Size = new Size(103, 37);
            TO_MAIN_MENU.TabIndex = 11;
            TO_MAIN_MENU.Text = "MAIN MENU";
            TO_MAIN_MENU.UseVisualStyleBackColor = true;
            TO_MAIN_MENU.Click += TO_MAIN_MENU_Click;
            // 
            // dgvPdfTools
            // 
            dgvPdfTools.AllowUserToDeleteRows = false;
            dgvPdfTools.AllowUserToResizeColumns = false;
            dgvPdfTools.AllowUserToResizeRows = false;
            dgvPdfTools.BackgroundColor = Color.FromArgb(212, 241, 244);
            dgvPdfTools.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvPdfTools.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvPdfTools.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPdfTools.Columns.AddRange(new DataGridViewColumn[] { FileName, Order, FullPath });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPdfTools.DefaultCellStyle = dataGridViewCellStyle2;
            dgvPdfTools.EnableHeadersVisualStyles = false;
            dgvPdfTools.ImeMode = ImeMode.Disable;
            dgvPdfTools.Location = new Point(228, 12);
            dgvPdfTools.Name = "dgvPdfTools";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvPdfTools.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvPdfTools.ScrollBars = ScrollBars.Vertical;
            dgvPdfTools.Size = new Size(644, 393);
            dgvPdfTools.TabIndex = 23;
            // 
            // PDFprogressBar
            // 
            PDFprogressBar.Location = new Point(228, 415);
            PDFprogressBar.Name = "PDFprogressBar";
            PDFprogressBar.Size = new Size(644, 23);
            PDFprogressBar.TabIndex = 27;
            // 
            // btnMergeOrdered
            // 
            btnMergeOrdered.Location = new Point(54, 204);
            btnMergeOrdered.Name = "btnMergeOrdered";
            btnMergeOrdered.Size = new Size(103, 37);
            btnMergeOrdered.TabIndex = 28;
            btnMergeOrdered.Text = "MERGE FILES";
            btnMergeOrdered.UseVisualStyleBackColor = true;
            btnMergeOrdered.Click += btnMergeOrdered_Click;
            // 
            // FileName
            // 
            FileName.HeaderText = "FileName";
            FileName.Name = "FileName";
            FileName.Width = 500;
            // 
            // Order
            // 
            Order.HeaderText = "Order";
            Order.Name = "Order";
            // 
            // FullPath
            // 
            FullPath.HeaderText = "FullPath";
            FullPath.Name = "FullPath";
            FullPath.Visible = false;
            // 
            // PDF_TOOLS
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(884, 450);
            ControlBox = false;
            Controls.Add(btnMergeOrdered);
            Controls.Add(PDFprogressBar);
            Controls.Add(dgvPdfTools);
            Controls.Add(pictureBox2);
            Controls.Add(EXIT);
            Controls.Add(SPLIT_PDF);
            Controls.Add(btnSelectMergeFiles);
            Controls.Add(TO_MAIN_MENU);
            Font = new Font("Segoe UI", 8.25F);
            MaximizeBox = false;
            Name = "PDF_TOOLS";
            ShowIcon = false;
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPdfTools).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Button EXIT;
        private Button SPLIT_PDF;
        private Button btnSelectMergeFiles;
        private Button TO_MAIN_MENU;
        private DataGridView dgvPdfTools;
        private ProgressBar PDFprogressBar;
        private Button btnMergeOrdered;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewTextBoxColumn Order;
        private DataGridViewTextBoxColumn FullPath;
    }
}