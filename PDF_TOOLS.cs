/*
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace DC_Tools
{
    public partial class PDF_TOOLS : Form
    {
        private string lastUsedFolder = string.Empty;

        public PDF_TOOLS()
        {
            InitializeComponent();
            ApplyButtonStyles();
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void ApplyButtonStyles()
        {
            SetButtonHoverEffect(SPLIT_PDF, Color.Crimson);
            SetButtonHoverEffect(MERGE_PDF, Color.DarkCyan);
            SetButtonHoverEffect(EXIT, Color.Red);
            SetButtonHoverEffect(TO_MAIN_MENU, Color.DarkBlue);

            ApplyRoundedEdges(SPLIT_PDF);
            ApplyRoundedEdges(MERGE_PDF);
            ApplyRoundedEdges(EXIT);
            ApplyRoundedEdges(TO_MAIN_MENU);
            ApplyRoundedEdges(btnOpenFolder);
        }

        private void ApplyRoundedEdges(Button button)
        {
            int radius = 20; // Adjust for more or less rounding
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
            int radius = 30; // Adjust the radius for more or less rounding
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
            base.OnPaint(e);
        }
        private void SetButtonHoverEffect(Button button, Color hoverColor)
        {
            button.MouseHover += (sender, e) =>
            {
                button.BackColor = hoverColor;
                button.ForeColor = Color.White;
            };

            button.MouseLeave += (sender, e) =>
            {
                button.BackColor = Color.Transparent;
                button.ForeColor = Color.Black;
            };
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x84;
            const int HTCLIENT = 1;
            const int HTCAPTION = 2;

            if (m.Msg == WM_NCHITTEST)
            {
                base.WndProc(ref m);
                if ((int)m.Result == HTCLIENT)
                    m.Result = (IntPtr)HTCAPTION;
                return;
            }

            base.WndProc(ref m);
        }

        private void MERGE_PDF_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "PDF Files|*.pdf", Multiselect = true })
                using (SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "PDF File|*.pdf" })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        MergeMultiplePDFs(openFileDialog.FileNames, saveFileDialog.FileName);
                        MessageBox.Show("PDFs merged successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error merging PDFs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MergeMultiplePDFs(string[] fileNames, string targetPath)
        {
            lastUsedFolder = Path.GetDirectoryName(targetPath);

            using (FileStream stream = new FileStream(targetPath, FileMode.Create))
            using (Document document = new Document())
            using (PdfCopy pdf = new PdfCopy(document, stream))
            {
                document.Open();
                foreach (string file in fileNames)
                {
                    using (PdfReader reader = new PdfReader(file))
                    {
                        for (int i = 1; i <= reader.NumberOfPages; i++)
                        {
                            pdf.AddPage(pdf.GetImportedPage(reader, i));
                        }
                    }
                }
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
                for (int pageNumber = 1; pageNumber <= reader.NumberOfPages; pageNumber++)
                {
                    string newFile = Path.Combine(outputPath, $"Page_{pageNumber}.pdf");
                    using (FileStream stream = new FileStream(newFile, FileMode.Create))
                    using (Document document = new Document())
                    using (PdfCopy pdfCopy = new PdfCopy(document, stream))
                    {
                        document.Open();
                        pdfCopy.AddPage(pdfCopy.GetImportedPage(reader, pageNumber));
                    }
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
    }
}
*/

using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Diagnostics;
using System.Drawing.Drawing2D;

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
            ApplyButtonStyles();
            this.FormBorderStyle = FormBorderStyle.None;
            this.MouseDown += PDF_TOOLS_MouseDown;
            this.MouseMove += PDF_TOOLS_MouseMove;
            this.MouseUp += PDF_TOOLS_MouseUp;
        }

        private void ApplyButtonStyles()
        {
            SetButtonHoverEffect(SPLIT_PDF, Color.Crimson);
            SetButtonHoverEffect(MERGE_PDF, Color.DarkCyan);
            SetButtonHoverEffect(EXIT, Color.Red);
            SetButtonHoverEffect(TO_MAIN_MENU, Color.DarkBlue);

            ApplyRoundedEdges(SPLIT_PDF);
            ApplyRoundedEdges(MERGE_PDF);
            ApplyRoundedEdges(EXIT);
            ApplyRoundedEdges(TO_MAIN_MENU);
            ApplyRoundedEdges(btnOpenFolder);
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
            try
            {
                using (OpenFileDialog openFileDialog = new OpenFileDialog { Filter = "PDF Files|*.pdf", Multiselect = true })
                using (SaveFileDialog saveFileDialog = new SaveFileDialog { Filter = "PDF File|*.pdf" })
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        MergeMultiplePDFs(openFileDialog.FileNames, saveFileDialog.FileName);
                        MessageBox.Show("PDFs merged successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error merging PDFs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MergeMultiplePDFs(string[] fileNames, string targetPath)
        {
            lastUsedFolder = Path.GetDirectoryName(targetPath);

            using (FileStream stream = new FileStream(targetPath, FileMode.Create))
            using (Document document = new Document())
            using (PdfCopy pdf = new PdfCopy(document, stream))
            {
                document.Open();
                PdfReader reader = null;
                foreach (string file in fileNames)
                {
                    try
                    {
                        reader = new PdfReader(file);
                        for (int i = 1; i <= reader.NumberOfPages; i++)
                        {
                            pdf.AddPage(pdf.GetImportedPage(reader, i));
                        }
                    }
                    finally
                    {
                        reader?.Close();
                    }
                }
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
                for (int pageNumber = 1; pageNumber <= reader.NumberOfPages; pageNumber++)
                {
                    string newFile = Path.Combine(outputPath, $"Page_{pageNumber}.pdf");
                    using (Document document = new Document(reader.GetPageSizeWithRotation(pageNumber)))
                    using (FileStream stream = new FileStream(newFile, FileMode.Create))
                    using (PdfCopy pdfCopy = new PdfCopy(document, stream))
                    {
                        document.Open();
                        pdfCopy.AddPage(pdfCopy.GetImportedPage(reader, pageNumber));
                    }
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
