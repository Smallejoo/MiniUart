using System;
using System.IO.Ports;


namespace UartMiniScreen
{
    public class UartManager
    {
        private SerialPort _port;

        // Event to notify when data is received will be added to log 
        public event Action<string> DataReceived;

        //checking port status  
       public bool CheckIfPortIsOpen()
        {
            return _port!=null&& _port.IsOpen;
        }

        //Connecting to a port 
        public void Open(string portName, int baudRate ,string parity ,int dataBits, string stopBits)
        {

            if (CheckIfPortIsOpen())
                Close();

            StopBits StopBits = (StopBits)Enum.Parse(typeof(StopBits),stopBits);
            Parity Parity = (Parity)Enum.Parse(typeof(Parity), parity);

            
            _port = new SerialPort(portName, baudRate, Parity, dataBits, StopBits);

            // Add an event/action every time data is recived  // in other words we added a function on data reciving .
            _port.DataReceived += OnDataReceived;
            _port.Open();
        }

        public void Close()
        {
            if (_port != null)
            {
                _port.DataReceived -= OnDataReceived;
                if (_port.IsOpen)
                    _port.Close();
                _port.Dispose();
                _port = null;
            }
        }

        //Sending data to threw the serial port  
        public void Send(string data)
        {
           

            if (!CheckIfPortIsOpen()) return;
            if (string.IsNullOrEmpty(data)) return;

           // added a timeout so the app wont freeze if no handshake or ack from the other side .
            _port.WriteTimeout = 500;      
            _port.ReadTimeout = 500;
            _port.WriteLine(data);

            
        }
        // same as before just this time we know there will be no device on the other side so the settings are abit
        //diffrent . 
        public void SendTest(string data)
        {
            if (!CheckIfPortIsOpen()) return;
            if (string.IsNullOrEmpty(data)) return;

            _port.WriteTimeout = 500;     
            _port.ReadTimeout = 500;      
            _port.Handshake = Handshake.None; // this is the diffrent part , no handshake 
            _port.DtrEnable = true;
            _port.RtsEnable = true;

            
            _port.WriteLine(data);
        }


        //the function that will handel data retrivel on event 
        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = _port.ReadExisting();
                if(DataReceived!=null)
                {
                    //this function later on will need to change contex to UI 
                    //without it it will  have no controll to show the data on the UI . 
                     DataReceived.Invoke(data);
                }
            }
            catch
            {
                //later on 
            }
        }
    }
}
