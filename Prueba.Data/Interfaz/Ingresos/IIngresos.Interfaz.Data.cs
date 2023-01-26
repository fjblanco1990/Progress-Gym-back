using Prueba.Entities.Dtos.Ingresos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Data.Interfaz.Ingresos
{
    public interface IIngresos_Data
    {
        bool GuardarIngreso(Ingresos_Dto ingresos_Dto);

        List<Ingresos_Completo_Dto> ConsultarTodosIngresos();

        List<Ingresos_log_Completo_Dto> ConsultarTodosIngresosLog();

        List<Ingresos_Completo_Dto> ConsultarIngresoId(int idIngreso);

        List<Ingresos_log_Completo_Dto> ConsultarIngresoLogId(int idIngreso);

        bool EditarIngreso(Ingresos_Dto ingreso_dto);

        bool EliminarIngreso(int idIngreso);
    }
}
