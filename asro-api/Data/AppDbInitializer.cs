using asro_api.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asro_api.Data
{
    public class AppDbInitializer
    {
        // Add Seeds
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                if (!context.thReports_1.Any())
                {
                    context.thReports_1.AddRange(
                    new thReports_1()
                    {
                        TeatcherFullName = "Василий Сергеев",
                        EventForm = "вебинары",
                        EventLevel = "областной",
                        EventData = DateTime.Now.AddDays(-10),
                        EventFullName = "WSR 2021 подготовка участников",
                        EventHours = "5",
                        EventDocument = "Да",
                        EventWho = "Центр подготовки к чемпионату WSR Сибирь",
                        EventNumber = "82349 - 5833",
                        ReportTimeAddIs = DateTime.Now,
                        IsLockReport = true
                    },
                    new thReports_1()
                    {
                        TeatcherFullName = "Константин Николаевич",
                        EventForm = "методические объединения",
                        EventLevel = "всероссийский",
                        EventData = DateTime.Now.AddDays(-10),
                        EventFullName = "Лучшие методики TRIZ",
                        EventHours = "8",
                        EventDocument = "Да",
                        EventWho = "Московский центр подготовки методистов TRIZ",
                        EventNumber = "NCI-3312-878492-768234",
                        ReportTimeAddIs = DateTime.Now,
                        IsLockReport = false
                    });

                    context.SaveChanges();
                }
            }
        }
    }
}
