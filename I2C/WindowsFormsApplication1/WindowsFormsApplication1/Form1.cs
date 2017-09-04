using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public SerialPort port;
        Boolean connection = false;
        delegate void SetTextCallback(string text);
        private BackgroundWorker worker;
        private Thread readThread = null;
        public Form1()
        {
            InitializeComponent();
            worker = new BackgroundWorker();
        }
        //runs when form loads
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(string s in SerialPort.GetPortNames()) //this loop gets a list of the ports
            {
                comboBox_port.Items.Add(s);
            }
            comboBox_port.SelectedIndex = 0;
            comboBox_baudrate.Items.Add("9600"); //repeat this line if you need different baudrates
            comboBox_baudrate.Items.Add("4800");
            comboBox_baudrate.SelectedIndex = 0;
        }
        //connect button, opens port and starts reading loop
        private void button1_Click(object sender, EventArgs e)
        {
            if (connection == false)
            {
                //open port that you have selected
                IContainer components = new Container();
                port = new System.IO.Ports.SerialPort(components);
                port.PortName = comboBox_port.SelectedItem.ToString();
                port.BaudRate = Int32.Parse(comboBox_baudrate.SelectedItem.ToString());
                port.DtrEnable = true;
                port.ReadTimeout = 5000;
                port.WriteTimeout = 500;
                port.Open();
                //check if you actually opened the port
                if (port.IsOpen)
                {

                    readThread = new Thread(new ThreadStart(this.Read));
                    readThread.Start();
                    this.worker.RunWorkerAsync();
                    checkBox1.Checked = true;
                    connection = true;
                }
            }else if(connection == true)
            {
                connection = false;
                checkBox1.Checked = false;
                port.Close();
            }

        }
        //This sends a command to tell the arduino to read and send its result to the serial port
        private void button2_Click(object sender, EventArgs e)
        {
            if (connection)
            {
                outputBox.Clear();
                outputBox.Text = "Reading Data...";
                outputBox.Text += Environment.NewLine;
                port.Write("READ\n"); //sends command for arduino to read
            }
        }
        //This constantly runs in the background to listen form arduino. If something is caught, write to screen.
        public void Read()
        {
            while (port.IsOpen && !worker.CancellationPending)
            {
                try
                {
                    if (port.BytesToRead > 0)
                    {
                        string message = port.ReadLine();
                        SetText(message);
                        Console.WriteLine(message);
                    }
                }
                catch (TimeoutException) { }
            }
        }
        private void SetText(string text)
        {
            if (this.outputBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new Object[] { text });
            }else
            {
                outputBox.Text += text;
                outputBox.Text += Environment.NewLine;
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (!(readThread == null))
                    readThread.Abort();
            }
            catch (NullReferenceException) { }
            try
            {
                port.Close();
            }
            catch (NullReferenceException) { }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean flag = true;

            if(textBox_day.TextLength != textBox_day.MaxLength)
            {
                textBox_day.BackColor = Color.LightSalmon;
                flag = false;
            }
            if (textBox_month.TextLength != textBox_month.MaxLength)
            {
                textBox_month.BackColor = Color.LightSalmon;
                flag = false;
            }
            if (textBox_year.TextLength != textBox_year.MaxLength)
            {
                textBox_year.BackColor = Color.LightSalmon;
                flag = false;
            }
            if (textBox_serialNumber.TextLength != textBox_serialNumber.MaxLength)
            {
                textBox_serialNumber.BackColor = Color.LightSalmon;
                flag = false;
            }
            if (textBox_partNumber.TextLength != textBox_partNumber.MaxLength)
            {
                textBox_partNumber.BackColor = Color.LightSalmon;
            }

            if (flag)
            {
                outputBox.Clear();
                outputBox.Text = "Sending Data...";
                char[] day = textBox_day.Text.ToCharArray();
                char[] month = textBox_month.Text.ToCharArray();
                char[] year = textBox_year.Text.ToCharArray();
                char[] partNumber = textBox_partNumber.Text.ToCharArray();
                char[] serialNumber = textBox_serialNumber.Text.ToCharArray();

                String command1 = "EDIT1 ";
                String command2 = "EDIT2 ";
                String command3 = "EDIT3 ";
                String command4 = "EDIT4 ";
                int count = 0;

                foreach (char letter in partNumber)
                {
                    int value = Convert.ToInt32(letter);
                    if (count < 8)
                    {
                        command1 += value;
                        command1 += " ";
                        count++;
                    }
                    else
                    {
                        command2 += value;
                        command2 += " ";
                    }
                }
                foreach (char letter in serialNumber)
                {
                    int value = Convert.ToInt32(letter);
                    string hexOutput = String.Format("{0:X}", value);
                    command3 += value;
                    command3 += " ";
                }
                foreach (char letter in year)
                {
                    int value = Convert.ToInt32(letter);
                    string hexOutput = String.Format("{0:X}", value);
                    command4 += value;
                    command4 += " ";
                }
                foreach (char letter in month)
                {
                    int value = Convert.ToInt32(letter);
                    string hexOutput = String.Format("{0:X}", value);
                    command4 += value;
                    command4 += " ";
                }
                foreach (char letter in day)
                {
                    int value = Convert.ToInt32(letter);
                    string hexOutput = String.Format("{0:X}", value);
                    command4 += value;
                    command4 += " ";
                }
                textBox_day.BackColor = Color.White;
                textBox_year.BackColor = Color.White;
                textBox_month.BackColor = Color.White;
                textBox_serialNumber.BackColor = Color.White;
                textBox_partNumber.BackColor = Color.White;
                port.Write(command1 + "\n");
                Thread.Sleep(300);
                port.Write(command2 + "\n");
                Thread.Sleep(300);
                port.Write(command3 + "\n");
                Thread.Sleep(300);
                port.Write(command4 + "\n");
                Thread.Sleep(300);
                port.Write("WRITE\n"); //to use a command, type the command and then add the end line symbol "\n"
                outputBox.Clear();
                outputBox.Text += "Data Sent";
            }
        }
    }
}
