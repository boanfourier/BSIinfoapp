using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ProjectApp
{
  public class OrganizerDal
    {
        const string strConn = "Server=.\\SQLEXPRESS02;Database=BSI_info;Trusted_Connection=True;";
        public IEnumerable<Organizers> GetAll()
        {
            List<Organizers> Organizers = new List<Organizers>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                string strSql = @"SELECT * FROM Organizers order by Name";
                SqlCommand cmd = new SqlCommand(strSql, conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                       Organizers.Add(new Organizers
                        {
                            organizer_id = Convert.ToInt32(dr["organizer_id"]),
                            name = dr["name"].ToString(),
                            email = dr["email"].ToString(),
                            phone = dr["phone"].ToString(),
                         
                        });
                    }
                }
                dr.Close();
                cmd.Dispose();
                conn.Close();
                return Organizers;
            }


            }
        }
    }

