using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Entity
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string AdminPassword { get; set; }
        public string AdminName { get; set; }
        public string AdminEmail { get; set; }
        public Admin/*method*/(int AdminId, string AdminPassword, string AdminName, string AdminEmail)
        {
            //arguments:

            this.AdminId = AdminId;
            this.AdminPassword = AdminPassword;
            this.AdminName = AdminName;
            this.AdminEmail = AdminEmail;
        }
        public Admin()
        {

        }
    }
}
