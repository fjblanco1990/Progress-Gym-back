using Prueba.Bussines.Interfaz.Usuarios;
using Prueba.Entities.Dtos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Prueba_Api.Controllers.Usuarios
{
    public class UsuariosController : ApiController
    {
        private readonly IUsuarios_Bussines _IUsuarios_Bussines;

        public UsuariosController(IUsuarios_Bussines IUsuarios_Bussines)
        {
            _IUsuarios_Bussines = IUsuarios_Bussines;
        }
        public UsuariosController()
        {

        }


        [HttpGet]
        [Route("GetUsuarios")]
        public HttpResponseMessage GetPlanes()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, this._IUsuarios_Bussines.GetUsuarios());

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("GuardarUsuarios")]
        public HttpResponseMessage GuardarUsuarios(Usuarios_Dto user)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, this._IUsuarios_Bussines.GuardarUsuarios(user));

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        [HttpPost]
        [Route("EditarUsuario")]
        public HttpResponseMessage EditarUsuario(Usuarios_Dto user)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, this._IUsuarios_Bussines.EditarUsuario(user));

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }


        [HttpGet]
        [Route("EliminarUsuario")]
        public HttpResponseMessage EliminarUsuario(int idUsuario)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, this._IUsuarios_Bussines.EliminarUsuario(idUsuario));

            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        [Route("GuardarLogUsuario")]
        public HttpResponseMessage GuardarLogUsuario(LogUsuario_Dto logUsuario)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, this._IUsuarios_Bussines.GuardarLogUsuario(logUsuario));
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex);
            }
        }



    }
}
