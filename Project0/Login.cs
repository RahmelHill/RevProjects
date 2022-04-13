using System;
using System.Data.SqlClient;


namespace HotelApp{

    class Login{
        public bool Logon(string user, string pass)
        {
            SqlConnection connect2 = new SqlConnection(@"Server=tcp:proj0.database.windows.net,1433;Initial Catalog=Proj0DB;Persist Security Info=False;User ID=proj0admin;Password=p@yt0nMan;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30"); 
            SqlCommand cmd_logon = new SqlCommand("select count(*) from Account where username=@user and password=@pass",connect2);

            cmd_logon.Parameters.AddWithValue("@user",user);
            cmd_logon.Parameters.AddWithValue("@pass",pass);

            try
            {
                connect2.Open();
                int Specification_count = (int) cmd_logon.ExecuteScalar();
                if (Specification_count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (System.Exception es)
            {
                throw new Exception(es.Message);
            }
            finally
            {
                connect2.Close();
            }
            }
        }
    }

