using HMS_Business;
using HMS_Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HospitalMgmtSys
{
    public class DoctorPL
    {
        private List<Doctor> doc;
        Doctor docs = null;
        public void DoctorMenu()
        {
            Console.WriteLine("Welcome........");
            Console.WriteLine("press 1 to Add");
            Console.WriteLine("press 2 to show the details");
            Console.WriteLine("press 3 to update");
            Console.WriteLine("press 4 to delete");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            {
                AddDoctor();
            }
            else if (x == 2)
            {
                GetAllDoctor();
            }
            else if (x == 3)
            {
                updateDoctor();
            }
            else if (x == 4)
            {
                RemoveDoctor();
            }


        }
        public List<Doctor> AddDoctor()
        {
            docs = new Doctor();
            Console.WriteLine("enter the details:");
            Console.WriteLine("Doctor Id:");
            docs.DId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Doctor Name:");
            docs.DName = Console.ReadLine();
            Console.WriteLine("Doctor Password: ");
            docs.DPassword = Console.ReadLine();
            Console.WriteLine("Doctor Email: ");
            docs.DEmail = Console.ReadLine();
            DoctorBL obj = new DoctorBL();
            string stats = obj.AddDoctor(docs);
            GetAllDoctor();
            return doc;

        }
        public List<Doctor> GetAllDoctor()
        {
            Console.WriteLine("----------Doctor's data----------");
            Console.WriteLine("----ID--PASSWORD--NAME--EMAIL------");
            DoctorBL dobj = new DoctorBL();
            doc = dobj.GetAllDoctors();
            foreach (var item in doc)
            {
                Console.WriteLine(item.DId + "\t" + item.DPassword + "\t\t" + item.DName + "\t\t" + item.DEmail);
            }
           DoctorMenu();
            return doc;
        }
        public List<Doctor> RemoveDoctor()
        {
            docs = new Doctor();
            Console.WriteLine("Enter the data.....");
            Console.WriteLine("enter doc id:");
            docs.DId = Convert.ToInt32(Console.ReadLine());
            DoctorBL removedoc = new DoctorBL();
            string doc1 = removedoc.RemoveDoctor(docs);
            Console.WriteLine("deleted succesfully....");
            GetAllDoctor();
            DoctorMenu();
            return doc;


        }
        public List<Doctor> updateDoctor()
        {
            docs = new Doctor();
            Console.WriteLine("Enter Details....");
            Console.WriteLine("Doctor Id:");
            docs.DId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Doctor Name:");
            docs.DName = Console.ReadLine();
            Console.WriteLine("Doctor Password: ");
            docs.DEmail = Console.ReadLine();
            Console.WriteLine("Doctor Email: ");
            docs.DEmail = Console.ReadLine();
            Console.WriteLine("updated successfully");
            DoctorBL updatedoc = new DoctorBL();
            string doc2 = updatedoc.UpdateDoctor(docs);
            GetAllDoctor();
            DoctorMenu();
            return doc;

        }

    }
}
