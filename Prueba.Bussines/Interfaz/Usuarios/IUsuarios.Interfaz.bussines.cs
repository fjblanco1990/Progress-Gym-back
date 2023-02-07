using Prueba.Entities.Dtos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Bussines.Interfaz.Usuarios
{
    public interface IUsuarios_Bussines
    {
        List<Usuarios_Dto> GetUsuarios();

        bool GuardarUsuarios(Usuarios_Dto userDto);

        bool EditarUsuario(Usuarios_Dto user);

        bool EliminarUsuario(int idUsuario);
    }
}
