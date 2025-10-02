using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DC_Tools
{
    public partial class PDF_TOOLS : Form
    {
        private string lastUsedFolder = string.Empty;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public PDF_TOOLS()
        {
            InitializeComponent();
            InitializeDataGridView();
            ApplyButtonStyles();
            this.FormBorderStyle = FormBorderStyle.None;
            this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += PDF_TOOLS_MouseDown;
            this.MouseMove += PDF_TOOLS_MouseMove;
            this.MouseUp += PDF_TOOLS_MouseUp;
        }



        private void InitializeDataGridView()
        {
            dgvPdfTools.Columns.Clear();
            dgvPdfTools.AllowUserToAddRows = false;
            dgvPdfTools.Columns.Add("FileName", "File Name");
            dgvPdfTools.Columns.Add("Order", "Order"); 
            dgvPdfTools.Columns.Add("FullPath", "File Path");
                        
            dgvPdfTools.Columns["FileName"].Width = 500;
            dgvPdfTools.Columns["Order"].Width = 50;
            dgvPdfTools.Columns["FullPath"].Width = 100;
          
           dgvPdfTools.Columns["Order"].ReadOnly = false;
           dgvPdfTools.Columns["FullPath"].Visible = true;
        }

        private void ApplyButtonStyles()
        {
            SetButtonHoverEffect(SPLIT_PDF, Color.Crimson);
            SetButtonHoverEffect(btnMergeOrdered, Color.DarkCyan);
            SetButtonHoverEffect(EXIT, Color.Red);
            SetButtonHoverEffect(TO_MAIN_MENU, Color.DarkBlue);
            SetButtonHoverEffect(btnSelectMergeFiles, Color.DarkOrange);

            ApplyRoundedEdges(SPLIT_PDF);
            ApplyRoundedEdges(btnMergeOrdered);
            ApplyRoundedEdges(EXIT);
            ApplyRoundedEdges(TO_MAIN_MENU);
            ApplyRoundedEdges(btnSelectMergeFiles);
        }

        private void ApplyRoundedEdges(Button button)
        {
            int radius = 20;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius, button.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            button.Region = new Region(path);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int radius = 30;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

            using (Pen blackPen = new Pen(Color.RoyalBlue, 10))
            {
                e.Graphics.DrawPath(blackPen, path);
            }

            base.OnPaint(e);
        }

        private void SetButtonHoverEffect(Button button, Color hoverColor)
        {
            Color originalColor = button.BackColor;
            button.MouseEnter += (sender, e) =>
            {
                button.BackColor = hoverColor;
                button.ForeColor = Color.White;
            };
            button.MouseLeave += (sender, e) =>
            {
                button.BackColor = originalColor;
                button.ForeColor = Color.Black;
            };
        }

        private void MERGE_PDF_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "PDF Files|*.pdf",
                Multiselect = true
            })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    dgvPdfTools.Rows.Clear();
                    int order = 1;
                    foreach (string file in openFileDialog.FileNames)
                    {
                        dgvPdfTools.Rows.Add(Path.GetFileName(file), file, order++);
                    }

                    lastUsedFolder = Path.GetDirectoryName(openFileDialog.FileNames.First());
                }
            }
        }

        private void btnMergeOrdered_Click(object sender, EventArgs e)
        {
            if (dgvPdfTools.Rows.Count == 0)
            {
                MessageBox.Show("No PDFs listed for merging.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            for (int i = dgvPdfTools.Rows.Count - 2; i >= 0; i--)
            {
                var row = dgvPdfTools.Rows[i];

                if (row.Cells["Order"].Value == null ||
                    row.Cells["FullPath"].Value == null ||
                    string.IsNullOrWhiteSpace(row.Cells["Order"].Value.ToString()) ||
                    string.IsNullOrWhiteSpace(row.Cells["FullPath"].Value.ToString()))
                {
                    dgvPdfTools.Rows.RemoveAt(i);
                }
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "PDF File|*.pdf" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string targetPath = saveFileDialog.FileName;
                    PDFprogressBar.Value = 0;

                    try
                    {
                        var orderedFiles = dgvPdfTools.Rows.Cast<DataGridViewRow>()
                            .Where(row =>
                                row.Cells["Order"].Value != null &&
                                row.Cells["FullPath"].Value != null &&
                                int.TryParse(row.Cells["Order"].Value.ToString(), out _))
                            .OrderBy(row => Convert.ToInt32(row.Cells["Order"].Value))
                            .Select(row => row.Cells["FullPath"].Value.ToString())
                            .ToArray();

                        if (orderedFiles.Length == 0)
                        {
                            MessageBox.Show("No valid PDF paths found to merge.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        MergeMultiplePDFs(orderedFiles, targetPath);
                        PDFprogressBar.Value = 100;

                        if (File.Exists(targetPath))
                        {
                            MessageBox.Show("PDFs merged and saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Process.Start("explorer.exe", Path.GetDirectoryName(targetPath));
                        }
                        else
                        {
                            MessageBox.Show("Merge completed but file was not created.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Merge failed: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void MergeMultiplePDFs(string[] fileNames, string targetPath)
        {
            lastUsedFolder = Path.GetDirectoryName(targetPath);

            try
            {
                using (FileStream stream = new FileStream(targetPath, FileMode.Create, FileAccess.Write))
                using (Document document = new Document())
                using (PdfCopy pdf = new PdfCopy(document, stream))
                {
                    document.Open();
                    int totalFiles = fileNames.Length;
                    int fileIndex = 0;

                    foreach (string file in fileNames)
                    {
                        fileIndex++;
                        if (!File.Exists(file)) continue;

                        using (PdfReader reader = new PdfReader(file))
                        {
                            for (int i = 1; i <= reader.NumberOfPages; i++)
                            {
                                pdf.AddPage(pdf.GetImportedPage(reader, i));
                            }
                        }

                        PDFprogressBar.Value = (int)((fileIndex / (float)totalFiles) * 100);
                        PDFprogressBar.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error merging PDF files: " + ex.Message, "Merge Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SPLIT_PDF_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "PDF Files|*.pdf" })
                using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK && folderDialog.ShowDialog() == DialogResult.OK)
                    {
                        SplitPDF(openFileDialog.FileName, folderDialog.SelectedPath);
                        MessageBox.Show("PDF split successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Process.Start("explorer.exe", lastUsedFolder);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error splitting PDF: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void SplitPDF(string sourcePath, string outputPath)
        {
            lastUsedFolder = outputPath;
            using (PdfReader reader = new PdfReader(sourcePath))
            {
                int totalPages = reader.NumberOfPages;
                PDFprogressBar.Value = 0;

                for (int pageNumber = 1; pageNumber <= totalPages; pageNumber++)
                {
                    string newFile = Path.Combine(outputPath, $"Page_{pageNumber}.pdf");

                    using (Document document = new Document(reader.GetPageSizeWithRotation(pageNumber)))
                    using (FileStream stream = new FileStream(newFile, FileMode.Create))
                    using (PdfCopy pdfCopy = new PdfCopy(document, stream))
                    {
                        document.Open();
                        pdfCopy.AddPage(pdfCopy.GetImportedPage(reader, pageNumber));
                    }

                    PDFprogressBar.Value = (int)((pageNumber / (float)totalPages) * 100);
                    PDFprogressBar.Refresh();
                }
            }
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lastUsedFolder) && Directory.Exists(lastUsedFolder))
            {
                Process.Start("explorer.exe", lastUsedFolder);
            }
            else
            {
                MessageBox.Show("No folder has been used yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EXIT_Click(object sender, EventArgs e) => Application.Exit();

        private void TO_MAIN_MENU_Click(object sender, EventArgs e)
        {
            this.Close();
            new MAINMENU().Show();
        }

        private void PDF_TOOLS_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void PDF_TOOLS_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void PDF_TOOLS_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}