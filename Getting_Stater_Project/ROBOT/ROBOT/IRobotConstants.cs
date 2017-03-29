using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBOT
{
    class IRobotConstants
    {
        public const int START_OPCODE = 128;// Passive mode
        public const int POWER_DOWN_OPCODE = 133;// Passive mode
        /**mode opcodes**/

        // change mode to safe mode
        public const int SAFE_MODE_OPCODE = 131;
        // change mode to full mode 
        public const int FULL_MODE_OPCODE = 132; 

        /**Cleaning Commands opcodes**/

        //This command starts the default cleaning mode. chanage mode to passive 
        public const int CLEAN_OPCODE = 135;
        //This command starts the Max cleaning mode. chanage mode to passive 
        public const int MAX_CLEAN_OPCODE = 136;
        //This command starts the Spot cleaning mode. chanage mode to passive 
        public const int SPOT_CLEAN_OPCODE = 134;
        //This command starts the seek dock mode. chnage mode to passive 
        public const int SEEK_DOCK_OPCODE = 143;
        //TODO add scheduling 

        /**Actuator commands // no mode changes **/

        //Drive with velocity and angle 
        //[137] [Velocity high byte] [Velocity low byte] [Radius high byte] [Radius low byte]
        //Velocity (-500 – 500 mm/s)
        //Radius(-2000 – 2000 mm)
        //TODO add special cases (see page 10 interface specs )
        public const int DRIVE_OPCODE = 137;

        //Drive derect opcode -- with independent values for each wheel 
        //Serial sequence: [145] [Right velocity high byte] [Right velocity low byte] [Left velocity high byte][Left velocity low byte]
        public const int DRIVE_DIRECT_OPCODE = 145;

        /**Song opcodes **/

        //Define song opcode 
        //Serial sequence: [140] [Song Number] [Song Length] [Note Number 1] [Note Duration 1] [Note Number 2] [Note Duration 2],etc
        public const int DEFINE_SONG_OPCODE = 140;

        //play pre defined song 
        //Serial sequence: [141] [Song Number]
        public const int PLAY_SONG = 141;

    }
}
