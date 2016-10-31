using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Dal
{
    public class UserRepository : BaseRepository, IRepository<User>
    {
        public UserRepository(DBConnection connection):base(connection)
        {
        }

        public List<User> GetAll()
        { 
            var queryString = "SELECT * FROM Users";
            List<User> userList = new List<User>();
            SqlCommand command = new SqlCommand(queryString, this.connection.Connection);
            //command.Parameters.AddWithValue("@tPatSName", "Your-Parm-Value");

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                userList.Add(UserMapper.GetFromReader(reader));
            }

            return userList;
        }

        public User GetById(int id)
        {
            var query = "SELECT * FROM Users WHERE Users.Id = @id";
            
            SqlCommand command = new SqlCommand(query, this.connection.Connection);
            command.Parameters.AddWithValue("@id", id);

            var reader = command.ExecuteReader();

            if (reader.Read())
            {
                return UserMapper.GetFromReader(reader);
            }

            return null;
        }

        public void Add(User t)
        {
            var query = "INSERT INTO Users(UserName, FirstName, LastNAme, EmployeeType) values (@UserName, @FirstName, @LastName, @EmployeeType)";
            SqlCommand command = new SqlCommand(query, this.connection.Connection);
            command.Parameters.AddWithValue("@UserName", t.UserName);
            command.Parameters.AddWithValue("@FirstName", t.FirstName);
            command.Parameters.AddWithValue("@LastName", t.LastName);
            command.Parameters.AddWithValue("@EmployeeType", t.Type);
            command.ExecuteNonQuery();

        }
    }
}
