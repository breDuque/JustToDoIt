using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustToDoIt.MVVM.Model
{
    public class Tasks
    {
        public int id { get; set; }
        public User user { get; set; }
        public string taskName { get; set; }
        public string description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
    }
}
