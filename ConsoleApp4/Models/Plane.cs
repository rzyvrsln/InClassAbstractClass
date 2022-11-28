using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    internal class Plane:VehicleAbstract
    {
        private int _wingLength;

        public int WingLength 
        { 
            get=> _wingLength;
            set=> _wingLength=value;
        }

        public Plane(int wingLength)
        {
            this.WingLength = wingLength;
        }
        public override int AverageSpeed()
        {
            return WingLength;
        }
    }
}
