using HMS_Data;
using HMS_Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS_Business
{
    public class PatientBL
    {
        public string AddPatientBl(Patient pat)
        {
            PatientDAL docdl = new PatientDAL();
            return docdl.AddPatientDl(pat);
        }
        public List<Patient> GetAllPatientBl()
        {
            PatientDAL docdl = new PatientDAL();
            return docdl.GetAllPatientDl();
        }
        public string RemovePatientBl(Patient pat)
        {
            PatientDAL docdl = new PatientDAL();
            return docdl.DeletePatientDl(pat);
        }
        public string UpdatePatientBl(Patient pat)
        {
            PatientDAL docdl = new PatientDAL();
            return docdl.UpdatePatientDl(pat);
        }
        public List<Room> RoomBl()
        {
            PatientDAL docdl = new PatientDAL();
            return docdl.GetAllRoom();
        }
    }
}
