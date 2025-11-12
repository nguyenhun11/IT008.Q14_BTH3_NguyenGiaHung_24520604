using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai9
{
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }

        Dictionary<string, List<string>> subjectsByMajor = new Dictionary<string, List<string>>
        {
            {
                "Công nghệ phần mềm", new List<string>
                {
                    "Nhập môn công nghệ phần mềm",
                    "Kiểm thử phần mềm",
                    "Quản lý dự án phần mềm"
                    // ... thêm các môn khác
                }
            },
            {
                "Khoa học máy tính", new List<string>
                {
                    "Cấu trúc dữ liệu và giải thuật",
                    "Trí tuệ nhân tạo",
                    "Hệ điều hành"
                    // ... thêm các môn khác
                }
            },
            {
                "Kỹ thuật máy tính", new List<string>
                {
                    "Kiến trúc máy tính",
                    "Vi xử lý",
                    "Thiết kế hệ thống nhúng"
                    // ... thêm các môn khác
                }
            }
            // ... Thêm các chuyên ngành còn lại
        };
        private void buttonChoose_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 1. Lấy tên chuyên ngành đã chọn
            // Dùng SelectedItem.ToString() sẽ an toàn hơn .Text
            if (comboBoxMajor.SelectedItem == null)
            {
                return; // Nếu không có gì được chọn, thì thoát
            }
            string selectedMajor = comboBoxMajor.SelectedItem.ToString();

            // 2. Kiểm tra xem chuyên ngành có trong Dictionary không
            // (Giả sử Dictionary của bạn tên là Major_Subject như bạn đã đặt)
            if (subjectsByMajor.ContainsKey(selectedMajor))
            {
                // 3. Lấy danh sách môn học
                List<string> subjects = subjectsByMajor[selectedMajor];

                // 4. CẬP NHẬT LISTBOX (Phần quan trọng)

                // Bước 1: Xóa tất cả các mục cũ
                listBoxAble.Items.Clear();

                // Bước 2: Thêm tất cả các mục mới từ danh sách
                // (Phải dùng .ToArray() vì AddRange yêu cầu một mảng)
                listBoxAble.Items.AddRange(subjects.ToArray());
            }
            else
            {
                // Nếu chuyên ngành không có trong Dictionary, cũng nên xóa list
                listBoxAble.Items.Clear();
            }
        }

        private void checkBoxMale_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBoxFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}
