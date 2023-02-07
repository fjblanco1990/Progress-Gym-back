using Prueba.Entities.Dtos.Clientes;
using Prueba.Entities.Dtos.Planes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entities.Dtos.Generales
{
    public class Informes_General_Dto
    {
        public int Cantidad_Ingresos { get; set; }
        public int Total_Ventas { get; set; }
        public int Tiquetera { get; set; }
        public int Mensual { get; set; }
        public int Bimestral { get; set; }
        public int Trimestral { get; set; }
        public int Semestral { get; set; }
        public int Anual { get; set; }
    }

    public class Informes_Dto
    {
        public Planes_Dto   planes { get; set; }
    }

    public class Dates
    {
        public DateTime Fecha_Inicial { get; set; }
        public DateTime Fecha_Final { get; set; }
    }

    //public class Planes_Dto
    //{
    //Id_Plan int not null primary key identity(1,1),
    //Descripcion nvarchar(max),
    //Valor_Plan int not null,
    //Cantidad_Dias int not null
    //    public int Id_Plan { get; set; }
    //    public string Descripcion { get; set; }
    //    public int Valor_Plan { get; set; }
    //    public int Cantidad_Dias { get; set; }
    //}

    //public class Ingresos_log_Dto
    //{
    //    public int Id_Ingreso { get; set; }
    //    public int Id_Cliente { get; set; }
    //    public DateTime Fecha_Ingreso { get; set; }
    //    public string Hora_Ingreso { get; set; }
    //}

}
