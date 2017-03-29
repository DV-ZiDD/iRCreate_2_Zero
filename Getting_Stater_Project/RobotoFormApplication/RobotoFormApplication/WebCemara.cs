using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RealSenseGoldR4_ver2;
using OpenCvSharp;
namespace RobotoFormApplication
{
    class WebCemara
    {
        private RealSenseGoldR4_ver2.Camera camera;

        public delegate void CameraFrameHandler(IplImage color_pic,IplImage depth_pic, IList<Camera.Face> face, String debug);
        public event CameraFrameHandler cameraFrameHandler;

        public void init()
        {
            camera = new Camera();
            camera.CameraFrameHandler += new Camera.FrameHandler(OnNewFrame);
            camera.debugHandler += new Camera.DebugHandler(this.onCameradebug);

            camera.SetColorCaptureSize(1280, 720);
            camera.setAllowDepth(true);

            //camera.camera_init();

            camera.start();

            //setting items high:0-479
            camera.setDepthHorizontalLine(240);
            camera.setDepthLinePermition(true);

            //setting items x:0-639 y:0-479
            camera.setDepthPinpoint(320, 240);
            camera.setDepthPointPermition(true);
            
        }
        public void start()
        {
            camera.start();
        }
        private void OnNewFrame(IplImage color_pic,IplImage depth_pic)
        {
            var face = camera.getFace();

            if (face.Count > 0)
            {
                //Console.WriteLine(face[0].facePosition.x);
         
            }

            //Console.WriteLine(camera.getDepthPinpoint());
            var rangedata = camera.getDepthHorizontalLineData();
            
            if (cameraFrameHandler != null)
            {
                cameraFrameHandler(color_pic,depth_pic, face, null);
            }

        }
        private void onCameradebug(String message)
        {
            //if (cameraFrameHandler != null) cameraFrameHandler(null, message);
        }

        internal void Dispose()
        {
            camera.CameraFrameHandler -= new Camera.FrameHandler(OnNewFrame);
            camera.Dispose();
        }


    }
}
