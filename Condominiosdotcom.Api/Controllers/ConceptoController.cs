using Microsoft.AspNetCore.Http;
using Condominiosdotcom.Api.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Condominiosdotcom.Api.Models;

namespace Condominiosdotcom.Api.Controllers
{
    [Route("api/Concepto")]
    [ApiController]
    public class ConceptoController : ControllerBase
    {
        public readonly IConceptoService _service;
        public ConceptoController(IConceptoService service)
        {
            _service = service;
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
        public IActionResult Post(Concepto data)
        {
            return Ok(_service.Add(data));
        }

        // PUT 
        [HttpPut, Route("UpdateOne")]
        public IActionResult Put(Concepto data)
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
