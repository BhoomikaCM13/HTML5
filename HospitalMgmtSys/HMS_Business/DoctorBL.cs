using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HMS_Entity;
using HMS_Data;

namespace HMS_Business
{
     public class DoctorBL
    {
        public string AddDoctor(Doctor doc)
        {
            DoctorDAL docdl =  new DoctorDAL();
            return docdl.AddDoctor(doc);
        }
        public List<Doctor> GetAllDoctors()
        {
            DoctorDAL docdl = new DoctorDAL();
            return docdl.GetDoctor();
        }
        public string RemoveDoctor(Doctor doc)
        {
            DoctorDAL docdl = new DoctorDAL();
            return docdl.DeleteDoctor(doc);
        }
        public string UpdateDoctor(Doctor doc)
        {
            DoctorDAL docdl = new DoctorDAL();
            return docdl.UpdateDoctorDl(doc);
        }
    }
}
