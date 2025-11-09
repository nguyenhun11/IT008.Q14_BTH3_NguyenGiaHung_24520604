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
    public partial class DemoForm : Form
    {
        private MainForm mainForm;
        private int ID;
        
        public DemoForm(int id, MainForm form)
        {
            InitializeComponent();
            ID = id;
            mainForm = form;
            ShowMessage("Construction");
            label1.Text = "Form " + ID;
        }

        private void ShowMessage(string s)
        {
            if (mainForm != null && !mainForm.IsDisposed)
            {
                mainForm.AddText($"Form {ID}: {s}");
            }
        }


        private void DemoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowMessage("Form closed");
        }

        private void DemoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ShowMessage("Form closing");
        }

        private void DemoForm_Load(object sender, EventArgs e)
        {
            ShowMessage("Load");
        }

        private void DemoForm_Activated(object sender, EventArgs e)
        {
            ShowMessage("Activated");
        }

        private void DemoForm_Deactivate(object sender, EventArgs e)
        {
            ShowMessage("Deactivate");
        }

        private void DemoForm_Shown(object sender, EventArgs e)
        {
            ShowMessage("Shown");
        }
    }
}
