using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using Dal;
using Models;

namespace TimeRegistrationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConnection dbConnection = new DBConnection();
            UserRepository userRepository = new UserRepository(dbConnection);

            User user = new User()
            {
                UserName = "Mihai",
                FirstName = "Misu",
                LastName = "Chereches",
                Type = "Employeee"
            };

            userRepository.Add(user);

            //var userList = userRepository.GetAll();

            Task task = new Task()
            {
                Name = "UNIT-1"
            };

            TaskRepository taskRepository = new TaskRepository(dbConnection);
            taskRepository.Add(task);

            Hour hour = new Hour()
            {
                UserId = 1,
                TaskId = 1,
                Count = 2,
                Date = DateTime.Today
            };

            HourRepository hourRepository = new HourRepository(dbConnection);
            hourRepository.Add(hour);

            List<Hour> listHours = hourRepository.GetAll();

        }
    }
}
