using AutoMapper;
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

namespace Prueba.Data.Implementacion.Planes
{
    public class Planes_Data : IPlanes_Data
    {
        private Pogress_gymEntities _Pogress_gymEntities = new Pogress_gymEntities();

        public List<Planes_Dto> GetPlanes()
        {
            var resultPlanes = _Pogress_gymEntities.tbl_Plan.ToList();
            return Mapper.Map<List<Planes_Dto>>(resultPlanes);
        }

        public List<Informes_Dto> GetVentasDiarias(DateTime dateInitial, DateTime dateFinish)
        {
            var result = (from c in _Pogress_gymEntities.tbl_pro_Clientes
                          join p in _Pogress_gymEntities.tbl_Plan on c.Id_Plan  equals p.Id_Plan
                          join v in _Pogress_gymEntities.tbl_ventas_clientes on p.Id_Plan equals v.Id_Plan
                          where v.Fecha >= dateInitial && v.Fecha <= dateFinish
                          select new
                          {
                              cliente = c,
                              planes = p,
                          }).ToList();

            return Mapper.Map<List<Informes_Dto>>(result);
        }
        public List<Ingresos_Completo_Dto> GetIngresosDiarios(DateTime dateInitial, DateTime dateFinish)
        {
            var result = (from i in _Pogress_gymEntities.tbl_IngresosXCliente
                          join c in _Pogress_gymEntities.tbl_pro_Clientes on i.Id_Cliente equals c.Id_Cliente
                                       
                          where i.Fecha_Ingreso >= dateInitial && i.Fecha_Ingreso <= dateFinish
                          select new
                          {
                              cliente = c,
                              ingreso = i,
                          }).ToList();

            return Mapper.Map<List<Ingresos_Completo_Dto>>(result);
        }


        public Informes_General_Dto GetInformeDiarioGeneral(DateTime dateInitial, DateTime dateFinish)
        {
            Informes_General_Dto informeGeneral = new Informes_General_Dto();

            informeGeneral.Cantidad_Ingresos = _Pogress_gymEntities.tbl_IngresosXCliente.Where(c => c.Fecha_Ingreso >= dateInitial && c.Fecha_Ingreso <= dateFinish).Count();

            informeGeneral.Total_Ventas = (from c in _Pogress_gymEntities.tbl_pro_Clientes
                                           join p in _Pogress_gymEntities.tbl_Plan on c.Id_Plan equals p.Id_Plan
                                           join v in _Pogress_gymEntities.tbl_ventas_clientes on p.Id_Plan equals v.Id_Plan
                                           where v.Fecha >= dateInitial && v.Fecha <= dateFinish
                                           select new { p.Valor_Plan }).ToList().Select(vp => vp.Valor_Plan).Sum();

            informeGeneral.Cantidad_Ingresos = _Pogress_gymEntities.tbl_IngresosXCliente.Where(c => c.Fecha_Ingreso >= dateInitial && c.Fecha_Ingreso <= dateFinish).Count();
           
            informeGeneral.Mensual = GetPlanes(dateInitial, dateFinish, informeGeneral, 1);
            informeGeneral.Tiquetera = GetPlanes(dateInitial, dateFinish, informeGeneral, 2);
            informeGeneral.Bimestral = GetPlanes(dateInitial, dateFinish, informeGeneral, 3);
            informeGeneral.Trimestral = GetPlanes(dateInitial, dateFinish, informeGeneral, 4);
            informeGeneral.Semestral = GetPlanes(dateInitial, dateFinish, informeGeneral, 5);
            informeGeneral.Anual = GetPlanes(dateInitial, dateFinish, informeGeneral, 6);
           
  
            return Mapper.Map<Informes_General_Dto>(informeGeneral);
        }

        private int GetPlanes(DateTime dateInitial, DateTime dateFinish, Informes_General_Dto informeGeneral, int idPlan)
        {
            return (from c in _Pogress_gymEntities.tbl_pro_Clientes
                    join p in _Pogress_gymEntities.tbl_Plan on c.Id_Plan equals p.Id_Plan
                    where (c.Fecha_Actualizacion >= dateInitial && c.Fecha_Actualizacion <= dateFinish) && (p.Id_Plan == idPlan)
                    select new { p }).ToList().Count();
        }


    }
}
