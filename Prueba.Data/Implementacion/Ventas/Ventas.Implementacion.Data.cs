using AutoMapper;
using Prueba.Data.Interfaz.Ventas;
using Prueba.Entities;
using Prueba.Entities.Dtos.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Data.Implementacion.Ventas
{
    public class Ventas_Data: IVentas_Data
    {
        private Pogress_gymEntities _Progress_gymEntities = new Pogress_gymEntities();

        public bool GuardarVenta(Ventas_Dto venta_Dto)
        {
            //se debe mapear para guardar la hora de ingreso
            var mapperData = Mapper.Map<tbl_Ventas>(venta_Dto);
            _Progress_gymEntities.tbl_Ventas.Add(mapperData);
            _Progress_gymEntities.SaveChanges();
            return true;
        }


        public List<Ventas_Completas_Dto> GetVentasUnicasDiarias(DateTime dateInitial, DateTime dateFinish)
        {
            var result = (from v in _Progress_gymEntities.tbl_Ventas
                          join u in _Progress_gymEntities.tbl_pro_Usuarios on v.Id_Usuario equals u.Id_Usuario
                          join c in _Progress_gymEntities.tbl_Conceptos on v.Id_Concepto equals c.Id_Concepto
                          where v.Fecha_Ingreso >= dateInitial && v.Fecha_Ingreso <= dateFinish
                          select new
                          {
                              venta = v,
                              usuario = u,
                              concepto = c
                          }).ToList();

            return Mapper.Map<List<Ventas_Completas_Dto>>(result);
        }

        public List<Ventas_Dto> GetVentasAll()
        {
            var response = _Progress_gymEntities.tbl_Ventas.ToList();
            return Mapper.Map<List<Ventas_Dto>>(response);
        }
    }
}
