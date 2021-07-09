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

        [HttpGet("get-all-reports-1")]
        public IActionResult GetAllReports01()
        {
            var AllthReports1 = _thReports01Services.GetAllReports01();
            return Ok(AllthReports1);
        }

        [HttpGet("get-reports-1-by-id/{id}")]
        public IActionResult GetThReports_1ById(int id)
        {
            var thReports1 = _thReports01Services.GetThReports_1ById(id);
            return Ok(thReports1);
        }

        [HttpPost("add-report-1")]

        public IActionResult AddThReports01([FromBody]thReports_01VM thReports01)
        {
            _thReports01Services.AddthReports01(thReports01);
            return Ok();
        }
    }
}
