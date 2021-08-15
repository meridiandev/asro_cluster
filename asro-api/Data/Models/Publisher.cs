using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asro_api.Data.Models
{
    public class Publisher
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public List<thReports_1> thReports_1 { get; set; }
    }
}
