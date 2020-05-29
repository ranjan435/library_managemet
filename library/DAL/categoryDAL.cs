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
    class categoryDAL
    {
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
                String sql = "SELECT * From category";

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
        public bool Insert(CategoryModel cat)
        {
            //create a boolean variable and set its default value to false
            bool isSuccess = false;

            //create an object of SqlConnection to connect db
            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                //create a string variable to store the insert query
                String sql = "INSERT INTO category(name) VALUES (@name) ";

                //create a sql command to pass the value in our query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create the parameter to pass get the value form UI and pass it on SQL query above
                cmd.Parameters.AddWithValue("@name", cat.name);

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
        public bool Update(CategoryModel cat)
        {
            bool isSucess = false;

            //create an object for Database Connection
            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                String sql = "UPDATE category SET name=@name WHERE category_id=@category_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", cat.name);

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
        public bool Delete(CategoryModel cat)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myConnectionString);
            try
            {
                String sql = "DELETE FROM category WHERE category_id = @category_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@staff_id", cat.category_id);

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
                String sql = "SELECT * FROM category WHERE category_id LIKE '%" + keywords + "%' OR name LIKE '%" + keywords + "%'";

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
        #region Search by name and return id
        public int SearchByName(string keywords)
        {
            //create an sql connection for connecting db
            SqlConnection conn = new SqlConnection(myConnectionString);

            //create data table to hold the data from db temporariy in memory
            DataTable dt = new DataTable();
            int i = 0;
            //main code
            try
            {
                //write the sql query for search operation
                String sql = "SELECT * FROM category WHERE name LIKE '%" + keywords + "%'";

                //create sql command to execute query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create sql data adapter to get data from db
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open connection
                conn.Open();

                //pass data from adapter to datatable
                adapter.Fill(dt);

                i = int.Parse(dt.Rows[0][0].ToString().Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return i;
        }
        #endregion
    }
}
