using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace QuanLyKhachHangWinApp
{
    class Connection //kết nối với database QLKH
    {
        private static string stringconnection = @"Data Source=ADMIN-PC\CONGPHATMIS;Initial Catalog=QLKH;Integrated Security=True;Encrypt=False";

        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringconnection);
        }     
    }
}
