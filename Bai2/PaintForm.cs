using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void DrawPaint()
        {
            Random rnd = new Random();
            Graphics draw = contentPanel.CreateGraphics();
            int x = rnd.Next(10, Size.Width - 10);
            int y = rnd.Next(10, Size.Height - 10);
            Font font = new Font(new FontFamily("Segoe UI"), rnd.Next(8, 30), FontStyle.Bold, GraphicsUnit.Pixel);
            SolidBrush solidBrush = new SolidBrush(Color.FromArgb(255, rnd.Next(255), rnd.Next(255), rnd.Next(255)));
            draw.DrawString("Paint Event", font, solidBrush, new PointF(x, y));
        }

        private void PaintForm_Paint(object sender, PaintEventArgs e)
        {
            DrawPaint();
        }

        private void PaintForm_Click(object sender, EventArgs e)
        {
            DrawPaint();           
        }
    }
}
