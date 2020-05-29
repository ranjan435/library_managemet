using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using library.BLL;

namespace library.DAL
{
    class userDAL
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
                String sql = "SELECT * From Table_1";

                //create sql command to execute query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create sql data adapter to hold the data from db temporarily on memory
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open database connection
                conn.Open();

                //transfer data from sqldata adapter to datatable
                adapter.Fill(dt);
            }
            catch(Exception ex)
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
        public bool Insert(UserModel u)
        {
            //create a boolean variable and set its default value to false
            bool isSuccess = false;

            //create an object of SqlConnection to connect db
            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                //create a string variable to store the insert query
                String sql = "INSERT INTO Table_1(username,first_name,last_name,email,address,mobile,gender,enrolled_date,membership_expiry_date,num_books_borrowed) VALUES (@username,@first_name,@last_name,@email,@address,@mobile,@gender,@enrolled_date,@membership_expiry_date,@num_books_borrowed) ";

                //create a sql command to pass the value in our query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create the parameter to pass get the value form UI and pass it on SQL query above
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@mobile", u.mobile);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@enrolled_date", u.enrolled_date);
                cmd.Parameters.AddWithValue("@membership_expiry_date", u.membership_expiry_date);
                cmd.Parameters.AddWithValue("@num_books_borrowed", u.num_books_borrowed);

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
        #endregion

        #region Update data in database (User Model)
        public bool Update(UserModel u)
        {
            bool isSucess = false;

            //create an object for Database Connection
            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                String sql = "UPDATE Table_1 SET username=@username,first_name=@first_name,last_name=@last_name,email=@email,address=@address,mobile=@mobile,gender=@gender,enrolled_date=@enrolled_date,membership_expiry_date=@membership_expiry_date,num_books_borrowed=@num_books_borrowed WHERE user_id=@user_id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@first_name", u.first_name);
                cmd.Parameters.AddWithValue("@last_name", u.last_name);
                cmd.Parameters.AddWithValue("@email", u.email);
                cmd.Parameters.AddWithValue("@address", u.address);
                cmd.Parameters.AddWithValue("@mobile", u.mobile);
                cmd.Parameters.AddWithValue("@gender", u.gender);
                cmd.Parameters.AddWithValue("@enrolled_date", u.enrolled_date);
                cmd.Parameters.AddWithValue("@membership_expiry_date", u.membership_expiry_date);
                cmd.Parameters.AddWithValue("@num_books_borrowed", u.num_books_borrowed);
                cmd.Parameters.AddWithValue("@user_id", u.user_id);

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

        #region
        public bool Update(String username, int numberOfBooks)
        {
            bool isSucess = false;

            //create an object for Database Connection
            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                String sql = "UPDATE Table_1 SET num_books_borrowed=@num_books_borrowed WHERE username=@user_name";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@num_books_borrowed", numberOfBooks);
                cmd.Parameters.AddWithValue("@user_name", username);

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
        #endregion update only number of books

        #region Delete data from db
        public bool Delete(UserModel u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myConnectionString);
            try
            {
                String sql = "DELETE FROM Table_1 WHERE user_id = @user_id";
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("@user_id", u.user_id);

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
                String sql = "SELECT * FROM Table_1 WHERE user_id LIKE '%" + keywords + "%' OR username LIKE '%" + keywords + "%'";

                //create sql command to execute query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create sql data adapter to get data from db
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open connection
                conn.Open();

                //pass data from adapter to datatable
                adapter.Fill(dt);
            }
            catch(Exception ex)
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
