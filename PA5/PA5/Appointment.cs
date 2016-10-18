using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA5
{
    class Appointment
    {
        /// <summary>
        /// gets sets the Name of the appointment
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// gets sets Due time
        /// </summary>
        public DateTime AppDateTime { get; set; }

        /// <summary>
        /// gets sets Reminder time
        /// </summary>
        public DateTime ReminderTime { get; set; }

        /// <summary>
        /// gets sets Note text
        /// </summary>
        public string Note { get; set; }
    }
}
