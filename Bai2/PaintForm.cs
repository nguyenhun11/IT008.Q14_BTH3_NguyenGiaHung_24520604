using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bai2
{
    public partial class PaintForm : Form
    {
        public PaintForm()
        {
            InitializeComponent();
            this.CreateGraphics();
        }

        private int lines = 1;

        private void ShowStatus(string s)
        {
            textBoxStatus.AppendText($"{lines}: {s} {Environment.NewLine}");
            lines++;
        }

        private void PaintForm_Paint(object sender, PaintEventArgs e)
        {
            Random rnd = new Random();
            Graphics draw = panelContent.CreateGraphics();
            int x = rnd.Next(10, panelContent.Size.Width - 10);
            int y = rnd.Next(10, panelContent.Size.Height - 10);
            Font font = new Font(new FontFamily("Segoe UI"), rnd.Next(8, 30), FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255)));
            draw.DrawString("Paint Event", font, solidBrush, new PointF(x, y));
        }

        private void Invalidate_Click(object sender, EventArgs e)
        {
            ShowStatus("Invalidate");
            this.Invalidate();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            ShowStatus("Refresh");
            this.Refresh();
        }

        private void PaintForm_Resize(object sender, EventArgs e)
        {
            ShowStatus("Resize");
        }

        private void PaintForm_Activated(object sender, EventArgs e)
        {
            ShowStatus("Activated");
        }

        private void PaintForm_Deactivate(object sender, EventArgs e)
        {
            ShowStatus("Deactivate");
        }

        private void PaintForm_Load(object sender, EventArgs e)
        {
            ShowStatus("Load");
        }

        private void buttonDeleteContent_Click(object sender, EventArgs e)
        {
            textBoxStatus.Clear();
            lines = 1;
        }
    }
}
