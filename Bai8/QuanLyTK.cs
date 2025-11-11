using System;
using System.Text.RegularExpressions; // Thêm thư viện này để kiểm tra (Regex)
using System.Windows.Forms;

namespace Bai8
{
    public partial class QuanLyTK : Form
    {
        public QuanLyTK()
        {
            InitializeComponent();
        }

        struct DataTK
        {
            public string STK;
            public string TenKH;
            public string DC;
            public double SoTien;

            public DataTK(string stk, string ten, string dc, double tien)
            {
                STK = stk;
                TenKH = ten;
                DC = dc;
                SoTien = tien;
            }
        }

        // 1. HÀM KIỂM TRA DỮ LIỆU (Đã có kiểm tra STK là số)
        private bool TryGetData(out DataTK taiKhoan, out string errorMessage)
        {
            taiKhoan = default(DataTK);
            errorMessage = string.Empty;

            string stk = textBoxSTK.Text.Trim();
            string tenKH = textBoxTenKH.Text.Trim();
            string dc = textBoxDC.Text.Trim();
            string soTienText = textBoxSoTien.Text.Trim();

            // 1. Kiểm tra trường rỗng
            if (string.IsNullOrEmpty(stk) || string.IsNullOrEmpty(tenKH) ||
                string.IsNullOrEmpty(dc) || string.IsNullOrEmpty(soTienText))
            {
                errorMessage = "Vui lòng nhập đầy đủ thông tin!";
                return false;
            }

            // 2. Kiểm tra số tài khoản chỉ là số
            if (!Regex.IsMatch(stk, @"^\d+$"))
            {
                errorMessage = "Số tài khoản chỉ được phép nhập số!";
                return false;
            }

            // 3. Kiểm tra kiểu số (cho Số tiền)
            double soTien;
            if (!double.TryParse(soTienText, out soTien))
            {
                errorMessage = "Số tiền phải là một con số hợp lệ!";
                return false;
            }

            // 4. Mọi thứ OK
            taiKhoan = new DataTK(stk, tenKH, dc, soTien);
            return true;
        }

        // 2. HÀM THÊM / CẬP NHẬT (Đã BỎ gán STT thủ công)
        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (!TryGetData(out DataTK taiKhoanMoi, out string loiThongBao))
            {
                MessageBox.Show(loiThongBao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // *** (Nhớ thay tên cột của bạn nếu khác) ***
            string colMaTK = "MaTK";
            string colTenKH = "TenKH";
            string colDiaChi = "DC";
            string colSoTien = "SoTien";

            DataGridViewRow rowDaTonTai = TimRowBangSTK(taiKhoanMoi.STK, colMaTK);

            if (rowDaTonTai == null)
            {
                // ----- TRƯỜNG HỢP 1: THÊM MỚI -----
                int rowIndex = dataGridView.Rows.Add();
                DataGridViewRow newRow = dataGridView.Rows[rowIndex];

                // Gán dữ liệu vào các ô
                // (Đã xóa dòng gán STT thủ công ở đây)
                newRow.Cells[colMaTK].Value = taiKhoanMoi.STK;
                newRow.Cells[colTenKH].Value = taiKhoanMoi.TenKH;
                newRow.Cells[colDiaChi].Value = taiKhoanMoi.DC;
                newRow.Cells[colSoTien].Value = taiKhoanMoi.SoTien;
                newRow.Tag = taiKhoanMoi; // Lưu dữ liệu gốc

                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // ----- TRƯỜG HỢP 2: CẬP NHẬT -----
                rowDaTonTai.Cells[colTenKH].Value = taiKhoanMoi.TenKH;
                rowDaTonTai.Cells[colDiaChi].Value = taiKhoanMoi.DC;
                rowDaTonTai.Cells[colSoTien].Value = taiKhoanMoi.SoTien;
                rowDaTonTai.Tag = taiKhoanMoi; // Cập nhật dữ liệu gốc

                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            TinhLaiTongTien();
            dataGridView.Columns[colSoTien].DefaultCellStyle.Format = "N0";

            // Yêu cầu: Xóa trắng các TextBox sau khi hoàn tất
            XoaTrangTextBox();
        }

        // 3. HÀM XÓA
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string stkCanXoa = textBoxSTK.Text.Trim();

            if (string.IsNullOrEmpty(stkCanXoa))
            {
                MessageBox.Show("Vui lòng chọn một tài khoản (hoặc nhập STK) để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // *** (Nhớ thay tên cột MaTK của bạn nếu khác) ***
            DataGridViewRow rowCanXoa = TimRowBangSTK(stkCanXoa, "MaTK");

            if (rowCanXoa != null)
            {
                // Hiển thị cảnh báo YES/NO
                DialogResult luaChon = MessageBox.Show(
                    $"Bạn có chắc chắn muốn xóa tài khoản {stkCanXoa} không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (luaChon == DialogResult.Yes)
                {
                    dataGridView.Rows.Remove(rowCanXoa);
                    TinhLaiTongTien();
                    XoaTrangTextBox();
                    MessageBox.Show("Xóa tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy số tài khoản cần xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 4. HÀM CLICK VÀO LƯỚI (HIỂN THỊ LÊN TEXTBOX)
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dataGridView.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                // Lấy dữ liệu từ Tag (an toàn nhất)
                if (selectedRow.Tag is DataTK data)
                {
                    textBoxSTK.Text = data.STK;
                    textBoxTenKH.Text = data.TenKH;
                    textBoxDC.Text = data.DC;
                    textBoxSoTien.Text = data.SoTien.ToString();
                }
            }
        }

        // 5. HÀM HỖ TRỢ: XÓA TRẮNG TEXTBOX
        private void XoaTrangTextBox()
        {
            textBoxSTK.Clear();
            textBoxTenKH.Clear();
            textBoxDC.Clear();
            textBoxSoTien.Clear();
            textBoxSTK.Focus();
        }

        // 6. HÀM HỖ TRỢ: TÌM HÀNG (ROW) BẰNG STK
        private DataGridViewRow TimRowBangSTK(string stkCanTim, string tenCotSTK)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Cells[tenCotSTK].Value != null &&
                    row.Cells[tenCotSTK].Value.ToString() == stkCanTim)
                {
                    return row;
                }
            }
            return null;
        }

        // 7. HÀM HỖ TRỢ: TÍNH TỔNG TIỀN
        private void TinhLaiTongTien()
        {
            double tongTien = 0;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow) continue;
                if (row.Tag is DataTK data)
                {
                    tongTien += data.SoTien;
                }
            }

            // *** THAY TÊN control TỔNG TIỀN CỦA BẠN VÀO ĐÂY ***
            // (Giả sử bạn dùng TextBox tên "textBoxTongTien" để hiển thị)
            textBoxTongTien.Text = tongTien.ToString("N0");

            // (Nếu dùng Label tên "labelTongTien")
            // labelTongTien.Text = tongTien.ToString("N0") + " VNĐ";
        }

        // 8. HÀM MỚI: TỰ ĐỘNG VẼ SỐ THỨ TỰ (STT)
        // (Bạn cần liên kết sự kiện CellPainting của DataGridView với hàm này)
        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            // *** (Nhớ thay "STT" bằng (Name) của cột STT nếu khác) ***
            if (e.ColumnIndex == dataGridView.Columns["STT"].Index && e.RowIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);

                // Lấy số thứ tự
                string soThuTu = (e.RowIndex + 1).ToString();

                // Căn giữa
                TextFormatFlags flags = TextFormatFlags.VerticalCenter | TextFormatFlags.HorizontalCenter;

                // Vẽ số thứ tự vào ô
                TextRenderer.DrawText(e.Graphics, soThuTu, e.CellStyle.Font,
                                      e.CellBounds, e.CellStyle.ForeColor, flags);

                // Báo là đã tự vẽ xong
                e.Handled = true;
            }
        }

        // 9. HÀM MỚI: NÚT THOÁT
        // (Bạn cần liên kết sự kiện Click của nút "Thoát" với hàm này)
        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult luaChon = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát chương trình không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (luaChon == DialogResult.Yes)
            {
                this.Close(); // Đóng Form
            }
        }

        private void buttonExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}