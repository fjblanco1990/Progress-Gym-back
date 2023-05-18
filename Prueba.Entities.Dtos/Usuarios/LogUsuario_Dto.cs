using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entities.Dtos.Usuarios
{
    public class LogUsuario_Dto
    {
        public int Id_LogRegistro { get; set; }
        public int Id_Usuario { get; set; }
        public System.DateTime Fecha_registro { get; set; }
        public string Accion { get; set; }
        public string info_data { get; set; }
    }
}
