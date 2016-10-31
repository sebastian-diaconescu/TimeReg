using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Dal
{
    public class DBConnection : IDisposable
    {
        public SqlConnection Connection;

        public DBConnection()
        {
            Connection = new SqlConnection();
            Connection.ConnectionString = @"Server = SEBASTIAND-LAP; Database = TimeRegistration; User Id = user; Password = Test1234%;";
            Connection.Open();
        }
        
        public void Dispose()
        {
            Connection.Close();
        }
    }
}
