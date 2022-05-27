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
    [Route("api/Residencial")]
    [ApiController]
    public class ResidencialController : ControllerBase
    {

        public readonly IResidencialService _ResidencialData;
        public ResidencialController(IResidencialService residencialData)
        {
            _ResidencialData = residencialData;
        }

        // GET: 
        [HttpGet, Route("getAll")]
        public IActionResult Get()
        {
            if (_ResidencialData.Get().Count() > 0)
            {
                return Ok(_ResidencialData.Get());
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
                return Ok(_ResidencialData.Get(codigo));
            }
            else
            {
                return BadRequest("Este empleado no existe");
            }

        }

        // POST 
        [HttpPost, Route("addOne")]
        public IActionResult Post(Residencial residencial)
        {
            if (residencial != null)
            {
                return Ok(_ResidencialData.Add(residencial));
            }
            else
            {
                return BadRequest("Vacio");
            }
        }

        // PUT 
        [HttpPut, Route("UpdateOne")]
        public IActionResult Put(Residencial residencial)
        {
            if (residencial != null)
            {

                return Ok(_ResidencialData.Modify(residencial));
            }
            else
            {
                return BadRequest("Vacio");
            }
        }

        //DELETE
        [HttpDelete, Route("DeleteOne/{codigo}")]
        public IActionResult Delete(int codigo)
        {
            if (_ResidencialData.Get(codigo) != null)
            {
                _ResidencialData.Delete(codigo);
                return Ok();
            }
            else
            {
                return BadRequest("Vacio");
            }

        }
    }
}
