using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
{
    public partial class Calculator : Form
    {
        private int maxNumOfChar = 10;

        private double firstValue;
        private bool isTypingFirstValue = true;
        private enum MathType
        {
            Add, Minus, Times, Divide, Single, None
        };
        private MathType mathType = MathType.None;
        private double secondValue;
        private bool isTypingSecondValue = false;
        private bool isDefaultInput = true;

        public Calculator()
        {
            InitializeComponent();
            Reset();
        }

        private void CalculateBinaryToFirstValue()
        {
            switch (mathType)
            {
                case MathType.Add: firstValue = firstValue + secondValue; break;
                case MathType.Minus: firstValue = firstValue - secondValue; break;
                case MathType.Times: firstValue = firstValue * secondValue; break;
                case MathType.Divide: firstValue = firstValue / secondValue; break;
            }
        }

        private void Write(char c)
        {
            if(isDefaultInput)
            {
                textBoxResult.Text = string.Empty;
                isTypingFirstValue = true;
                isDefaultInput = false;
            }
            string current = textBoxResult.Text;

            // --- Xử lý nhập dấu phẩy (thập phân) ---
            if (c == ',')
            {
                if (!current.Contains(","))
                {
                    if (string.IsNullOrEmpty(current))
                        current = "0,";
                    else
                        current += ",";
                }
                textBoxResult.Text = current;
                return;
            }

            // --- Chỉ cho phép ký tự số ---
            if (!char.IsDigit(c))
                return;

            // --- Nếu chưa có dấu ',' → phần nguyên ---
            if (!current.Contains(","))
            {
                string integerPart = current.Replace(".", "");

                // Xử lý khi phần nguyên là "0"
                if (integerPart == "0")
                {
                    if (c == '0')
                    {
                        // Không cho thêm 0 nữa
                        return;
                    }
                    else
                    {
                        // Nếu nhập số khác 0 → thay thế 0
                        integerPart = c.ToString();
                    }
                }
                else
                {
                    // Thêm ký tự mới nếu chưa đạt giới hạn
                    if (integerPart.Length < maxNumOfChar)
                        integerPart += c;
                }

                // Cập nhật hiển thị
                textBoxResult.Text = FormatWithDots(integerPart);
            }
            else
            {
                // --- Nếu có dấu ',' → phần thập phân ---
                string[] parts = current.Split(',');
                string integerPart = parts[0].Replace(".", "");
                string decimalPart = parts.Length > 1 ? parts[1] : "";

                // Giới hạn tổng độ dài
                if (integerPart.Length + decimalPart.Length >= maxNumOfChar)
                    return;

                decimalPart += c;
                textBoxResult.Text = FormatWithDots(integerPart) + "," + decimalPart;
            }
        }

        private string FormatWithDots(string number)
        {
            if (string.IsNullOrEmpty(number))
                return "";

            char[] arr = number.Reverse().ToArray();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < arr.Length; i++)
            {
                if (i > 0 && i % 3 == 0)
                    sb.Append('.');
                sb.Append(arr[i]);
            }

            return new string(sb.ToString().Reverse().ToArray());
        }

        private void InputDelete()
        {
            textBoxResult.Text = string.Empty;
            Write('0');
        }

        private void MathDelete()
        {
            textBoxPre.Text = string.Empty;
        }

        private void ToggleSign()
        {
            string current = textBoxResult.Text;

            if (string.IsNullOrEmpty(current) || current == "0" || current == "0," || current == "-0" || current == "-0,")
            {
                // Trường hợp đang là 0 hoặc trống
                return;
            }

            // Nếu có dấu '-' ở đầu → xóa
            if (current.StartsWith("-"))
            {
                textBoxResult.Text = current.Substring(1);
            }
            else
            {
                // Thêm dấu '-' phía trước
                textBoxResult.Text = "-" + current;
            }
        }

        private double GetValue()
        {
            string current = textBoxResult.Text;

            if (string.IsNullOrWhiteSpace(current))
                return 0;

            // Loại bỏ dấu chấm (phân cách nghìn)
            current = current.Replace(".", "");

            // Thay dấu phẩy (,) thành dấu chấm (.) để parse được dạng double chuẩn
            current = current.Replace(",", ".");

            // Nếu chuỗi chỉ còn dấu '-' → trả về 0
            if (current == "-")
                return 0;

            // Thử parse giá trị
            if (double.TryParse(current, System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out double value))
                return value;

            // Nếu parse lỗi → mặc định 0
            return 0;
        }
        
        private void MathWrite(string s)
        {
            textBoxPre.Text = s;
        }

        private void Reset()
        {
            firstValue = 0;
            isTypingFirstValue = true;
            secondValue = 0;
            isTypingSecondValue = false;
            mathType = MathType.None;
            InputDelete();
            MathDelete();
            isDefaultInput = true;
        }

        private void buttonFraction_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            Write('0');
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Write('1');
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Write('2');
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Write('3');
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Write('4');
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Write('5');
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Write('6');
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Write('7');
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Write('8');
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Write('9');
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            Write(',');
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            InputDelete();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            Reset();
        }

        

        private void buttonDel_Click(object sender, EventArgs e)
        {
            string current = textBoxResult.Text;

            if (string.IsNullOrEmpty(current))
            {
                textBoxResult.Text = "0";
                return;
            }

            // --- Xóa ký tự cuối ---
            current = current.Substring(0, current.Length - 1);

            // --- Nếu chỉ còn dấu '-' thì coi như 0 ---
            if (current == "-" || current == "" || current == "-0" || current == "-0," || current == "-0.")
            {
                textBoxResult.Text = "0";
                return;
            }

            // --- Nếu còn dấu ',' → tách phần nguyên & phần thập phân ---
            if (current.Contains(","))
            {
                string sign = current.StartsWith("-") ? "-" : "";
                if (sign == "-") current = current.Substring(1);

                string[] parts = current.Split(',');
                string integerPart = parts[0].Replace(".", "");
                string decimalPart = parts.Length > 1 ? parts[1] : "";

                // Nếu xóa hết phần thập phân, loại dấu ','
                if (decimalPart.Length == 0)
                {
                    textBoxResult.Text = sign + FormatWithDots(integerPart);
                }
                else
                {
                    textBoxResult.Text = sign + FormatWithDots(integerPart) + "," + decimalPart;
                }
            }
            else
            {
                // --- Không có dấu ',' → chỉ có phần nguyên ---
                string sign = current.StartsWith("-") ? "-" : "";
                if (sign == "-") current = current.Substring(1);

                string integerPart = current.Replace(".", "");

                // Nếu phần nguyên trống → hiển thị 0
                if (integerPart.Length == 0)
                {
                    textBoxResult.Text = "0";
                }
                else
                {
                    textBoxResult.Text = sign + FormatWithDots(integerPart);
                }
            }
        }

        private void buttonPm_Click(object sender, EventArgs e)
        {
            if (isTypingFirstValue || isTypingSecondValue)
            {
                ToggleSign();
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (isTypingFirstValue)
            {
                firstValue = GetValue();
                MathWrite(firstValue + " =");
                isTypingFirstValue = false;
            }
            else if (isTypingSecondValue)
            {
                secondValue = GetValue();
                MathWrite(textBoxPre.Text + " " +  secondValue);
                CalculateBinaryToFirstValue();
                textBoxResult.Text = FormatWithDots(firstValue.ToString());
                isTypingSecondValue = false;
            }
            else
            {
                SetUpForBinaryOperator(mathType);
                isTypingSecondValue = false;
                MathWrite(textBoxPre.Text + " " + secondValue);
                CalculateBinaryToFirstValue();
                textBoxResult.Text = FormatWithDots(firstValue.ToString());
            }
            isDefaultInput = true;
        }

        private void SetUpForBinaryOperator(MathType type)
        {
            if (isTypingSecondValue)
            {
                secondValue = GetValue();
                CalculateBinaryToFirstValue();
            }
            else
            {
                firstValue = GetValue();
                isTypingFirstValue = false;
                isTypingSecondValue = true;
            }
            mathType = type;
            char setOperator;
            switch (type)
            {
                case MathType.Add: setOperator = '+'; break;
                case MathType.Minus: setOperator = '-'; break;
                case MathType.Times: setOperator = '×'; break;
                case MathType.Divide: setOperator = '÷'; break;
                default: setOperator = ' '; break;
            }
            MathWrite($"{firstValue} {setOperator}");
            isDefaultInput = true;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            SetUpForBinaryOperator(MathType.Add);
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            SetUpForBinaryOperator(MathType.Minus);
        }

        private void buttonTime_Click(object sender, EventArgs e)
        {
            SetUpForBinaryOperator(MathType.Times);
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            SetUpForBinaryOperator(MathType.Divide);
        }
    }
}
