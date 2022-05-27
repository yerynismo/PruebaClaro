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
    [Route("api/Condominio")]
    [ApiController]
    public class CondominioController : ControllerBase
    {
        public readonly ICondominioService _CondominioData;
        public CondominioController(ICondominioService condominioData)
        {
            _CondominioData = condominioData;
        }

        // GET: 
        [HttpGet, Route("getAll")]
        public IActionResult Get()
        {
            if (_CondominioData.Get().Count() > 0)
            {
                return Ok(_CondominioData.Get());
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
                return Ok(_CondominioData.Get(codigo));
            }
            else
            {
                return BadRequest("Este empleado no existe");
            }

        }

        // POST
        [HttpPost, Route("addOne")]
        public IActionResult Post(Condominio condominio)
        {
            if (condominio != null)
            {
                return Ok(_CondominioData.Add(condominio));
            }
            else
            {
                return BadRequest("Vacio");
            }
        }

        // PUT 
        [HttpPut, Route("UpdateOne")]
        public IActionResult Put(Condominio condominio)
        {
            if (condominio != null)
            {

                return Ok(_CondominioData.Modify(condominio));
            }
            else
            {
                return BadRequest("Vacio");
            }
        }


        [HttpDelete, Route("DeleteOne/{codigo}")]
        public IActionResult Delete(int codigo)
        {
            if (_CondominioData.Get(codigo) != null)
            {
                _CondominioData.Delete(codigo);
                return Ok();
            }
            else
            {
                return BadRequest("Vacio");
            }
        }
    }
}
