using Prueba.Bussines.Interfaz.Ventas;
using Prueba.Data.Interfaz.Ventas;
using Prueba.Entities.Dtos.Generales;
using Prueba.Entities.Dtos.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Bussines.Implementacion.Ventas
{
    public class Ventas_Bussines : IVentas_Bussines
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
                return _IVentas_Data.GetVentasUnicasDiarias(dateInitial, dateFinish);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<Ventas_Completas_Dto> GetAllVentasByUserDiarias(DateTime dateInitial, DateTime dateFinish, int idUsuario)
        {
            try
            {
                return _IVentas_Data.GetAllVentasByUserDiarias(dateInitial, dateFinish, idUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Ventas_Clientes_Completo_Dto> GetAllVentasByUserPlanes(DateTime dateInitial, DateTime dateFinish, int idUsuario)
        {
            try
            {
                return _IVentas_Data.GetAllVentasByUserPlanes(dateInitial, dateFinish, idUsuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Ventas_Palnes_Completas_Dto> GetVentasPlanesDiarios(DateTime dateInitial, DateTime dateFinish)
        {
            try
            {
                return _IVentas_Data.GetVentasPlanesDiarios(dateInitial, dateFinish);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        public List<Ventas_Completas_Dto> GetVentasIngresosUnicos(Dates dates)
        {
            try
            {
                return _IVentas_Data.GetVentasIngresosUnicos(dates);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public Ventas_usuarios_Cierre GetReportePorUsuario(DatesAndUser dates)
        {
            try
            {
                return _IVentas_Data.GetReportePorUsuario(dates);
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

        public bool GuardarDeuda(Deuda_Dto deuda_Dto)
        {
            try
            {
                return _IVentas_Data.GuardarDeuda(deuda_Dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EliminarDeuda(int idDeuda)
        {
            try
            {
                return _IVentas_Data.EliminarDeuda(idDeuda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Deuda_Completas_Dto> GetAllDeudas()
        {
            try
            {
                return _IVentas_Data.GetAllDeudas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<Deuda_Completas_Dto> GetDuedByUser(int idCliente)
        {
            try
            {
                return _IVentas_Data.GetDuedByUser(idCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
