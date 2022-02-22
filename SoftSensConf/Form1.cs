using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace SoftSensConf
{
    public partial class SoftSensConf : Form
    {
        public SoftSensConf()
        {
            InitializeComponent();
            ComBox.Items.AddRange(SerialPort.GetPortNames());
            ComBox.Text = "--Select--";
            string[] bitRate = new string[] { "1200", "2400", "4800t", "9600",
                                              "19200", "38400", "57600", "115200" };
            BitBox.Items.AddRange(bitRate);
            BitBox.SelectedIndex = BitBox.Items.IndexOf("9600");
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);
            StatusTimer.Interval = 500;
            StatusTimer.Tick += new EventHandler(StatusTimer_Tick);
        }
        void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string RecievedData = ((SerialPort)sender).ReadLine();
            string[] recievedData = RecievedData.Split(';');

            if (recievedData[0] == "readconf")
            {
                SerialStatusTextBox.Invoke((MethodInvoker)delegate
                  {
                      SerialNum.Text = recievedData[1];
                      UpperVal.Text = recievedData[3];
                      LowVal.Text = recievedData[2];
                      AlarmUp.Text = recievedData[5];
                      AlarmLow.Text = recievedData[4];

                  });

            }
            if (recievedData[0] == "writeconf" && recievedData[1] == "1\r")
            {
                MessageBox.Show("Correct Password! Instrument Configuration has been changed!");
                serialPort1.WriteLine("readconf");
                //MessageBox.Show(wa);
            }
            if (recievedData[0] =="writeconf" && recievedData[1] == "0\r")
            {
                MessageBox.Show("Wrong Password! Try again! Instrument Configuration has not been changed!");
            }

        }                
            
        
        private void ConnectButt_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                serialPort1.PortName = ComBox.Text;
                StatusTimer.Start();
                while (serialPort1.IsOpen) ;
                serialPort1.Open();
                SerialStatusTextBox.Clear();
                MessageBox.Show("Connection Successfull! ");
                SerialStatusTextBox.AppendText("Success!");
                SerialLightStatus.BackColor = Color.Green;

            }
            catch (Exception ex)
            {
                serialPort1.Close();
                if (ex is ArgumentException)
                {
                    StatusTimer.Stop();
                    SerialStatusTextBox.Clear();
                    MessageBox.Show("Invalid Port!");
                    SerialStatusTextBox.AppendText("Invalid Port!");
                    SerialLightStatus.BackColor = Color.Red;

                }
                else if (ex is UnauthorizedAccessException)
                {
                    StatusTimer.Stop();
                    SerialStatusTextBox.Clear();
                    MessageBox.Show("Cannot Connect! Port might be in use ");
                    SerialStatusTextBox.AppendText("Cant Connect!");
                    SerialLightStatus.BackColor = Color.Red;
                }
                else
                {
                    StatusTimer.Stop();
                    SerialStatusTextBox.Clear();
                    MessageBox.Show("Check if USB is connected!");
                    SerialLightStatus.BackColor = Color.Yellow;

                    //throw;
                }
            }
        }

        private void updateComBox_MouseClick(object sender, MouseEventArgs e)

        {
            ComBox.Items.Clear();
            ComBox.Items.AddRange(SerialPort.GetPortNames());
        }

        private void DisconnectButt_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            StatusTimer.Stop();
            MessageBox.Show("Disconnected!");
            SerialStatusTextBox.Clear();
            SerialStatusTextBox.AppendText("Disconnected!");
            SerialLightStatus.BackColor = Color.Red;
            StatusInstCon.Text = SerialStatusTextBox.Text;
            LightInstCont.BackColor = SerialLightStatus.BackColor;
            ConStatCV.Text = SerialStatusTextBox.Text;
            LightStatCV.BackColor = SerialLightStatus.BackColor;



        }

        private void CurrentConf_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Current Config Loaded!");
            serialPort1.WriteLine("readconf");


        }


        private void StatusTimer_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SerialStatusTextBox.Clear();
                SerialStatusTextBox.AppendText("Connected!");
                SerialLightStatus.BackColor = Color.Green;
                StatusInstCon.Text = SerialStatusTextBox.Text;
                LightInstCont.BackColor = SerialLightStatus.BackColor;
                ConStatCV.Text = SerialStatusTextBox.Text;
                LightStatCV.BackColor = SerialLightStatus.BackColor;
            }
            else if (serialPort1.IsOpen == false)
            {
                StatusTimer.Stop();
                MessageBox.Show("Connection lost to the instrument!");
                SerialStatusTextBox.Clear();
                SerialStatusTextBox.AppendText("Disconnected!");
                SerialLightStatus.BackColor = Color.Red;
                StatusInstCon.Text = SerialStatusTextBox.Text;
                LightInstCont.BackColor = SerialLightStatus.BackColor;
                ConStatCV.Text = SerialStatusTextBox.Text;
                LightStatCV.BackColor = SerialLightStatus.BackColor;

            }
        }
        private string getNewSerial()
        {

            return NewSerial.Text;


        }
        private float getNewUpperValue()
        {
            return float.Parse(NewUpper.Text);
        }

        private float getNewLowerValue()
        {
            return float.Parse(NewLower.Text);
        }

        private int getNewAlarmUpper()
        {
            return int.Parse(NewAlarmUP.Text);
        }
        private int getNewAlarmLower()
        {
            return int.Parse(NewAlarmLow.Text);
        }
       
        private string ValidateText(string n, float lv, float uv, int al, int au)
        {
            if (n.Length == 0 || n.Length > 10)
            {
                MessageBox.Show("Serial Number Lenght is invalid! It cannot be longer than 10 characters or have 0 characters!");
                return "";
            }
            if (lv < 0.0 || lv > 500.0)
            {
                MessageBox.Show("lower value is out of range 0.0 - 500");
                return "";
            }
            if (uv < 500.0 || uv > 1000.0)
            {
                MessageBox.Show("Upper value is out of range 500.0 - 1000.0");
                return "";
            }
            if (uv == lv)
            {
                MessageBox.Show("The upper and lower value cannot be the same!");
                return "";
            }
            if (al < 0.0 || al > 500.0)
            {
                MessageBox.Show("Alarm Lower is out of range 0.0 - 500.0");
                return "";
            }
            if (au > 1000.0)
            {
                MessageBox.Show("Alarm Upper is out of range 0.0 - 1000.0");
                return "";
            }
            if (au < al)
            {
                MessageBox.Show("Alarm Upper cannot be smaller than Alarm Lower!");
                return "";
            }
            if (au == al)
            {
                MessageBox.Show("Alarm Upper and Alarm Lower cannot be the same!");
                return "";
            }
            else
            {
                string newn = n.ToString();
                string newlv = lv.ToString();
                string newuv = uv.ToString();
                string newal = al.ToString();
                string newau = au.ToString();
                string[] newargs = {newn,newlv,newuv,newal,newau};
                string NewConf = string.Join(";", newargs);
                return NewConf;

                

            }
        }
   
        private void SendInstCont_Click(object sender, EventArgs e)
        {

            string n = getNewSerial();
            float lv = getNewLowerValue();
            float uv = getNewUpperValue();
            int al = getNewAlarmLower();
            int au = getNewAlarmUpper();
            string sendAll = ValidateText(n, lv, uv, al, au);
            string passwordbox = Interaction.InputBox("Authentication is required to update instrument values. Please enter password:", "Authentication Required", "..", 10, 10);
            serialPort1.WriteLine("writeconf"+">" + passwordbox + ">" + sendAll);
            

        }

        private void ConfFromFile_Click(object sender, EventArgs e)
        {

        }
    }
}

