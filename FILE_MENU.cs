using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Drawing.Drawing2D;

namespace DC_Tools
{
    public partial class FILE_MENU : Form
    {
        public FILE_MENU()
        {
            InitializeComponent();
            ApplyButtonStyles();
            this.FormBorderStyle = FormBorderStyle.None;

        }

        private void ApplyButtonStyles()
        {
            // Apply styles to buttons
            SetButtonHoverEffect(btnMainMenu, Color.DarkBlue);
            SetButtonHoverEffect(btnMAKE_FOLDER, Color.MediumVioletRed);
            SetButtonHoverEffect(btnFILES_TOOLS, Color.DarkCyan);
            SetButtonHoverEffect(btnExit1, Color.Red);
            SetButtonHoverEffect(btnMoveFiles, Color.RoyalBlue);

            // Apply rounded edges
            ApplyRoundedEdges(btnMainMenu);
            ApplyRoundedEdges(btnMAKE_FOLDER);
            ApplyRoundedEdges(btnFILES_TOOLS);
            ApplyRoundedEdges(btnExit1);
            ApplyRoundedEdges(btnMoveFiles);
        }

        private void ApplyRoundedEdges(Button button)
        {
            int radius = 20; // Adjust for more or less rounding
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(button.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(button.Width - radius - 1, button.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, button.Height - radius - 1, radius, radius, 90, 90);
            path.CloseFigure();

            button.Region = new Region(path);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int radius = 30;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(Width - radius, -2, radius, radius, 270, 90);
            path.AddArc(Width - radius, Height - radius, radius, radius, -2, 90);
            path.AddArc(0, Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);

            using (Pen blackPen = new Pen(Color.Red, 10))
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

        private void pictureBox1_Click_1(object sender, EventArgs e)
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


        private void btnMAKE_FOLDER_Click(object sender, EventArgs e)
        {
            this.Hide();
            CREATE_FOLDER cREATE_FOLDER = new CREATE_FOLDER();
            cREATE_FOLDER.Show();
        }

        private void btnFILES_TOOLS_Click(object sender, EventArgs e)
        {
            this.Hide();
            FILE_TOOLS fileTools = new FILE_TOOLS();
            fileTools.Show();
        }
        private void btnExit1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMoveFiles_Click(object sender, EventArgs e)
        {
            string correctPassword = "Move"; // Replace with your actual password
            string userInput = Interaction.InputBox("Are you Sure you want To Process Move Files? Type Move", "Password Required", "", -1, -1);

            if (userInput == correctPassword)
            {
                this.Hide();
                MOVE_FILES mOVE_FILES = new MOVE_FILES();
                mOVE_FILES.Show();
            }
            else if (userInput != "") // Check if the user didn't cancel
            {
                MessageBox.Show("Incorrect password.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            MAINMENU mAINMENU = new MAINMENU();
            mAINMENU.ShowDialog();

        }
    }
}