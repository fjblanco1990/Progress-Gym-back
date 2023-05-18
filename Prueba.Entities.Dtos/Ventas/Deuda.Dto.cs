using Prueba.Entities.Dtos.Clientes;
using Prueba.Entities.Dtos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entities.Dtos.Ventas
{
    public class Deuda_Dto
    {
        public int Id_Deuda { get; set; }
        public int Id_Usuario { get; set; }
        public int Id_Cliente { get; set; }
        public DateTime Fecha_deuda { get; set; }
        public string Hora_deuda { get; set; }
        public string descripcion { get; set; }
        public int Valor_deuda { get; set; }
    }

    public class Deuda_Completas_Dto
    {
        public Deuda_Dto deuda { get; set; }
        public Usuarios_Dto usuario { get; set; }
        public Clientes_Dto cliente { get; set; }

    }
}
