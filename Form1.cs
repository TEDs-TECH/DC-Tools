using System.Diagnostics; // Added namespace for Process.Start
using System.Drawing.Drawing2D;

namespace DC_Tools
{
    public partial class MAINMENU : Form
    {
        public MAINMENU()
        {
            InitializeComponent();
            ApplyButtonStyles();
            this.FormBorderStyle = FormBorderStyle.None;

        }


        private void ApplyButtonStyles()
        {
            // Apply styles to buttons
            SetButtonHoverEffect(btnPDF_TOOLS, Color.MediumVioletRed);
            SetButtonHoverEffect(btnFILES_TOOLS, Color.DarkCyan);
            SetButtonHoverEffect(btnExit, Color.Red);
            SetButtonHoverEffect(btn_Others, Color.RoyalBlue);

            // Apply rounded edges
            ApplyRoundedEdges(btnPDF_TOOLS);
            ApplyRoundedEdges(btnFILES_TOOLS);
            ApplyRoundedEdges(btnExit);
            ApplyRoundedEdges(btn_Others);
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

        private void btnFILES_TOOLS_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            FILE_TOOLS fileTools = new FILE_TOOLS();
            fileTools.Show();
        }

        private void btnPDF_TOOLS_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            PDF_TOOLS pdfTools = new PDF_TOOLS();
            pdfTools.Show();
        }

        private void btnAbout_Click_1(object sender, EventArgs e)
        {
            string message = "My DC Tools\n" +
                             "Version: 1.0.13\n" +
                             "Created by: TED NAVALTA\n" +
                             "WhatsApp: +63 945 804 9025\n" +
                             "YT Channel: https://www.youtube.com/@tedstech2718\n" +

                             "© 2025 Ted's Tech";

            MessageBox.Show(message, "About My Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = "https://www.youtube.com/@tedstech2718",
                    UseShellExecute = true // Ensures the default browser is used
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open webpage: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_Others_Click(object sender, EventArgs e)
        {
            this.Hide();
            FILE_MENU fileTools = new FILE_MENU();
            fileTools.Show();
        }


    }
}
