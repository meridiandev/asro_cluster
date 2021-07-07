using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asro_api.Data.Models
{
    public class thReports_1
    {
        public int Id { get; set; }
        public string TeatcherFullName { get; set; }
        public string EventForm { get; set; }
        public string EventLevel { get; set; }
        public DateTime? EventData { get; set; }
        public string EventFullName { get; set; }
        public string EventHours { get; set; }
        public string EventDocument { get; set; }
        public string EventWho { get; set; }
        public string EventNumber { get; set; }
        public DateTime ReportTimeAddIs { get; set; }
        public bool IsLockReport { get; set; }
    }
}
