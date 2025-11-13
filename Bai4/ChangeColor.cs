using System;
using System.Windows.Forms;

namespace Bai4
{
    public partial class ChangeColor : Form
    {
        public ChangeColor()
        {
            InitializeComponent();
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog chooseColor = new ColorDialog();
            if (chooseColor.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = chooseColor.Color;
            }
        }
    }
}
