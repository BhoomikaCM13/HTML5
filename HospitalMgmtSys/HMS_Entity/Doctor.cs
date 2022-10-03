using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Entity
{
    public class Doctor
    {
        public int DId { get; set; }
        public string DName { get; set; }
        public string DEmail { get; set; }
        public string DPassword { get; set; }

        public Doctor(int DId, string DName, string DEmail, string DPassword)
        {
            this.DId = DId;
            this.DName = DName;
            this.DEmail = DEmail;
            this.DPassword = DPassword;
        }

        public Doctor()
        {
        }
   } 
}
