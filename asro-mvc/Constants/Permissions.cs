using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asro_mvc.Constants
{
    public class Permissions
    {
        public static List<string> GeneratePermissionsForModule(string module)
        {
            return new List<string>()
            {
                $"Permissions.{module}.View",
                $"Permissions.{module}.Create",
                $"Permissions.{module}.Edit",
                $"Permissions.{module}.Delete",
            };
        }

        public static class Reports
        {
            public const string View = "Permissions.Reports.View";
            public const string Create = "Permissions.Reports.Create";
            public const string Edit = "Permissions.Reports.Edit";
            public const string Delete = "Permissions.Reports.Delete";
        }
    }
}
