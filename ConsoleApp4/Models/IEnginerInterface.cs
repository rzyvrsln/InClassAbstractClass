using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4.Models
{
    internal class IEnginerInterface
    {
        private int _oilCapacity;
        private int _currentOil;
        private int _fuelType;
        private int _remainOilAmount;

        public int OilCapacity
        {
            get => _oilCapacity;
            set => _oilCapacity = value;
        }
        public int CurrentOil
        {
            get => _currentOil;
            set => _currentOil = value;
        }
        public int FuelType
        {
            get => _fuelType;
            set => _fuelType = value;
        }
        public int RemainOilAmount
        {
            get => _remainOilAmount;
            set => _remainOilAmount = value;
        }

        interface IEngine
        {

        }

    }
}
