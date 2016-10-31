using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Models;

namespace Dal
{
    class TaskMapper
    {
        public static Task GetFromReader(SqlDataReader reader)
        {
            var taskId = 0;

            int.TryParse(reader["Id"].ToString(), out taskId);
            return new Task
            {
                Id = taskId,
                Name = reader["UserName"].ToString()
            };
        }
    }
}
