# BÁO CÁO THỰC HÀNH 3 - LẬP TRÌNH TRỰC QUAN
| Họ và tên | MSSV | Lớp |
| :--- | :--- | :--- |
| **Nguyễn Gia Hưng** | **24520604** | **IT008.Q14.1** |

## I. Tổng quan
## 1. Các bài thực hành
1. [Vòng đời của form](#1-vòng-đời-của-form)
2. [Sự kiện Paint](#2-sự-kiện-paint)
3. [Đổi màu nền bất kỳ](#3-đổi-màu-nền-bất-kỳ)
4. [Chọn màu nền](#4-chọn-màu-nền)
5. [Máy tính đơn giản](#5-máy-tính-đơn-giản)
6. [Máy tính mô phỏng calculator của Windows](#6-máy-tính-mô-phỏng-calculator-của-windows)
7. [Đặt vé xem phim](#7-đặt-vé-xem-phim)
8. [Quản lý tài khoản ngân hàng](#8-quản-lý-tài-khoản-ngân-hàng)
9. [Quản lý sinh viên](#9-quản-lý-sinh-viên)
## 2. Chạy thử các bài thực hành
- Chạy file [BTH3_NguyenGiaHung_24520604.sln](./BTH3_NguyenGiaHung_24520604.sln)
- Mở list ***Startup Item*** và chọn bài cần chạy, sau đó ***Start*** 

<!-- ![hướng dẫn](image/huongDan.png) -->

## II. Nội dung báo cáo
### 1️⃣ Vòng đời của form
#### Mô tả chương trình
- Yêu cầu:  Viết chương trình minh họa các sự kiện trong vòng đời của form
- Hướng xử lý:
    - Một form tổng có thể tạo ra các form con và đánh số thứ tự các form tạo ra
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

Clip minh họa
![](video/Bai1.mp4)


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

### 3️⃣ Đổi màu nền bất kỳ
#### Mô tả chương trình
- Yêu cầu: 
    - Viết chương trình minh họa sự kiện Click trên Button
    - Khi nhấn vào nút Change Color sẽ tiến hành chuyển màu nền của Form sang một màu ngẫu nhiên
- Hướng xử lý: Tại sự kiện Click của Button Change Color, thay đổi BackColor của Form thành màu RGB ngẫu nhiên nhờ Random

#### Nội dung code
- [Thư mục bài 3](./Bai03/)
- [ChangeColor.cs](./Bai03/ChangeColor.cs)
- [ChangeColor.Designer.cs](./Bai03/ChangeColor.Designer.cs)

#### Kiểm thử chương trình
Các trường hợp: click vào button Change Color

Video minh họa

### 4️⃣ Chọn màu nền
#### Mô tả chương trình
- Yêu cầu:
    - Viết chương trình minh họa sử dụng Menu và hộp thoại ColorDialog
    - Khi chọn chức năng Color trong menu Format sẽ mở ra hộp thoại ColorDialog
    - Sau  khi  chọn  màu  trong  hộp  thoại  ColorDialog  sẽ  tiến hành đổi  màu  nền  của  Form theo màu đã chọn
- Hướng xử lý:
    - Tạo menutrip có Format và Color trong đó
    - Khi click vào Color sẽ mở ColorDialog và chọn màu mong muốn
    - Nếu DialogResult là OK thì đặt BackColor là màu đã chọn

### 5. Máy tính đơn giản

### 6. Máy tính mô phỏng calculator của Windows

### 7. Đặt vé xem phim

### 8. Quản lý tài khoản ngân hàng

### 9. Quản lý sinh viên
