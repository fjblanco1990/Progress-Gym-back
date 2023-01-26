using Prueba.Bussines.Interfaz.Planes;
using Prueba.Entities.Dtos.Generales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba_Api.Controllers.Planes
{
    public class PlanesController : ApiController
    {
        private readonly IPlanes_Bussines _IPlanes_Bussines;
        public PlanesController(IPlanes_Bussines _IPlanes_Bussines)
        {
            this._IPlanes_Bussines = _IPlanes_Bussines;
        }

        public PlanesController()
        {
            
        }

        [HttpGet]
        [Route("GetPlanes")]
        public HttpResponseMessage GetPlanes()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, this._IPlanes_Bussines.GetPlanes());

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("GetIngresosDiarios")]
        public HttpResponseMessage GetIngresosDiarios(Dates dates)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, this._IPlanes_Bussines.GetIngresosDiarios(dates.Fecha_Inicial, dates.Fecha_Final));

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("GetVentasDiarias")]
        public HttpResponseMessage GetVentasDiarias(Dates dates)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, this._IPlanes_Bussines.GetVentasDiarias(dates.Fecha_Inicial, dates.Fecha_Final));

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("GetInformeDiarioGeneral")]
        public HttpResponseMessage GetInformeDiarioGeneral(Dates dates)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, this._IPlanes_Bussines.GetInformeDiarioGeneral(dates.Fecha_Inicial, dates.Fecha_Final));

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

    }
}
