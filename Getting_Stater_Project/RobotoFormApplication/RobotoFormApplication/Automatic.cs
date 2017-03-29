using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenCvSharp;
using RealSenseGoldR4_ver2;


using System.Threading;

namespace RobotoFormApplication
{
    class Automatic
    {
        public delegate void CameraFrameHandler(IplImage color_pic,IplImage depth_pic, IList<Camera.Face> face, String debug);
        public event CameraFrameHandler cameraFrameHandler;

        public delegate void SensorDataHandler(IRobotCreate.SensorData sensorData);
        public event SensorDataHandler sensorDataHandler;

        private RealSenseGoldR4_ver2.SpeechRecognition speechRec;

        private MySpeechSynthesis mySpeechSynthesis;
        private WebCemara camera;

        private IRobotCreate iRobot;

        private Servo.ServoControlSharpV2 servo;
        

        private enum Automatic_MODE
        {
            RECOGNITION,
            NONE
        }
        private Automatic_MODE auto_mode;

        private enum STATE_SPEAK
        {
            SPEAKING,
            FORCING_SPEAKING,
            NONE
        }
        private STATE_SPEAK state_speaking;


        private enum INTERRUPT
        {
            INTERRUPT,
            NONE
        }
        private INTERRUPT interrupt;

        private enum RECOGNITION_MODE
        {
            REC,
            NONE
        }
        private RECOGNITION_MODE rec_mode;

        private String servo1 = "servo1";
        private String servo2 = "servo2";
        public void init()
        {
            auto_mode = new Automatic_MODE();
            auto_mode = Automatic_MODE.NONE;

            servo = new Servo.ServoControlSharpV2(57600, "COM3");

            servo.add(servo1, 1, Servo.ServoControlSharpV2.ServoType.MX);
            servo.add(servo2, 2, Servo.ServoControlSharpV2.ServoType.MX);

            servo.setTargetPosition(servo1, 1400);
            servo.SetSpeed(servo1, 50);
            servo.setTargetPosition(servo2, 1400);
            
            

            camera = new WebCemara();
            camera.cameraFrameHandler += new WebCemara.CameraFrameHandler(OnNewFrame);
            camera.init();

            mySpeechSynthesis = new MySpeechSynthesis();
            mySpeechSynthesis.init();
            
            
            iRobot = new IRobotCreate();
            iRobot.init(115200, "COM3");
            iRobot.sensorDataHandler += new IRobotCreate.SensorDataHandler(onSensorData);
            

            speechRec = new SpeechRecognition();
            speechRec.setJSGF_Path(@"C:\Users\icduser\Documents\JSGF\speechRec_test.jsgf");
            speechRec.recognitionHandler += new SpeechRecognition.RecognitionHandler(onSpeechRecognition);
            //speechRec.init();
            
            speechRec.start();


        }
        public void Speak(String message)
        {
            mySpeechSynthesis.speak(message);
        }
        private void onSensorData(IRobotCreate.SensorData sensorData)
        {
            if(this.sensorDataHandler != null)
            {
                sensorDataHandler(sensorData);
            }
        }

        public void SetIRobotDrive(int left,int right)
        {
            iRobot.SetDrive(left, right);
        }
        public void setServoDrive1(int position, int speed)
        {
            this.servo.SetSpeed(this.servo1, speed);
            this.servo.setTargetPosition(this.servo1, position);

        }
        public void setServoDrive2(int position, int speed)
        {
            this.servo.SetSpeed(this.servo2, speed);
            this.servo.setTargetPosition(this.servo2, position);
        }

        private void onSpeechAlert(SpeechRecognition.AlertData alert_data)
        {
            this.debug("alert:" + alert_data.ToString());

            //if (alert_data == SpeechRecognition.AlertData.SPEECH_BEGIN) client.set_Rec_Begin();

            if (alert_data == SpeechRecognition.AlertData.SPEECH_UNRECOGNIZABLE)
            {
                //client.set_Rec_End();
            }
        }
        public void start()
        {
            // speechRec.init();
            camera.start();
            servo.Start();
            


        }

        public void dispose()
        {
            
            servo.Stop();
            speechRec.Dispose();
            
           camera.Dispose();

           iRobot.my_close();
            
        }

        private void onSpeechRecognition(String message, IList<String> tags)
        {
            //this.speechRec.stop();

            this.debug("recognition:" + message);


        }

        
        private Boolean flag_face_old = false;
        private int face_none_count = 0;
        private int check_count = 0;
        
        private Boolean face_true = false;
        private void OnNewFrame(IplImage color_pic,IplImage depth_pic, IList<Camera.Face> face, String message)
        {
            if (cameraFrameHandler != null) cameraFrameHandler(color_pic,depth_pic, face, message);


        }
        
        private void debug(String message)
        {
            Console.WriteLine(message);
        }
    }
}
