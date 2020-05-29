using library.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library.DAL
{
    class LoginDAL
    {
        static string myConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
    
        public bool loginCheck(LoginModel log)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                string sql = "SELECT * From staff WHERE username = @username AND password = @password";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", log.username);
                cmd.Parameters.AddWithValue("@password", log.password);

                SqlDataAdapter adaper = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adaper.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
    }
}
