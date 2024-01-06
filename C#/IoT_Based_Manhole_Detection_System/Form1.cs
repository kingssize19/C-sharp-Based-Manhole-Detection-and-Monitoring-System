using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IoT_Based_Manhole_Detection_System
{
    public partial class Form1 : Form
    {
        private int waterValue = 0;
        private int gasValue = 0;
        private int lightValue = 0;
        private int soundValue = 0;

        public Form1()
        {
            InitializeComponent();

            cBoxMic.DropDownStyle = ComboBoxStyle.DropDown;
            cBoxMic.DropDown += new EventHandler(cBoxMic_DropDown);

            cBoxGas.DropDownStyle = ComboBoxStyle.DropDown;
            cBoxGas.DropDown += new EventHandler(cBoxGas_DropDown);

            cBoxLight.DropDownStyle = ComboBoxStyle.DropDown;
            cBoxLight.DropDown += new EventHandler(cBoxLight_DropDown);

            cBoxWater.DropDownStyle = ComboBoxStyle.DropDown;
            cBoxWater.DropDown += new EventHandler(cBoxWater_DropDown);
        }
        private void cBoxMic_DropDown(object sender, EventArgs e)
        {
            cBoxMic.Items.Clear();
            cBoxMic.Items.Add("Short Time");
            cBoxMic.Items.Add("Middle Time");
            cBoxMic.Items.Add("Long Time");
            cBoxMic.Items.Add("OFF");
            
        }

        private void cBoxGas_DropDown(object sender, EventArgs e)
        {
            cBoxGas.Items.Clear();
            cBoxGas.Items.Add("Slow Speed");
            cBoxGas.Items.Add("Medium Speed");
            cBoxGas.Items.Add("Fast Speed");
            cBoxGas.Items.Add("OFF");
            

        }

        private void cBoxLight_DropDown(object sender, EventArgs e)
        {
            cBoxLight.Items.Clear();
            cBoxLight.Items.Add("Little Brightness");
            cBoxLight.Items.Add("Medium Brightness");
            cBoxLight.Items.Add("High Brightness");
            cBoxLight.Items.Add("OFF");

        }
        private void cBoxWater_DropDown(object sender, EventArgs e)
        {
            cBoxWater.Items.Clear();
            cBoxWater.Items.Add("Low Speed");
            cBoxWater.Items.Add("Medium Speed");
            cBoxWater.Items.Add("High Speed");
            cBoxWater.Items.Add("OFF");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            cBoxCOMPORT.Items.AddRange(ports);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cBoxBAUDRATE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cBoxDATABITS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = cBoxCOMPORT.Text;
                serialPort1.BaudRate = Convert.ToInt32(cBoxBAUDRATE.Text);
                serialPort1.DataBits = Convert.ToInt32(cBoxDATABITS.Text);
                serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cBoxSTOPBITS.Text);
                serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), cBoxPARITYBITS.Text);

                serialPort1.Open();
                progressBar1.Value = 100;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Close();
                progressBar1.Value = 0;
            }
        }

        private void sendMicValue_Click(object sender, EventArgs e)
        {

            try
            {
                if(serialPort1.IsOpen)
                {
                    string selectedMicValue = cBoxMic.SelectedItem.ToString();
                    string messageToSend = String.Empty;

                    switch(selectedMicValue)
                    {
                        case "Short Time":
                            messageToSend = "Buzzer Time = 2000";
                            break;
                        case "Middle Time":
                            messageToSend = "Buzzer Time = 8000";
                            break;
                        case "Long Time":
                            messageToSend = "Buzzer Time = 16000";
                            break;
                        case "OFF":
                            messageToSend = "Buzzer Time = 0";
                            break;
                        default:
                            break;
                    }

                    //Send Message
                    serialPort1.WriteLine(messageToSend);
                    MessageBox.Show("Buzzer Time Value: " + messageToSend);
                }
                else
                {
                    MessageBox.Show("Serial port connection is not established or open.");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }

        }

        private void sendWaterValue_Click(object sender, EventArgs e)
        {
            try
            {
                if(serialPort1.IsOpen)
                {
                    string selectedWaterValue = cBoxWater.SelectedItem.ToString();
                    string messageToSend = string.Empty;

                    switch(selectedWaterValue)
                    {
                        case "Low Speed":
                            messageToSend = "Servo Speed = 15";
                            break;
                        case "Medium Speed":
                            messageToSend = "Servo Speed = 8";
                            break;
                        case "High Speed":
                            messageToSend = "Servo Speed = 1";
                            break;
                        case "OFF":
                            messageToSend = "Servo Speed = 30";
                            break;
                        default:
                            break;
                    }

                    //Send To Message
                    serialPort1.WriteLine(messageToSend);
                    MessageBox.Show("Servo Speed Value: " + messageToSend);
                }
                else
                {
                    MessageBox.Show("Serial port connection is not established or open.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void sendGasValue_Click(object sender, EventArgs e)
        {
            try
            {
                if(serialPort1.IsOpen)
                {
                    string selectedGasValue = cBoxGas.SelectedItem.ToString();
                    string messageToSend = string.Empty;

                    switch(selectedGasValue)
                    {
                        case "Slow Speed":
                            messageToSend = "Fan Speed = 830";
                            break;
                        case "Medium Speed":
                            messageToSend = "Fan Speed = 450";
                            break;
                        case "Fast Speed":
                            messageToSend = "Fan Speed = 0";
                            break;
                        case "OFF":
                            messageToSend = "Fan Speed = 1200";
                            break;
                        default:
                            break;
                    }

                    //Send To Message
                    serialPort1.WriteLine(messageToSend);
                    MessageBox.Show("Fan Speed Value: " + messageToSend);
                }
                else
                {
                    MessageBox.Show("Serial port connection is not established or open.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void sendLightValue_Click(object sender, EventArgs e)
        {
            try
            {
                if(serialPort1.IsOpen)
                {
                    string selectedLightValue = cBoxLight.SelectedItem.ToString();
                    string messageToSend = string.Empty;

                    switch(selectedLightValue)
                    {
                        case "Little Brightness":
                            messageToSend = "Light Intensity = 20";
                            break;
                        case "Medium Brightness":
                            messageToSend = "Light Intensity = 250";
                            break;
                        case "High Brightness":
                            messageToSend = "Light Intensity = 800";
                            break;
                        case "OFF":
                            messageToSend = "Light Intensity = 0";
                            break;
                        default:
                            break;
                    }

                    //Send To Message
                    serialPort1.WriteLine(messageToSend);
                    MessageBox.Show("Light Intensity Value: " + messageToSend);
                }
                else
                {
                    MessageBox.Show("Serial port connection is not established or open.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void cBoxMic_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void cBoxGas_SelectedIndexChanged(object sender, EventArgs e)
        {
      
        }

        private void cBoxLight_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void micStatus_Click(object sender, EventArgs e)
        {

        }

        private void gasStatus_Click(object sender, EventArgs e)
        {

        }

        private void waterStatus_Click(object sender, EventArgs e)
        {

        }

        private void lightStatus_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen && serialPort1.BytesToRead > 0)
            {
                string receivedData = serialPort1.ReadLine();
                HandleReceivedData(receivedData);
            }
        }

        private void HandleReceivedData(string receivedData)
        {
            string[] dataValues = receivedData.Split(',');
            if(dataValues.Length >= 4)
            {
                try
                {
                    waterValue = int.Parse(dataValues[0]);
                    gasValue = int.Parse(dataValues[1]);
                    lightValue = int.Parse(dataValues[2]);
                    soundValue = int.Parse(dataValues[3]);

                    CheckStatus(waterValue, gasValue, lightValue, soundValue);
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Data processing error: " + ex.Message);
                }
            }
        }
        /*
        private void CheckStatus(int waterValue, int gasValue, int lightValue, int soundValue)
        {

           
            string waterStatus = waterValue == 0 ? "It is Normal" : "Dangerous!! Water level is HIGH";
            string gasStatus = gasValue == 0 ? "It is normal." : "Dangerous!! Gas level is HIGH";
            string lightStatus = lightValue == 0 ? "It is normal." : "Dangerous!! Light level is HIGH";
            string soundStatus = soundValue == 0 ? "It is normal." : "Dangerous!! Sound level is HIGH";

            waterStatusLabel.Text = "Water Status: " + waterStatus;
            gasStatusLabel.Text = "Gas Status: " + gasStatus;
            lightStatusLabel.Text = "Light Status: " + lightStatus;
            soundStatusLabel.Text = "Sound Status: " + soundStatus;
            
        }
        */
        private void CheckStatus(int waterValue, int gasValue, int lightValue, int soundValue)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate {
                    string waterStatus = waterValue == 0 ? "It is Normal" : "Dangerous!! Water level is HIGH";
                    string gasStatus = gasValue == 0 ? "It is normal." : "Dangerous!! Gas level is HIGH";
                    string lightStatus = lightValue == 0 ? "It is normal." : "Dangerous!! Light level is HIGH";
                    string soundStatus = soundValue == 0 ? "It is normal." : "Dangerous!! Sound level is HIGH";

                    waterStatusLabel.Text = "Water Status: " + waterStatus;
                    gasStatusLabel.Text = "Gas Status: " + gasStatus;
                    lightStatusLabel.Text = "Light Status: " + lightStatus;
                    soundStatusLabel.Text = "Sound Status: " + soundStatus;
                }));
            }
            else
            {
                // Bu kod zaten UI thread'inde çalışıyor.
                string waterStatus = waterValue == 0 ? "It is Normal" : "Dangerous!! Water level is HIGH";
                string gasStatus = gasValue == 0 ? "It is normal." : "Dangerous!! Gas level is HIGH";
                string lightStatus = lightValue == 0 ? "It is normal." : "Dangerous!! Light level is HIGH";
                string soundStatus = soundValue == 0 ? "It is normal." : "Dangerous!! Sound level is HIGH";

                waterStatusLabel.Text = "Water Status: " + waterStatus;
                gasStatusLabel.Text = "Gas Status: " + gasStatus;
                lightStatusLabel.Text = "Light Status: " + lightStatus;
                soundStatusLabel.Text = "Sound Status: " + soundStatus;
            }
        }


        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string receivedData = serialPort1.ReadLine();
            HandleReceivedData(receivedData);
        }

        
    }
}
