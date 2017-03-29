/**
 *  28/03/2017 RIS Center
 * 
 * This class is use to connect and send commnads to IRobot
 * 
 * 
 * */

using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBOT
{
    class IRobot
    {
        /**
         * IO - Handdle all serial port communications
         * portNumber - store port number
         * baudRate - baud rate for port communications 
         * */
        private SerialPort IO;
        private String portNumber;
        private int baudRate; //115200
        private IRobot irobot = null;

        private IRobot(String portNumber, int baudRate)
        {
            this.portNumber = portNumber;
            this.baudRate = baudRate;

            this.SetPort();
        }

        /**
         * Initialize IRobot and return IRobot object to use
         * 
         * @param portNumber port number of IRobot
         * @param baudRate Baud rate for communicate 
         * 
         * @return IRobot object
         * **/
        public IRobot init(String portNumber, int baudRate)
        {
            if(irobot != null)
            {
                return irobot;
            }
            else
            {
                irobot = new IRobot(portNumber,baudRate);
                return irobot;
            }
        }

        /**
         * Openport and start IRobot to send command 
         * **/
        private bool SetPort()
        {
            try
            {
                if (IO != null)
                {
                    IO.Close();//Just in case port is already taken
                }
                IO = new SerialPort(portNumber, baudRate, Parity.None, 8, StopBits.One);
                IO.DtrEnable = false;
                IO.Handshake = Handshake.None;
                IO.RtsEnable = false;
                IO.DataReceived += new SerialDataReceivedEventHandler(SensorDataReceived);

                IO.Open();
                return SendCommand(new byte[] { IRobotConstants.START_OPCODE });
            }
            catch
            {
                IO.Close();
                return false;
            }

        }

        /**
         * Send commands to serial port 
         * @param commandCollection command list to send
         * @return command sent success or not 
         * **/
        private bool SendCommand(IEnumerable<byte> commandCollection)
        {
            try
            {
                byte[] commandArr = commandCollection.ToArray();
                IO.Write(commandArr, 0, commandArr.Length);
                return true;
            }
            catch
            {
                return false;
            }
        }

        /**
         * Handle sensor data
         * **/
        private void SensorDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (IO.IsOpen == false)
            {
                return;
            }
            try
            {
                var numOfBytes = IO.BytesToRead;
                byte[] sensorsData = new byte[numOfBytes];
                IO.Read(sensorsData, 0, numOfBytes);
                this.debug(Encoding.Default.GetString(sensorsData));
            }
            catch (Exception ex)
            {
                this.debug("fail to get sensor data");
            } 
        }

        //debug writer
        private void debug(String message)
        {
            Console.WriteLine(message);

        }

    }
}
