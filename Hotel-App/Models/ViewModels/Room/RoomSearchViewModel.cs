using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_App.Models.ViewModels.Room
{
    public class RoomSearchViewModel
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public byte Adult { get; set; }
        public byte? Child { get; set; }
    }
}
