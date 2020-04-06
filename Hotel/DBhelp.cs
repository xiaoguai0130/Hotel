using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Hotel
{
    class DBhelp
    {
        static string connStr= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\课件及作业\C#\Hotel\Hotel\hotel.mdf;Integrated Security=True";
        
        public static DataSet getSql(string sql)
        {
            SqlConnection conn = new SqlConnection(connStr);
            try
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }

        public static int exeSql(string sql)
        {
            SqlConnection conn = new SqlConnection(connStr);
            
            try
            {
                conn.Open();
                SqlCommand comm = new SqlCommand(sql, conn);
                return comm.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                //return 0;
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            
        }
    }
}
