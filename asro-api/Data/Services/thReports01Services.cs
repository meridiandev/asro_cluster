using asro_api.Data.Models;
using asro_api.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asro_api.Data.Services
{
    public class thReports01Services
    {
        private AppDbContext _context;
        public thReports01Services(AppDbContext context)
        {
            _context = context;
        }

        public void AddthReports01(thReports_01VM thReports01)
        {
            var _thReports01 = new thReports_1()
            {
                TeatcherFullName = thReports01.TeatcherFullName,
                EventForm = thReports01.EventForm,
                EventLevel = thReports01.EventLevel,
                EventData = thReports01.EventData,
                EventFullName = thReports01.EventFullName,
                EventHours = thReports01.EventHours,
                EventDocument = thReports01.EventDocument,
                EventWho = thReports01.EventWho,
                EventNumber = thReports01.EventNumber,
                ReportTimeAddIs = DateTime.Now,
                IsLockReport = true
            };
            _context.thReports_1.Add(_thReports01);
            _context.SaveChanges();
        }
        public List<thReports_1> GetAllReports01() => _context.thReports_1.ToList();
        public thReports_1 GetThReports_1ById(int thReports_1Id) => _context.thReports_1.FirstOrDefault(n => n.Id == thReports_1Id);
    }
}
