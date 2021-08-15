using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asro_api.Data.Models
{
    public class thReports_1_Teacher
    {
        public int Id { get; set; }
        public int thReports_1Id { get; set; }
        public thReports_1 thReports_1 { get; set; }


        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
    }
}
