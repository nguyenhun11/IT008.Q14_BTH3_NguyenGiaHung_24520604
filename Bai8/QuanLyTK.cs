using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        // Sử dụng "out" để trả về dữ liệu nếu thành công
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
                // Đây là thông báo lỗi bạn yêu cầu
                errorMessage = "Vui lòng nhập đầy đủ thông tin!";
                return false;
            }

            // 2. Kiểm tra kiểu số
            double soTien;
            if (!double.TryParse(soTienText, out soTien))
            {
                errorMessage = "Số tiền phải là một con số hợp lệ!";
                return false;
            }

            // 3. Mọi thứ OK
            taiKhoan = new DataTK(stk, tenKH, dc, soTien);
            return true;
        }

        // 1. SỰ KIỆN CLICK CỦA NÚT "THÊM / CẬP NHẬT"
        private void buttonModify_Click(object sender, EventArgs e)
        {
            // Bước 1: Lấy và kiểm tra dữ liệu từ TextBox
            if (!TryGetData(out DataTK taiKhoanMoi, out string loiThongBao))
            {
                // Nếu dữ liệu không hợp lệ (trống hoặc sai), hiển thị lỗi và dừng lại
                MessageBox.Show(loiThongBao, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // *** THAY TÊN CỘT CỦA BẠN VÀO ĐÂY ***
            string colMaTK = "MaTK"; // Tên cột Mã tài khoản
            string colTenKH = "TenKH";     // Tên cột Tên khách hàng
            string colDiaChi = "DC";   // Tên cột Địa chỉ
            string colSoTien = "SoTien";   // Tên cột Số tiền

            // Bước 2: Tìm xem STK đã tồn tại trong DataGridView chưa
            DataGridViewRow rowDaTonTai = TimRowBangSTK(taiKhoanMoi.STK, colMaTK);

            if (rowDaTonTai == null)
            {
                // ----- TRƯỜNG HỢP 1: THÊM MỚI -----
                // (Vì STK không tìm thấy)

                // Thêm một hàng mới vào DataGridView và lấy về hàng đó
                int rowIndex = dataGridView.Rows.Add();
                DataGridViewRow newRow = dataGridView.Rows[rowIndex];

                // Gán dữ liệu vào các ô (cell) của hàng mới
                // (Nếu bạn dùng code RowPostPaint/CellPainting để tự vẽ STT thì không cần dòng colSTT)
                newRow.Cells["STT"].Value = dataGridView.Rows.Count; // STT
                newRow.Cells[colMaTK].Value = taiKhoanMoi.STK;
                newRow.Cells[colTenKH].Value = taiKhoanMoi.TenKH;
                newRow.Cells[colDiaChi].Value = taiKhoanMoi.DC;
                newRow.Cells[colSoTien].Value = taiKhoanMoi.SoTien;

                // *** Rất quan trọng: Lưu đối tượng DataTK vào Tag của Row ***
                // Điều này giúp việc tính tổng tiền sau này cực kỳ chính xác
                newRow.Tag = taiKhoanMoi;

                // Thông báo
                MessageBox.Show("Thêm mới dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // ----- TRƯỜNG HỢP 2: CẬP NHẬT -----
                // (Vì đã tìm thấy STK)

                // Chỉ cập nhật các ô dữ liệu (không cập nhật STK)
                rowDaTonTai.Cells[colTenKH].Value = taiKhoanMoi.TenKH;
                rowDaTonTai.Cells[colDiaChi].Value = taiKhoanMoi.DC;
                rowDaTonTai.Cells[colSoTien].Value = taiKhoanMoi.SoTien;

                // *** Cập nhật lại Tag của Row ***
                rowDaTonTai.Tag = taiKhoanMoi;

                // Thông báo
                MessageBox.Show("Cập nhật dữ liệu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Bước 3: Tính lại tổng tiền (cho cả 2 trường hợp)
            TinhLaiTongTien();

            // Bước 4 (Tùy chọn): Định dạng lại cột số tiền cho đẹp
            // Bạn nên làm việc này trong cửa sổ Properties của cột (DefaultCellStyle.Format = "N0")
            dataGridView.Columns[colSoTien].DefaultCellStyle.Format = "N0";
        }

        // 2. HÀM HỖ TRỢ: TÌM HÀNG (ROW) DỰA TRÊN SỐ TÀI KHOẢN
        private DataGridViewRow TimRowBangSTK(string stkCanTim, string tenCotSTK)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Bỏ qua hàng mới (hàng trống ở cuối cùng)
                if (row.IsNewRow) continue;

                // Kiểm tra giá trị của ô trong cột STK
                if (row.Cells[tenCotSTK].Value != null &&
                    row.Cells[tenCotSTK].Value.ToString() == stkCanTim)
                {
                    return row; // Trả về hàng nếu tìm thấy
                }
            }
            return null; // Trả về null nếu không tìm thấy
        }

        // 3. HÀM HỖ TRỢ: TÍNH LẠI TỔNG TIỀN
        private void TinhLaiTongTien()
        {
            double tongTien = 0;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.IsNewRow) continue;

                // Lấy dữ liệu trực tiếp từ Tag (an toàn và chính xác nhất)
                if (row.Tag is DataTK data)
                {
                    tongTien += data.SoTien;
                }

                /* // Cách 2: Lấy từ Cell (rủi ro hơn nếu dữ liệu bị format)
                try {
                    tongTien += Convert.ToDouble(row.Cells["colSoTien"].Value);
                } catch {}
                */
            }

            // Hiển thị tổng tiền lên Label (hoặc TextBox)
            // (Thay lblTongTien bằng tên control của bạn)
            //lblTongTien.Text = tongTien.ToString("N0") + " VNĐ";
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {

        }

    }
}
