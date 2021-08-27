using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO.Ports;
using System.Diagnostics;

namespace SC_SerialSimulator_EKOS
{
    class GW_SerialCommLib
    {

        public struct stSerialInfo
        {
            public string      portName;
            public int         baudRate;
            public int         dataBit;
            public StopBits    stopBit;
            public Parity      parity;
        }

        SerialPort serialPort1;

        public GW_SerialCommLib()
        {
            serialPort1 = new SerialPort();

            serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(serialPort1_DataReceived);
        }

        public int GW_connectSerialPort(stSerialInfo _stSerial )
        {
            try
            {
                serialPort1.PortName = _stSerial.portName;
                serialPort1.BaudRate = _stSerial.baudRate;
                serialPort1.DataBits = _stSerial.dataBit;
                serialPort1.StopBits = _stSerial.stopBit;
                serialPort1.Parity = _stSerial.parity;

            
                serialPort1.Open();

                return 1;

            } catch(UnauthorizedAccessException uae)
            {
                return 0;
            }
            /* LINQ 로 그룹박스 안에서 선택된 라디오버튼의 Text를 가져오는 방법 */
            //var a = from RadioButton rb in GroupBox_Baudrate.Controls where rb.Checked == true select rb.Text;

            /* */
        }

        public int GW_closeSerialPort()
        {
            serialPort1.Close();

            return 0;
        }

        public void GW_SendDataToSerialPort(byte[] sb)
        {
            serialPort1.Write(sb,0,sb.Count());
            global.gwLogLib.Append_Log(string.Format("[ << SEND, {0} ] \t",sb.Count()) , sb);
        }

        public List<string> GW_findSerialPorts()
        {
            List<string> _serialPortList = new List<string>();

            _serialPortList = SerialPort.GetPortNames().ToList<string>();

            return _serialPortList;
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(100);

            byte[] _Byterecv = new byte[8];
            List<byte> _Bytelist = new List<byte>();

            int _byteLength = serialPort1.BytesToRead;

            for (int i = 0; i < _byteLength; i++)
            {
                _Bytelist.Add((byte)serialPort1.ReadByte());
            }

            Debug.Write(string.Format("RECV {0} byte(s) : ", _Bytelist.Count));

            foreach (byte bt in _Bytelist)
            {
                Debug.Write(string.Format("{0:X2} ", bt));
            }
            Debug.Print("");

            global.gwLogLib.Append_Log(string.Format("[RECV, {0} >> ]  ",_Bytelist.Count),_Bytelist.ToArray());

            //gwLogLib.Append_Log(ListBox_Log, _Bytelist.ToArray<byte>());
            global.gwEventCommLib.EventCheck(_Bytelist.ToArray<byte>());
        }
    }
}
