using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Entities.Dtos.Planes
{
    public class Planes_Dto
    {
        //Id_Plan int not null primary key identity(1,1),
	    //Descripcion nvarchar(max),
	    //Valor_Plan int not null,
        //Cantidad_Dias int not null
        public int Id_Plan { get; set; }
        public string Descripcion { get; set; }
        public int Valor_Plan { get; set; }
        public int Cantidad_Dias { get; set; }
    }
}
