using System;
using System.Windows.Forms;

namespace Bai5
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void ShowAnswer(string s)
        {
            textBoxAns.Text = s;
        }

        private double GetNumber(TextBox textBox)
        {
            if (double.TryParse(textBox.Text, out double value))
                return value;
            else
            {
                ShowAnswer("Giá trị nhập không hợp lệ!");
                return double.NaN; // Trả về giá trị đặc biệt để báo lỗi
            }
        }

        private bool HasError(double num1, double num2)
        {
            // Nếu có lỗi ở đầu vào, dừng lại
            return double.IsNaN(num1) || double.IsNaN(num2);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double num1 = GetNumber(textBoxNum1);
            double num2 = GetNumber(textBoxNum2);
            if (HasError(num1, num2)) return;

            double result = num1 + num2;
            ShowAnswer(result.ToString());
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            double num1 = GetNumber(textBoxNum1);
            double num2 = GetNumber(textBoxNum2);
            if (HasError(num1, num2)) return;

            double result = num1 - num2;
            ShowAnswer(result.ToString());
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            double num1 = GetNumber(textBoxNum1);
            double num2 = GetNumber(textBoxNum2);
            if (HasError(num1, num2)) return;

            double result = num1 * num2;
            ShowAnswer(result.ToString());
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            double num1 = GetNumber(textBoxNum1);
            double num2 = GetNumber(textBoxNum2);
            if (HasError(num1, num2)) return;

            if (num2 == 0)
            {
                ShowAnswer("Không thể chia cho 0!");
                return;
            }

            double result = num1 / num2;
            ShowAnswer(result.ToString());
        }
    }
}
