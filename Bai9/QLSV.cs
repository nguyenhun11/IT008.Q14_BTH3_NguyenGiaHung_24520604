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

        // Đặt class này bên ngoài class QLSV, nhưng bên trong namespace
        public class SinhVien
        {
            public string MSSV { get; set; }
            public string HoTen { get; set; }
            public string ChuyenNganh { get; set; }
            public string GioiTinh { get; set; }
            public List<string> CacMonHoc { get; set; }

            public SinhVien()
            {
                // Khởi tạo danh sách môn học để tránh lỗi Null
                CacMonHoc = new List<string>();
            }
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            // --- 1. VALIDATION (Kiểm tra dữ liệu) ---

            // Kiểm tra MSSV phải là số
            if (string.IsNullOrWhiteSpace(textBoxMSSV.Text) || !long.TryParse(textBoxMSSV.Text, out _))
            {
                MessageBox.Show("Mã số sinh viên không hợp lệ. Chỉ được nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMSSV.Focus(); // Focus vào ô MSSV
                return; // Dừng lại
            }

            // Kiểm tra các trường khác
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Vui lòng nhập họ tên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxName.Focus();
                return;
            }

            if (comboBoxMajor.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn chuyên ngành.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxMajor.Focus();
                return;
            }

            // --- 2. LẤY DỮ LIỆU ---
            SinhVien sv = new SinhVien();
            sv.MSSV = textBoxMSSV.Text;
            sv.HoTen = textBoxName.Text;
            sv.ChuyenNganh = comboBoxMajor.SelectedItem.ToString();
            sv.GioiTinh = radioButtonMale.Checked ? "Nam" : "Nữ"; // Lấy từ RadioButton

            // Lấy các môn đã đăng ký từ listBoxChoose
            foreach (var item in listBoxChoose.Items)
            {
                sv.CacMonHoc.Add(item.ToString());
            }

            // --- 3. THÊM VÀO DATAGRIDVIEW ---
            int rowIndex = dataGridView.Rows.Add(
                sv.MSSV,
                sv.HoTen,
                sv.ChuyenNganh,
                sv.GioiTinh,
                sv.CacMonHoc.Count // Chỉ hiển thị SỐ MÔN như bạn yêu cầu
            );

            // !! Rất quan trọng cho Yêu cầu 3 !!
            // Lưu trữ TOÀN BỘ đối tượng 'sv' vào trong 'Tag' của dòng
            // để sau này có thể lấy lại đầy đủ thông tin.
            dataGridView.Rows[rowIndex].Tag = sv;

            // --- 4. XÓA TRẮNG INPUT ---
            ClearInputs();
        }

        // Tạo một hàm riêng để xóa input, dùng cho cả nút Save và nút Delete
        private void ClearInputs()
        {
            textBoxMSSV.Text = "";
            textBoxName.Text = "";
            comboBoxMajor.SelectedIndex = -1; // Xóa lựa chọn ComboBox
            radioButtonMale.Checked = true;  // Quay về giá trị mặc định
            radioButtonFemale.Checked = false;

            listBoxChoose.Items.Clear(); // Xóa các môn đã chọn
            listBoxAble.Items.Clear();   // Xóa các môn có thể chọn

            textBoxMSSV.Focus(); // Đưa con trỏ về ô đầu tiên
        }


        // Hàm chung để di chuyển mục được chọn từ ListBox này sang ListBox kia
        private void MoveSelectedItem(ListBox fromList, ListBox toList)
        {
            if (fromList.SelectedItem == null)
            {
                return; // Không có gì được chọn để di chuyển
            }

            // Lấy mục đã chọn
            object selectedItem = fromList.SelectedItem;

            // Thêm nó sang list kia
            toList.Items.Add(selectedItem);

            // Xóa nó khỏi list ban đầu
            fromList.Items.Remove(selectedItem);
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            // Di chuyển từ Able -> Choose
            MoveSelectedItem(listBoxAble, listBoxChoose);
        }

        private void buttonUnchoose_Click(object sender, EventArgs e)
        {
            // Di chuyển từ Choose -> Able
            MoveSelectedItem(listBoxChoose, listBoxAble);
        }


        private void comboBoxMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMajor.SelectedItem == null)
            {
                listBoxAble.Items.Clear();
                return;
            }

            string selectedMajor = comboBoxMajor.SelectedItem.ToString();

            // Giả sử Dictionary của bạn tên là Major_Subject
            if (subjectsByMajor.ContainsKey(selectedMajor))
            {
                // Lấy tất cả môn học của chuyên ngành
                List<string> allSubjects = subjectsByMajor[selectedMajor];

                // Lọc: Tạo một set (tập hợp) các môn ĐÃ CHỌN để tra cứu nhanh hơn
                var chosenSubjects = new HashSet<string>();
                foreach (var item in listBoxChoose.Items)
                {
                    chosenSubjects.Add(item.ToString());
                }

                // Cập nhật listBoxAble
                listBoxAble.Items.Clear();
                foreach (string subject in allSubjects)
                {
                    // Chỉ thêm môn học vào listBoxAble NẾU nó CHƯA CÓ trong listBoxChoose
                    if (!chosenSubjects.Contains(subject))
                    {
                        listBoxAble.Items.Add(subject);
                    }
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // e.RowIndex < 0 nghĩa là người dùng nhấn vào header, không phải dòng dữ liệu
            if (e.RowIndex < 0)
            {
                return;
            }

            // Lấy dòng hiện tại đã được nhấn
            DataGridViewRow row = dataGridView.Rows[e.RowIndex];

            // Kiểm tra xem 'Tag' có chứa đối tượng SinhVien không
            if (row.Tag is SinhVien sv)
            {
                // Nếu có, bắt đầu "đổ" dữ liệu ngược lại các control

                // 1. Đổ dữ liệu cơ bản
                textBoxMSSV.Text = sv.MSSV;
                textBoxName.Text = sv.HoTen;
                radioButtonMale.Checked = (sv.GioiTinh == "Nam");
                radioButtonFemale.Checked = (sv.GioiTinh == "Nữ");

                // 2. Đổ dữ liệu cho listBoxChoose (PHẢI LÀM TRƯỚC ComboBox)
                // Vì khi chọn ComboBox, sự kiện SelectedIndexChanged sẽ chạy
                // và nó cần biết listBoxChoose đang có gì
                listBoxChoose.Items.Clear();
                listBoxChoose.Items.AddRange(sv.CacMonHoc.ToArray());

                // 3. Đổ dữ liệu cho ComboBox
                // Dòng này sẽ tự động kích hoạt sự kiện 'comboBoxMajor_SelectedIndexChanged',
                // sự kiện này sẽ tự động điền 'listBoxAble' một cách chính xác (theo logic ở Yêu cầu 2)
                comboBoxMajor.SelectedItem = sv.ChuyenNganh;
            }
        }

        private void button1_Click(object sender, EventArgs e)
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



    }
}
