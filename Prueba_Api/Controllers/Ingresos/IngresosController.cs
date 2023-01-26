using Prueba.Bussines.Interfaz.Ingresos;
using Prueba.Entities.Dtos.Ingresos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba_Api.Controllers.Ingresos
{
    public class IngresosController : ApiController
    {
        private readonly IIngresos_Bussines _iIngresos_Bussines;
        public IngresosController()
        {

        }

        public IngresosController(IIngresos_Bussines iIngresos_Bussines)
        {
            _iIngresos_Bussines = iIngresos_Bussines;
        }

        [HttpGet]
        [Route("ConsultarIngresoId")]
        public HttpResponseMessage ConsultarIngresoId(int idIngreso)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _iIngresos_Bussines.ConsultarIngresoId(idIngreso));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("ConsultarTodosIngresos")]
        public HttpResponseMessage ConsultarTodosIngresos()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _iIngresos_Bussines.ConsultarTodosIngresos());
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("ConsultarIngresoLogId")]
        public HttpResponseMessage ConsultarIngresoLogId(int idIngreso)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _iIngresos_Bussines.ConsultarIngresoLogId(idIngreso));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("ConsultarTodosIngresosLog")]
        public HttpResponseMessage ConsultarTodosIngresosLog()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _iIngresos_Bussines.ConsultarTodosIngresosLog());
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        [HttpPost]
        [Route("GuardarIngreso")]
        public HttpResponseMessage GuardarIngreso(Ingresos_Dto ingresoDto)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _iIngresos_Bussines.GuardarIngreso(ingresoDto));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("EditarIngreso")]
        public HttpResponseMessage EditarIngreso(Ingresos_Dto ingresoDto)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _iIngresos_Bussines.EditarIngreso(ingresoDto));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("EliminarIngreso/{idIngreso}")]
        public HttpResponseMessage EliminarIngreso(int idIngreso)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _iIngresos_Bussines.EliminarIngreso(idIngreso));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }




    }
}
