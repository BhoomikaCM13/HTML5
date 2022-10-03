using HMS_Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Data
{
    public class AdminDAL
    {
        public List<Admin> admin;
        public List<Admin> GetAllAdminsDAL()
        {
            List<Admin> adminn = new List<Admin>();
            Admin adminObj = new Admin(1, "ADMIN", "bhoomika", "admin@gmail.com");
            adminn.Add(adminObj);

            return adminn;
        }
    }
}