using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asro_api.Data.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public int FullName { get; set; }
        // Navigation Props

        public List<thReports_1_Teacher> thReports_1_Teacher { get; set; }
    }
}
