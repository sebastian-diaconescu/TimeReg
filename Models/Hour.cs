using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Hour : Entity
    {
        public int UserId { get; set; }
        public int TaskId { get; set; }
        public int Count { get; set; }
        public DateTime Date { get; set; }
    }
}
