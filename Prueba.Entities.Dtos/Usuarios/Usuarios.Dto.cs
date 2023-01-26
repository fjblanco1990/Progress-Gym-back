using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entities.Dtos.Usuarios
{
    public class Usuarios_Dto
    {
       public int Id_Usuario { get; set; }
       public string Nombre_completo { get; set; }
       public DateTime Fecha_creacion { get; set; }
       public bool Estado { get; set; }
       public string Nick_Name { get; set; }
       public string Password { get; set; }
    }
}
