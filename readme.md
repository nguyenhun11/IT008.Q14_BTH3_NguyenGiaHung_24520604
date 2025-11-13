# BÁO CÁO THỰC HÀNH 3 - LẬP TRÌNH TRỰC QUAN
| Họ và tên | MSSV | Lớp |
| :--- | :--- | :--- |
| **Nguyễn Gia Hưng** | **24520604** | **IT008.Q14.1** |

## I. Tổng quan
## 1. Các bài thực hành
1. [Vòng đời của form](#1-vòng-đời-của-form)
2. [Sự kiện Paint](#2-sự-kiện-paint)
3. [Minh họa sự kiện Click trên Button](#3️⃣-minh-họa-sự-kiện-click-trên-button)
4. [Bài 4.	Minh họa sử dụng Menu và hộp thoại ColorDialog](#4-chọn-màu-nền)
5. [Máy tính đơn giản](#5-máy-tính-đơn-giản)
6. [Máy tính mô phỏng calculator của Windows](#6-máy-tính-mô-phỏng-calculator-của-windows)
7. [Đặt vé xem phim](#7-đặt-vé-xem-phim)
8. [Quản lý tài khoản ngân hàng](#8-quản-lý-tài-khoản-ngân-hàng)
9. [Quản lý sinh viên](#9-quản-lý-sinh-viên)
## 2. Chạy thử các bài thực hành
- Chạy file [BTH3_NguyenGiaHung_24520604.sln](./BTH3_NguyenGiaHung_24520604.sln)
- Mở list ***Startup Item*** và chọn bài cần chạy, sau đó ***Start*** 

<!-- ![hướng dẫn](image/huongDan.png) -->
### 3. Video minh họa
- Xem đầy đủ trên playlist [Báo cáo lập trình trực quan 3](https://youtube.com/playlist?list=PLdcN3QW0mt2w8-pIhZBgHjUvyLp4gqZhw&si=o05H7OKdVqsBVZpB)

## II. Nội dung báo cáo
### 1️⃣ Vòng đời của form
#### Mô tả chương trình
- Yêu cầu:  Viết chương trình minh họa các sự kiện trong vòng đời của form
- Hướng xử lý:
    - Một form tổng có thể tạo ra các form con và đánh số thứ tự các form tạo ra
        - Form tổng có button tạo ra form con
        - Có một textbox lớn để hiển thị trạng thái vòng đời của form con, bên cạnh là button xóa textbox để dễ quan sát
    - Các form con gửi thông báo về form tổng mỗi khi sự kiện liên quan đến vòng đời của form được kích hoạt
    - Form tổng tổng hợp các thông báo gửi về từ các form con, in ra thông báo thể hiện giai đoạn vòng đời của form con đã gửi (thông báo hỗ trợ đánh số thứ tự dòng, và xóa các dòng thông báo cũ)
#### Nội dung code
- [Thư mục bài 1](./Bai1/)
- Form chính
    - [MainForm.cs](./Bai1/MainForm.cs)
    - [MainForm.Design.cs](./Bai1/MainForm.Designer.cs)
- Các form demo
    - [DemoForm.cs](./Bai1/DemoForm.cs)
    - [DemoForm.Designer.cs](./Bai1/DemoForm.Designer.cs)
#### Kiểm thử chương trình
Các trường hợp
- Tạo một form con, đóng ngay form con
- Tạo một form con, chuyển các cửa sổ qua lại để form con **Deactivate** và **Activate** luân phiên
- Nhiều form con xuất hiện, kích hoạt và kết thúc

[Video minh họa](https://youtu.be/Wa-0478Xb-k)

### 2️⃣ Sự kiện Paint
#### Mô tả chương trình
- Yêu cầu: 
    - Viết chương trình minh họa sự kiện Paint trên Form
    - Mỗi khi sự kiện Paint xảy ra sẽ vẽ lại chuỗi “Paint Event” tại một vị trí x, y ngẫu nhiên trên Form
- Hướng xử lý:
    - Thêm vào sự kiện Paint của form, khi xảy ra thì vẽ lại chuỗi “Paint Event” tại một vị trí ngẫu nhiên
    - Thêm một khung textbox thể hiện trạng thái của form khi kích hoạt Paint
        - Resize (khi thay đổi kích thước form)
        - Invalidate (cũng kích hoạt Paint của form)
    - Thêm các nút refresh lại Form (xóa hình vẽ), Xóa thông báo và Invalidate (kích hoạt Paint thủ công)
#### Nội dung code
- [Thư mục bài 2](./Bai2/)
- [PaintForm.cs](./Bai2/PaintForm.cs)
- [PaintForm.Designer.cs](./Bai2/PaintForm.Designer.cs)

#### Kiểm thử chương trình
Các trường hợp
- Thay đổi kích thước form
- Nhấn vào button Invalidate để kích hoạt Paint bằng click

Video minh họa


### 3️⃣ Minh họa sự kiện Click trên Button
#### Mô tả chương trình
- Yêu cầu: 
    - Viết chương trình minh họa sự kiện Click trên Button
    - Khi nhấn vào nút Change Color sẽ tiến hành chuyển màu nền của Form sang một màu ngẫu nhiên
- Hướng xử lý: 
    - Tạo một button Change Color
    - Tại sự kiện Click của Button Change Color, thay đổi BackColor của Form thành màu RGB ngẫu nhiên nhờ Random

#### Nội dung code
- [Thư mục bài 3](./Bai03/)
- [ChangeColor.cs](./Bai03/ChangeColor.cs)
- [ChangeColor.Designer.cs](./Bai03/ChangeColor.Designer.cs)

#### Kiểm thử chương trình
Các trường hợp: click vào button Change Color

Video minh họa

### 4️⃣ Bài 4.	Minh họa sử dụng Menu và hộp thoại ColorDialog
#### Mô tả chương trình
- Yêu cầu:
    - Viết chương trình minh họa sử dụng Menu và hộp thoại ColorDialog
    - Khi chọn chức năng Color trong menu Format sẽ mở ra hộp thoại ColorDialog
    - Sau  khi  chọn  màu  trong  hộp  thoại  ColorDialog  sẽ  tiến hành đổi  màu  nền  của  Form theo màu đã chọn
- Hướng xử lý:
    - Tạo menutrip có Format và Color trong đó
    - Khi click vào Color sẽ mở ColorDialog và chọn màu mong muốn
    - Nếu DialogResult là OK thì đặt BackColor là màu đã chọn
#### Nội dung code

#### Kiểm thử chương trình
Các trường hợp:
- Chọn được màu phù hợp và click OK
- Click vào Cancle, không chọn màu
- Tắt chương trình khi chưa chọn màu xong

Video minh họa


### 5️⃣ Máy tính đơn giản
#### Mô tả chương trình
- Yêu cầu:
    - Xây dựng ứng ựng GUI có giao diện tính toán cơ bản
    - Người dụng nhập 2 số vào textbox
    - 4 button thực hiện chức năng cộng, trừ, nhân, chia
    - Sau khi click, kết quả xuất hiện tại textbox Answer
- Hướng xử lý:
    - Cần phương thức lấy giá trị số từ hai textbox Input, nếu nhập không hợp lệ thì thông báo bằng Message box.
    - Thực hiện tính năng tính toán cho sự kiện Click của các button tương ứng và gửi kết quả xuống textbox kết quả. Riêng phép chia nếu number2 $=0$ thì gửi xuống kết quả là không thể chia cho $0$.
#### Nội dung code

#### Kiểm thử chương trình
Các trường hợp:
- Nhập 2 số nguyên hợp lệ khác $0$ và click vào 4 phép tính
- Nhập 2 số thực hợp lệ khác $0$ và click vào 4 phép tính
- Nhập số thứ 2 là $0$ để kiểm tra phép chia
- Nhập vào dữ liệu không hợp lệ (ký tự chữ, khoảng trắng)

Video minh họa



### 6. Máy tính mô phỏng calculator của Window
#### Mô tả chương trình
- Yêu cầu: Xây dựng ứng Calculator có giao diện tương tự Calculator của Window
- Hướng xử lý cơ bản:
    - Tạo menutrip, các button số, phép tính, thao tác xóa và bộ nhớ, 2 textbox hiển thị số đang nhập (input/textBoxResult) và phép toán đang tính (math/textBoxPre).
    - Xử lý thao tác nhập dữ liệu cho sự kiện Click của các button số, dấu ",".
    - Trong lớp `Calculator`, tạo các biến tính toán như giá trị thứ nhất (`firstValue`) và thứ 2 (`secondValue`) cho toán tử 2 ngôi, loại phép tính (`mathType`) như cộng, trừ, nhân, chia và không. Đặt các biến bool cho biết đang nhập giá trị nào (`isTypingFirstValue`, `isTypingSecondValue`), giá trị trên Input là giá trị mặc định hay người dùng tạo (`isDefaultInput`)
- Hướng xử lý chi tiết:
    - Xử lý Nhập liệu: 
        - Kiểm tra `isDefaultInput` nghĩa là số `0` mặc định hoặc là kết quả của phép tính trước, sẽ xóa số trên khung input trước khi ta nhập số mới
        - Xử lý dấu "," để đảm bảo chỉ có một dấu "," cho số thập phân. Phương thức `FormatWithDots` xử lý dấu "." cho phần nguyên cách mỗi 3 số
        - `GetValue()` lấy dữ liệu từ input, chuyển về dạng `double` hợp lệ, bên cạnh `FormatResult()` chuyển từ `double` sang dạng hiển thị phù hợp với khung input
    - Xử lý phép toán 2 ngôi (+, –, ×, ÷)
        - Khi nhấn vào một phép tính, phải kiểm tra và tính toán phép tính đang chờ và cập nhật vào giá trị 1, sau đó cho phép nhập tiếp giá trị 2.
        - Xử lý cách tính toán cho mỗi button, riêng phép chia sẽ báo ra kết quả `Cannot divide by zero`
    - Xử lý dấu bằng = 
        - Nếu đang nhập `firstValue`, chỉ lưu giá trị đang nhập vào `firstValue` và hiển thị chỉ phép $=$ trên thanh tính toán
        - Nếu đang nhập `secondValue`, tính toán kết quả và lưu vào `firstValue` sau đó hiển thị kết quả lên input, dòng phép tính trên thanh math
        - Nếu nhấn dấu $=$ liên tiếp mà không nhập số mới, sẽ lặp lại phép toán cuối cùng bằng cách sử dụng `secondValue` và `mathType` đã được lưu
    - Xử lý phép toán 1 ngôi:
        - Lấy giá trị hiện tại và thực hiện phép toán lập tức
        - Hiển thị kết quả lên thanh input và thanh math, lưu kết quả tính vào `firstValue`
    - Chức năng xử lý trạng thái CE, C, DEL và quản lý bộ nhớ
#### Nội dung code

#### Kiểm thử chương trình
Các trường hợp
- Các thao tác nhập liệu
    - Nhập số nguyên (kiểm tra ký tự tối đa, xử lý dấu . mỗi 3 số)
    - Kiểm tra dấu , của số thập phân, nhiều dấu ,
    - Các thao tác DEL, C, CE
    - Nút đổi dấu +/- khi đang nhập input
    - Click dấu = khi đang nhập input
- Các toán tử 2 ngôi
    - Phép toán đơn giản với số tự nhiên, số thực
    - Phép chia số thực và chia $0$
    - Nhập dấu = liên tiếp, kết nối nhiều phép toán, nhiều dấu =
- Toán tử một ngôi
    - Chọn phép toán 1 ngôi khi nhập giá trị đầu tiên
    - Chọn phép toán 1 ngôi sau khi chọn phép toán 2 ngôi và đang nhập giá trị thứ 2
    - Nhiều phép toán 1 ngôi, kết hợp với dấu =
    - Kiểm tra căn của số âm
- Thao tác bộ nhớ kiểm tra các thao tác bộ nhớ

Video minh họa

### 7. Đặt vé xem phim
#### Mô tả chương trình
- Yêu cầu:
    -  Xây dựng ứng dụng giúp cho rạp chiếu phim quản lý việc bán vé
    - Rạp có 3 hàng ghế, mỗi hàng có 5 ghế, các ghế được đánh số từ 1 đến 15 và được phân thành 3 dãy. Giá vé của mỗi dãy là 5000, 6500 và 8000 một vé
    - Trên Form trình bày một sơ đồ các chỗ ngồi để người sử dụng chọn vị trí muốn mua. Trên sơ đồ này cũng thể hiện những vị trí đã bán vé và những vị trí chưa bán vé bằng cách thể hiện màu khác nhau (ghế chưa bán vé màu trắng, ghế đã bán vé màu vàng)
    - Click vào một chỗ, chuyển từ:
        - Trắng sang xanh
        - Xanh sang trắng
        - Vàng thì in ra thông báo đã bán
    - Click vào nút chọn:
        - Tất cả nút xanh chuyển sang vàng
        - Tính tổng giá các chỗ xanh và in ra thành tiền
    - Click vào nút hủy:
        - Tất cả nút xanh chuyển thành trắng
        - Hiển thị tổng tiền là 0
    - Click vào kết thúc: thoát chương trình
- Hướng xử lý:
    - Tạo lớp `Seat` quản lý chỗ ngồi, gồm các biến màu, biến trạng thái đã bán, chưa bán và đang chọn, không chọn, cùng giá vé. Cùng với các hàm xử lý chọn, đặt vé và hủy bỏ
    - Tạo list 15 Seat quản lý 15 chỗ, thêm các button chỗ, các button thao tác và tổng tiền, sắp xếp giao diện
    - Xử lý các thao tác chọn, hủy bỏ

#### Nội dung code

#### Kiểm thử chương trình
Các trường hợp
- Chọn 1 hoặc nhiều chỗ ngồi trống, bỏ chọn, chọn ghế đã bán
- Click chọn khi chọn 1, nhiều ghế, và khi không chọn ghế
- Hủy bỏ 1 ghế, nhiều ghế, và khi không chọn ghế
- Đang chọn và đóng chương trình

Video minh họa

### 8. Quản lý tài khoản ngân hàng
#### Mô tả chương trình
- Yêu cầu:
    - Xây dựng chương trình quản lý thông tin tài khoản cần lưu trữ các thông tin sau: số tài khoản, tên khách hàng, địa chỉ khách hàng và số tiền trong tài khoản. Thiết kế chương trình quản lý thông tin tài khoản cho một ngân hàng có giao diện
    - 

### 9. Quản lý sinh viên
