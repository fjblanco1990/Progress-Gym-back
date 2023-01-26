using Prueba.Bussines.Interfaz.Ventas;
using Prueba.Entities.Dtos.Generales;
using Prueba.Entities.Dtos.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba_Api.Controllers.Ventas
{
    public class VentasController : ApiController
    {
        private readonly IVentas_Bussines _IVentas_Bussines;
        public VentasController(IVentas_Bussines iVentas_Bussines)
        {
            _IVentas_Bussines = iVentas_Bussines;
        }

        public VentasController()
        {

        }

        [HttpGet]
        [Route("GetVentasAll")]
        public HttpResponseMessage GetVentasAll()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _IVentas_Bussines.GetVentasAll());
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("GetVentasUnicasDiarias")]
        public HttpResponseMessage GetVentasUnicasDiarias(Dates dates)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _IVentas_Bussines.GetVentasUnicasDiarias(dates.Fecha_Inicial, dates.Fecha_Final));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        [HttpPost]
        [Route("GuardarVenta")]
        public HttpResponseMessage GuardarIngreso(Ventas_Dto ventaDto)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _IVentas_Bussines.GuardarVenta(ventaDto));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}
