using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class ChangeColor : Form
    {
        public ChangeColor()
        {
            InitializeComponent();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            BackColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
        }
    }
}
