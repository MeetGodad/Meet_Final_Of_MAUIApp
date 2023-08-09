using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectMAUIAPP
{
    public class Event
    {
        public decimal TicketCost { get; set; }
        public string Genre { get; set; }
        public string Artist { get; set; }
        public DateTime EventDate { get; set; }
        public TimeSpan EventTime { get; set; }
        public string Venue { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
    }

}
