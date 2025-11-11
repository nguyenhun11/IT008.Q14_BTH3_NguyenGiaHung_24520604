using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Cinema : Form
    {
        enum SeatStatus
        {
            Unsold, Sold
        }
        class Seat
        {
            public SeatStatus status { get; private set; }
            public bool isChoosing { get; private set; }
            Button button;
            Color emptyColor = Color.Gainsboro;
            Color chooseColor = Color.PaleTurquoise;
            Color soldColor = Color.PaleGoldenrod;

            public Seat(Button button)
            {
                this.button = button;
                button.BackColor = emptyColor;
                status = SeatStatus.Unsold;
                isChoosing = false;
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
                if (!isChoosing)
                {
                    return 0;
                }
                button.BackColor = soldColor;
                return 0;
            }
        }
        static List<Seat> seats;//Dữ liệu chung

        public Cinema()
        {
            InitializeComponent();
            panelThanhTien.Visible = false;
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
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonEnd_Click(object sender, EventArgs e)
        {

        }

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
