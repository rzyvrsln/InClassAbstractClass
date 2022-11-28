using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    internal class Car:VehicleAbstract
    {
        private int _doorCount;
        private int _s;
        private int _t;

        public int DoorCount 
        {
            get=> _doorCount;
            set=> _doorCount=value;
        }
        public int S 
        {
            get=> _s;
            set=> _doorCount=value;
        }
        public int T 
        {
            get=> _t;
            set=> _t=value;
        }

        public Car(int dourCount,int S,int T)
        {
            this.DoorCount=dourCount;
            this._t=T;
            this._s=S;
        }
        public override int AverageSpeed()
        {
            int v;
            v = S/T;

            return v;
        }
    }
}
