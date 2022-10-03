using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_Business;
using HMS_Entity;

namespace HospitalMgmtSys
{
    public class AdminPL
    {
        public void MainMenu()
        {
            Console.WriteLine("Welcome to HMS");
            Console.WriteLine("press 1 to Admin");
            Console.WriteLine("press 2 to Doctor");
            Console.WriteLine("press 3 to patient");
            Console.WriteLine("press 4 to exit");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                AdminLogin();
            }
        }
        public void AdminLogin()
        {
            Console.WriteLine("admin login........");
            Console.WriteLine("Enter Admin ID:");
            int adminId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();
            AdminBL adminbl = new AdminBL();
            bool item = adminbl.AdminLogin(adminId, password);
            if (item)
            {
                AdminSection();
            }

        }
        
        public void AdminSection()
        {
            Console.WriteLine("this is admin section....");
            Console.WriteLine("press 1 to  display doctor list....");
            Console.WriteLine("press 2 to display patient...");
            Console.WriteLine("press 3 to exit");
            DoctorPL obj = new DoctorPL();
           // PatientPL obj1 = new PatientPL();
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                obj.DoctorMenu();
                //SubMenu1();

            }
            else if (x == 2)
            {
                SubMenu();
            }
           

           
        }
        //public void SubMenu1()
        //{

        //    //Console.WriteLine("this is admin section....");
        //    //Console.WriteLine("press 1 to  display doctor list....");
        //    //Console.WriteLine("press 2 to display patient...");
        //    Console.WriteLine("Welcome");
        //    DoctorPL obj = new DoctorPL();
        //    // PatientPL obj1 = new PatientPL();
        //    int x = Convert.ToInt32(Console.ReadLine());
        //    if (x == 1)
        //    {
        //        obj.DoctorMenu();
        //    }
        //}
        public void SubMenu()
        {

            Console.WriteLine("this is admin section....");
            Console.WriteLine("press 1 to  display doctor list....");
            Console.WriteLine("press 2 to display patient...");
            Console.WriteLine("press 3 to exit");
            PatientPL obj1 = new PatientPL();
            int x = Convert.ToInt32(Console.ReadLine());
           if (x == 2)
            {
                obj1.PatientMenu();
            }
        }
    }
}
