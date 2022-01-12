using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseF
{
    public class House
    {
        public int NoOfRooms { get; set; } = 1;

        public int NoOfWindows { get; set; } = 0;

        /// <summary>This field includes the street name and the street number</summary>
        public string StreetAdress { get; set; }

        public bool HasSwimmingPool { get; set; }

        public int ParkingSpotsInGarage { get; set; }

        public bool HasGarage => ParkingSpotsInGarage > 0;

        public House() { }

        public House(int noOfRooms, int noOfWindows, string streeAdress, bool hasSwimmingPool, int parkingSpotsInGarage)
        {
            NoOfRooms = noOfRooms;
            NoOfWindows = noOfWindows;
            StreetAdress = streeAdress;
            HasSwimmingPool = hasSwimmingPool;
            ParkingSpotsInGarage = parkingSpotsInGarage;
        }

        public static string ToString(House house)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"This house is located at {house.StreetAdress}.");
            sb.AppendLine($"It has {house.NoOfRooms} rooms and {house.NoOfWindows} windows");
            if (house.HasSwimmingPool & house.HasGarage)
            {
                sb.Append($"It is very fancy and have both a swimming pool, and a garage with place for {house.ParkingSpotsInGarage} car");
                if (house.ParkingSpotsInGarage > 1)
                {
                    sb.Append("s");
                }
                sb.AppendLine(".");
            }
            else if (house.HasSwimmingPool)
            {
                sb.AppendLine("It has a nice swimming pool");
            }
            else if (house.HasGarage)
            {
                sb.AppendLine($"It has a garage with place for {house.ParkingSpotsInGarage} cars");
            }
            return sb.ToString();
        }

    }
}
