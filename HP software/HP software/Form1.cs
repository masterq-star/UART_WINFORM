using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Threading;

namespace HP_software
{
    //public class WeatherForecast
    //{
    //    public DateTimeOffset Date { get; set; }
    //    public int TemperatureCelsius { get; set; }
    //    public string Summary { get; set; }
    //    public string SummaryField;
    //    public IList<DateTimeOffset> DatesAvailable { get; set; }
    //    public Dictionary<string, HighLowTemps> TemperatureRanges { get; set; }
    //    public string[] SummaryWords { get; set; }
    //}
    //public class HighLowTemps
    //{
    //    public int High { get; set; }
    //    public int Low { get; set; }
    //}
    public partial class Form1 : MetroSetForm
    {
        bool first_line = true, cn_or_dcn = false;
        String data_receive, String_json_data = "", old_data = "";
        Color color_red = Color.Red;
        Color color_black = Color.Black;
        Color color_blue = Color.Blue;
        Color color_dark_red = Color.DarkRed;
        





        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 101; i++)
                cbb_port_name.Items.Add("COM" + i);
            cbb_port_name.Text = Settings1.Default.Nameport;
            cbb_baudrate.Text = Settings1.Default.Baudrate;
            cbb_datasize.Text = Settings1.Default.databits;
            cbb_stop_bits.Text = Settings1.Default.Stopbits;
            cbb_parity_bits.Text = Settings1.Default.Parity;
            tb_send_data.Text = Settings1.Default.datasend;
            Thread thread_read_json_data = new Thread(json_check);
            thread_read_json_data.IsBackground = true;
            spinner_test.Speed = 1;
            spinner_test.Value = 5;
            thread_read_json_data.Start();
            
        }
        void json_check()
        {
            while (true) {
                if (NewPort.IsOpen)
                {
                    if (String_json_data == old_data) { }//gioongs nhau thi bo qua 
                    else
                    {//khac nhau thi thu xem no co phai json hay khong 
                        try
                        {
                            SENSOR sensor =
                       JsonSerializer.Deserialize<SENSOR>(String_json_data);
                            test_receive_data.SelectedText += Environment.NewLine + $"name: {sensor.sensor1}" + " : " + $"value: {sensor.value1}"
                                                              + Environment.NewLine + $"name: {sensor.sensor2}" + " : " + $"value: {sensor.value2}"
                                                              + Environment.NewLine + "name: get or set :" + " : " + $"value: {sensor.get_or_set}";
                        }
                        catch
                        {
                            test_receive_data.SelectedText += Environment.NewLine + "this string json have error";
                        }
                        old_data = String_json_data;
                    }
                }
                Thread.Sleep(10);
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            NewPort.Close();
            Settings1.Default.Nameport = cbb_port_name.Text;
            Settings1.Default.Baudrate = cbb_baudrate.Text;
            Settings1.Default.Stopbits = cbb_stop_bits.Text;
            Settings1.Default.Parity = cbb_parity_bits.Text;
            Settings1.Default.databits = cbb_datasize.Text;
            Settings1.Default.datasend = tb_send_data.Text;
            Settings1.Default.Save();
            
        }

        private void vbButton1_Click(object sender, EventArgs e)
        {
            if (!cn_or_dcn)//if current not connect
            {
                try
                {
                    NewPort.PortName = cbb_port_name.Text;
                    NewPort.BaudRate = Convert.ToInt32(cbb_baudrate.Text);
                    NewPort.DataBits = Convert.ToInt32(cbb_datasize.Text);
                    NewPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), cbb_stop_bits.Text);
                    NewPort.Parity = (Parity)Enum.Parse(typeof(Parity), cbb_parity_bits.Text);
                    NewPort.Open();
                    if (first_line)
                    {
                        first_line = false;
                        tb_receive_data.SelectedText += "Conncetion OK !!!";
                    }
                    else tb_receive_data.SelectedText = Environment.NewLine + "Conncetion OK !!!";
                    cn_or_dcn = true;
                    vbButton1.Text = "DISCONNECT";
                }
                catch (Exception err)
                {
                    tb_receive_data.SelectionColor = color_red;

                    if (first_line)
                    {
                        first_line = false;
                        tb_receive_data.SelectedText += err.Message;
                    }
                    else tb_receive_data.SelectedText = Environment.NewLine + err.Message;

                    tb_receive_data.SelectionColor = color_black;
                }

            }
            else // if current connect 
            {
                NewPort.Close();
                tb_receive_data.SelectedText += Environment.NewLine + "Disconncetion OK !!!";
                cn_or_dcn = false;
                vbButton1.Text = "CONNECT";
            }
            tb_receive_data.ScrollToCaret();

        }

        private void NewPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data_receive = NewPort.ReadExisting();
            String_json_data = data_receive;
            this.Invoke(new EventHandler(showdata));
        }

        private void showdata(object sender, EventArgs e)
        {
            tb_receive_data.SelectionColor = color_dark_red;
            tb_receive_data.SelectedText += Environment.NewLine + get_time() + "(Receivedata):" + data_receive;
            tb_receive_data.SelectionColor = color_black;
            tb_receive_data.ScrollToCaret();
        }

        private void btn_send_data_Click(object sender, EventArgs e)
        {
            if (NewPort.IsOpen)
            {
                tb_receive_data.SelectionColor = color_blue;
                NewPort.Write(tb_send_data.Text);
                tb_receive_data.SelectedText += Environment.NewLine + get_time() + "(Senddata:)" + tb_send_data.Text;
                tb_receive_data.SelectionColor = color_black;
            }
            else {
                tb_receive_data.SelectionColor = color_red;

                if (first_line)
                {
                    first_line = false;
                    tb_receive_data.SelectedText += "Port doesn't open ! please open port ";
                }
                else tb_receive_data.SelectedText = Environment.NewLine + "Port doesn't open ! please open port ";

                tb_receive_data.SelectionColor = color_black;
            }
            tb_receive_data.ScrollToCaret();
        }

        private void tb_receive_data_MouseMove(object sender, MouseEventArgs e)
        {
            if (!tb_receive_data.ClientRectangle.Contains(e.Location))
            {
                tb_receive_data.Capture = false;
            }
            else if (!tb_receive_data.Capture)
            {
                tb_receive_data.Capture = true;
            }
        }

        private void btn_test_json_Click(object sender, EventArgs e)
        {
            string jsonstring = tbjson.Text;
            try {

                SENSOR sensor =
                JsonSerializer.Deserialize<SENSOR>(jsonstring);
                test_receive_data.SelectedText += Environment.NewLine + $"name: {sensor.sensor1}" + " : " + $"value: {sensor.value1}"
                                                  + Environment.NewLine + $"name: {sensor.sensor2}" + " : " + $"value: {sensor.value2}"
                                                  //+ Environment.NewLine + $"name: {sensor.sensor3}" + " : " + $"value: {sensor.value3}"
                                                  //+ Environment.NewLine + $"name: {sensor.sensor4}" + " : " + $"value: {sensor.value4}"
                                                  //+ Environment.NewLine + $"name: {sensor.sensor5}" + " : " + $"value: {sensor.value5}"
                                                  //+ Environment.NewLine + $"name: {sensor.sensor6}" + " : " + $"value: {sensor.value6}"
                                                  //+ Environment.NewLine + $"name: {sensor.sensor7}" + " : " + $"value: {sensor.value7}"
                                                  + Environment.NewLine + "name: get or set :" + " : " + $"value: {sensor.get_or_set}"
                        ;
            }
            catch {
                test_receive_data.SelectedText += Environment.NewLine + "this string json have error";
            }

        }

        private string get_time()
        {
            return DateTime.Now.ToString();
            
        }
        
    }
}
