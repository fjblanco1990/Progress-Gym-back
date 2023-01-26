using Prueba.Bussines.Interfaz.Clientes;
using Prueba.Entities.Dtos.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba_Api.Controllers.Clientes
{
    public class ClientesController : ApiController
    {
        private readonly IClientes_Bussines _IClientes_Bussines;
        public ClientesController(IClientes_Bussines _IClientes_Bussines)
        {
            this._IClientes_Bussines = _IClientes_Bussines;
        }

        public ClientesController()
        {

        }

        [HttpGet]
        [Route("ConsultarClienteCedula")]
        public HttpResponseMessage ConsultarClienteCedula(string documento)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _IClientes_Bussines.ConsultarClienteCedula(documento));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("ConsultarTodosClientes")]
        public HttpResponseMessage ConsultarTodosClientes()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _IClientes_Bussines.ConsultarTodosClientes());
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("GuardarClientes")]
        public HttpResponseMessage GuardarClientes(Clientes_Dto clientesDto)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _IClientes_Bussines.GuardarClientes(clientesDto));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("ValidarDocumentoCliente")]
        public HttpResponseMessage ValidarDocumentoCliente(string documento)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _IClientes_Bussines.ValidarDocumentoCliente(documento));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPost]
        [Route("EditarClientes")]
        public HttpResponseMessage EditarClientes(Clientes_Dto clientesDto)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _IClientes_Bussines.EditarClientes(clientesDto));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("EliminarCliente/{idCliente}")]
        public HttpResponseMessage EliminarCliente(int idCliente)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _IClientes_Bussines.EliminarCliente(idCliente));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }




    }
}
