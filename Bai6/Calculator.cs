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
using System.Globalization; // Cần thêm để dùng CultureInfo

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

        // --- THÊM BIẾN BỘ NHỚ ---
        private double memoryValue = 0;

        public Calculator()
        {
            InitializeComponent();
            Reset();
            // Bạn có thể thêm một Label (ví dụ: labelMemory)
            // và gọi UpdateMemoryLabel() ở đây và trong các hàm M_
            UpdateMemoryLabel();
        }

        // --- SỬA LỖI 1: Trả về bool để báo hiệu thành công/thất bại ---
        private bool CalculateBinaryToFirstValue()
        {
            switch (mathType)
            {
                case MathType.Add: firstValue = firstValue + secondValue; break;
                case MathType.Minus: firstValue = firstValue - secondValue; break;
                case MathType.Times: firstValue = firstValue * secondValue; break;
                case MathType.Divide:
                    // *** KIỂM TRA CHIA CHO 0 ***
                    if (secondValue == 0)
                    {
                        return false; // Báo lỗi
                    }
                    firstValue = firstValue / secondValue;
                    break;
            }
            return true; // Tính toán thành công
        }

        private void Write(char c)
        {
            if (isDefaultInput)
            {
                // --- LOGIC SỬA LỖI ---
                // Kiểm tra xem trạng thái "default" này là sau dấu =
                // (bắt đầu phép tính mới) hay sau dấu + - * / (tiếp tục phép tính).
                if (!isTypingSecondValue)
                {
                    // Nếu KHÔNG phải đang chờ số thứ 2, nghĩa là ta đang
                    // bắt đầu một phép tính mới (ví dụ: sau khi bấm 5 =).
                    // Cần reset lại trạng thái về như ban đầu.
                    isTypingFirstValue = true;
                    MathDelete(); // Xóa "5 =" khỏi thanh math
                }
                // --- KẾT THÚC LOGIC SỬA LỖI ---

                textBoxResult.Text = string.Empty;
                isDefaultInput = false;
            }
            string current = textBoxResult.Text;

            // --- Xử lý nhập dấu phẩy (thập phân) ---
            if (c == ',')
            {
                if (!current.Contains(","))
                {
                    if (string.IsNullOrEmpty(current) || current == "-")
                        current += "0,";
                    else
                        current += ",";
                }
                textBoxResult.Text = current;
                return;
            }

            // --- Chỉ cho phép ký tự số ---
            if (!char.IsDigit(c))
                return;

            // --- Tách phần nguyên và phần thập phân (đã loại bỏ dấu '.') ---
            string sign = current.StartsWith("-") ? "-" : "";
            string currentNoSign = current.StartsWith("-") ? current.Substring(1) : current;
            string[] parts = currentNoSign.Split(',');
            string integerPart = parts[0].Replace(".", "");
            string decimalPart = parts.Length > 1 ? parts[1] : "";

            // --- Giới hạn tổng số chữ số ---
            if (integerPart.Length + decimalPart.Length >= maxNumOfChar)
            {
                // Nếu đang là "0" thì cho phép thay thế
                if (integerPart == "0" && !current.Contains(","))
                {
                    // Cho phép thay 0 bằng số khác
                }
                else
                {
                    return; // Đã đạt giới hạn
                }
            }

            // --- Nếu chưa có dấu ',' → phần nguyên ---
            if (!current.Contains(","))
            {
                // Xử lý khi phần nguyên là "0"
                if (integerPart == "0")
                {
                    if (c == '0') return; // Không cho thêm 0 nữa
                    integerPart = c.ToString(); // thay thế 0
                }
                else
                {
                    integerPart += c;
                }
                textBoxResult.Text = sign + FormatWithDots(integerPart);
            }
            else
            {
                // --- Nếu có dấu ',' → phần thập phân ---
                decimalPart += c;
                textBoxResult.Text = sign + FormatWithDots(integerPart) + "," + decimalPart;
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

        // --- HÀM MỚI (SỬA LỖI 2) ---
        // Hàm này nhận 1 số double và định dạng nó đúng chuẩn (,.): 1.234,56
        private string FormatResult(double value)
        {
            // Xử lý trường hợp vô cực hoặc NaN (Not-a-Number)
            if (double.IsNaN(value) || double.IsInfinity(value))
            {
                return "Error";
            }

            // Chuyển double sang string dùng InvariantCulture (luôn dùng '.')
            // "G" để loại bỏ số 0 không cần thiết ở phần thập phân
            string s = value.ToString("G", CultureInfo.InvariantCulture);

            string sign = "";
            if (s.StartsWith("-"))
            {
                sign = "-";
                s = s.Substring(1);
            }

            string[] parts = s.Split('.');
            string integerPart = parts[0];
            string decimalPart = (parts.Length > 1) ? parts[1] : null;

            string formattedInteger = FormatWithDots(integerPart);

            if (decimalPart != null)
            {
                // Giới hạn lại số ký tự thập phân nếu quá dài
                int maxDecimalLength = maxNumOfChar - integerPart.Length;
                if (maxDecimalLength < 0) maxDecimalLength = 0;

                if (decimalPart.Length > maxDecimalLength)
                {
                    // Thử làm tròn thay vì cắt bỏ
                    try
                    {
                        double roundedValue = Math.Round(value, maxDecimalLength);
                        s = roundedValue.ToString("G", CultureInfo.InvariantCulture);
                        if (s.StartsWith("-")) s = s.Substring(1);
                        parts = s.Split('.');
                        integerPart = parts[0];
                        decimalPart = (parts.Length > 1) ? parts[1] : null;
                        formattedInteger = FormatWithDots(integerPart);
                    }
                    catch
                    {
                        // Nếu làm tròn lỗi, quay lại cắt bỏ
                        if (maxDecimalLength > 0)
                            decimalPart = decimalPart.Substring(0, maxDecimalLength);
                        else
                            decimalPart = null; // Không có phần thập phân
                    }
                }

                if (decimalPart != null && decimalPart.Length > 0)
                    return sign + formattedInteger + "," + decimalPart;
            }

            return sign + formattedInteger;
        }

        // --- HÀM MỚI: Xử lý lỗi tính toán ---
        private void HandleCalculationError(string message = "Error")
        {
            textBoxResult.Text = message;
            isDefaultInput = true;
            isTypingFirstValue = true; // Reset về trạng thái chờ số đầu tiên
            isTypingSecondValue = false;
            mathType = MathType.None;
            // Không xóa MathDelete() để người dùng biết phép tính lỗi
        }


        private void InputDelete()
        {
            textBoxResult.Text = "0"; // Chỉ cần set 0
            isDefaultInput = true; // Đặt lại cờ này
        }

        private void MathDelete()
        {
            textBoxPre.Text = string.Empty;
        }

        private void ToggleSign()
        {
            string current = textBoxResult.Text;

            // Không đổi dấu khi là "0" hoặc lỗi
            if (string.IsNullOrEmpty(current) || current == "0" || current.Contains("Error"))
            {
                return;
            }

            if (current == "0,")
            {
                textBoxResult.Text = "-0,";
                return;
            }
            if (current == "-0,")
            {
                textBoxResult.Text = "0,";
                return;
            }

            if (current.StartsWith("-"))
                textBoxResult.Text = current.Substring(1);
            else
                textBoxResult.Text = "-" + current;
        }

        private double GetValue()
        {
            string current = textBoxResult.Text;

            if (string.IsNullOrWhiteSpace(current) || current.Contains("Error"))
                return 0;

            // Loại bỏ dấu chấm (phân cách nghìn)
            current = current.Replace(".", "");

            // Thay dấu phẩy (,) thành dấu chấm (.) để parse
            current = current.Replace(",", ".");

            if (current == "-" || current == "-.")
                return 0;
            if (current.EndsWith("."))
                current = current.TrimEnd('.');

            if (double.TryParse(current, NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
                return value;

            return 0;
        }

        // --- HÀM TRỢ GIÚP MỚI ---
        // Lấy biểu thức toán học cho các phép toán 1 ngôi (sqrt, sqr, 1/x)
        private string GetMathExpressionForSingleOp()
        {
            double currentValue = GetValue();
            string mathExpression;

            // Kiểm tra xem có phải trạng thái "sau khi nhấn =" không
            // (Không phải đang gõ số 1 VÀ không phải đang gõ số 2)
            if (!isTypingFirstValue && !isTypingSecondValue)
            {
                mathExpression = textBoxPre.Text;
                // Lọc bỏ dấu " =" ở cuối nếu có
                if (mathExpression.EndsWith(" ="))
                {
                    mathExpression = mathExpression.Substring(0, mathExpression.Length - 2);
                }
                // Nếu không có " =", nó có thể là một biểu thức (vd: "sqrt(9)")
                // chúng ta sẽ dùng nó
            }
            else
            {
                // Nếu đang gõ (hoặc gõ số đầu tiên, hoặc gõ số thứ 2)
                // thì chỉ dùng giá trị hiện tại trên màn hình
                mathExpression = FormatResult(currentValue);
            }
            return mathExpression;
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
            InputDelete(); // Đã sửa: set "0" và isDefaultInput = true
            MathDelete();
            // Lưu ý: Reset (nút C) không xóa bộ nhớ (memoryValue)
        }

        // --- SỬA LỖI 4: Implement 1/x (CẬP NHẬT LOGIC) ---
        private void buttonFraction_Click(object sender, EventArgs e)
        {
            double currentValue = GetValue();
            if (currentValue == 0)
            {
                HandleCalculationError("Cannot divide by zero");
                return;
            }

            string mathExpression = GetMathExpressionForSingleOp(); // Lấy biểu thức
            double result = 1 / currentValue;
            MathWrite($"1/({mathExpression})"); // Sử dụng biểu thức
            textBoxResult.Text = FormatResult(result);
            isDefaultInput = true;

            // Cập nhật giá trị nền để tiếp tục tính toán
            if (isTypingFirstValue)
            {
                firstValue = result;
                isTypingFirstValue = false; // Coi như đã nhập xong số đầu tiên
            }
            else if (isTypingSecondValue)
            {
                secondValue = result;
                // Vẫn giữ isTypingSecondValue = true, chờ phép toán
            }
            else // Trường hợp vừa bấm =
            {
                firstValue = result;
            }
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {
            // ...
        }

        // ... (Các hàm button 0-9) ...
        private void button0_Click(object sender, EventArgs e) { Write('0'); }
        private void button1_Click(object sender, EventArgs e) { Write('1'); }
        private void button2_Click(object sender, EventArgs e) { Write('2'); }
        private void button3_Click(object sender, EventArgs e) { Write('3'); }
        private void button4_Click(object sender, EventArgs e) { Write('4'); }
        private void button5_Click(object sender, EventArgs e) { Write('5'); }
        private void button6_Click(object sender, EventArgs e) { Write('6'); }
        private void button7_Click(object sender, EventArgs e) { Write('7'); }
        private void button8_Click(object sender, EventArgs e) { Write('8'); }
        private void button9_Click(object sender, EventArgs e) { Write('9'); }
        private void buttonDot_Click(object sender, EventArgs e) { Write(','); }


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

            if (isDefaultInput || current.Contains("Error"))
            {
                return; // Không xóa số 0 mặc định hoặc lỗi
            }

            // Xóa ký tự cuối
            current = current.Substring(0, current.Length - 1);

            // Nếu rỗng hoặc chỉ còn dấu "-"
            if (string.IsNullOrEmpty(current) || current == "-")
            {
                InputDelete(); // Đặt lại là "0"
                return;
            }

            // Nếu ký tự cuối bị xóa là dấu "." phân cách
            if (current.EndsWith("."))
                current = current.Substring(0, current.Length - 1);

            // Kiểm tra lại nếu xóa hết (ví dụ: "-." -> "-")
            if (string.IsNullOrEmpty(current) || current == "-")
            {
                InputDelete(); // Đặt lại là "0"
                return;
            }

            // Nếu xóa dấu ","
            if (current.EndsWith(","))
            {
                textBoxResult.Text = current; // Tạm thời cho phép "123,"
                return;
            }


            // Xử lý lại định dạng
            string sign = current.StartsWith("-") ? "-" : "";
            string currentNoSign = current.StartsWith("-") ? current.Substring(1) : current;

            if (current.Contains(","))
            {
                // Nếu đang có phần thập phân, không format lại
                textBoxResult.Text = current;
            }
            else
            {
                // Nếu chỉ còn phần nguyên, format lại
                string integerPart = currentNoSign.Replace(".", "");
                textBoxResult.Text = sign + FormatWithDots(integerPart);
            }

        }

        private void buttonPm_Click(object sender, EventArgs e)
        {
            if (isTypingFirstValue || isTypingSecondValue)
            {
                // Case 1: Đang gõ số
                // if (isDefaultInput && textBoxResult.Text == "0") return; // Không đổi dấu số 0 (đã xử lý trong ToggleSign)
                ToggleSign(); // Chỉ đổi dấu số trên màn hình
            }
            else
            {
                // Case 2: Ngay sau khi nhấn = (hoặc 1/x, Sqrt, x²) (CẬP NHẬT LOGIC)
                string mathExpression = GetMathExpressionForSingleOp(); // Lấy biểu thức

                firstValue = -firstValue; // Đổi dấu giá trị kết quả
                textBoxResult.Text = FormatResult(firstValue); // Cập nhật hiển thị
                MathWrite($"negate({mathExpression})"); // Sử dụng biểu thức
                isDefaultInput = true; // Sẵn sàng cho phép tính mới
            }
        }

        // --- SỬA LỖI 2: Dùng FormatResult và kiểm tra lỗi ---
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (isTypingFirstValue)
            {
                // TH: Bấm "5 ="
                firstValue = GetValue();
                MathWrite(FormatResult(firstValue) + " =");
                isTypingFirstValue = false; // Đã xong số đầu tiên
            }
            else if (isTypingSecondValue)
            {
                // TH: Bấm "5 + 3 ="
                secondValue = GetValue();
                // Lấy biểu thức trước đó (ví dụ: "5 +")
                string mathPrefix = textBoxPre.Text.TrimEnd(' ');
                MathWrite(mathPrefix + " " + FormatResult(secondValue) + " =");

                if (!CalculateBinaryToFirstValue())
                {
                    HandleCalculationError("Cannot divide by zero");
                    return;
                }

                textBoxResult.Text = FormatResult(firstValue);
                isTypingSecondValue = false; // Đã tính xong
            }
            else
            {
                // TH: Bấm "5 + 3 = = =" (lặp lại phép toán)
                // firstValue là 8, secondValue là 3, mathType là Add
                string currentFirstValStr = FormatResult(firstValue);

                // --- SỬA LỖI THEO YÊU CẦU ---
                // Lấy toán tử trực tiếp từ mathType, không parse chuỗi textBoxPre.Text
                string op = "";
                switch (mathType)
                {
                    case MathType.Add: op = "+"; break;
                    case MathType.Minus: op = "-"; break;
                    case MathType.Times: op = "×"; break;
                    case MathType.Divide: op = "÷"; break;
                    case MathType.None:
                        // Trường hợp "5 = =", không làm gì cả (lỗi "5 0 =" đã sửa)
                        isDefaultInput = true;
                        return; // Thoát sớm
                }
                // --- KẾT THÚC SỬA LỖI ---

                // Hàm này sẽ dùng (firstValue = 8) và (secondValue = 3) để tính toán
                if (!CalculateBinaryToFirstValue())
                {
                    HandleCalculationError("Cannot divide by zero");
                    return;
                }
                // firstValue bây giờ là 11

                // Hiển thị: "8 + 3 ="
                MathWrite($"{currentFirstValStr} {op} {FormatResult(secondValue)} =");
                // Hiển thị kết quả: 11
                textBoxResult.Text = FormatResult(firstValue);
            }
            isDefaultInput = true;
        }

        // --- SỬA LỖI 2, 3: Dùng FormatResult, cập nhật textBoxResult, kiểm tra lỗi ---
        private void SetUpForBinaryOperator(MathType type)
        {
            // Xử lý lỗi nếu người dùng bấm 5 + Error
            if (textBoxResult.Text.Contains("Error"))
            {
                Reset(); // Hoặc chỉ HandleCalculationError
                return;
            }

            if (isTypingSecondValue)
            {
                // TH: Phép toán chuỗi "5 + 3 -"
                secondValue = GetValue();
                if (!CalculateBinaryToFirstValue())
                {
                    HandleCalculationError("Cannot divide by zero");
                    return;
                }
                // *** SỬA LỖI 3: Cập nhật kết quả trung gian ***
                textBoxResult.Text = FormatResult(firstValue);
            }
            else
            {
                // TH: Phép toán đầu tiên "5 +"
                firstValue = GetValue();
                isTypingFirstValue = false;
            }

            // Thiết lập cho phép toán MỚI
            isTypingSecondValue = true; // Luôn sẵn sàng chờ số thứ 2
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
            // *** SỬA LỖI 2: Dùng FormatResult ***
            MathWrite($"{FormatResult(firstValue)} {setOperator}");
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

        // --- THÊM LOGIC MỚI (CẬP NHẬT LOGIC) ---
        private void buttonSquare_Click(object sender, EventArgs e)
        {
            double currentValue = GetValue();
            string mathExpression = GetMathExpressionForSingleOp(); // Lấy biểu thức
            double result = currentValue * currentValue;

            MathWrite($"sqr({mathExpression})"); // Sử dụng biểu thức
            textBoxResult.Text = FormatResult(result);
            isDefaultInput = true;

            // Cập nhật giá trị nền để tiếp tục tính toán
            if (isTypingFirstValue)
            {
                firstValue = result;
                isTypingFirstValue = false; // Coi như đã nhập xong số đầu tiên
            }
            else if (isTypingSecondValue)
            {
                secondValue = result;
                // Vẫn giữ isTypingSecondValue = true, chờ phép toán
            }
            else // Trường hợp vừa bấm =
            {
                firstValue = result;
            }
        }

        // --- THÊM LOGIC MỚI (CẬP NHẬT LOGIC) ---
        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            double currentValue = GetValue();

            // Kiểm tra lỗi căn bậc hai của số âm
            if (currentValue < 0)
            {
                HandleCalculationError("Invalid input");
                return;
            }

            string mathExpression = GetMathExpressionForSingleOp(); // Lấy biểu thức
            double result = Math.Sqrt(currentValue);
            MathWrite($"sqrt({mathExpression})"); // Sử dụng biểu thức
            textBoxResult.Text = FormatResult(result);
            isDefaultInput = true;

            // Cập nhật giá trị nền để tiếp tục tính toán
            if (isTypingFirstValue)
            {
                firstValue = result;
                isTypingFirstValue = false; // Coi như đã nhập xong số đầu tiên
            }
            else if (isTypingSecondValue)
            {
                secondValue = result;
                // Vẫn giữ isTypingSecondValue = true, chờ phép toán
            }
            else // Trường hợp vừa bấm =
            {
                firstValue = result;
            }
        }

        // --- THÊM LOGIC MỚI: NÚT PHẦN TRĂM (%) ---
        private void buttonPercent_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Contains("Error")) return;

            double currentValue = GetValue();
            double result = 0;
            string mathExpression = "";

            if (isTypingFirstValue)
            {
                // TH 1: Bấm "500 %" -> Kết quả là 0 (theo máy tính Windows)
                result = 0;
                mathExpression = "0";
                firstValue = result;
                // isTypingFirstValue vẫn là true (hoặc reset)
                isTypingFirstValue = true;
                isTypingSecondValue = false;
            }
            else if (isTypingSecondValue)
            {
                // TH 2: Bấm "100 + 50 %"
                // Giá trị % được tính toán và lưu vào secondValue
                if (mathType == MathType.Add || mathType == MathType.Minus)
                {
                    // 100 + (50% của 100) = 100 + 50
                    result = firstValue * (currentValue / 100);
                }
                else if (mathType == MathType.Times || mathType == MathType.Divide)
                {
                    // 100 * (50%) = 100 * 0.5
                    result = currentValue / 100;
                }

                secondValue = result; // Cập nhật secondValue để dùng khi nhấn "="

                // Lấy toán tử để hiển thị
                char opChar = ' ';
                switch (mathType)
                {
                    case MathType.Add: opChar = '+'; break;
                    case MathType.Minus: opChar = '-'; break;
                    case MathType.Times: opChar = '×'; break;
                    case MathType.Divide: opChar = '÷'; break;
                }
                mathExpression = $"{FormatResult(firstValue)} {opChar} {FormatResult(result)}";

                // Sau khi nhấn %, secondValue đã được chốt.
                // Trạng thái chuyển về "chờ" (giống như vừa nhấn "=")
                isTypingSecondValue = false;
            }
            else
            {
                // TH 3: Bấm sau dấu = (ví dụ: "100 + 10 = (110) %")
                // Kết quả là 0 (theo máy tính Windows)
                result = 0;
                mathExpression = "0";
                firstValue = result;
                isTypingFirstValue = true; // Sẵn sàng cho phép tính mới
            }

            MathWrite(mathExpression);
            textBoxResult.Text = FormatResult(result);
            isDefaultInput = true;
        }


        // --- THÊM CÁC HÀM BỘ NHỚ ---

        // (Bạn có thể thêm 1 Label tên 'labelMemory' vào Form
        // và gọi UpdateMemoryLabel() trong các hàm này để thấy chữ M)
        private void UpdateMemoryLabel()
        {
            if (labelMemory != null) // Giả định labelMemory tồn tại trong Designer
            {
                // Thay đổi logic từ Visible sang Text
                labelMemory.Text = memoryValue.ToString();
            }
        }

        private void buttonMC_Click(object sender, EventArgs e)
        {
            memoryValue = 0;
            UpdateMemoryLabel();
        }

        private void buttonMR_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = FormatResult(memoryValue);
            isDefaultInput = true;
            // Giá trị này sẽ được GetValue() lấy khi bấm phép toán tiếp theo
        }

        private void buttonMplus_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Contains("Error")) return;
            memoryValue += GetValue();
            isDefaultInput = true; // Kết thúc thao tác nhập
            UpdateMemoryLabel();
        }

        private void buttonMminus_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Contains("Error")) return;
            memoryValue -= GetValue();
            isDefaultInput = true; // Kết thúc thao tác nhập
            UpdateMemoryLabel();
        }

        private void buttonMS_Click(object sender, EventArgs e)
        {
            if (textBoxResult.Text.Contains("Error")) return;
            memoryValue = GetValue();
            isDefaultInput = true; // Kết thúc thao tác nhập
            UpdateMemoryLabel();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edit đi");
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Viuuu");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn cần giúp đỡ, OK");
        }
    }
}