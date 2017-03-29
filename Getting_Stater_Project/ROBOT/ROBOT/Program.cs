using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBOT
{
    class Program
    {
        static void Main(string[] args)
        {
            TestConnection ts = new TestConnection();
            ts.SetPort("COM3");
            ts.SendCommand(new byte[] { 132 });


            //sensor test
            ts.SendCommand(new byte[] { 149 });
            ts.SendCommand(new byte[] { 1 });
            ts.SendCommand(new byte[] { 7 });
            ts.SensorDataWasReceived();


            //76 16 76 16 76 32 76 16 76 16 76 32 76 16 79 16
            //128 131
            //ts.SendCommand(new byte[] { 140, 0, 16 });
            //ts.SendCommand(new byte[] { 76, 16, 76, 16, 76, 32, 76, 16, 76, 16, 76, 32, 76, 16, 79, 16 });
            //ts.SendCommand(new byte[] { 72, 16, 74, 16, 76, 32, 77, 16, 77, 16, 77, 16, 77, 32, 77, 16 });
            //ts.SendCommand(new byte[] { 140, 1, 7 });
            //ts.SendCommand(new byte[] { 76, 16, 76, 32, 79, 16, 79, 16, 77, 16, 74, 16, 72, 32 });
            //ts.SendCommand(new byte[] { 141, 0 });
            //ts.SendCommand(new byte[] { 141, 1 });
            //[164] [65] [66] [67] [68]
            ts.SendCommand(new byte[] { 164 });
            ts.SendCommand(new byte[] { 65 });
            ts.SendCommand(new byte[] { 66 });
            ts.SendCommand(new byte[] { 67 });
            ts.SendCommand(new byte[] { 68 });
            ////131
            //Console.Read();

            //ts.SendCommand(new byte[] { 164 });
            //ts.SendCommand(new byte[] { 32 });
            //ts.SendCommand(new byte[] { 32 });
            //ts.SendCommand(new byte[] { 32 });
            //ts.SendCommand(new byte[] { 32 });

            //drive
            // ts.SendCommand(new byte[] { 137 });
            // //0 100 128 0
            // ts.SendCommand(new byte[] { 255});
            // ts.SendCommand(new byte[] { 56 });
            // ts.SendCommand(new byte[] { 128});
            // ts.SendCommand(new byte[] { 0 });
            //// Console.Read();
            // //ts.SendCommand(new byte[] { 0, 0, 0, 0 });
            //// ts.SendCommand(new byte[] { 128});
            // Console.Write("end");
            // Console.Read();
            // ts.SendCommand(new byte[] { 137 });
            // //0 100 128 0
            // ts.SendCommand(new byte[] { 0 });
            // ts.SendCommand(new byte[] { 0 });
            // ts.SendCommand(new byte[] { 0 });
            // ts.SendCommand(new byte[] { 0 });

            Console.Write(ts.DecimalToHighLowBytes(-1).ToArray()[0]);
            Console.Write("c");
            Console.Write(ts.DecimalToHighLowBytes(-1).ToArray()[1]);
            Console.Read();
            ts.close();
            
        }
    }
}
