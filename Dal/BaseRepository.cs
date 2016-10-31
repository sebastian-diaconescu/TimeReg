using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class BaseRepository
    {
        protected DBConnection connection;

        public BaseRepository(DBConnection connection)
        {
            this.connection = connection;
        }
    }
}
