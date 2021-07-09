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

        public thReports_1 UpdateThReports_1ById(int thReports_1Id, thReports_01VM thReports_1)
        {
            var _thReports01 = _context.thReports_1.FirstOrDefault(n => n.Id == thReports_1Id);
            if(_thReports01 != null)
            {
                _thReports01.TeatcherFullName = thReports_1.TeatcherFullName;
                _thReports01.EventForm = thReports_1.EventForm;
                _thReports01.EventLevel = thReports_1.EventLevel;
                _thReports01.EventData = thReports_1.EventData;
                _thReports01.EventFullName = thReports_1.EventFullName;
                _thReports01.EventHours = thReports_1.EventHours;
                _thReports01.EventDocument = thReports_1.EventDocument;
                _thReports01.EventWho = thReports_1.EventWho;
                _thReports01.EventNumber = thReports_1.EventNumber;
                _thReports01.ReportTimeAddIs = DateTime.Now;
                _thReports01.IsLockReport = true;

                _context.SaveChanges();
            }

            return _thReports01;
        }

        public void DeleteThReports_1ById(int thReports_1Id)
        {
            var _thReports01 = _context.thReports_1.FirstOrDefault(n => n.Id == thReports_1Id);
            if(_thReports01 != null)
            {
                _context.thReports_1.Remove(_thReports01);
                _context.SaveChanges();
            }
        }
    }
}
