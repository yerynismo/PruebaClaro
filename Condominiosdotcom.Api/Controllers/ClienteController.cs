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
    [Route("api/cliente")]
    [ApiController]
    public class clienteController : ControllerBase
    {
        public readonly IClienteData _clienteData;
        public clienteController(IClienteData clienteData)
        {
            _clienteData = clienteData;
        }

        // GET:
        [HttpGet, Route("getAll")]
        public IActionResult Get()
        {
            if (_clienteData.GetClient().Count() > 0)
            {
                return Ok(_clienteData.GetClient());
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
                return Ok(_clienteData.GetClient(codigo));
            }
            else
            {
                return BadRequest("Este empleado no existe");
            }

        }

        // POST
        [HttpPost, Route("addOne")]
        public IActionResult Post(Cliente cliente)
        {
            if (cliente != null)
            {
                return Ok(_clienteData.AddClient(cliente));
            }
            else
            {
                return BadRequest("Vacio");
            }
        }

        // PUT 
        [HttpPut, Route("UpdateOne")]
        public IActionResult Put(Cliente cliente)
        {
            if (cliente != null)
            {

                return Ok(_clienteData.ModifyClient(cliente));
            }
            else
            {
                return BadRequest("Vacio");
            }
        }


        [HttpDelete, Route("DeleteOne/{codigo}")]
        public IActionResult Delete(int codigo)
        {
            if (_clienteData.GetClient(codigo) != null)
            {
                _clienteData.DeleteClient(codigo);
                return Ok();
            }
            else
            {
                return BadRequest("Vacio");
            }

        }
    }
}
