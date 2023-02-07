using Prueba.Bussines.Interfaz.Usuarios;
using Prueba.Data.Interfaz.Usuarios;
using Prueba.Entities.Dtos.Usuarios;
using System;
using System.Collections.Generic;


namespace Prueba.Bussines.Implementacion.Usuarios
{
    public class Usuarios_Bussines: IUsuarios_Bussines
    {
        private readonly IUsuarios_Data _IUsuarios_Data;
        public Usuarios_Bussines(IUsuarios_Data iUsuarios_Data)
        {
            _IUsuarios_Data = iUsuarios_Data;
        }

        public List<Usuarios_Dto> GetUsuarios()
        {
            try
            {
                return this._IUsuarios_Data.GetUsuarios();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool GuardarUsuarios(Usuarios_Dto userDto)
        {
            try
            {
                return this._IUsuarios_Data.GuardarUsuarios(userDto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EditarUsuario(Usuarios_Dto user)
        {
            try
            {
                return this._IUsuarios_Data.EditarUsuario(user);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EliminarUsuario(int idUsuario)
        {
            try
            {
                return this._IUsuarios_Data.EliminarUsuario(idUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
