using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace DC_Tools
{
    public partial class FILE_TOOLS : Form
    {
        private string destinationPath = "";

        public FILE_TOOLS()
        {
            InitializeComponent();
            ApplyButtonStyles();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void ApplyButtonStyles()
        {
            // Apply hover effects for buttons
            SetButtonHoverEffect(btnPaste, Color.Crimson);
            SetButtonHoverEffect(btnCopyFiles, Color.DarkCyan);
            SetButtonHoverEffect(btnExit, Color.Red);
            SetButtonHoverEffect(btnMainMenu, Color.DarkBlue);
            SetButtonHoverEffect(btnClear, Color.DarkSeaGreen);

            ApplyRoundedEdges(btnPaste);
            ApplyRoundedEdges(btnCopyFiles);
            ApplyRoundedEdges(btnMainMenu);
            ApplyRoundedEdges(btnClear);
            ApplyRoundedEdges(btnExit);

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
            int radius = 30;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(Width - radius, Height - radius, radius, radius, 0, 90);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

            using (Pen blackPen = new Pen(Color.DeepSkyBlue, 10))
            {
                e.Graphics.DrawPath(blackPen, path);
            }

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

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string clipboardText = Clipboard.GetText();
                string[] rows = clipboardText.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string row in rows)
                {
                    int rowIndex = dgvFileSystem.Rows.Add();
                    dgvFileSystem.Rows[rowIndex].Cells["OriginalFile"].Value = row;
                }
            }
            else
            {
                MessageBox.Show("Clipboard is empty", "Paste Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCopyFiles_Click(object sender, EventArgs e)
        {
            if (dgvFileSystem.Rows.Count == 0)
            {
                MessageBox.Show("No files to process", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string fileExtension = txtExtension.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(fileExtension))
            {
                fileExtension = "PDF";
                txtExtension.Text = fileExtension;
            }

            string sourcePath = SelectFolder("Select Source Folder",
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "for print"));
            destinationPath = SelectFolder("Select Destination Folder",
                Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "for print"));

            int errorCount = 0;

            // Calculate total files to process
            int totalFiles = 0;
            foreach (DataGridViewRow row in dgvFileSystem.Rows)
            {
                if (!row.IsNewRow)
                    totalFiles++;
            }

            // Initialize progress bar
            progressBar1.Maximum = totalFiles;
            progressBar1.Value = 0;

            foreach (DataGridViewRow row in dgvFileSystem.Rows)
            {
                if (row.IsNewRow) continue;

                try
                {
                    string originalFile = row.Cells["OriginalFile"].Value?.ToString();
                    string targetFile = $"{originalFile}.{fileExtension}";
                    string sourceFile = Path.Combine(sourcePath, targetFile);
                    string destFile = Path.Combine(destinationPath, targetFile);

                    row.Cells["FileWithExtension"].Value = targetFile;

                    File.Copy(sourceFile, destFile, true);

                    row.Cells["Status"].Value = "COMPLETED";
                    row.Cells["Status"].Style.BackColor = Color.LightGreen;
                }
                catch (Exception ex)
                {
                    errorCount++;
                    row.Cells["Status"].Value = ex.Message;
                    row.Cells["Status"].Style.BackColor = Color.Salmon;
                }

                // Update progress bar and refresh UI
                progressBar1.Value++;
                Application.DoEvents(); // Allows the UI to update
            }

            // Reset progress bar after completion
            progressBar1.Value = 0;

            if (errorCount > 0)
            {
                MessageBox.Show($"{errorCount} files failed to copy", "Copy Results",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("All files copied successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            {
                Process.Start("explorer.exe", destinationPath);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear all content?", "Confirm Clear",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvFileSystem.Rows.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        // Helper method for folder selection
        private string SelectFolder(string title, string defaultPath)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                dialog.Description = title;
                dialog.SelectedPath = defaultPath;
                dialog.ShowNewFolderButton = true;

                return dialog.ShowDialog() == DialogResult.OK
                    ? dialog.SelectedPath
                    : defaultPath;
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MAINMENU mAINMENU = new MAINMENU();
            mAINMENU.ShowDialog();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    string message = "My DC Tools\n" +
                                     "Version: 1.0.13\n" +
                                     "Created by: TED NAVALTA\n" +
                                     "WhatsApp: +63 945 804 9025\n" +
                                     "YT Channel: https://www.youtube.com/@tedstech2718\n" +
                                     "My Portfolio: https://teds-tech.github.io/TED-NAVALTA/\n" +

                                     "© 2025 Ted's Tech";

                    MessageBox.Show(message, "About My Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Fix for CS1912: Only one FileName property should be set per ProcessStartInfo.
                // To open multiple URLs, call Process.Start separately for each.

                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://www.youtube.com/@tedstech2718",
                    UseShellExecute = true
                });
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://teds-tech.github.io/TED-NAVALTA/",
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open webpage: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}