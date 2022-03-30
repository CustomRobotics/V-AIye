using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace shopping_cart_pc_tester
{
    public partial class pc_tester : Form
    {
        SerialPort serial;

        public pc_tester()
        {
            InitializeComponent();

            serial = new SerialPort();
            serial.PortName = "COM4";
            serial.BaudRate = 9600;
            serial.DataReceived += Serial_DataReceived;
        }

        private void Serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke(new Action(() => { txtResponse.AppendText(serial.ReadLine() + Environment.NewLine); }));
        }

        private void btnOpen_Click(object sender, System.EventArgs e)
        {
            if(btnOpen.Text=="Open")
            {
                btnOpen.Text = "Close";
                serial.Open();
            }
            else
            {
                btnOpen.Text = "Open";
                serial.Close();
            }
        }

        private void btnForward_Click(object sender, System.EventArgs e)
        {
            serial.WriteLine("F");
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            serial.WriteLine("B");
        }

        private void btnLeft_Click(object sender, System.EventArgs e)
        {
            serial.WriteLine("L");
        }

        private void btnRigth_Click(object sender, System.EventArgs e)
        {
            serial.WriteLine("R");
        }

        private void btnStop_Click(object sender, System.EventArgs e)
        {
            serial.WriteLine("S");
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            serial.WriteLine("C");
        }
    }
}
