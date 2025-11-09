using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class MainForm : Form
    {
        private DemoForm demoForm;
        private int count = 1;
        private int line = 1;
        private int CreateFormID()
        {
            return count++;
        }

        public MainForm()
        {
            InitializeComponent();
        }

        public void AddText(string s)
        {
            textBox.AppendText(line + "\t" + s + Environment.NewLine);
            line++;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AddText("Tạo form mới và xem vòng đời của form");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBox.Clear();
            line = 1;
        }

        private void buttonNewForm_Click(object sender, EventArgs e)
        {
            AddText($"Tạo form {count}");
            demoForm = new DemoForm(CreateFormID(), this);
            demoForm.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                Form form = Application.OpenForms[i];
                if (form is DemoForm)
                {
                    form.Close();
                }
            }
        }
    }
}
