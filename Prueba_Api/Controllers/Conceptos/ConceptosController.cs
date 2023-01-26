using Prueba.Bussines.Interfaz.Conceptos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba_Api.Controllers.Conceptos
{
    public class ConceptosController : ApiController
    {
        private readonly IConceptos_Bussines _IConceptos_Bussines;
        public ConceptosController(IConceptos_Bussines iConceptos_Bussines)
        {
            _IConceptos_Bussines = iConceptos_Bussines;
        }

        public ConceptosController()
        {

        }

        [HttpGet]
        [Route("getConceptos")]
        public HttpResponseMessage getConceptos()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, _IConceptos_Bussines.getConceptos());
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
