using HMS_Data;
using HMS_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Business
{
    public class AdminBL
    {
        public bool AdminLogin(int adminId, string password)
        {
            bool block = false;
            AdminDAL obj = new AdminDAL();
            List<Admin> adminn = obj.GetAllAdminsDAL();
            foreach (var items in adminn)
            {
                if(items.AdminId == adminId && items.AdminPassword== password)
                {

                    block = true;
                }
            }
            return block;
}
        //    public string GetAdmins(Admin admin)
        //{
        //    AdminDAL docdl = new AdminDAL();
        //    return docdl.GetAdmins(admin);
        //}
    }
}
