using Prueba.Entities.Dtos.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entities.Dtos.Ingresos
{

    public class Ingresos_log_Dto
    {
        public int Id_Ingreso { get; set; }
        public int Id_Cliente { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public string Hora_Ingreso { get; set; }
    }

    public class Ingresos_log_Completo_Dto
    {

        public Clientes_Dto cliente { get; set; }
        public Ingresos_log_Dto ingreso { get; set; }
    }
}
