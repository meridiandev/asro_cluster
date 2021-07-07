using asro_api.Data.Services;
using asro_api.Data.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asro_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class thReports01Controller : ControllerBase
    {
        public thReports01Services _thReports01Services;
        public thReports01Controller(thReports01Services thReports01Services)
        {
            _thReports01Services = thReports01Services;
        }

        [HttpPost("add-report-1")]

        public IActionResult AddThReports01([FromBody]thReports_01VM thReports01)
        {
            _thReports01Services.AddthReports01(thReports01);
            return Ok();
        }
    }
}
