using System;
using System.Windows.Forms;

namespace BUS_TRACKER
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // เปิดฟอร์มนี้ตอนเริ่มโปรแกรม
        }
    }
}
