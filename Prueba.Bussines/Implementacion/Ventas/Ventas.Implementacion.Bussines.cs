using Prueba.Bussines.Interfaz.Ventas;
using Prueba.Data.Interfaz.Ventas;
using Prueba.Entities.Dtos.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Bussines.Implementacion.Ventas
{
    public class Ventas_Bussines: IVentas_Bussines
    {
        private readonly IVentas_Data _IVentas_Data;

        public Ventas_Bussines(IVentas_Data iVentas_Data)
        {
            _IVentas_Data = iVentas_Data;
        }

        public bool GuardarVenta(Ventas_Dto venta_Dto)
        {
            try
            {
                return _IVentas_Data.GuardarVenta(venta_Dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Ventas_Completas_Dto> GetVentasUnicasDiarias(DateTime dateInitial, DateTime dateFinish)
        {
            try
            {
                return _IVentas_Data.GetVentasUnicasDiarias(dateInitial,dateFinish);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Ventas_Dto> GetVentasAll()
        {
            try
            {
                return _IVentas_Data.GetVentasAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
