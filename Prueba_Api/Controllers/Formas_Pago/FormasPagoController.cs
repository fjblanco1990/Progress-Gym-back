using Prueba.Bussines.Interfaz.Formas_pago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba_Api.Controllers.Formas_Pago
{
    public class FormasPagoController : ApiController
    {
        private readonly IFormas_pago_Bussines _IFormas_pago_Bussines;
        public FormasPagoController(IFormas_pago_Bussines _IFormas_pago_Bussines)
        {
            this._IFormas_pago_Bussines = _IFormas_pago_Bussines;
        }

        public FormasPagoController()
        {

        }

        [HttpGet]
        [Route("GetFormasPago")]
        public HttpResponseMessage GetFromasPago()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _IFormas_pago_Bussines.GetFormasPago());
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
