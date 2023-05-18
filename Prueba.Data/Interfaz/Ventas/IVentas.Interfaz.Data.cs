using Prueba.Entities.Dtos.Generales;
using Prueba.Entities.Dtos.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Data.Interfaz.Ventas
{
    public interface IVentas_Data
    {
        bool GuardarVenta(Ventas_Dto venta_Dto);
        List<Ventas_Completas_Dto> GetVentasUnicasDiarias(DateTime dateInitial, DateTime dateFinish);

        List<Ventas_Completas_Dto> GetAllVentasByUserDiarias(DateTime dateInitial, DateTime dateFinish, int idUsuario);
        List<Ventas_Clientes_Completo_Dto> GetAllVentasByUserPlanes(DateTime dateInitial, DateTime dateFinish, int idUsuario);

        List<Ventas_Palnes_Completas_Dto> GetVentasPlanesDiarios(DateTime dateInitial, DateTime dateFinish);

        List<Ventas_Completas_Dto> GetVentasIngresosUnicos(Dates dates);
        Ventas_usuarios_Cierre GetReportePorUsuario(DatesAndUser dates);

        List<Ventas_Dto> GetVentasAll();

        bool GuardarDeuda(Deuda_Dto deuda_Dto);

        bool EliminarDeuda(int idDeuda);

        List<Deuda_Completas_Dto> GetAllDeudas();

        List<Deuda_Completas_Dto> GetDuedByUser(int idCliente);
    }
}
