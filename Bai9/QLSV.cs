using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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
            // (Giữ nguyên phần validation của bạn, nó đã tốt rồi)
            if (string.IsNullOrWhiteSpace(textBoxMSSV.Text) || !long.TryParse(textBoxMSSV.Text, out _))
            {
                MessageBox.Show("Mã số sinh viên không hợp lệ. Chỉ được nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMSSV.Focus();
                return;
            }
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

            // --- 2. TÌM SINH VIÊN HIỆN TẠI (LOGIC MỚI) ---
            string mssvToSave = textBoxMSSV.Text;
            DataGridViewRow existingRow = null;

            // Duyệt qua tất cả các dòng trong DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // row.Cells[0] là cột MSSV
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == mssvToSave)
                {
                    existingRow = row; // Đã tìm thấy
                    break;
                }
            }

            // --- 3. LẤY DỮ LIỆU TỪ INPUT ---
            // Lấy thông tin từ các control
            string hoTen = textBoxName.Text;
            string chuyenNganh = comboBoxMajor.SelectedItem.ToString();
            string gioiTinh = radioButtonMale.Checked ? "Nam" : "Nữ";
            List<string> cacMonHoc = new List<string>();
            foreach (var item in listBoxChoose.Items)
            {
                cacMonHoc.Add(item.ToString());
            }

            // --- 4. THÊM MỚI HOẶC CẬP NHẬT ---
            if (existingRow != null)
            {
                // 4A: CẬP NHẬT (UPDATE)
                SinhVien sv = (SinhVien)existingRow.Tag; // Lấy đối tượng SinhVien đã lưu

                // Cập nhật đối tượng
                sv.HoTen = hoTen;
                sv.ChuyenNganh = chuyenNganh;
                sv.GioiTinh = gioiTinh;
                sv.CacMonHoc = cacMonHoc; // Ghi đè danh sách môn học cũ

                // Cập nhật các ô trong DataGridView
                existingRow.Cells[1].Value = sv.HoTen;
                existingRow.Cells[2].Value = sv.ChuyenNganh;
                existingRow.Cells[3].Value = sv.GioiTinh;
                existingRow.Cells[4].Value = sv.CacMonHoc.Count;

                MessageBox.Show("Đã cập nhật thông tin sinh viên " + mssvToSave, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // 4B: THÊM MỚI (ADD NEW)
                SinhVien sv = new SinhVien();
                sv.MSSV = mssvToSave;
                sv.HoTen = hoTen;
                sv.ChuyenNganh = chuyenNganh;
                sv.GioiTinh = gioiTinh;
                sv.CacMonHoc = cacMonHoc;

                int rowIndex = dataGridView.Rows.Add(
                    sv.MSSV,
                    sv.HoTen,
                    sv.ChuyenNganh,
                    sv.GioiTinh,
                    sv.CacMonHoc.Count
                );

                // Lưu đối tượng vào Tag của dòng (rất quan trọng)
                dataGridView.Rows[rowIndex].Tag = sv;
            }

            // --- 5. XÓA TRẮNG INPUT ---
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

            // Giả sử Dictionary của bạn tên là subjectsByMajor
            if (subjectsByMajor.ContainsKey(selectedMajor))
            {
                // Lấy tất cả môn học của chuyên ngành MỚI
                List<string> allSubjectsForNewMajor = subjectsByMajor[selectedMajor];
                // Dùng HashSet để tra cứu nhanh (Yêu cầu 2)
                var subjectSetForNewMajor = new HashSet<string>(allSubjectsForNewMajor);

                // --- YÊU CẦU 2: Lọc các môn trong listBoxChoose ---
                // Phải duyệt ngược khi xóa các mục khỏi ListBox
                for (int i = listBoxChoose.Items.Count - 1; i >= 0; i--)
                {
                    string subject = listBoxChoose.Items[i].ToString();

                    // NẾU môn đã chọn KHÔNG có trong danh sách môn của chuyên ngành MỚI
                    if (!subjectSetForNewMajor.Contains(subject))
                    {
                        // Xóa nó khỏi danh sách đã chọn
                        listBoxChoose.Items.RemoveAt(i);
                    }
                }

                // --- YÊU CẦU 3: Cập nhật lại listBoxAble ---
                // (Code này gần giống code cũ của bạn, nhưng giờ nó chạy SAU KHI đã lọc)

                // Tạo set các môn ĐÃ CHỌN (sau khi đã lọc)
                var chosenSubjects = new HashSet<string>();
                foreach (var item in listBoxChoose.Items)
                {
                    chosenSubjects.Add(item.ToString());
                }

                // Cập nhật listBoxAble
                listBoxAble.Items.Clear();
                foreach (string subject in allSubjectsForNewMajor)
                {
                    // Chỉ thêm môn học vào listBoxAble NẾU nó CHƯA CÓ trong listBoxChoose
                    if (!chosenSubjects.Contains(subject))
                    {
                        listBoxAble.Items.Add(subject);
                    }
                }
            }
            else
            {
                // Nếu chuyên ngành không có trong dictionary (ví dụ bạn chưa thêm môn)
                listBoxAble.Items.Clear();
                listBoxChoose.Items.Clear(); // Xóa luôn các môn đã chọn
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // Duyệt qua tất cả các mục trong listBoxChoose
            // Dùng ToList() để tạo 1 bản sao, tránh lỗi "collection was modified"
            foreach (var item in listBoxChoose.Items.Cast<object>().ToList())
            {
                // Thêm mục này vào listBoxAble
                listBoxAble.Items.Add(item);

                // Xóa mục này khỏi listBoxChoose
                listBoxChoose.Items.Remove(item);
            }
        }



    }
}
