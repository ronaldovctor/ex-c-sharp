using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Listas.Models
{
    public class HotelReserve
    {
        public Guest[] Reserve { get; private set; } = new Guest[10];

        public HotelReserve() { }

        public void AddReserve((int room, Guest guest) reserve)
        {
            Reserve[reserve.room] = reserve.guest;
        }
    }
}
