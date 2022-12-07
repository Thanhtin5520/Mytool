using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Mytool
{
    class ConnectDatabase
    {
        public static SqlConnection conn;

        // mở kết nối

        public static void connect()
        {
            if (conn == null)

              conn = new SqlConnection(@"Data Source=WS30206\MSSQLSERVER01;Initial Catalog=ToolLo;Integrated Security=True");

            if (conn.State == ConnectionState.Closed)

                conn.Open();
        }
        public static void disconnect()

        {

            if ((conn != null) && (conn.State == ConnectionState.Open))

                conn.Close();

        }
        public static DataTable getDataTable(string sql)

        {

            connect();

            SqlDataAdapter da = new SqlDataAdapter(sql, conn);

            DataTable dt = new DataTable();

            da.Fill(dt);

            disconnect();

            return dt;

        }
        public static int KiemTraTrong(string Textbox)
        {
            int flag = 0;
            if (Textbox == "")
            {
                flag = 1;
            }

            return flag;
        }

        // thực thi câu lệnh truy vấn insert,delete,update

        public void ExecuteNonQuery(string sql)

        {

            connect();

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.ExecuteNonQuery();

            disconnect();

        }


        // trả về DataReader

        public static SqlDataReader getDataReader(string sql)

        {

            connect();

            SqlCommand com = new SqlCommand(sql, conn);

            SqlDataReader dr = com.ExecuteReader();

            return dr;

        }

    }
}

