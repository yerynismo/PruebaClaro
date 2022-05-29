using Condominiosdotcom.Api.Interfaces;
using Condominiosdotcom.Api.Models;
using Condominiosdotcom.Api.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Condominiosdotcom.Api.Controllers
{
    [Route("api/Report")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        public readonly IReportService _service;
        public ReportController(IReportService service)
        {
            _service = service;
        }


        // GET 
        [HttpGet, Route("GetOne/{codigo}")]
        public IActionResult Report(int codigo)
        {
          var data = _service.Report(codigo);
          if (data == null)
            {
                return NotFound();
            }
          return Ok(data);          
        }

    }
}
