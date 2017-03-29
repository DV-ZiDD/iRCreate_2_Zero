using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using System.Management;
using System.Threading;
using System.Timers;
using System.IO;

namespace RobotoFormApplication
{
    class IRobotCreate
    {
        public delegate void SensorDataHandler(SensorData sensorData);
        public event SensorDataHandler sensorDataHandler;

        private SerialPort myPort;
        private Boolean runnning = false;
        private Boolean init_flag = false;

        private bool fullmode()
        {
            if (myPort.IsOpen == true)
            {
                if (passive())
                {
                    return SendCommand(new byte[] { 132 });
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private bool passive()
        {
            try
            {
                return SendCommand(new byte[] { 128 });
            }
            catch { return false; }
        }

        private bool SendCommand(IEnumerable<byte> commandCollection)
        {
            try
            {
                byte[] commandArr = commandCollection.ToArray();
                myPort.Write(commandArr, 0, commandArr.Length);

                return true;
            }
            catch
            {
                return false;
            }
        }

        private struct I_RobotPara{
            public int leftSpeed;
            public int rightSpeed;
            public I_RobotPara(int leftSpeed ,int rightSpeed)
            {
                this.leftSpeed = leftSpeed;
                this.rightSpeed = rightSpeed;
            }
        }

        public struct SensorData{
            public WheelDrop wheelDrop;
            public Bump bump;
            public LightBump lightBump;
        }

        private SensorData sensorData;

        public struct WheelDrop
        {
            public Boolean left;
            public Boolean righ;
        }

        public struct Bump
        {
            public Boolean left;
            public Boolean right;
        }

        public struct LightBump
        {
            public Boolean right;
            public Boolean frongRight;
            public Boolean centerRight;
            public Boolean centerLeft;
            public Boolean frontLeft;
            public Boolean left;

        }

        private I_RobotPara robotPara;

        private enum SensorMode
        {
            BumpsAndWheelDrop,
            LightBumper

        }
        private SensorMode sensorMode;

        public void init(int bourate,String port)
        {
            
            robotPara = new I_RobotPara(0, 0);
            sensorMode = new SensorMode();
            sensorMode = SensorMode.BumpsAndWheelDrop;
            sensorData = new SensorData();
            

            myPort = new SerialPort();
            myPort.PortName = port;
            myPort.BaudRate = bourate;

            myPort.Parity = System.IO.Ports.Parity.None;
            myPort.DataBits = 8;
            myPort.StopBits = System.IO.Ports.StopBits.One;
            myPort.DtrEnable = false;
            myPort.Handshake = Handshake.None;
            myPort.RtsEnable = false;
            myPort.DataReceived += new SerialDataReceivedEventHandler(SensorDataReceived);

            // Timeout の秒数についてはあとで詳しい人に聞く
            myPort.ReadTimeout = 10;
            myPort.WriteTimeout = 10;

            try
            {
                myPort.Open();
                this.fullmode();
                this.init_flag = true;
                this.action();
            }
            catch
            {
                this.debug("error");
            }
        }


        public void SendSensorCommand()
        {
            List<byte> sendbuff = new List<byte>();
            sendbuff.Add(142);
            if (this.sensorMode == SensorMode.BumpsAndWheelDrop) sendbuff.Add(7);
            if (this.sensorMode == SensorMode.LightBumper) sendbuff.Add(45);
            this.SendCommand(sendbuff);

            //this.SendCommand(this.createSensorCommand());
        }

        public void SetDrive(int left,int right)
        {
            if (left > 500) { left = 500; }
            else if (left < -500) { left = -500; }

            if (right > 500) { right = 500; }
            else if (right < -500) { right = -500; }

            this.robotPara.leftSpeed = left;
            this.robotPara.rightSpeed = right;
        }


        private IEnumerable<byte> createDriveCommand(int left, int right)
        {
            List<byte> sendbuff = new List<byte>();

            sendbuff.Add(145);
            sendbuff.AddRange(DecimalToHighLowBytes(right));
            sendbuff.AddRange(DecimalToHighLowBytes(left));
            return sendbuff;
            
        }

        private static IEnumerable<byte> DecimalToHighLowBytes(int decimalNum)
        {
            byte highByte = (byte)(decimalNum >> 8);
            byte lowByte = (byte)(decimalNum & 255);
            var commands = new List<byte>() { highByte, lowByte };
            return commands;
        }
        public bool my_close()
        {
            this.runnning = false;
            Thread.Sleep(10);
            if (myPort.IsOpen == false)
            {
                return false;
            }
            else
            {
                try
                {
                    if (SendCommand(new byte[] { 131, 7 }))
                    {
                        myPort.Close();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch { return false; }
            }
        }

        private void action()
        {
            if (runnning == false)
            {

                if (init_flag)
                {
                    runnning = true;
                    Task.Run(() =>
                    {
                        action_thred();
                    });
                }
                else
                {
                    this.debug("init_error");
                }

            }

        }
        private Boolean flagReceive = true;
        private void action_thred()
        {

            while (runnning)
            {
                Thread.Sleep(5);
                SendCommand(createDriveCommand(this.robotPara.leftSpeed,this.robotPara.rightSpeed));

                if(flagReceive == true)
                {
                    flagReceive = false;

                    this.SendSensorCommand();
                }


            }
            
        }
        private void debug(String message)
        {
            Console.WriteLine(message);
            
        }
        private void SensorDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            //! シリアルポートをオープンしていない場合、処理を行わない.
            if (myPort.IsOpen == false)
            {
                return;
            }

            try
            {
                //! 受信データを読み込む.
                // string data = myPort.ReadExisting();
                var numOfBytes = myPort.BytesToRead;
                byte[] sensorsData = new byte[numOfBytes];
                myPort.Read(sensorsData, 0, numOfBytes);

                this.setSensorData(sensorsData);
                /*
                this.debug("受信");
                foreach (var item in sensorsData)
                {
                    this.debug(item.ToString());
                }*/
                
                if(sensorDataHandler != null)
                {
                    sensorDataHandler(this.sensorData);
                }

               
            }
            catch (Exception ex)
            {
                this.debug("エラー");
            }

            this.flagReceive = true;

            if (this.sensorMode == SensorMode.BumpsAndWheelDrop) this.sensorMode = SensorMode.LightBumper;
            else this.sensorMode = SensorMode.BumpsAndWheelDrop;
        }
        private void setSensorData(byte[] sensorsData)
        {
            if(this.sensorMode == SensorMode.BumpsAndWheelDrop)
            {
                int jyu = sensorsData[0];
                //変換
                for (int i = 0; i < 16; i++)
                {
                    int data = jyu % 2;
                    if (i == 0) this.sensorData.bump.right = booleanConvert(data);
                    if (i == 1) this.sensorData.bump.left = booleanConvert(data);
                    if (i == 2) this.sensorData.wheelDrop.righ = booleanConvert(data);
                    if (i == 3) this.sensorData.wheelDrop.left = booleanConvert(data);

                    jyu = jyu / 2;
                }
            }
            else
            {
                int jyu = sensorsData[0];
                //変換
                for (int i = 0; i < 16; i++)
                {
                    int data = jyu % 2;
                    if (i == 0) this.sensorData.lightBump.left = booleanConvert(data);
                    if (i == 1) this.sensorData.lightBump.frontLeft = booleanConvert(data);
                    if (i == 2) this.sensorData.lightBump.centerLeft = booleanConvert(data);
                    if (i == 3) this.sensorData.lightBump.centerRight = booleanConvert(data);
                    if (i == 4) this.sensorData.lightBump.frongRight = booleanConvert(data);
                    if (i == 5) this.sensorData.lightBump.right = booleanConvert(data);

                    jyu = jyu / 2;
                }
            }
        }

        private Boolean booleanConvert(int num)
        {
            Boolean data = true;
            if (num == 0) data = false;
            return data;
        }
    }
}
