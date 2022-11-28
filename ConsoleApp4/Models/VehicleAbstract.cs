using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    internal abstract class VehicleAbstract
    {
        private int _driveTime;
        private int _drivePath;

        public int DriveTime
        { 
            get=>_driveTime; 
            set=>_driveTime=value; 
        }
        public int DrivePath 
        { 
            get=> _drivePath;
            set=> _drivePath=value;
        }

        public abstract int AverageSpeed();

        //AverageSpeed() - ortalama sureti

    }
}
