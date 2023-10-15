using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAn_Nhom10
{
    class DBConnect
    {
        private static string connectString = "Data Source = AORUS-LAPTOP; Initial Catalog = QLCH; User ID = sa; Password = 123";
        private SqlConnection sqlConnect = new SqlConnection();

        //Khởi tạo
        public DBConnect()
        {
            sqlConnect = new SqlConnection(connectString);
        }

        //Phương thức
        public void Open()
        {
            if (sqlConnect.State == ConnectionState.Closed)
            {
                sqlConnect.Open();
            }
        }

        public void Close()
        {
            if (sqlConnect.State == ConnectionState.Open)
            {
                sqlConnect.Close();
            }
        }

        //Chạy lệnh non query
        public int getNonQuery(string sqlQuery)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnect);

            int result = cmd.ExecuteNonQuery();

            Close();
            return result;
        }

        //Chạy lệnh Scalar (Select,...)
        public int getScalar(string sqlQuery)
        {
            Open();
            SqlCommand cmd = new SqlCommand(sqlQuery, sqlConnect);

            int result = (int)cmd.ExecuteScalar();

            Close();
            return result;
        }
    }
}
