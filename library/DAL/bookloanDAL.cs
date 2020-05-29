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
    class bookloanDAL
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
                string sql = "SELECT * FROM book_loan";

                //create the sql commannd to execute the query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create sql data adapter to hold the data temporarily
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open database connection
                conn.Open();

                //pass the data from data adapter to data table
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

        #region Insert data to database
        public bool Insert(BookLoanModel b)
        {
            bool isSuccess = false;

            //create sql connection to connect database
            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                //write the query to insert into database
                string sql = "INSERT INTO book_loan (issued_book_id,issued_to_user_id,issued_date,return_date,issued_book_name,issued_user_name,return_status) VALUES(@issued_book_id,@issued_to_user_id,@issued_date,@return_date,@issued_book_name,@issued_user_name,@return_status)";

                //create sql command to execute the query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //pass the value to sql query
                cmd.Parameters.AddWithValue("@issued_book_id", b.issued_book_id);
                cmd.Parameters.AddWithValue("@issued_to_user_id", b.issued_to_user_id);
                cmd.Parameters.AddWithValue("@issued_date", b.issued_date);
                cmd.Parameters.AddWithValue("@return_date", b.return_date);
                cmd.Parameters.AddWithValue("@issued_book_name", b.issued_book_name);
                cmd.Parameters.AddWithValue("@issued_user_name", b.issued_user_name);
                cmd.Parameters.AddWithValue("@return_status", b.return_status);

                //open database connection
                conn.Open();

                //create an integer variable to check whether the query was executed succesfully or not
                int checkValue = cmd.ExecuteNonQuery();

                if (checkValue > 0)
                {
                    isSuccess = true;
                    userDAL u = new userDAL();
                    u.Update(b.issued_user_name, countBooksLend(b.issued_user_name));
                    bookDAL bro = new bookDAL();
                    bro.Update(b.issued_book_name, b.return_status);
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

        #region Update 
        public bool Update(BookLoanModel b)
        {
            bool isUpdateSuccess = false;

            //create sql connection
            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                string sql = "UPDATE book_loan SET issued_book_id=@issued_book_id,issued_to_user_id=@issued_to_user_id,issued_date=@issued_date,return_date=@return_date,issued_book_name=@issued_book_name,return_status=@return_status WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@issued_book_id", b.issued_book_id);
                cmd.Parameters.AddWithValue("@issued_to_user_id", b.issued_to_user_id);
                cmd.Parameters.AddWithValue("@issued_date", b.issued_date);
                cmd.Parameters.AddWithValue("@return_date", b.return_date);
                cmd.Parameters.AddWithValue("@id", b.id);
                cmd.Parameters.AddWithValue("@issued_book_name", b.issued_book_name);
                cmd.Parameters.AddWithValue("@issued_user_name", b.issued_user_name);
                cmd.Parameters.AddWithValue("@return_status", b.return_status);

                conn.Open();

                int checkValue = cmd.ExecuteNonQuery();

                if (checkValue > 0)
                {
                    isUpdateSuccess = true;
                    userDAL u = new userDAL();
                    u.Update(b.issued_user_name, countBooksLend(b.issued_user_name));
                    bookDAL bro = new bookDAL();
                    bro.Update(b.issued_book_name, b.return_status);
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
        public bool Delete(BookLoanModel b)
        {
            bool isDeleteSuccess = false;

            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                String sql = "DELETE FROM book_loan WHERE id = @id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@id", b.id);

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
                String sql = "SELECT * FROM book_loan WHERE id LIKE '%" + keywords + "%' OR issued_book_name LIKE '%" + keywords + "%' OR issued_user_name LIKE '%" + keywords + "%'";

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

        #region Search book loan by user
        public List<BookLoanModel> Search(int userID)
        {
            List<BookLoanModel> listBook = new List<BookLoanModel>();
            //create an sql connection for connecting db
            SqlConnection conn = new SqlConnection(myConnectionString);

            //create data table to hold the data from db temporariy in memory
            DataTable dt = new DataTable();

            //main code
            try
            {
                //write the sql query for search operation
                String sql = "SELECT * FROM book_loan WHERE issued_to_user_id LIKE '%" + userID + "%' AND return_status = '" + 0 + "'";

                //create sql command to execute query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //create sql data adapter to get data from db
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //open connection
                conn.Open();

                //pass data from adapter to datatable
                adapter.Fill(dt);

                for (int i= 0; i < dt.Rows.Count; i++)
                {
                    BookLoanModel m = new BookLoanModel();
                    m.issued_book_name = dt.Rows[i]["issued_book_name"].ToString();
                    m.issued_user_name = dt.Rows[i]["issued_user_name"].ToString();
                    m.issued_date = DateTime.Parse(dt.Rows[i]["issued_date"].ToString());
                    m.return_date = DateTime.Parse(dt.Rows[i]["return_date"].ToString());
                    listBook.Add(m);
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

            return listBook;
        }
        #endregion

        #region count number of books lend to a user
        public int countBooksLend(string lender_name)
        {
            SqlConnection conn = new SqlConnection(myConnectionString);

            int number = 0;
            try
            {
                string sql = "SELECT * FROM book_loan WHERE issued_user_name= '" + lender_name + "' AND return_status = '" + 0 + "' ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                adapter.Fill(dt);

                number = dt.Rows.Count;

            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            finally {
                conn.Close();
            }
            return number;
        }
        #endregion
    }
}
