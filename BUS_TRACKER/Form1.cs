using System;
using System.Drawing;
using System.Windows.Forms;

namespace BUS_TRACKER
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        PictureBox bus = new PictureBox();

        int posX = 0;
        int speed = 5;

        public Form1()
        {
            InitializeComponent();

            // ตั้งค่าฟอร์ม
            this.Text = "Bus Moving Simulation";
            this.ClientSize = new Size(800, 450);
            this.StartPosition = FormStartPosition.CenterScreen;

            // กำหนดสีพื้นหลังให้เห็นชัด
            this.BackColor = Color.LightSkyBlue;

            // สร้าง PictureBox เป็นรถ
            bus.Size = new Size(50, 30);
            bus.BackColor = Color.Red; // เป็นกล่องสีแดงแทนรถ
            bus.Left = posX;
            bus.Top = this.ClientSize.Height / 2;

            this.Controls.Add(bus);

            // ตั้ง Timer ให้เคลื่อนที่
            timer.Interval = 30; // 30 ms
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            posX += speed;

            // ถ้าวิ่งเลยขอบขวา ให้กลับมาเริ่มต้นที่ซ้าย
            if (posX > this.ClientSize.Width)
            {
                posX = -bus.Width;
            }

            bus.Left = posX;
        }
    }
}
