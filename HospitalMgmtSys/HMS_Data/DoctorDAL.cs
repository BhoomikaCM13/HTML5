using HMS_Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace HMS_Data
{
    public class DoctorDAL
    {

        public static string sqlcon = "Data Source=VDC01LTC2126;Initial Catalog=HospitalMS;Integrated Security=True;";
        public List<Doctor> admin;
        public string AddDoctor(Doctor doc)
        {

            #region disconnected approach
            string msg = "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("insert into Doctor values(" + doc.DId + ",'" + doc.DPassword + "','" + doc.DName + "','" + doc.DEmail + "')", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            adp.Fill(dt);
            msg = "inserted";
            return msg;
            #endregion
        }
        public List<Doctor> GetDoctor()
        {
            #region disconnected region
            //string msg = "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("select * from Doctor", con);
            DataTable dt = new DataTable();
            List<Doctor> doc = new List<Doctor>();
            adp.Fill(dt);
            if (dt != null && dt.Rows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    doc.Add(new Doctor
                    {
                        DId = Convert.ToInt32(dt.Rows[i]["DId"]),
                        DPassword = dt.Rows[i]["DPassword"].ToString(),
                        DName= dt.Rows[i]["DName"].ToString(),
                        DEmail = dt.Rows[i]["DEmail"].ToString()
                    });
                }
            }
            return doc;
            #endregion
        }
        public string  DeleteDoctor(Doctor doc)
        {
            #region disconnected approach
            string msg = "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("delete from Doctor where DId=(" + doc.DId + ") ", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            adp.Fill(dt);
            msg = "deleted";
            return msg;
            #endregion
        }
        public string UpdateDoctorDl(Doctor doc)
        {
            #region disconnected approach
            string msg = "";
            SqlConnection con = new SqlConnection(sqlcon);
            SqlDataAdapter adp = new SqlDataAdapter("update Doctor set Did=(" + doc.DId + "), DPassword=('" + doc.DPassword + "'), DName=('" + doc.DName + "'),DEmail=('" + doc.DEmail + "')", con);
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            adp.Fill(dt);
            msg = "updatedd";
            return msg;
            #endregion
        }
    }
}
