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
    [Route("api/Pagos")]
    [ApiController]
    public class PagosController : ControllerBase
    {
        public readonly IPagosService _PagosData;
        public PagosController(IPagosService PagosData)
        {
            _PagosData = PagosData;
        }

        // GET: 
        [HttpGet, Route("getAll")]
        public IActionResult Get()
        {
            if (_PagosData.Get().Count() > 0)
            {
                return Ok(_PagosData.Get());
            }
            else
            {
                return BadRequest("Vacio");
            }


        }

        // GET
        [HttpGet, Route("GetOne/{codigo}")]
        public IActionResult Get(int codigo)
        {

            if (codigo > 0)
            {
                return Ok(_PagosData.Get(codigo));
            }
            else
            {
                return BadRequest("Este empleado no existe");
            }

        }

        // POST 
        [HttpPost, Route("addOne")]
        public IActionResult Post(Pagos pagos)
        {
            if (pagos != null)
            {
                return Ok(_PagosData.Add(pagos));
            }
            else
            {
                return BadRequest("Vacio");
            }
        }

        // PUT 
        [HttpPut, Route("UpdateOne")]
        public IActionResult Put(Pagos pagos)
        {
            if (pagos != null)
            {

                return Ok(_PagosData.Modify(pagos));
            }
            else
            {
                return BadRequest("Vacio");
            }
        }


        [HttpDelete, Route("DeleteOne/{codigo}")]
        public IActionResult Delete(int codigo)
        {
            if (_PagosData.Get(codigo) != null)
            {
                _PagosData.Delete(codigo);
                return Ok();
            }
            else
            {
                return BadRequest("Vacio");
            }

        }
    }
}
