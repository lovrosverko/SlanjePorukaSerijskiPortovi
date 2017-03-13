using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace nizoviSlanjePorukaSerialPort
{
    public partial class start : Form
    {
        int servoPos1 = 90;
        SerialPort currentPort;
        bool statusLed1 = false;
        bool statusLed2 = false;

        public start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
           /* btnLed1.Enabled = false;
            btnLed2.Enabled = false;

            servo1Manje.Enabled = false;
            servo1Vise.Enabled = false;
            btnServo1.Enabled = false;
            txtStatus.Enabled = false;
            txtServoPos1.Enabled = false;
            */
         
        }

        public void SetComPort()
        {
            int baud = Convert.ToInt16(cmbBaudRate.Text);
            bool portFound;
            try
            {
                string[] ports = SerialPort.GetPortNames();
                foreach (string port in ports)
                {
                    currentPort = new SerialPort(port, baud);
                    if (DetectArduino())
                    {
                        cmbPort.Text = port;
                        portFound = true;
                        MessageBox.Show("Arduino je spojen na " + port);
                        btnFindArduino.Text = "Arduino pronađen";
                        btnFindArduino.ForeColor = Color.Green;
                        btnFindArduino.Enabled = false;
                        btnLed1.Enabled = true;
                        btnLed2.Enabled = true;
                        btnServo1.Enabled = true;
                        txtServoPos1.Enabled = true;
                        servo1Manje.Enabled = true;
                        servo1Vise.Enabled = true;
                        scrollServo1.Enabled = true;
                        break;

                    }
                    else
                    {
                        portFound = false;
                        MessageBox.Show("Nisam pronašao Arduino!");
                        btnFindArduino.ForeColor = Color.Black;

                    }
                }
            }
            catch (Exception e)
            {

            }
        }

        // metoda za pronalaženje Arduina
        public bool DetectArduino()
        {
            try
            {
                // "handshake" naredba
                byte[] buffer = new byte[5];
                buffer[0] = Convert.ToByte(16);
                buffer[1] = Convert.ToByte(128);
                buffer[2] = Convert.ToByte(0);
                buffer[3] = Convert.ToByte(0);
                buffer[4] = Convert.ToByte(4);
                int intReturnASCII = 0;
                char charReturnValue = (Char)intReturnASCII;
                currentPort.Open();
                currentPort.Write(buffer, 0, 5);
                Thread.Sleep(1000);
                int count = currentPort.BytesToRead;
                string returnMessage = "";
                while (count > 0)
                {
                    intReturnASCII = currentPort.ReadByte();
                    returnMessage = returnMessage + Convert.ToChar(intReturnASCII);
                    count--;
                }

                txtStatus.Text = returnMessage;
                currentPort.Close();
                if (returnMessage.Contains("Arduino je ovdje!"))
                {
                    return true;
                }
                else
                {

                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Nisam pronašao Arduino!");
                return false;
            }
        }

        private void btnFindArduino_Click(object sender, EventArgs e)
        {
            SetComPort();
        }

        private void btnLed1_Click(object sender, EventArgs e)
        {
            if (!statusLed1)
            {
                statusLed1 = true;
                paliLed1();
            }
            else
            {
                statusLed1 = false;
                gasiLed1();
            }
        }

        private void btnLed2_Click(object sender, EventArgs e)
        {
            if (!statusLed2)
            {
                statusLed2 = true;
                // paliLed2();
            }
            else
            {
                statusLed2 = false;
                // gasiLed2();
            }
        }

        private void paliLed1()
        {
            btnLed1.ForeColor = Color.Green;
        }
        private void gasiLed1()
        {
            btnLed1.ForeColor = Color.Green;
        }
    }
}
