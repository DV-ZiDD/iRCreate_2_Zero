using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RealSenseGoldR4_ver2;
namespace RobotoFormApplication
{
    class MySpeechSynthesis
    {
        private RealSenseGoldR4_ver2.SpeechSynthesis speechSynthesis;
        public void init()
        {
            speechSynthesis = new SpeechSynthesis();
            speechSynthesis.init();
            
        }
        public void speak(String message)
        {
            speechSynthesis.Speak(message);
        }
    }
}
