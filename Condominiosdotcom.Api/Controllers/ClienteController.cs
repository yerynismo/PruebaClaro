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
    [Route("api/Cliente")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        public readonly IClienteService _service;
        public ClienteController(IClienteService service)
        {
            _service = service;
        }

        // GET REPORT:
        [HttpGet, Route("getReport/{id}")]
        public IActionResult GetReport(int id)
        {
            return Ok(_service.GetReport(id));
        }

        // GET:
        [HttpGet, Route("getAll")]
        public IActionResult Get()
        {
             return Ok(_service.Get());
        }

        // GET 
        [HttpGet, Route("GetOne/{codigo}")]
        public IActionResult Get(int codigo)
        {
          var data = _service.Get(codigo);
          if (data == null)
            {
                return NotFound();
            }
          return Ok(data);          
        }

        // POST
        [HttpPost, Route("addOne")]
        public IActionResult Post(Cliente data)
        {
            return Ok(_service.Add(data));
        }

        // PUT 
        [HttpPut, Route("UpdateOne")]
        public IActionResult Put(Cliente data)
        {
               return Ok(_service.Modify(data));
        }


        [HttpDelete, Route("DeleteOne/{codigo}")]
        public IActionResult Delete(int codigo)
        {
           _service.Delete(codigo);
           return Ok();
        }
    }
}
