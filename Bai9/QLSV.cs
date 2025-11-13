using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bai9
{
    

    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
            ClearInputs();
        }

        #region Thông tin sinh viên và môn học
        // Thông tin sinh viên
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

        // Các môn học theo chuyên ngành
        Dictionary<string, List<string>> subjectsByMajor = new Dictionary<string, List<string>>
        {
            {
                "Công nghệ phần mềm", new List<string>
                {
                    "Nhập môn công nghệ phần mềm",
                    "Lập trình hướng đối tượng",
                    "Cấu trúc dữ liệu và giải thuật",
                    "Cơ sở dữ liệu",
                    "Phân tích và thiết kế phần mềm",
                    "Kiểm thử phần mềm",
                    "Quản lý dự án phần mềm",
                    "Kiến trúc phần mềm",
                    "Phát triển ứng dụng Web",
                    "Phát triển ứng dụng di động",
                    "Mẫu thiết kế (Design Patterns)"
                }
            },
            {
                "Khoa học máy tính", new List<string>
                {
                    "Toán rời rạc",
                    "Cấu trúc dữ liệu và giải thuật",
                    "Hệ điều hành",
                    "Trí tuệ nhân tạo",
                    "Học máy",
                    "Lý thuyết trình biên dịch",
                    "Xử lý ngôn ngữ tự nhiên",
                    "Thị giác máy tính",
                    "Phân tích thuật toán",
                    "Lý thuyết đồ thị"
                }
            },
            {
                "Kỹ thuật máy tính", new List<string>
                {
                    "Mạch logic",
                    "Kiến trúc máy tính",
                    "Vi xử lý và vi điều khiển",
                    "Thiết kế hệ thống nhúng",
                    "Điện tử cơ bản",
                    "Tín hiệu và hệ thống",
                    "Hệ thống thời gian thực",
                    "Mạng máy tính",
                    "Lập trình hệ thống",
                    "Thiết kế VLSI"
                }
            },
            {
                "Hệ thống thông tin", new List<string>
                {
                    "Nhập môn Hệ thống thông tin",
                    "Phân tích thiết kế hệ thống thông tin",
                    "Quản trị cơ sở dữ liệu",
                    "Hệ thống thông tin quản lý (MIS)",
                    "Thương mại điện tử",
                    "Khai phá dữ liệu",
                    "Hệ hỗ trợ quyết định (DSS)",
                    "Bảo mật hệ thống thông tin",
                    "Quản lý dự án CNTT",
                    "Tích hợp hệ thống"
                }
            },
            {
                "Mạng máy tính và truyền thông", new List<string>
                {
                    "Nhập môn Mạng máy tính",
                    "Truyền dữ liệu",
                    "Mạng không dây và di động",
                    "Quản trị mạng",
                    "An ninh mạng",
                    "Lập trình mạng",
                    "Các giao thức mạng",
                    "Hệ thống mạng viễn thông",
                    "Đánh giá hiệu năng mạng",
                    "Dịch vụ mạng (DNS, DHCP, Web)"
                }
            },
            {
                "Khoa học và kỹ thuật thông tin", new List<string>
                {
                    "Nhập môn Khoa học dữ liệu",
                    "Xử lý dữ liệu lớn (Big Data)",
                    "Học máy",
                    "Khai phá dữ liệu",
                    "Phân tích dữ liệu",
                    "Trực quan hóa dữ liệu",
                    "Tìm kiếm thông tin",
                    "Hệ cơ sở dữ liệu nâng cao",
                    "Thống kê ứng dụng",
                    "Xử lý ngôn ngữ tự nhiên"
                }
            }
        };
        #endregion

        #region Nhập sinh viên
        //Lưu sinh viên
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // 1. Kiểm tra dữ liệu nhập
            if (string.IsNullOrWhiteSpace(textBoxMSSV.Text) || !long.TryParse(textBoxMSSV.Text, out _))
            {
                MessageBox.Show("Mã số sinh viên không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            // 2. Kiểm tra đã tồn tại sinh viên chưa
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

            // 3. Lấy dữ liệu từ input
            // Lấy thông tin từ các control
            string hoTen = textBoxName.Text;
            string chuyenNganh = comboBoxMajor.SelectedItem.ToString();
            string gioiTinh = radioButtonMale.Checked ? "Nam" : "Nữ";
            List<string> cacMonHoc = new List<string>();
            foreach (var item in listBoxChoose.Items)
            {
                cacMonHoc.Add(item.ToString());
            }

            // 4. Thêm hoặc cập nhật
            if (existingRow != null)
            {
                // 4.1. Cập nhật
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
                // 4.2. Thêm mới
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

            // 5. Xóa phần đã nhập trong input
            ClearInputs();
        }

        // Xóa input
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
        #endregion

        #region Chọn môn
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

        // Chọn chuyên ngành và hiển thị môn
        private void comboBoxMajor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMajor.SelectedItem == null)
            {
                listBoxAble.Items.Clear();
                return;
            }

            string selectedMajor = comboBoxMajor.SelectedItem.ToString();

            if (subjectsByMajor.ContainsKey(selectedMajor))
            {
                // Lấy tất cả môn học của chuyên ngành
                List<string> allSubjectsForNewMajor = subjectsByMajor[selectedMajor];
                // Nếu đổi chuyên ngành, xóa các môn trong ngành cũ, trừ những môn trong ngành cũ và ngành mới
                var subjectSetForNewMajor = new HashSet<string>(allSubjectsForNewMajor);

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

                // Tạo set các môn đã chọn (sau khi đã lọc)
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
        #endregion

        #region Cập nhật sinh viên

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // e.RowIndex < 0 nghĩa là người dùng nhấn vào header
            if (e.RowIndex < 0)
            {
                return;
            }

            DataGridViewRow row = dataGridView.Rows[e.RowIndex];

            // Kiểm tra xem 'Tag' có chứa đối tượng SinhVien không
            if (row.Tag is SinhVien sv)
            {
                // 1. Đổ dữ liệu cơ bản đã lưu
                textBoxMSSV.Text = sv.MSSV;
                textBoxName.Text = sv.HoTen;
                radioButtonMale.Checked = (sv.GioiTinh == "Nam");
                radioButtonFemale.Checked = (sv.GioiTinh == "Nữ");

                // 2. Đổ dữ liệu môn học đã lưu vào listBoxChoose
                listBoxChoose.Items.Clear();
                listBoxChoose.Items.AddRange(sv.CacMonHoc.ToArray());

                // 3. Đặt lại ComboBox về chuyên ngành đã lưu
                comboBoxMajor.SelectedItem = sv.ChuyenNganh;
                comboBoxMajor_SelectedIndexChanged(comboBoxMajor, EventArgs.Empty);
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // 1. LẤY MSSV TỪ TEXTBOX
            string mssvToDelete = textBoxMSSV.Text;

            if (string.IsNullOrWhiteSpace(mssvToDelete))
            {
                MessageBox.Show("Vui lòng chọn một sinh viên từ bảng để xóa, hoặc nhập MSSV của sinh viên cần xóa.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxMSSV.Focus();
                return;
            }

            //  2. TÌM SINH VIÊN TRONG DATAGRIDVIEW 
            DataGridViewRow rowToDelete = null;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // row.Cells[0] là cột MSSV
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == mssvToDelete)
                {
                    rowToDelete = row; // Đã tìm thấy
                    break;
                }
            }

            //  3. KIỂM TRA NẾU KHÔNG TÌM THẤY 
            if (rowToDelete == null)
            {
                MessageBox.Show($"Không tìm thấy sinh viên nào có MSSV là '{mssvToDelete}'.", "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //  4. HỎI XÁC NHẬN TRƯỚC KHI XÓA 
            string hoTen = rowToDelete.Cells[1].Value?.ToString() ?? "Không rõ"; // Lấy tên từ hàng sẽ xóa
            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa vĩnh viễn sinh viên:\n\nMSSV: {mssvToDelete}\nHọ tên: {hoTen}",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            //  5. TIẾN HÀNH XÓA NẾU NGƯỜI DÙNG ĐỒNG Ý 
            if (result == DialogResult.Yes)
            {
                // 6. Xóa dòng khỏi DataGridView
                dataGridView.Rows.Remove(rowToDelete);

                // 7. Xóa trống các ô input (gọi lại hàm ClearInputs)
                ClearInputs();

                MessageBox.Show("Đã xóa sinh viên thành công.", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            // Nếu người dùng chọn "No", không làm gì cả
        }
        #endregion

    }
}
