using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using OpenCvSharp;
using RealSenseGoldR4_ver2;

namespace RobotoFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.init();

        }
        private Automatic auto;
        private void init()
        {

            auto = new Automatic();


            auto.cameraFrameHandler += new Automatic.CameraFrameHandler(onNewFrame);
            //auto.automaticHandler += new Automatic.AutomaticHandler(onNewData);
            /*
            auto.speechRecognitionHandler += new Automatic.SpeechRecognitionHandler(onSpeechRecognition);

            auto.responseHandler += new Automatic.ResponseHandler(onResponse);

            auto.wizavoHandler += new Automatic.WizavoHandler(onWizavo);*/

            auto.init();

            auto.sensorDataHandler += new Automatic.SensorDataHandler(onSensorReceived);

            auto.start();

        }

        private void onSensorReceived(IRobotCreate.SensorData sensorData)
        {
            try
            {

                //Console.WriteLine(sensorData.lightBump.right);
                clearSensorData();
                setSensorData("WheelLeft  :" + sensorData.wheelDrop.left.ToString());
                setSensorData("WheelRight :" + sensorData.wheelDrop.righ.ToString());
                setSensorData("BumpLeft   :" + sensorData.bump.left.ToString());
                setSensorData("BumpRight  :" + sensorData.bump.right.ToString());
                setSensorData("LBumpLeft  :" + sensorData.lightBump.left.ToString());
                setSensorData("LBumpFLeft :" + sensorData.lightBump.frontLeft.ToString());
                setSensorData("LBumpCLeft :" + sensorData.lightBump.centerLeft.ToString());
                setSensorData("LBumpCRight:" + sensorData.lightBump.centerRight.ToString());
                setSensorData("LBumpFRight:" + sensorData.lightBump.frongRight.ToString());
                setSensorData("LBumpRight :" + sensorData.lightBump.right.ToString());
            }
            catch (Exception)
            {

                

            }
        }

        public void onNewFrame(IplImage color_pic, IplImage depth_pic, IList<Camera.Face> face,String message)
        {
            if (this.end_flag == false)
            {
                try
                {
                    if (color_pic != null) Invoke(new setColorPictureDelegate(setColorPicture), new object[] { color_pic });
                    if (depth_pic != null) Invoke(new setDepthPictureDelegate(setDepthPicture), new object[] { depth_pic });
                }
                catch (Exception)
                {


                }
            }
            this.clearFaceData();
            if(face != null)
            {
                this.setFaceData("x:" + face[0].facePosition.x.ToString() + "  y:" + face[0].facePosition.y.ToString());


            }
            

            


        }



        delegate void setColorPictureDelegate(IplImage pic);
        private void setColorPicture(IplImage color_pic)//piyo関数
        {
            try
            {
                pictureBoxIpl_color_original.RefreshIplImage(color_pic);
            }
            catch (Exception)
            {


            }


        }
        delegate void setDepthPictureDelegate(IplImage depth_pic);
        private void setDepthPicture(IplImage depth_pic)//piyo関数
        {
            try
            {
                pictureBoxIpl_depth_original.RefreshIplImage(depth_pic);
            }
            catch (Exception)
            {


            }


        }
        Boolean end_flag = false;
        private void onFormClosing(object sender, FormClosingEventArgs e)
        {
            this.end_flag = true;
            auto.cameraFrameHandler -= new Automatic.CameraFrameHandler(onNewFrame);

            auto.dispose();


        }

        private void button_iRobot_forward_Click(object sender, EventArgs e)
        {
            double speed = Double.Parse(this.textBox_iRobot_ForwadSpeed.Text);

            int  rate = (int)(500 * speed/100.0);
            //value :-500-500
            auto.SetIRobotDrive(rate, rate);
        }

        private void button_iRobot_Turn_Click(object sender, EventArgs e)
        {
            double speed = Double.Parse(this.textBox_iRobotTurnSpeed.Text);

            int rate = (int)(500 * speed / 100.0);
            auto.SetIRobotDrive(-rate, rate);
        }

        private void button_iRobot_Stop_Click(object sender, EventArgs e)
        {
            auto.SetIRobotDrive(0, 0);
        }

        private void textBox_iRobot_ForwadSpeed_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
        void setSensorData(string message)
        {
            //他スレッドからの呼び出しなら。 
            if (this.InvokeRequired)
            {
                //Invokeを使って許可されたスレッドから呼び出してもらう。
                this.BeginInvoke
                ((MethodInvoker)delegate () { setSensorData(message); });
                return;
            }
            //textBox_debug.Text = message;

            textBox_iRobotSensroData.AppendText(message+"\n");
            //Formのコントロールにアクセスする。
        }
        void clearSensorData()
        {
            //他スレッドからの呼び出しなら。 
            if (this.InvokeRequired)
            {
                //Invokeを使って許可されたスレッドから呼び出してもらう。
                this.BeginInvoke
                ((MethodInvoker)delegate () { clearSensorData(); });
                return;
            }
            //textBox_debug.Text = message;

            textBox_iRobotSensroData.Clear();
            //Formのコントロールにアクセスする。
        }

        private void button_Servo1_Click(object sender, EventArgs e)
        {
            auto.setServoDrive1(int.Parse(textBox_Servo1Target.Text), int.Parse(textBox_Servo1Speed.Text));

        }

        private void button_Servo2_Click(object sender, EventArgs e)
        {
            auto.setServoDrive2(int.Parse(textBox_Servo2Target.Text), int.Parse(textBox_Servo2Speed.Text));

        }

        private void button_Speak_Click(object sender, EventArgs e)
        {
            auto.Speak(this.textBox_Speak.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        void setFaceData(string message)
        {
            //他スレッドからの呼び出しなら。 
            if (this.InvokeRequired)
            {
                //Invokeを使って許可されたスレッドから呼び出してもらう。
                this.BeginInvoke
                ((MethodInvoker)delegate () { setFaceData(message); });
                return;
            }
            //textBox_debug.Text = message;

            textBox1.AppendText(message + "\n");
            //Formのコントロールにアクセスする。
        }
        void clearFaceData()
        {
            //他スレッドからの呼び出しなら。 
            if (this.InvokeRequired)
            {
                //Invokeを使って許可されたスレッドから呼び出してもらう。
                this.BeginInvoke
                ((MethodInvoker)delegate () { clearFaceData(); });
                return;
            }
            //textBox_debug.Text = message;

            textBox1.Clear();
            //Formのコントロールにアクセスする。
        }



        /*
        public void onSpeechRecognition(String recognition, String alert, String debug)
        {
            if (recognition != null) setSpeechRecognitionMessage(recognition);

            if (alert != null) setSpeechAlertMessage(alert);

            if (debug != null) setSpeechDebugMessage(debug);
        }
        public void onWizavo(String debg)
        {
            setWizavoDebugMessage(debg);
        }
        public void onResponse(String debg)
        {
            setResponseDebugMessage(debg);
        }*/
    }
}
