using Prueba.Bussines.Interfaz.Ingresos;
using Prueba.Data.Interfaz.Ingresos;
using Prueba.Entities.Dtos.Ingresos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Bussines.Implementacion.Ingresos
{
    public class Ingresos_bussines: IIngresos_Bussines
    {
        private readonly IIngresos_Data _iIngresos_Data;
        public Ingresos_bussines(IIngresos_Data iIngresos_Data)
        {
            _iIngresos_Data = iIngresos_Data;
        }


        public bool GuardarIngreso(Ingresos_Dto ingresos_Dto)
        {
            try
            {
                return _iIngresos_Data.GuardarIngreso(ingresos_Dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Ingresos_Completo_Dto> ConsultarTodosIngresos()
        {
            try
            {
                return _iIngresos_Data.ConsultarTodosIngresos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Ingresos_Completo_Dto> ConsultarIngresoId(int idIngreso)
        {
            try
            {
                return _iIngresos_Data.ConsultarIngresoId(idIngreso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Ingresos_log_Completo_Dto> ConsultarTodosIngresosLog()
        {
            try
            {
                return _iIngresos_Data.ConsultarTodosIngresosLog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Ingresos_log_Completo_Dto> ConsultarIngresoLogId(int idIngreso)
        {
            try
            {
                return _iIngresos_Data.ConsultarIngresoLogId(idIngreso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public bool EditarIngreso(Ingresos_Dto ingreso_dto)
        {
            try
            {
                return _iIngresos_Data.EditarIngreso(ingreso_dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EliminarIngreso(int idIngreso)
        {
            try
            {
                return _iIngresos_Data.EliminarIngreso(idIngreso);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        

    }
}
