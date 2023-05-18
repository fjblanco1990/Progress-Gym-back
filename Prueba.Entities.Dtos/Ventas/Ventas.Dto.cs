using Prueba.Entities.Dtos.Clientes;
using Prueba.Entities.Dtos.Conceptos;
using Prueba.Entities.Dtos.Fromas_Pago;
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
        public int Id_Forma_pago { get; set; }

    }

    public class Ventas_Completas_Dto
    {
        public Ventas_Dto venta { get; set; }
        public Usuarios_Dto usuario { get; set; }
        public Concepto_Dto concepto { get; set; }
        public Formas_pago_Dto formas { get; set; }

    }

    public class Ventas_Palnes_Completas_Dto
    {
        public Clientes_Dto cliente { get; set; }
        public VentasClientes_Dto ventasClientes { get; set; }
        public Planes_Dto plan { get; set; }
        public Usuarios_Dto usuario { get; set; }

    }

    public class Ventas_usuarios_Cierre
    {
        public List<Ventas_Completas_Dto> venta_completa { get; set; }
        public List<Ventas_Clientes_Completo_Dto> ventas_planes_usuarios { get; set; }
    }
}
