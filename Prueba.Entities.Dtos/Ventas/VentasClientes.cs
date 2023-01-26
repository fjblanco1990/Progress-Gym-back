using Prueba.Entities.Dtos.Clientes;
using Prueba.Entities.Dtos.Planes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Entities.Dtos.Ventas
{
    public class VentasClientes_Dto
    {
        public int Id_Ventas_Cliente { get; set; }
        public int Id_Plan { get; set; }
        public int Valor_Venta { get; set; }
        public DateTime Fecha { get; set; }         
    }

    public class VentasClientesCompleto
    {
        public VentasClientes_Dto Ventas_Cliente { get; set; }
        public Clientes_Dto Cliente { get; set; }
        public Planes_Dto Id_Plan { get; set; }
    }
}