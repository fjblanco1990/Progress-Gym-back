using Prueba.Entities.Dtos.Fromas_Pago;
using Prueba.Entities.Dtos.Planes;
using Prueba.Entities.Dtos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entities.Dtos.Clientes
{
    public class Clientes_Dto
    {
        public int Id_Cliente { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public System.DateTime Fecha_nacimiento { get; set; }
        public string Documento_identitdad { get; set; }
        public string Celular { get; set; }
        public int Id_Plan { get; set; }
        public int Id_Forma_pago { get; set; }
        public bool Estado { get; set; }
        public System.DateTime Fecha_registro { get; set; }
        public int Id_Usuario { get; set; }
        public System.DateTime Fecha_inicio { get; set; }
        public System.DateTime Fecha_fin { get; set; }
        public bool Reingreso { get; set; }
        public System.DateTime Fecha_Actualizacion { get; set; }
        public string Hora_Registro { get; set; }
    }

    public class Clientes_completo_Dto
    {
        public Clientes_Dto cliente { get; set; }
        public Planes_Dto plan { get; set; }
        public Formas_pago_Dto forma_pago { get; set; }
        public Usuarios_Dto usuario { get; set; }

    }
}
