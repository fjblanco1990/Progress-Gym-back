using Prueba.Entities.Dtos.Clientes;
using Prueba.Entities.Dtos.Conceptos;
using Prueba.Entities.Dtos.Planes;
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
        public string Hora_Venta { get; set; }

    }

    public class Ventas_Completas_Dto
    {
        public Ventas_Dto venta { get; set; }
        public Usuarios_Dto usuario { get; set; }
        public Concepto_Dto concepto  { get; set; }
 
    }

    public class Ventas_Palnes_Completas_Dto
    {
        public Clientes_Dto cliente { get; set; }
        public VentasClientes_Dto ventasClientes { get; set; }
        public Planes_Dto plan { get; set; }
        public Usuarios_Dto usuario { get; set; }

    }
}
