using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace Dal
{
    public class HourRepository : BaseRepository, IRepository<Hour>
    {
        public HourRepository(DBConnection connection) : base(connection) {}

        public List<Hour> GetAll()
        {
            var queryString = "SELECT * FROM Hours";
            List<Hour> hourList = new List<Hour>();
            SqlCommand command = new SqlCommand(queryString, this.connection.Connection);
            //command.Parameters.AddWithValue("@tPatSName", "Your-Parm-Value");

            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                hourList.Add(HourMapper.GetFromReader(reader));
            }

            return hourList;
        }

        public Hour GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Add(Hour t)
        {
            var insert = "INSERT INTO Hours(UserId, TaskId, Count, Date) VALUES (@UserId, @TaskId, @Count, @Date)";
            SqlCommand command = new SqlCommand(insert, this.connection.Connection);
            command.Parameters.AddWithValue("@UserId", t.UserId);
            command.Parameters.AddWithValue("@TaskId", t.TaskId);
            command.Parameters.AddWithValue("@Count", t.Count);
            command.Parameters.AddWithValue("@Date", t.Date);
            command.ExecuteNonQuery();
        }
    }
}
