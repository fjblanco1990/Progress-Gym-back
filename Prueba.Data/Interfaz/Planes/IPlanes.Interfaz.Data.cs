using Prueba.Entities.Dtos.Generales;
using Prueba.Entities.Dtos.Ingresos;
using Prueba.Entities.Dtos.Planes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Data.Interfaz.Planes
{
    public interface IPlanes_Data
    {
        List<Planes_Dto> GetPlanes();

        List<Informes_Dto> GetVentasDiarias(DateTime dateInitial, DateTime dateFinish);

        List<Ingresos_Completo_Dto> GetIngresosDiarios(DateTime dateInitial, DateTime dateFinish);

        Informes_General_Dto GetInformeDiarioGeneral(DateTime dateInitial, DateTime dateFinish);
    }
}
