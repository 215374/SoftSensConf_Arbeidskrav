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
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Globalization;




namespace SoftSensConf_Arbeidskrav
{
    public partial class Form1 : Form
        
    {
        List<int> analogReading = new List<int>();
        List<DateTime> timeStamp = new List<DateTime>();

        List<float> scaledReading = new List<float>();
        List<DateTime> timeStampScaled = new List<DateTime>();
        public Form1()
        {
            InitializeComponent();
            comboBoxPort.Items.AddRange(SerialPort.GetPortNames());
            comboBoxPort.Text = "--Select--";
            string[] bitRate = new string[] { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };  // Teksten med alternativene i nedtrekksmenyene til comboBoxPort og comboBoxBit

            comboBoxBit.Items.AddRange(bitRate);
            comboBoxBit.SelectedIndex = comboBoxBit.Items.IndexOf("9600");
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataRecievedHandler);
           


            timerRaw.Interval = 5000;
            timerRaw.Tick += new EventHandler(timerRaw_Tick);

            timerScaled.Interval = 5000;
            timerScaled.Tick += new EventHandler(timerScaled_Tick);

        }

        private void timerScaled_Tick(object sender, EventArgs e)
        {
            serialPort1.WriteLine("readscaled");
        }

        private void timerRaw_Tick(object sender, EventArgs e)
        {
            serialPort1.WriteLine("readraw");
        }

        void DataRecievedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string RecievedData = ((SerialPort)sender).ReadLine();
            string[] recievedData = RecievedData.Split(';');
            string[] separateParts = RecievedData.Split(';');

            int iVab;
            float iVab_float;
            //textBoxSend.Invoke((MethodInvoker)delegate //{ textBoxSend.AppendText(separateParts[1] + "\r\n"); });
            //{

            if (separateParts[0] == "readstatus")
            {
                labelAlarmStatus.Invoke((MethodInvoker)delegate
                {


                if (separateParts[1].Trim() == "0")
                {
                    labelAlarmStatus.Text = "ok";
                }

                if (separateParts[1].Trim() == "1")
                {
                    labelAlarmStatus.Text = "fail";
                }

                if (separateParts[1].Trim() == "2")
                {
                    labelAlarmStatus.Text = "alarm lower";
                }

                if (separateParts[1].Trim() == "3")
                {
                    labelAlarmStatus.Text = "alarm upper";
                }
                });
            }



            if (recievedData[0] == "readconf")
            {
                textBoxSerialResult.Invoke((MethodInvoker)delegate
                {
                    labelAdress.Text = recievedData[1];
                    labelUpperValue.Text = recievedData[3];
                    labelLowerValue.Text = recievedData[2];
                    labelAlarmUpper.Text = recievedData[5];
                    labelAlarmLower.Text = recievedData[4];

                });
            }
        //});
                

            
            if (recievedData[0] == "writeconf")
            {
                textBoxSerialResult.Invoke((MethodInvoker)delegate
                {
                    if (RecievedData == "writeconf;0")
                    {
                        MessageBox.Show("Wrong Password! Try again");
                    }
                    if (RecievedData == "writeconf;1")
                    {
                        MessageBox.Show("Correct Password! Instrument Configuration has been updated!");
                        serialPort1.WriteLine("readconf");
                    }
                });
            }

            if (separateParts[0] == "readraw")
            { 
                if (int.TryParse(separateParts[1], out iVab))
                {
                    analogReading.Add(iVab);
                    timeStamp.Add(DateTime.Now);
                    textBoxSend.Invoke((MethodInvoker)delegate { Chart.Series["Vba"].Points.DataBindXY(timeStamp, analogReading); });
                    textBoxSend.Invoke((MethodInvoker)delegate { Chart.Invalidate(); });
                    textBoxSend.Invoke((MethodInvoker)delegate { textBoxSend.AppendText(separateParts[1] + "\r\n"); });
                    serialPort1.WriteLine("readstatus");

                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }

            if (separateParts[0] == "readscaled")
            {
                if (float.TryParse(separateParts[1], NumberStyles.Float, CultureInfo.InvariantCulture, out iVab_float))
                    textBoxSend.Invoke((MethodInvoker)delegate
                    {
                        scaledReading.Add(iVab_float);
                        timeStampScaled.Add(DateTime.Now);
                        Chart.Series["Vba"].Points.DataBindXY(timeStampScaled, scaledReading);
                        Chart.Invalidate();
                        textBoxSend.Invoke((MethodInvoker)delegate { textBoxSend.AppendText(separateParts[1] + "\r\n"); });
                        serialPort1.WriteLine("readstatus");

                    });
            }

        }
        private void Connect_Button_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                serialPort1.PortName = comboBoxPort.Text;
                //StatusTimer.Start();
                while (serialPort1.IsOpen) ;
                serialPort1.Open();
                MessageBox.Show("Connection established to " + comboBoxPort.Text);

                /*textBoxConStatInstrument.Clear();
                textBoxConStatInstrument.AppendText(" Connected ");
                textBoxIndicator1.BackColor = Color.Green; // grønn farge på indicator når den er connected*/
            }
            catch (Exception ex)
            {
                serialPort1.Close();
                if (ex is ArgumentException)
                {
                    MessageBox.Show("Cannot Connect! Port might be in use ");
                    /*StatusTimer.Stop();
                    SerialStatusTextBox.Clear();
                    
                    SerialStatusTextBox.AppendText("Cant Connect!");
                    textBoxIndicator1.BackColor = Color.Red*/
                }
                else if (ex is UnauthorizedAccessException)
                {
                    //StatusTimer.Stop();
                    //SerialStatusTextBox.Clear();
                    MessageBox.Show("Not connected. Port may be in use.");
                    //textBoxIndicator1.BackColor = Color.Red;
                }
                else
                {
                    //StatusTimer.Stop();
                    //SerialStatusTextBox.Clear();
                    MessageBox.Show(ex.ToString());
                }

            }
        }//Connect_Button i Tab.1

        private void D_Connect_Button_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            MessageBox.Show(" Disconnected from " + comboBoxPort.Text);

        }//Disconnect_Button i Tab 1

        private void buttonReadCurrentValue_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                MessageBox.Show("Current value loaded");
                serialPort1.WriteLine("readconf");
            }
            else
            {
                MessageBox.Show("Current value not loaded");
            }
        }   //henter currentvalue fra Arduino og poster i current parameters

        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                StreamReader inputfile = new StreamReader(@filename);

                string text = inputfile.ReadLine();
                string[] splitelements = text.Split(';');
                textBoxAdress.Text = splitelements[0];
                textBoxLowerValue.Text = splitelements[2];
                textBoxUpperValue.Text = splitelements[1];
                textBoxAlarmUpper.Text = splitelements[4];
                textBoxAlarmLower.Text = splitelements[3];
            }
        } //Henter current value fra fil og poster i current parameters

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            {
                string a = labelAdress.Text;
                string uv = labelUpperValue.Text;
                string lv = labelLowerValue.Text;
                string al = labelAlarmLower.Text;
                string au = labelAlarmUpper.Text;
                string[] viewconf = { a, uv, lv, al, au };
                string viewConf = string.Join(";", viewconf);

                SaveFileDialog saveConfigDialog = new SaveFileDialog();
                saveConfigDialog.Filter = "txt files (.ssc)|.ssc|All files (.)|.";
                if (saveConfigDialog.ShowDialog() == DialogResult.OK)
                {
                    Stream s = File.Open(saveConfigDialog.FileName, FileMode.CreateNew);
                    StreamWriter sw = new StreamWriter(s);
                    {
                        sw.Write(viewConf);
                        sw.Close();
                    }
                }
            }
        } // Save To File knappen lagrer current parameters til fil

        private string getNewSerial()
        {
            return textBoxAdress.Text;
        }
        private float getNewUpperValue()
        {
            return float.Parse(textBoxUpperValue.Text);
        }
        private float getNewLowerValue()
        {
            return float.Parse(textBoxLowerValue.Text);
        }
        private int getNewAlarmUpper()
        {
            return int.Parse(textBoxAlarmUpper.Text);
        }
        private int getNewAlarmLower()
        {
            return int.Parse(textBoxAlarmLower.Text);
        }

        private string ValidateText(string a, float lv, float uv, int al, int au)

        {
            if (a.Length == 0 || a.Length < 10 || a.Length > 10)
            {
                MessageBox.Show("Serial Number Lenght is invalid! It must be 10 characters!");
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
            else        //If all the checks above are passed return the string
            {


                string newa = a.ToString();
                string newuv = lv.ToString();
                string newlv = uv.ToString();
                string newal = al.ToString();
                string newau = au.ToString();
                string[] newargs = { newa, newuv, newlv, newal, newau };
                string NewConf = string.Join(";", newargs);                     //String joined with ; that the instrument needs
                return NewConf;                                   //New config returned 


            }
        }
 
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string a = getNewSerial();
            float lv = getNewLowerValue();
            float uv = getNewUpperValue();
            int al = getNewAlarmLower();
            int au = getNewAlarmUpper();
            string sendAll = ValidateText(a, lv, uv, al, au);
            string passwordbox = Interaction.InputBox("Authentication is required to update instrument values. Please enter password:", "Authentication Required", "..", 10, 10);
            serialPort1.WriteLine("writeconf" + ">" + passwordbox + ">" + sendAll);
            
        }



        

        private void buttonManual_Click(object sender, EventArgs e) //ReadRaw
        {
            timerScaled.Stop();
            if (serialPort1.IsOpen)
            {
                textBoxCommando.Text = "readraw";
                textBoxCommando.ReadOnly = true;
                timerRaw.Start();
            }
            else
            {
                MessageBox.Show("Port not open!");
            }
            label18.Text = "Raw Values";
        }

        private void buttonAuto_Click(object sender, EventArgs e) //Readscaled
        {
            timerRaw.Stop();
            if (serialPort1.IsOpen)
            {
                textBoxCommando.Text = "readscaled";
                textBoxCommando.ReadOnly = true;
                timerScaled.Start();
            }
            else
            {
                MessageBox.Show("Port not open!");
            }
            label18.Text = "Scaled Values";
        }

        private void buttonStop_Click(object sender, EventArgs e) //Stop + save
        {
            if (serialPort1.IsOpen)
            {
                textBoxCommando.ReadOnly = false;
                timerRaw.Stop();
                timerScaled.Stop();

                DialogResult dialogResult = MessageBox.Show("Do you want to save file?", "Save To File", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    StreamWriter Save = new StreamWriter(@"C:\Users\ander\OneDrive\Skrivebord\Test.csv");
                    Save.WriteLine("Dato : " + DateTime.Now.ToString()); Save.Write(textBoxSend.Text);
                    MessageBox.Show("Saving completed!");
                    Save.Close();
                }



                else
                {
                    MessageBox.Show("Port not open!");
                }
            }
        }

        private void D_Connect_Button_Click_1(object sender, EventArgs e)
        {
            serialPort1.Close();
            MessageBox.Show(" Disconnected from " + comboBoxPort.Text);
        }
    }
}
