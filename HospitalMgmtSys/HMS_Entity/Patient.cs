using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Entity
{
    public class Patient
    {
        public int PId { get; set; }
        public string PName { get; set; }
        public string PEmail { get; set; }
        public string PPassword { get; set; }
        public string PDisease { get; set; }
        public Patient(int PId, string PName, string PEmail, string PPassword, string pDisease)
        {
            this.PId = PId;
            this.PName = PName;
            this.PEmail = PEmail;
            this.PPassword = PPassword;
            this.PDisease = pDisease;
        }
        public Patient()
        {

        }
    }
}
