using AutoMapper;
using Prueba.Bussines.Interfaz.Planes;
using Prueba.Data.Interfaz.Planes;
using Prueba.Entities;
using Prueba.Entities.Dtos.Generales;
using Prueba.Entities.Dtos.Ingresos;
using Prueba.Entities.Dtos.Planes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Bussines.Implementacion.Planes
{
    public class Planes_Bussines: IPlanes_Bussines
    {
        private readonly IPlanes_Data _IPlanes_Data;

        public Planes_Bussines(IPlanes_Data _IPlanes_Data)
        {
            this._IPlanes_Data = _IPlanes_Data;
        }

        public List<Planes_Dto> GetPlanes()
        {
            try
            {
                return this._IPlanes_Data.GetPlanes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Informes_Dto> GetVentasDiarias(DateTime dateInitial, DateTime dateFinish)
        {
            try
            {
                return this._IPlanes_Data.GetVentasDiarias(dateInitial, dateFinish);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public List<Ingresos_Completo_Dto> GetIngresosDiarios(DateTime dateInitial, DateTime dateFinish)
        {
            try
            {
                return this._IPlanes_Data.GetIngresosDiarios(dateInitial, dateFinish);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Informes_General_Dto GetInformeDiarioGeneral(DateTime dateInitial, DateTime dateFinish)
        {
            try
            {
                return this._IPlanes_Data.GetInformeDiarioGeneral(dateInitial, dateFinish);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
