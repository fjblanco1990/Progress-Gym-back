using AutoMapper;
using Prueba.Data.Interfaz.Usuarios;
using Prueba.Entities;
using Prueba.Entities.Dtos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Data.Implementacion.Usuarios
{
    public class Usuarios_Data: IUsuarios_Data
    {
        private Pogress_gymEntities _Progress_gymEntities = new Pogress_gymEntities();

        public List<Usuarios_Dto> GetUsuarios()
        {
            return Mapper.Map<List<Usuarios_Dto>>(_Progress_gymEntities.tbl_pro_Usuarios.ToList());
        }

        public bool GuardarUsuarios(Usuarios_Dto userDto)
        {
            var user = Mapper.Map<tbl_pro_Usuarios>(userDto);
            _Progress_gymEntities.tbl_pro_Usuarios.Add(user);
            _Progress_gymEntities.SaveChanges();
            return true;
        }

        public bool EditarUsuario(Usuarios_Dto userDto)
        {

            var resultUsers = _Progress_gymEntities.tbl_pro_Usuarios.Where(c => c.Id_Usuario == userDto.Id_Usuario).FirstOrDefault();

            resultUsers.Nombre_completo = userDto.Nombre_completo;
            resultUsers.Password = userDto.Password;
            resultUsers.Nick_Name = userDto.Nick_Name;
            resultUsers.Estado = userDto.Estado;

            _Progress_gymEntities.SaveChanges();
            return true;
        }


        public bool EliminarUsuario(int idUsuario)
        {
            var resultUser = _Progress_gymEntities.tbl_pro_Usuarios.Where(c => c.Id_Usuario == idUsuario).FirstOrDefault();
            _Progress_gymEntities.tbl_pro_Usuarios.Remove(resultUser);
            _Progress_gymEntities.SaveChanges();
            return true;
        }

    }
}
