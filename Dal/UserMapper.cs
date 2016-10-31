using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Models;

namespace Dal
{
    public static class UserMapper
    {
        public static User GetFromReader(SqlDataReader reader)
        {
            /*var user = new User();
            user.UserName = reader["UserName"].ToString();*/
            var userId = 0;

            int.TryParse(reader["Id"].ToString(), out userId);
            return new User
            {
                Id = userId,
                UserName = reader["UserName"].ToString(),
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                Type = reader["EmployeeType"].ToString()
            };
        } 
    }
}
