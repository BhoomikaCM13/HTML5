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
    public class PatientDAL
    {

        public static string sqlcon = "Data Source=VDC01LTC2126;Initial Catalog=HospitalMS;Integrated Security=True;";
        public List<Patient> patient;
        public List<Room> rooms;
        public string AddPatientDl(Patient pat)
        {

            #region disconnected approach
            string msg = "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("insert into Patient values(" +pat.PId + ",'" +pat.PPassword + "','" +pat.PName + "','" +pat.PEmail + "','"+pat.PDisease+"')", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            adp.Fill(dt);
            msg = "inserted";
            return msg;
            #endregion
        }
        public List<Patient> GetAllPatientDl()
        {
            #region disconnected region
            //string msg = "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("select * from Patient", con);
            DataTable dt = new DataTable();
            List<Patient> pat = new List<Patient>();
            adp.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    pat.Add(new Patient
                    {
                        PId = Convert.ToInt32(dt.Rows[i]["PId"]),
                        PPassword = dt.Rows[i]["PPassword"].ToString(),
                        PName = dt.Rows[i]["PName"].ToString(),
                        PEmail = dt.Rows[i]["PEmail"].ToString(),
                        PDisease = dt.Rows[i]["PDisease"].ToString()
                    });
                }
            }
            return pat;
            #endregion
        }
        public string DeletePatientDl(Patient pat)
        {
            #region disconnected approach
            string msg = "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("delete from patient where PId=(" + pat.PId + ") ", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            adp.Fill(dt);
            msg = "deleted";
            return msg;
            #endregion
        }
        public string UpdatePatientDl(Patient pat)
        {
            #region disconnected approach
            string msg = "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("update patient set Pid=(" + pat.PId + "), PPassword=('" + pat.PPassword + "'), PName=('" + pat.PName + "'),PEmail=('" + pat.PEmail + "'), PDisease=('" + pat.PDisease + "')", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            adp.Fill(dt);
            msg = "updatedd";
            return msg;
            #endregion
        }
        public List<Room> GetAllRoom()
        {
            #region disconnected region
//string msg = "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("select RoomNo, PId, date_of_discharge from Room", con);
            DataTable dt = new DataTable();
            List<Room> rooms = new List<Room>();
            adp.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    rooms.Add(new Room
                    {
                        RoomNo = Convert.ToInt32(dt.Rows[i]["RoomNo"]),
                        PId = Convert.ToInt32(dt.Rows[i]["PId"]),
                        //location = dt.Rows[i]["location"].ToString(),
                        //AvailableRooms = Convert.ToInt32(dt.Rows[i]["AvailableRooms"]),
                        //date_of_addmission = Convert.ToDateTime(dt.Rows[i]["date_of_admission"]),
                        date_of_discharge = Convert.ToDateTime(dt.Rows[i]["date_of_discharge"])
                    });
                }
            }
            return rooms;
            #endregion
        }
        }
    }
