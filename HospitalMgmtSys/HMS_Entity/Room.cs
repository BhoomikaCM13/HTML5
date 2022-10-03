using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Entity
{
    public class Room
    {
        public int RoomNo { get; set; }
        public int PId { get; set; }
        //public string location { get; set; }
        //public int AvailableRooms { get; set; }
        //public DateTime date_of_addmission { get; set; }
        public DateTime date_of_discharge { get; set; }

        public Room(int RoomNo, int PId, DateTime date_of_discharge)/* string location, int AvailableRooms, DateTime date_of_addmission, DateTime date_of_discharge)*/
        {
            this.RoomNo = RoomNo;
            this.PId = PId;
            this.date_of_discharge = date_of_discharge;
            //this.location = location;
            //this.AvailableRooms = AvailableRooms;
            //this.date_of_addmission = date_of_addmission;
            //this.date_of_discharge = date_of_discharge;
        }

        public Room()
        {
        }
    }
}
