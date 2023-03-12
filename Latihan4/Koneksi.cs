using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan4
{
    internal class Koneksi
    {
        public SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Data source = LAPTOP-T69S43N8\SQLEXPRESS; Initial Catalog = latihan4; Integrated Security = true";
            return conn;
        } 
    }
}
