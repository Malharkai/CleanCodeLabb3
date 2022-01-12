using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseF;

namespace HouseF
{
    public class HouseType1 : IHouse
    {
        
        private int _noOfRooms = 2;
        private int _noOfWindows = 6;
        private string _streetAdress = "Gågatan 19";
        private bool _hasSwimmingPool = true;
        private int _parkingSpotsInGarage = 0;

        public bool _hasGarage => _parkingSpotsInGarage > 0;

        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"This house is located at {_streetAdress}.");
            sb.AppendLine($"It has {_noOfRooms} rooms and {_noOfWindows} windows");
            if (_hasSwimmingPool & _hasGarage)
            {
                sb.Append($"It is very fancy and have both a swimming pool, and a garage with place for {_parkingSpotsInGarage} car");
                if (_parkingSpotsInGarage > 1)
                {
                    sb.Append("s");
                }
                sb.AppendLine(".");
            }
            else if (_hasSwimmingPool)
            {
                sb.AppendLine("It has a nice swimming pool");
            }
            else if (_hasGarage)
            {
                sb.AppendLine($"It has a garage with place for {_parkingSpotsInGarage} cars");
            }
            return sb.ToString();
        }
    }
}
