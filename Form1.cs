using System.IO.Ports;


namespace UartMiniScreen
{
    public partial class Form1 : Form
    {

        private System.Windows.Forms.Timer RXTimer;
        private UartManager UManager = new UartManager();

        private long bytesSent = 0;
        private long bytesReceived = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadComboBoxs();
            SetConnectedLable(false);

        }

        public Form1()
        {
            InitializeComponent();
            UManager.DataReceived += DataReceived_Event;
            RXTimer = new System.Windows.Forms.Timer();
            RXTimer.Interval = 200;       
            RXTimer.Tick += RXTimer_Tick;
            RXTimer.Enabled = false;

        }
        private void RXTimer_Tick(object sender, EventArgs e)
        {
            RXTimer.Stop();
            PingLed.ForeColor = Color.Gray;
        }

        private void LoadComboBoxs()
        {
            DataBitsComboBox.Items.Clear();
            DataBitsComboBox.Items.Add("7");
            DataBitsComboBox.Items.Add("8");
            DataBitsComboBox.Items.Add("5");
            DataBitsComboBox.Items.Add("6");

            ParityComboBox.Items.Clear();
            ParityComboBox.Items.Add("None");
            ParityComboBox.Items.Add("Odd");
            ParityComboBox.Items.Add("Even");
            ParityComboBox.Items.Add("Mark");
            ParityComboBox.Items.Add("Space");

            StopBitsComboBox.Items.Clear();
            StopBitsComboBox.Items.Add("One");
            StopBitsComboBox.Items.Add("Two");
           
         
            //combo box 1 ports names , combo box 2 rates 
            comboBox2.Items.Clear();
            comboBox2.Items.Add("9600");
            comboBox2.Items.Add("19200");
            comboBox2.Items.Add("38400");
            comboBox2.Items.Add("57600");
            comboBox2.Items.Add("115200");
            comboBox2.SelectedIndex = 0;

            //check what ports are avalible . 
            comboBox1.Items.Clear();
            comboBox1.Items.AddRange(SerialPort.GetPortNames());

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }


        }

        private void SetConnectedLable(bool connected)
        {
            if (connected)
            {
                StatusLable2.Text = "Connected";
                StatusLable2.ForeColor = System.Drawing.Color.Green;
            }
            else
            {
                StatusLable2.Text = "Disconnected";
                StatusLable2.ForeColor = System.Drawing.Color.Red;
            }
        }

        //writing logs to the big screen of the app 
        private void LogWtire(string message)
        {
            string line = "[" + DateTime.Now.ToString("HH:mm:ss") + "] ...." + message;
            LogWindow.AppendText(line + Environment.NewLine);
        }

        //the connect button  ( establishing a uart connection ) 
        private void ConnectButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (!UManager.CheckIfPortIsOpen())
                {
                    if (comboBox1.SelectedItem == null)
                    {
                        MessageBox.Show("No COM port selected.");
                        LogWtire("Select a port in the option selection ");
                        return;
                    }

                    string portName = comboBox1.SelectedItem.ToString();
                    string stopBit = (StopBitsComboBox.SelectedItem.ToString());
                    string parity = ParityComboBox.SelectedItem.ToString();
                    int baudRate = int.Parse(comboBox2.SelectedItem.ToString());
                    int dataBits = int.Parse(DataBitsComboBox.SelectedItem.ToString());

                    UManager.Open(portName, baudRate,parity,dataBits,stopBit);
                    SetConnectedLable(true);
                    LogWtire("Connected to " + portName + " @ " + baudRate);
                    ConnectButton.Text = "Disconnect";
                 
                }
                else
                {
                    UManager.Close();
                    SetConnectedLable(false);
                    LogWtire("Disconnected");
                    ConnectButton.Text = "Connect";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening port: " + ex.Message);
                SetConnectedLable(false);
            }

        }

        //send data via TX 
        private void TXButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("inside TX Button Click ");
            try
            {
                if (!UManager.CheckIfPortIsOpen())
                {
                    LogWtire("Port is closed ");
                    return;
                }
                if (string.IsNullOrEmpty(TXTextBox.Text))
                {
                    LogWtire("enter a message in the TX textBox ");
                    return;
                }
               
                if(!TestCheckBox.Checked)
                {
                  UManager.Send(TXTextBox.Text);
                  LogWtire("TX:" + TXTextBox.Text);

                }
                else
                {
                    try
                    {
                        System.Diagnostics.Debug.WriteLine("XXXXXXXXXx test send XXXXXXXXXXXx");
                        UManager.SendTest(TXTextBox.Text);

                    }
                    catch (TimeoutException)
                    {
                        LogWtire("TX:" + TXTextBox.Text);
                    }
                    catch (Exception ex)
                    {
                        LogWtire("Error msg " + ex);
                    }
                }

            }
            catch (Exception error)
            {
                System.Diagnostics.Debug.WriteLine("error on TX writing " + error);
                LogWtire("looks like there is no device listening on the other side");
            }
        }


        // event that will be trigered from anouther context when msg is recived . 
        private void DataReceived_Event(string data)
        {
            //check what context we are . 
            if (this.InvokeRequired)
            {
                //call again if in wrong contex 
                this.BeginInvoke(new Action<string>(DataReceived_Event), data);
                return;
            }


            RXTextBox.Text = data;
            LogWtire("RX:" + data);

            PingLed.ForeColor = Color.Green;
            RXTimer.Stop();
            RXTimer.Start();
        }


        private void ClearLogButton_Click(object sender, EventArgs e)
        {
            LogWindow.Clear();
        }

        private void AutoScrollCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LogWindow.SelectionStart = LogWindow.TextLength;
            LogWindow.ScrollToCaret();
        }
    }
}
