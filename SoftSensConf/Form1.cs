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
            // serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);
            StatusTimer.Interval = 500;
            StatusTimer.Tick += new EventHandler(StatusTimer_Tick);
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
                    SerialStatusTextBox.Clear();
                    MessageBox.Show("Invalid Port!");
                    SerialStatusTextBox.AppendText("Invalid Port!");
                    SerialLightStatus.BackColor = Color.Red;

                }
                else if (ex is UnauthorizedAccessException)
                {
                    SerialStatusTextBox.Clear();
                    MessageBox.Show("Cannot Connect! Port might be in use ");
                    SerialStatusTextBox.AppendText("Cant Connect!");
                    SerialLightStatus.BackColor = Color.Red;
                }
                else
                {
                    SerialStatusTextBox.Clear();
                    MessageBox.Show(ex.ToString());
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

        }

        private void CurrentConf_Click(object sender, EventArgs e)
        {

        }


        private void StatusTimer_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                SerialStatusTextBox.Clear();
                SerialStatusTextBox.AppendText("Success!");
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




    }
}

