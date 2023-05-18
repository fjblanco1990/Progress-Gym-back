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

        [HttpPost]
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
        [Route("GetAllVentasByUserDiarias")]
        public HttpResponseMessage GetAllVentasByUserDiarias(DatesAndUser data)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _IVentas_Bussines.GetAllVentasByUserDiarias(data.Fecha_Inicial, data.Fecha_Final, data.idUsuario));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPost]
        [Route("GetAllVentasByUserPlanes")]
        public HttpResponseMessage GetAllVentasByUserDPlanes(DatesAndUser data)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _IVentas_Bussines.GetAllVentasByUserPlanes(data.Fecha_Inicial, data.Fecha_Final, data.idUsuario));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        [HttpPost]
        [Route("GetVentasPlanesDiarios")]
        public HttpResponseMessage GetVentasPlanesDiarios(Dates dates)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _IVentas_Bussines.GetVentasPlanesDiarios(dates.Fecha_Inicial, dates.Fecha_Final));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("GetReportePorUsuario")]
        public HttpResponseMessage GetReportePorUsuario(DatesAndUser dates)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _IVentas_Bussines.GetReportePorUsuario(dates));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        [HttpPost]
        [Route("GuardarVenta")]
        public HttpResponseMessage GuardarVenta(Ventas_Dto ventaDto)
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

        [HttpPost]
        [Route("GetVentasIngresosUnicos")]
        public HttpResponseMessage GetVentasIngresosUnicos(Dates dates)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _IVentas_Bussines.GetVentasIngresosUnicos(dates));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

 
        [HttpPost]
        [Route("GuardarDeuda")]
        public HttpResponseMessage GuardarDeuda(Deuda_Dto deudaDto)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _IVentas_Bussines.GuardarDeuda(deudaDto));
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("EliminarDeuda")]
        public HttpResponseMessage EliminarDeuda(int idDeuda)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, this._IVentas_Bussines.EliminarDeuda(idDeuda));

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpGet]
        [Route("GetAllDeudas")]
        public HttpResponseMessage GetAllDeudas()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, this._IVentas_Bussines.GetAllDeudas());

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        [HttpGet]
        [Route("GetDuedByUser")]
        public HttpResponseMessage GetDuedByUser(int idCliente)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, this._IVentas_Bussines.GetDuedByUser(idCliente));

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


    }
}
