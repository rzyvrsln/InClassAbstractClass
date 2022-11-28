using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    internal class Bicycle:VehicleAbstract
    {
        private int _pedalCount;

        public int PedalCount
        { 
            get=> _pedalCount;
            set=> _pedalCount=value;
        }

        public Bicycle(int pedalCount)
        {
            this.PedalCount = pedalCount;
        }

        public override int AverageSpeed()
        {
            return PedalCount;

        }
    }
}
