using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using library.BLL;

namespace library.DAL

{
    class staffDAL
    {
        // static string to connect database
        static string myConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;
        public DataTable Select()
        {
            //create an object to connect database
            SqlConnection conn = new SqlConnection(myConnectionString);

            //create a datatable to hold the data from database
            DataTable dt = new DataTable();
            try
            {
                //sql query to get data from db
                String sql = "SELECT * From staff";

                //create sql command to execute query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create sql data adapter to hold the data from db temporarily on memory
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open database connection
                conn.Open();

                //transfer data from sqldata adapter to datatable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        #region Insert Data into Database for User Model
        public bool Insert(StaffModel staff)
        {
            //create a boolean variable and set its default value to false
            bool isSuccess = false;

            //create an object of SqlConnection to connect db
            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                //create a string variable to store the insert query
                String sql = "INSERT INTO staff(username,password) VALUES (@username,@password) ";

                //create a sql command to pass the value in our query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create the parameter to pass get the value form UI and pass it on SQL query above
                cmd.Parameters.AddWithValue("@username", staff.username);
                cmd.Parameters.AddWithValue("@password", staff.password);
                
                //open database connection
                conn.Open();

                //create an integer var to hold the value after the query is executed
                int rows = cmd.ExecuteNonQuery();

                //the value of rows will be greate than 0 if the query is successfully executed
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        #endregion

        #region Update data in database (User Model)
        public bool Update(StaffModel staff)
        {
            bool isSucess = false;

            //create an object for Database Connection
            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                String sql = "UPDATE staff SET username=@username,password=@password WHERE staff_id=@staff_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", staff.username);
                cmd.Parameters.AddWithValue("@password",staff.password);
      
                //open database connection
                conn.Open();


                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSucess = true;
                }
                else
                {
                    isSucess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSucess;
        }
        #endregion

        #region Delete data from db
        public bool Delete(StaffModel staff)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myConnectionString);
            try
            {
                String sql = "DELETE FROM staff WHERE staff_id = @staff_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@staff_id", staff.staff_id);

                //open database
                conn.Open();


                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;

        }
        #endregion

        #region Search
        public DataTable Search(string keywords)
        {
            //create an sql connection for connecting db
            SqlConnection conn = new SqlConnection(myConnectionString);

            //create data table to hold the data from db temporariy in memory
            DataTable dt = new DataTable();

            //main code
            try
            {
                //write the sql query for search operation
                String sql = "SELECT * FROM staff WHERE staff_id LIKE '%" + keywords + "%' OR username LIKE '%" + keywords + "%'";

                //create sql command to execute query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create sql data adapter to get data from db
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open connection
                conn.Open();

                //pass data from adapter to datatable
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return dt;
        }
        #endregion
    }
}
