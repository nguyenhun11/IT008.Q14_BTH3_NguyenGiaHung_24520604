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

        #region Dữ liệu và phương thức lấy dữ liệu
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

        private bool TryGetData(out DataTK taiKhoan, out string errorMessage)
        {
            taiKhoan = new DataTK();
            errorMessage = string.Empty;

            string stk = textBoxSTK.Text;
            string tenKH = textBoxTenKH.Text;
            string dc = textBoxDC.Text;
            string soTienText = textBoxSoTien.Text;

            // Kiểm tra rỗng
            if (string.IsNullOrEmpty(stk) || string.IsNullOrEmpty(tenKH) ||
                string.IsNullOrEmpty(dc) || string.IsNullOrEmpty(soTienText))
            {
                errorMessage = "Vui lòng nhập đầy đủ thông tin!";
                return false;
            }

            // Số tài khoản chỉ được nhập số
            if (!Regex.IsMatch(stk, @"^\d+$"))
            {
                errorMessage = "Số tài khoản chỉ được phép nhập số!";
                return false;
            }

            // Kiểm tra số tiền hợp lệ
            double soTien;
            if (!double.TryParse(soTienText, out soTien))
            {
                errorMessage = "Số tiền phải là một con số hợp lệ!";
                return false;
            }

            // Trả về số tiền
            taiKhoan = new DataTK(stk, tenKH, dc, soTien);
            return true;
        }

        #endregion

        #region Các thao tác nút

        // Thêm/sửa
        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (!TryGetData(out DataTK dataTK, out string message))
            {
                MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Biến tên cột
            string colMaTK = "MaTK";
            string colTenKH = "TenKH";
            string colDiaChi = "DC";
            string colSoTien = "SoTien";

            DataGridViewRow rowDaTonTai = TimRowBangSTK(dataTK.STK, colMaTK);

            if (rowDaTonTai == null)
            {
                // Trường hợp thêm mới
                int rowIndex = dataGridView.Rows.Add();
                DataGridViewRow newRow = dataGridView.Rows[rowIndex];

                newRow.Cells[colMaTK].Value = dataTK.STK;
                newRow.Cells[colTenKH].Value = dataTK.TenKH;
                newRow.Cells[colDiaChi].Value = dataTK.DC;
                newRow.Cells[colSoTien].Value = dataTK.SoTien;
                newRow.Tag = dataTK; // Lưu dữ liệu gốc vào tag

                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Trường hợp cập nhật dữ liệu
                rowDaTonTai.Cells[colTenKH].Value = dataTK.TenKH;
                rowDaTonTai.Cells[colDiaChi].Value = dataTK.DC;
                rowDaTonTai.Cells[colSoTien].Value = dataTK.SoTien;
                rowDaTonTai.Tag = dataTK; // Cập nhật dữ liệu gốc

                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            TinhLaiTongTien();
            dataGridView.Columns[colSoTien].DefaultCellStyle.Format = "N0";

            // Xóa trường nhập dữ liệu
            XoaTrangTextBox();
        }

        // Xóa dữ liệu
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string stkCanXoa = textBoxSTK.Text;

            if (string.IsNullOrEmpty(stkCanXoa))
            {
                MessageBox.Show("Vui lòng chọn một tài khoản (hoặc nhập STK) để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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

        // CLick hiển thị lên input
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !dataGridView.Rows[e.RowIndex].IsNewRow)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[e.RowIndex];

                // Lấy dữ liệu từ Tag đã gán sau khi nhập
                if (selectedRow.Tag is DataTK data)
                {
                    textBoxSTK.Text = data.STK;
                    textBoxTenKH.Text = data.TenKH;
                    textBoxDC.Text = data.DC;
                    textBoxSoTien.Text = data.SoTien.ToString();
                }
            }
        }

        #endregion

        #region Phương thức hỗ trợ

        // Xóa dữ liệu trong input
        private void XoaTrangTextBox()
        {
            textBoxSTK.Clear();
            textBoxTenKH.Clear();
            textBoxDC.Clear();
            textBoxSoTien.Clear();
            textBoxSTK.Focus();
        }

        // Tìm row bằng STK
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

        // Tính lại tổng tiền
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
            textBoxTongTien.Text = tongTien.ToString("N0");
        }

        // Cập nhật cột STT
        private void dataGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex == dataGridView.Columns["STT"].Index && e.RowIndex >= 0)
            {
                e.PaintBackground(e.CellBounds, true);

                // Lấy số thứ tự
                string soThuTu = (e.RowIndex + 1).ToString();

                // Căn giữa
                TextFormatFlags flags = TextFormatFlags.VerticalCenter | TextFormatFlags.Left;

                // Vẽ số thứ tự vào ô
                TextRenderer.DrawText(e.Graphics, soThuTu, e.CellStyle.Font,
                                      e.CellBounds, e.CellStyle.ForeColor, flags);

                // Báo là đã tự vẽ xong
                e.Handled = true;
            }
        }

        #endregion

        // 9. HÀM MỚI: NÚT THOÁT
        // (Bạn cần liên kết sự kiện Click của nút "Thoát" với hàm này)


    }
}