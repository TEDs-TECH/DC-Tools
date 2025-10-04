using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace DC_Tools
{
    public partial class CREATE_FOLDER : Form
    {
        private string destinationPath = "";
        public CREATE_FOLDER()


        {
            InitializeComponent();
            ApplyButtonStyles();
            this.FormBorderStyle = FormBorderStyle.None;
        }
        private void ApplyButtonStyles()
        {
            // Apply hover effects for buttons
            SetButtonHoverEffect(btnPaste, Color.Crimson);
            SetButtonHoverEffect(btnCreateFolder, Color.DarkCyan);
            SetButtonHoverEffect(btnExit, Color.Red);
            SetButtonHoverEffect(btnMainMenu, Color.DarkBlue);
            SetButtonHoverEffect(btnClear, Color.DarkSeaGreen);
            SetButtonHoverEffect(btnOpenDestinationFolder, Color.DarkOrange);

            ApplyRoundedEdges(btnPaste);
            ApplyRoundedEdges(btnCreateFolder);
            ApplyRoundedEdges(btnMainMenu);
            ApplyRoundedEdges(btnClear);
            ApplyRoundedEdges(btnOpenDestinationFolder);
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

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MAINMENU mAINMENU = new MAINMENU();
            mAINMENU.ShowDialog();

        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string clipboardText = Clipboard.GetText();
                string[] rows = clipboardText.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string row in rows)
                {
                    int rowIndex = dgvCreateFolder.Rows.Add();
                    dgvCreateFolder.Rows[rowIndex].Cells["OriginalFile"].Value = row;
                }
            }
            else
            {
                MessageBox.Show("Clipboard is empty", "Paste Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCreateFolder_Click(object sender, EventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Select Destination Folder";
                DialogResult result = dialog.ShowDialog();

                if (result != DialogResult.OK || string.IsNullOrWhiteSpace(dialog.SelectedPath))
                {
                    MessageBox.Show("No folder selected.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                destinationPath = dialog.SelectedPath;
                if (!destinationPath.EndsWith("\\"))
                    destinationPath += "\\";

                foreach (DataGridViewRow row in dgvCreateFolder.Rows)
                {
                    if (row.IsNewRow) continue;

                    string folderName = row.Cells["OriginalFile"]?.Value?.ToString().Trim();

                    if (!string.IsNullOrEmpty(folderName))
                    {
                        string fullPath = Path.Combine(destinationPath, folderName);

                        try
                        {
                            if (!Directory.Exists(fullPath))
                            {
                                Directory.CreateDirectory(fullPath);
                                row.Cells["Status"].Value = "Created";
                                row.Cells["Status"].Style.BackColor = Color.LightGreen;
                            }
                            else
                            {
                                row.Cells["Status"].Value = "Exists";
                                row.Cells["Status"].Style.BackColor = Color.LightCoral;
                            }

                            row.Cells["FolderName"].Value = folderName;
                            row.Cells["FolderLink"].Value = fullPath;

                        }
                        catch (Exception ex)
                        {
                            row.Cells["Status"].Value = "Error";
                            row.Cells["Status"].Style.BackColor = Color.Yellow;
                            MessageBox.Show($"Failed to create folder: {fullPath}\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                MessageBox.Show("Folders processed successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Clear all content?", "Confirm Clear",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dgvCreateFolder.Rows.Clear();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnOpenDestinationFolder_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(destinationPath) && Directory.Exists(destinationPath))
            {
                Process.Start("explorer.exe", destinationPath);
            }
            else
            {
                MessageBox.Show("Destination folder not available", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

