using library.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace library.DAL
{
    class bookDAL
    {
        //create a Connection String to Connect database
        static string myConnectionString = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        #region SELECT method to display all data in datagridview from database
        public DataTable Select()
        {
            DataTable dt = new DataTable();

            //create object of sql connection
            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                //write sql query to select the data from database
                string sql = "SELECT * FROM book";

                //create the sql commannd to execute the query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create sql data adapter to hold the data temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open database connection
                conn.Open();

                //pass the data from data adapter to data table
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

        #region Insert data to database
        public bool Insert(BookModel b)
        {
            bool isSuccess = false;

            //create sql connection to connect database
            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                //write the query to insert into database
                string sql = "INSERT INTO book (book_name,book_image,availability,author,edition,price,rack_number,category_name) VALUES(@book_name,@book_image,@availability,@author,@edition,@price,@rack_number,@category_name)";

                //create sql command to execute the query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //pass the value to sql query
                cmd.Parameters.AddWithValue("@book_name", b.book_name);
                cmd.Parameters.AddWithValue("@book_image", b.book_image);
                cmd.Parameters.AddWithValue("@availability", b.availability);
                cmd.Parameters.AddWithValue("@author", b.author);
                cmd.Parameters.AddWithValue("@edition", b.edition);
                cmd.Parameters.AddWithValue("@price", b.price);
                cmd.Parameters.AddWithValue("@rack_number", b.rack_number);
                cmd.Parameters.AddWithValue("@category_name", b.category_name);

                //open database connection
                conn.Open();

                //create an integer variable to check whether the query was executed succesfully or not
                int checkValue = cmd.ExecuteNonQuery();

                if (checkValue > 0)
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

        #region Update 
        public bool Update(BookModel b)
        {
            bool isUpdateSuccess = false;

            //create sql connection
            SqlConnection conn = new SqlConnection(myConnectionString);

            try{
                string sql = "UPDATE book SET book_name=@book_name,book_image=@book_image,availability=@availability,author=@author,edition=@edition,price=@price,rack_number=@rack_number,category_name=@category_name WHERE book_id=@book_id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@book_name", b.book_name);
                cmd.Parameters.AddWithValue("@book_image", b.book_image);
                cmd.Parameters.AddWithValue("@availability", b.availability);
                cmd.Parameters.AddWithValue("@author", b.author);
                cmd.Parameters.AddWithValue("@edition", b.edition);
                cmd.Parameters.AddWithValue("@price", b.price);
                cmd.Parameters.AddWithValue("@rack_number", b.rack_number);
                cmd.Parameters.AddWithValue("@book_id", b.book_id);
                cmd.Parameters.AddWithValue("@category_name", b.category_name);


                conn.Open();

                int checkValue = cmd.ExecuteNonQuery();

                if (checkValue > 0)
                {
                    isUpdateSuccess = true;
                }
                else
                {
                    isUpdateSuccess = false;
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
            return isUpdateSuccess;
        }
        #endregion

        #region Update only the availabitity
        public bool Update(string bookName, int return_status)
        {
            bool isUpdateSuccess = false;

            //create sql connection
            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                string sql = "UPDATE book SET availability=@availability WHERE book_name=@book_name";

                SqlCommand cmd = new SqlCommand(sql, conn);
               /* switch (return_status)
                {
                    case 1:
                        return_status = 0;
                        break;
                    case 0:
                        return_status = 0;
                        break;
                }*/

                cmd.Parameters.AddWithValue("@book_name", bookName);
                cmd.Parameters.AddWithValue("@availability", return_status);

                conn.Open();

                int checkValue = cmd.ExecuteNonQuery();

                if (checkValue > 0)
                {
                    isUpdateSuccess = true;
                }
                else
                {
                    isUpdateSuccess = false;
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
            return isUpdateSuccess;
        }
        #endregion

        #region Delete
        public bool Delete(BookModel b)
        {
            bool isDeleteSuccess = false;

            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                String sql = "DELETE FROM book WHERE book_id = @book_id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@book_id", b.book_id);

                conn.Open();

                int checkValue = cmd.ExecuteNonQuery();

                if (checkValue > 0)
                {
                    isDeleteSuccess = true;
                }
                else
                {
                    isDeleteSuccess = false;
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

            return isDeleteSuccess;
        }
        #endregion

        #region Search by keyword

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
                String sql = "SELECT * FROM book WHERE book_id LIKE '%" + keywords + "%' OR book_name LIKE '%" + keywords + "%'";

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
