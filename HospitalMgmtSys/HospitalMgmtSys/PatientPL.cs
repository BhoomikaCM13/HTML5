using HMS_Business;
using HMS_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HospitalMgmtSys
{
    public class PatientPL
    {
        private List<Patient> pat;
        private List<Room> rooms;
        Patient pats = null;
        public void PatientMenu()
        {
            Console.WriteLine("Welcome........");
            Console.WriteLine("press 1 to Add");
            Console.WriteLine("press 2 to show the details");
            Console.WriteLine("press 3 to update");
            Console.WriteLine("press 4 to delete");
            Console.WriteLine("press 5 to RoomDetails");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                AddPatient();
            }
            else if (x == 2)
            {
                GetAllPatient();
            }
            else if (x == 3)
            {
                updatePatient();
            }
            else if (x == 4)
            {
                RemovePatient();
            }
            else if (x == 5)
            {
                Rooms();
            }

        }
        public List<Patient> AddPatient()
        {
            pats = new Patient();
            Console.WriteLine("enter the details:");
            Console.WriteLine("Patient Id:");
            pats.PId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Patient Name:");
            pats.PName = Console.ReadLine();
            Console.WriteLine("patient Password: ");
            pats.PPassword = Console.ReadLine();
            Console.WriteLine("Patient Email: ");
            pats.PEmail = Console.ReadLine();
            Console.WriteLine("Patient Disease:");
            pats.PDisease = Console.ReadLine();
            PatientBL obj = new PatientBL();
            string stats = obj.AddPatientBl(pats);
            GetAllPatient();
            return pat;

        }
        public List<Patient> GetAllPatient()
        {
            Console.WriteLine("--------------------------Patient's data-----------------------------------------");
            Console.WriteLine("-ID----------EMAIL----------PASSWORD------------NAME-----------------DISEASE-----");
            PatientBL dobj = new PatientBL();
            pat = dobj.GetAllPatientBl();
            foreach (var item in pat)
            {
                Console.WriteLine(item.PId + "\t" + item.PPassword + "\t\t" + item.PName + "\t\t" + item.PEmail + "\t\t" + item.PDisease);
            }
            PatientMenu();
            return pat;
        }
        public List<Patient> RemovePatient()
        {
            pats = new Patient();
            Console.WriteLine("Enter the data.....");
            Console.WriteLine("enter patient id:");
            pats.PId = Convert.ToInt32(Console.ReadLine());
            PatientBL removedoc = new PatientBL();
            string doc1 = removedoc.RemovePatientBl(pats);
            Console.WriteLine("deleted succesfully....");
            GetAllPatient();
            PatientMenu();
            return pat;


        }
        public List<Patient> updatePatient()
        {
            pats = new Patient();
            Console.WriteLine("Enter Details....");
            Console.WriteLine("patient Id:");
            pats.PId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("patient Name:");
            pats.PName = Console.ReadLine();
            Console.WriteLine("patient Password: ");
            pats.PPassword = Console.ReadLine();
            Console.WriteLine("patient Email: ");
            pats.PEmail = Console.ReadLine();
            Console.WriteLine("updated successfully");
            PatientBL updatedoc = new PatientBL();
            string doc2 = updatedoc.UpdatePatientBl(pats);
            GetAllPatient();
            PatientMenu();
            return pat;

        }
        public List<Room> Rooms()
        {
            Console.WriteLine("--------------------------Room's data-----------------------------------------");
            Console.WriteLine("ROOM.NO----PID-----------DATE_OF_DISCHARGE----");
            PatientBL obj = new PatientBL();
            rooms = obj.RoomBl();
            foreach (var item in rooms)
            {
                Console.WriteLine(item.RoomNo + "\t" + item.PId + "\t\t" + item.date_of_discharge);/* + "\t\t" + item.location + "\t\t" + item.AvailableRooms + "\t\t" + item.date_of_addmission */
            }
            SubMenu();
           
            return rooms;
        }
        public void SubMenu()
        {

            Console.WriteLine("hmmmmmmmm....");
            Console.WriteLine("press 1 to  Admin Section....");
            Console.WriteLine("press 2 to exit...");
            //Console.WriteLine("press 3 to exit");
            AdminPL obj1 = new AdminPL();
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                obj1.AdminSection();
            }
        }


    }
}
