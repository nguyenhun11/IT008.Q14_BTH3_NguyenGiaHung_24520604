using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Cinema : Form
    {
        #region Dữ liệu chỗ ngồi
        enum SeatStatus
        {
            Unsold, Sold
        }
        class Seat
        {
            public SeatStatus status { get; private set; }
            public bool isChoosing { get; private set; }
            public Button button { get; private set; }
            public int price;
            Color emptyColor = Color.Gainsboro;
            Color chooseColor = Color.PaleTurquoise;
            Color soldColor = Color.PaleGoldenrod;

            public Seat(Button button, int price = 0)
            {
                this.button = button;
                button.BackColor = emptyColor;
                status = SeatStatus.Unsold;
                isChoosing = false;
                this.price = price;
            }

            public bool Choose()
            {
                if (status == SeatStatus.Sold)
                {
                    MessageBox.Show("Chỗ ngồi đã được bán!");
                    return false;
                }
                else
                {
                    if (isChoosing)
                    {
                        isChoosing = false;
                        button.BackColor = emptyColor;
                        return false;
                    }
                    else
                    {
                        isChoosing = true;
                        button.BackColor = chooseColor;
                        return true;
                    }
                }
            }

            public int Order()
            {
                if (!isChoosing || status == SeatStatus.Sold)
                {
                    return 0;
                }
                isChoosing = false;
                status = SeatStatus.Sold;
                button.BackColor = soldColor;
                return price;
            }

            public void Cancel()
            {
                if (status == SeatStatus.Unsold && isChoosing)
                {
                    isChoosing = false;
                    button.BackColor = emptyColor;
                }
            }
        }
        List<Seat> seats;
        #endregion

        public Cinema()
        {
            InitializeComponent();
            HideTotalCost();
            // Khởi tạo và gán các button vào dữ liệu chỗ ngồi
            seats = new List<Seat>();
            seats.Add(null);
            seats.Add(new Seat(button1));
            seats.Add(new Seat(button2));
            seats.Add(new Seat(button3));
            seats.Add(new Seat(button4));
            seats.Add(new Seat(button5));
            seats.Add(new Seat(button6));
            seats.Add(new Seat(button7));
            seats.Add(new Seat(button8));
            seats.Add(new Seat(button9));
            seats.Add(new Seat(button10));
            seats.Add(new Seat(button11));
            seats.Add(new Seat(button12));
            seats.Add(new Seat(button13));
            seats.Add(new Seat(button14));
            seats.Add(new Seat(button15));
            for(int i = 1; i <= 15; i++)
            {
                if(i <= 5)
                {
                    seats[i].price = 5000;
                }
                else if (i <= 10)
                {
                    seats[i].price = 6500;
                }
                else
                {
                    seats[i].price = 8000;
                }
                // Khi chọn chỗ ngồi, ẩn thanh thành tiền đi
                seats[i].button.Click += (s, e) => HideTotalCost();

            }
        }

        // Ẩn thanh thành tiền
        void HideTotalCost()
        {
            panelThanhTien.Visible = false;
        }

        // Nút chọn
        private void buttonChoose_Click(object sender, EventArgs e)
        {
            int total = 0;
            foreach( Seat seat in seats)
            {
                if (seat is null) continue;
                total += seat.Order();
            }
            panelThanhTien.Visible = true;
            textBoxCost.Text = total.ToString();
        }

        // Nút hủy
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            foreach (Seat seat in seats)
            {
                if (seat is null) continue;
                seat.Cancel();
            }
            panelThanhTien.Visible = true;
            textBoxCost.Text = "0";
        }

        // Nút kết thúc
        private void buttonEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Các nút chọn chỗ ngồi
        private void button1_Click(object sender, EventArgs e)
        {
            seats[1].Choose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            seats[2].Choose();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            seats[3].Choose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            seats[4].Choose();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            seats[5].Choose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            seats[6].Choose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            seats[7].Choose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            seats[8].Choose();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            seats[9].Choose();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            seats[10].Choose();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            seats[11].Choose();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            seats[12].Choose();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            seats[13].Choose();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            seats[14].Choose();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            seats[15].Choose();
        }
    }
}
