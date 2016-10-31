using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Models;

namespace Dal
{
    public class TaskRepository : BaseRepository, IRepository<Task>
    {
        public TaskRepository(DBConnection connection) : base(connection) {}

        public List<Task> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Task t)
        {
            var insert = "INSERT INTO Tasks(Name) VALUES (@Name)";
            SqlCommand command = new SqlCommand(insert, this.connection.Connection);
            command.Parameters.AddWithValue("@Name", t.Name);
            command.ExecuteNonQuery();
        }
    }
}
