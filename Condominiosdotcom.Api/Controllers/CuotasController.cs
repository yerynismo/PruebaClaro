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

    [Route("api/Cuotas")]
    [ApiController]
    public class CuotasController : ControllerBase
    {
        public readonly ICuotaService _CuotasData;
        public CuotasController(ICuotaService CuotasData)
        {
            _CuotasData = CuotasData;
        }

        // GET: 
        [HttpGet, Route("getAll")]
        public IActionResult Get()
        {
            if (_CuotasData.Get().Count() > 0)
            {
                return Ok(_CuotasData.Get());
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
                return Ok(_CuotasData.Get(codigo));
            }
            else
            {
                return BadRequest("Este empleado no existe");
            }

        }

        // POST 
        [HttpPost, Route("addOne")]
        public IActionResult Post(Cuotas Cuotas)
        {
            if (Cuotas != null)
            {
                return Ok(_CuotasData.Add(Cuotas));
            }
            else
            {
                return BadRequest("Vacio");
            }
        }

        // PUT 
        [HttpPut, Route("UpdateOne")]
        public IActionResult Put(Cuotas Cuotas)
        {
            if (Cuotas != null)
            {

                return Ok(_CuotasData.Modify(Cuotas));
            }
            else
            {
                return BadRequest("Vacio");
            }
        }


        [HttpDelete, Route("DeleteOne/{codigo}")]
        public IActionResult Delete(int codigo)
        {
            if (_CuotasData.Get(codigo) != null)
            {
                _CuotasData.Delete(codigo);
                return Ok();
            }
            else
            {
                return BadRequest("Vacio");
            }
        }
    }
}
