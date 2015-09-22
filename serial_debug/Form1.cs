using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO.Ports;

namespace serial_debug
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DataReceived_IRQ);
        }

        private void list_ports()
        {
            this.portsls.Items.Clear();
            this.portsls.Text = "";
            string[] portNames = SerialPort.GetPortNames();
            foreach (string str in portNames)
            {
                this.portsls.Items.Add(str);
                this.portsls.SelectedIndex = 0;
            }
        }

        private bool isclose()
        {
            if (serialPort1.IsOpen)
            {
                return false;
            }
            else
            {
                MessageBox.Show("Serial port isn't open!");
                return true;
            }

        }

        private void Form1_FormClosing(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }
        private void refreshbt_Click(object sender, EventArgs e)
        {
            list_ports();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list_ports();
        }

        private void clrbt_Click(object sender, EventArgs e)
        {
            rxbox.Text = "";
            txbox.Text = "";
            rxcounter.Text = "0";
            txcounter.Text = "0";
        }

        private void restartPort(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                switchbt_Click(sender, e);
                Thread.Sleep(500);
                switchbt_Click(sender, e);
            }
        }

        private void databits_ls_SelectedIndexChanged(object sender, EventArgs e)
        {
            restartPort(sender, e);
        }

        private void portsls_SelectedIndexChanged(object sender, EventArgs e)
        {
            restartPort(sender, e);
        }

        private void baudls_SelectedIndexChanged(object sender, EventArgs e)
        {
            restartPort(sender, e);
        }

        private void parityls_SelectedIndexChanged(object sender, EventArgs e)
        {
            restartPort(sender, e);
        }

        private void stopls_SelectedIndexChanged(object sender, EventArgs e)
        {
            restartPort(sender, e);
        }

        private void DataReceived_IRQ(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort1.BytesToRead == 0) { return; }
            byte[] data = new byte[serialPort1.BytesToRead];
            serialPort1.Read(data, 0, data.Length);
            rxcounter.BeginInvoke(new Action(() =>
            {
                rxcounter.Text = (int.Parse(rxcounter.Text) + data.Length).ToString();
            }));
            if (rxishex.Checked)
            {
                rxbox.BeginInvoke(new Action(() =>
                {
                    rxbox.AppendText(BitConverter.ToString(data, 0).Replace('-', ' ') + " ");
                }));
            }
            else
            {
                rxbox.BeginInvoke(new Action(() =>
                {
                    rxbox.AppendText(System.Text.Encoding.Default.GetString(data, 0, data.Length));
                }));
            }
        }

        private bool strtobyte(string str, out byte[] data)
        {
            string[] datastr = str.Split(new char[] { ' ', '-' }, StringSplitOptions.RemoveEmptyEntries);
            List<byte> datals = new List<byte>();
            try
            {
                foreach (string da in datastr)
                {
                    datals.Add(Convert.ToByte(da, 16));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                data = null;
                return false;
            }
            data = datals.ToArray();
            return true;
        }

        private void send_bt_Click(object sender, EventArgs e)
        {
            if (isclose()) { return; }
            byte[] data = null;
            if (txishex.Checked) { if (!strtobyte(txbox.Text.Trim(), out data)) { return; } }
            else
            {
                data = System.Text.Encoding.Default.GetBytes(txbox.Text.Trim());
            }
            try
            {
                serialPort1.Write(data, 0, data.Length);
                txcounter.Text = (int.Parse(txcounter.Text) + data.Length).ToString();
            }
            catch (Exception ex)
            {
                portst.Text = "ERR";
                switchbt.Text = "Open";
                MessageBox.Show(ex.Message);
            }
        }

        private void switchbt_Click(object sender, EventArgs e)
        {
            int baudtmp = 9600;
            int databits = 8;
            if (switchbt.Text == "Open")
            {
                if (portsls.Text == "")
                {
                    MessageBox.Show("Please select a serial port!");
                    return;
                }
                else
                {
                    serialPort1.PortName = portsls.Text;
                    if (int.TryParse(databits_ls.Text.Trim(), out databits))
                    {
                        if (databits < 5 || databits > 8)
                        {
                            databits = serialPort1.DataBits;
                            databits_ls.Text = databits.ToString();
                        }
                        else
                        {
                            serialPort1.DataBits = databits;
                        }
                    }
                    else
                    {
                        databits_ls.Text = serialPort1.DataBits.ToString();
                    }
                    try
                    {
                        serialPort1.Parity = (Parity)parityls.Items.IndexOf(parityls.Text);
                        serialPort1.StopBits = (StopBits)stopls.Items.IndexOf(stopls.Text);
                    }
                    catch (Exception ex)
                    {
                        parityls.Text = serialPort1.Parity.ToString();
                        stopls.Text = serialPort1.StopBits.ToString();
                    }

                    if (int.TryParse(baudls.Text.Trim(), out baudtmp))
                    {
                        serialPort1.BaudRate = baudtmp;
                    }
                    else
                    {
                        baudls.Text = serialPort1.BaudRate.ToString();
                    }
                    try
                    {
                        serialPort1.Open();
                    }
                    catch (Exception ex)
                    {
                        portst.Text = "ERR";
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
            else
            {
                try
                {
                    serialPort1.Close();
                }
                catch (Exception ex)
                {
                    this.portst.Text = "ERR";
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            if (serialPort1.IsOpen)
            {
                portst.Text = "Open";
                switchbt.Text = "Close";
            }
            else
            {
                portst.Text = "Close";
                switchbt.Text = "Open";
            }
        }

        private void txishex_CheckedChanged(object sender, EventArgs e)
        {
            if (txishex.Checked)
            {
                txbox.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(txbox.Text.Trim()), 0).Replace('-', ' ');
            }
            else
            {
                byte[] data = null;
                if (strtobyte(txbox.Text.Trim(), out data))
                {
                    txbox.Text = System.Text.Encoding.Default.GetString(data, 0, data.Length);
                }
            }
        }

        private void rxishex_CheckedChanged(object sender, EventArgs e)
        {
            if (rxishex.Checked)
            {
                rxbox.Text = BitConverter.ToString(System.Text.Encoding.Default.GetBytes(rxbox.Text.Trim()), 0).Replace('-', ' ');
            }
            else
            {
                byte[] data = null;
                if (strtobyte(rxbox.Text.Trim(), out data))
                {
                    rxbox.Text = System.Text.Encoding.Default.GetString(data, 0, data.Length);
                }
            }
        }
    }
}
