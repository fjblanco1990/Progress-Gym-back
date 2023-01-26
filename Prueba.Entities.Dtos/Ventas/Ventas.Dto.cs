using Prueba.Entities.Dtos.Conceptos;
using Prueba.Entities.Dtos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entities.Dtos.Ventas
{
    public class Ventas_Dto
    {
        public int Id_Venta { get; set; }
        public int Id_Usuario { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public int Id_Concepto { get; set; }
        public int Valor_Venta { get; set; }

    }

    public class Ventas_Completas_Dto
    {
        public Ventas_Dto venta { get; set; }
        public Usuarios_Dto usuario { get; set; }
        public Conceptos_Dto concepto  { get; set; }
 
    }
}
