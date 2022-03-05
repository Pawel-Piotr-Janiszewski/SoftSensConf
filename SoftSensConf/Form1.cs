using System;
using System.IO;
using System.Globalization;
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
using System.Windows.Forms.DataVisualization.Charting;

namespace SoftSensConf
{
    public partial class SoftSensConf : Form
    {
        List<int> rawReading = new List<int>();
        List<float> ScaledReading = new List<float>();
        List<string> timeStampRaw = new List<string>();
        List<string> timeStampScaled = new List<string>();
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
            MonitorTimer.Interval = 2000;
            MonitorTimer.Tick += new EventHandler(MonitorTimer_Tick);
            AlarmTimer.Interval = 1500;
            AlarmTimer.Tick += new EventHandler (AlarmTimer_Tick);
        }
        void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string RecievedData = ((SerialPort)sender).ReadLine();
            string[] recievedData = RecievedData.Split(';');
            int iVab;
            

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
                
            }

            if (recievedData[0] =="writeconf" && recievedData[1] == "0\r")
            {
                MessageBox.Show("Wrong Password! Try again! Instrument Configuration has not been changed!");
            }

            if (recievedData[0] == "readstatus" && recievedData[1] == "0\r")
            {
                SerialStatusTextBox.Invoke((MethodInvoker)delegate
                {
                    string ok = "Ok";
                    AlarmStatus.Text = ok;
                    AlarmLightStatus.BackColor = Color.Green;
                });
            }
            if (recievedData[0] == "readstatus" && recievedData[1] == "1\r")
            {
                SerialStatusTextBox.Invoke((MethodInvoker)delegate
                {
                    string ok = "Fail";
                    AlarmStatus.Text = ok;
                    AlarmLightStatus.BackColor = Color.Red;
                });
            }

            if (recievedData[0] == "readstatus" && recievedData[1] == "2\r")
            {
                SerialStatusTextBox.Invoke((MethodInvoker)delegate
                {
                    string ok = "Alarm Low";
                    AlarmStatus.Text = ok;
                    AlarmLightStatus.BackColor = Color.Yellow;
                });
            }

            if (recievedData[0] == "readstatus" && recievedData[1] == "3\r")
            {
                SerialStatusTextBox.Invoke((MethodInvoker)delegate
                {
                    string ok = "Alarm High";
                    AlarmStatus.Text = ok;
                    AlarmLightStatus.BackColor = Color.Red;
                });
            }

            if (recievedData[0] == "readraw")
            {
                

                MonitorList.Invoke((MethodInvoker)delegate
                {
                    MonitorList.Items.Add("RawData" + "," + DateTime.Now.ToString("HH:mm:ss") + ", " + recievedData[1] + "\n");
                    if (int.TryParse(recievedData[1], out iVab))
                    {
                        rawReading.Add(iVab);
                        timeStampRaw.Add(DateTime.Now.ToString());
                        MonitorList.Invoke((MethodInvoker)delegate
                        {
                            MonitorPlot.Series["Instrument Values"].Points.DataBindXY(timeStampRaw, rawReading);
                        });
                        MonitorList.Invoke((MethodInvoker)delegate
                        { MonitorPlot.Invalidate(); });
                    }
                    else
                    {
                        MessageBox.Show("Didnt work");
                    }
                });
            }

            if (recievedData[0] == "readscaled")
            {
                float scaled;
                MonitorList.Invoke((MethodInvoker)delegate
                {
                    MonitorList.Items.Add("ScaledData" + "," + DateTime.Now.ToString("HH:mm:ss") + "," + recievedData[1] + "\n");
                    string data = recievedData[1];
                    scaled = float.Parse(data, CultureInfo.InvariantCulture);
                    timeStampScaled.Add(DateTime.Now.ToString());
                    ScaledReading.Add(scaled);
                    MonitorPlot.Series["Instrument Values"].Points.DataBindXY(timeStampScaled, ScaledReading);
                    MonitorPlot.Invalidate();

                });
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
                string text = "Success";
                MessageBox.Show("Connection Successfull! ");
                SerialStatusTextBox.Text = text;
                SerialLightStatus.BackColor = Color.Green;

            }
            catch (Exception ex)
            {
                serialPort1.Close();
                if (ex is ArgumentException)
                {
                    string text = "Invalid Port!";
                    StatusTimer.Stop();
                    MessageBox.Show("Invalid Port!");
                    SerialStatusTextBox.Text = text;
                    SerialLightStatus.BackColor = Color.Red;

                }
                else if (ex is UnauthorizedAccessException)
                {
                    string text = "Cant Connect!";
                    StatusTimer.Stop();
                    MessageBox.Show("Cannot Connect! Port might be in use ");
                    SerialStatusTextBox.Text = text;
                    SerialLightStatus.BackColor = Color.Red;
                }
                else
                {
                    string text = "....";
                    StatusTimer.Stop();
                    MessageBox.Show("Check if USB is connected!");
                    SerialStatusTextBox.Text = text;
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
            string text = "Disconnected!";
            serialPort1.Close();
            StatusTimer.Stop();
            MessageBox.Show("Disconnected!");
            SerialStatusTextBox.Text = text;
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
                string text = "Connected!";
                SerialStatusTextBox.Text = text;
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
                string text = "Disconnected!";
                SerialStatusTextBox.Text= text;
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
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                StreamReader inputfile = new StreamReader(@filename);

                string text = inputfile.ReadLine();
                string[] splitelements = text.Split(';');
                NewSerial.Text = splitelements[0];
                NewUpper.Text = splitelements[2];
                NewLower.Text = splitelements[1];
                NewAlarmLow.Text = splitelements[3];
                NewAlarmUP.Text = splitelements[4];
                DialogResult dialogResult = MessageBox.Show("Config from file loaded do you want to upload now?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    SendInstCont_Click(sender, e);
                }
                

                
            }
        }
        

        private void SaveConf_Click(object sender, EventArgs e)
        {
            
            string n = SerialNum.Text;
            string lv = LowVal.Text;
            string uv = UpperVal.Text;
            string al = AlarmLow.Text;
            string au = AlarmUp.Text;
            string[] sa = {n,lv,uv,al,au};
            string savearray = string.Join(";", sa);
            

            SaveFileDialog SaveConfigDialog = new SaveFileDialog();
            SaveConfigDialog.Filter = "txt files (.ssc)|.scc|All files (.)|.";
            SaveConfigDialog.Title = "Save Current Configuration";


            if (SaveConfigDialog.ShowDialog() == DialogResult.OK)
            {
                Stream s = File.Open(SaveConfigDialog.FileName, FileMode.CreateNew);
                StreamWriter sw = new StreamWriter(s);
                {
                    sw.Write(savearray);
                    sw.Close();
                }
                MessageBox.Show("File Saved Succesfully!");
            }
            
        


        }

        private void Readraw_Click(object sender, EventArgs e)
        {
            string text = "DataType,Timestamp,Values\n";
            MonitorList.Items.Clear();
            ScaledVal.Enabled = false;
            MonitorTimer.Start();
            AlarmTimer.Start();
            MonitorList.Items.Add(text);
        }

        private void StopMonitoring_Click(object sender, EventArgs e)
        {
            ScaledVal.Enabled = true;
            string text = "-";
            MonitorTimer.Stop();
            AlarmTimer.Stop();
            DialogResult dialogResult = MessageBox.Show("Monitoring has ended. Would you like to save the data?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SaveSensorData_Click(sender, e);
            }
            AlarmStatus.Text = text;
            AlarmLightStatus.BackColor = Color.White;
        }

        private void SaveSensorData_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveMonitoringDialog = new SaveFileDialog();
            SaveMonitoringDialog.Filter = "CSV file (.csv)|.csv|All files (.)|.";
            SaveMonitoringDialog.Title = "Save Monitoring Data";


            if (SaveMonitoringDialog.ShowDialog() == DialogResult.OK)
            {
                string save;
                Stream s = File.Open(SaveMonitoringDialog.FileName, FileMode.CreateNew);
                StreamWriter sw = new StreamWriter(s);
                {
                    
                    foreach (var item in MonitorList.Items)
                    {
                        save = item.ToString();
                        sw.Write(save);

                    }

                    sw.Close();
                }
                MessageBox.Show("File Saved Succesfully!");
            }
        }

        private void MonitorTimer_Tick(object sender, EventArgs e)
        {
            if (ScaledVal.Checked)
            {
                string text = "Scaled Data";
                serialPort1.WriteLine("readscaled");
                MonitorType.Text = text;


            }
            else
            {
                string text = "Raw Data";
                serialPort1.WriteLine("readraw");
                MonitorType.Text = text;
            }
        }

        private void AlarmTimer_Tick(object sender, EventArgs e)
        {
            serialPort1.WriteLine("readstatus");
        }

        private void About_Click(object sender, EventArgs e)
        {
            About aboutwindow = new About();
            aboutwindow.ShowDialog(this);
        }
    }
}

