using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Models;
using Task = System.Threading.Tasks.Task;

namespace Dal
{
    static class HourMapper
    {
        public static Hour GetFromReader(SqlDataReader reader)
        {
            var hourId = 0;
            var userId = 0;
            var taskId = 0;
            var count = 0;
            var date = new DateTime();

            int.TryParse(reader["Id"].ToString(), out hourId);
            int.TryParse(reader["UserId"].ToString(), out userId);
            int.TryParse(reader["TaskId"].ToString(), out taskId);
            int.TryParse(reader["Count"].ToString(), out count);
            DateTime.TryParse(reader["Date"].ToString(), out date);
            return new Hour
            {
                Id = hourId,
                UserId = userId,
                TaskId = taskId,
                Count = count,
                Date = date
            };
        }
    }
    
}
