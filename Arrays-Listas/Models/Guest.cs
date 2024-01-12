using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Listas.Models
{
    public class Guest
    {
        public int Room { get; set; }
        public string Name { get; private set; }
        public string Email { get; private set; }

        public Guest() { }

        public Guest(int room, string name, string email)
        {
            Room = room;
            Name = name;
            Email = email;
        }
    }
}
