using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HouseF;
using HouseF.HouseTypes;

namespace HouseF
{
    public static class HouseFactory
    {
        public static IHouse CreateHouse(int houseType)
        {
            if (houseType == 1)
            {
                return new HouseType1();
            }
            else if(houseType == 2)
            {
                return new HouseType2();
            }
            else if(houseType == 3)
            {
                return new HouseType3();
            }
            else { return null; }
        }
    }
}
