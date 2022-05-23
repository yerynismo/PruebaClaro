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
        public readonly ICondominioData _CondominioData;
        public CondominioController(ICondominioData condominioData)
        {
            _CondominioData = condominioData;
        }

        // GET: 
        [HttpGet, Route("getAll")]
        public IActionResult Get()
        {
            if (_CondominioData.GetCondominio().Count() > 0)
            {
                return Ok(_CondominioData.GetCondominio());
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
                return Ok(_CondominioData.GetCondominio(codigo));
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
                return Ok(_CondominioData.AddCondominio(condominio));
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

                return Ok(_CondominioData.ModifyCondominio(condominio));
            }
            else
            {
                return BadRequest("Vacio");
            }
        }


        [HttpDelete, Route("DeleteOne/{codigo}")]
        public IActionResult Delete(int codigo)
        {
            if (_CondominioData.GetCondominio(codigo) != null)
            {
                _CondominioData.DeleteCondominio(codigo);
                return Ok();
            }
            else
            {
                return BadRequest("Vacio");
            }
        }
    }
}
