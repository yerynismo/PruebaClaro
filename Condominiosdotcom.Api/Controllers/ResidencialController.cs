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

        public readonly IResidencialData _ResidencialData;
        public ResidencialController(IResidencialData residencialData)
        {
            _ResidencialData = residencialData;
        }

        // GET: 
        [HttpGet, Route("getAll")]
        public IActionResult Get()
        {
            if (_ResidencialData.GetResidencial().Count() > 0)
            {
                return Ok(_ResidencialData.GetResidencial());
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
                return Ok(_ResidencialData.GetResidencial(codigo));
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
                return Ok(_ResidencialData.AddResidencial(residencial));
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

                return Ok(_ResidencialData.ModifyResidencial(residencial));
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
            if (_ResidencialData.GetResidencial(codigo) != null)
            {
                _ResidencialData.DeleteResidencial(codigo);
                return Ok();
            }
            else
            {
                return BadRequest("Vacio");
            }

        }
    }
}
