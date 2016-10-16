using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA5
{
    class Appointment
    {
        public string Name { get; set; }
        public DateTime AppDateTime { get; set; }
        public DateTime ReminderTime { get; set; }
        public string Note { get; set; }
    }
}
