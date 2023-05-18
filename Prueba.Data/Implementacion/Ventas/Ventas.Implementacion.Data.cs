using AutoMapper;
using Prueba.Data.Interfaz.Ventas;
using Prueba.Entities;
using Prueba.Entities.Dtos.Generales;
using Prueba.Entities.Dtos.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Data.Implementacion.Ventas
{
    public class Ventas_Data : IVentas_Data
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
                          join f in _Progress_gymEntities.tbl_Forma_Pago on v.Id_Forma_pago equals f.Id_Forma_Pago
                          where v.Fecha_Ingreso >= dateInitial && v.Fecha_Ingreso <= dateFinish
                          select new
                          {
                              venta = v,
                              usuario = u,
                              concepto = c,
                              formas = f
                          }).ToList();

            return Mapper.Map<List<Ventas_Completas_Dto>>(result);
        }

        public List<Ventas_Completas_Dto> GetAllVentasByUserDiarias(DateTime dateInitial, DateTime dateFinish, int idUsuario)
        {
            var resultVentasDiarias = (from v in _Progress_gymEntities.tbl_Ventas
                                       join u in _Progress_gymEntities.tbl_pro_Usuarios on v.Id_Usuario equals u.Id_Usuario
                                       join c in _Progress_gymEntities.tbl_Conceptos on v.Id_Concepto equals c.Id_Concepto
                                       join f in _Progress_gymEntities.tbl_Forma_Pago on v.Id_Forma_pago equals f.Id_Forma_Pago
                                       where (v.Fecha_Ingreso >= dateInitial && v.Fecha_Ingreso <= dateFinish) && (v.Id_Usuario == idUsuario)
                                       select new
                                       {
                                           venta = v,
                                           usuario = u,
                                           concepto = c,
                                           formas = f
                                       }).ToList();
            return Mapper.Map<List<Ventas_Completas_Dto>>(resultVentasDiarias);
        }
        public List<Ventas_Clientes_Completo_Dto> GetAllVentasByUserPlanes(DateTime dateInitial, DateTime dateFinish,int idUsuario)
        {
            var resultVentasPlanes = (from v in _Progress_gymEntities.tbl_ventas_clientes
                                      join c in _Progress_gymEntities.tbl_pro_Clientes on v.Id_Cliente equals c.Id_Cliente
                                      join u in _Progress_gymEntities.tbl_pro_Usuarios on c.Id_Usuario equals u.Id_Usuario
                                      join p in _Progress_gymEntities.tbl_Plan on v.Id_Plan equals p.Id_Plan
                                      where (v.Fecha >= dateInitial && v.Fecha <= dateFinish) && u.Id_Usuario == idUsuario
                                      select new 
                                      {
                                          Ventas_Cliente = v,
                                          Cliente = c,
                                          Plan = p,
                                          Usuario = u
                                      }).ToList();



        
            return Mapper.Map<List<Ventas_Clientes_Completo_Dto>>(resultVentasPlanes);
        }
        public List<Ventas_Palnes_Completas_Dto> GetVentasPlanesDiarios(DateTime dateInitial, DateTime dateFinish)
        {
            var result = (from v in _Progress_gymEntities.tbl_ventas_clientes
                          join c in _Progress_gymEntities.tbl_pro_Clientes on v.Id_Cliente equals c.Id_Cliente
                          join u in _Progress_gymEntities.tbl_pro_Usuarios on c.Id_Usuario equals u.Id_Usuario
                          join p in _Progress_gymEntities.tbl_Plan on c.Id_Plan equals p.Id_Plan
                          where v.Fecha >= dateInitial && v.Fecha <= dateFinish
                          select new
                          {
                              cliente = c,
                              ventasClientes = v,
                              plan = p,
                              usuario = u

                          }).ToList();

            return Mapper.Map<List<Ventas_Palnes_Completas_Dto>>(result);
        }

        public List<Ventas_Completas_Dto> GetVentasIngresosUnicos(Dates dates)
        {
            var ingresosUnicos = (from v in _Progress_gymEntities.tbl_Ventas
                                  join u in _Progress_gymEntities.tbl_pro_Usuarios on v.Id_Usuario equals u.Id_Usuario
                                  join c in _Progress_gymEntities.tbl_Conceptos on v.Id_Concepto equals c.Id_Concepto
                                  join f in _Progress_gymEntities.tbl_Forma_Pago on v.Id_Forma_pago equals f.Id_Forma_Pago
                                  where v.Fecha_Ingreso >= dates.Fecha_Inicial && v.Fecha_Ingreso <= dates.Fecha_Final && v.Id_Concepto == 6
                                  select new
                                  {
                                      venta = v,
                                      usuario = u,
                                      concepto = c,
                                      formas = f
                                  }).ToList();

            return Mapper.Map<List<Ventas_Completas_Dto>>(ingresosUnicos);
        }

        public Ventas_usuarios_Cierre GetReportePorUsuario(DatesAndUser dates)
        {
            var ventasUsuario = (from v in _Progress_gymEntities.tbl_Ventas
                                  join u in _Progress_gymEntities.tbl_pro_Usuarios on v.Id_Usuario equals u.Id_Usuario
                                  join c in _Progress_gymEntities.tbl_Conceptos on v.Id_Concepto equals c.Id_Concepto
                                  join f in _Progress_gymEntities.tbl_Forma_Pago on v.Id_Forma_pago equals f.Id_Forma_Pago
                                  where v.Fecha_Ingreso >= dates.Fecha_Inicial && v.Fecha_Ingreso <= dates.Fecha_Final && v.Id_Usuario == dates.idUsuario
                                  select new
                                  {
                                      venta = v,
                                      usuario = u,
                                      concepto = c,
                                      formas = f
                                  }).ToList();

            List<Ventas_Completas_Dto> lstVentaUsuario = Mapper.Map<List<Ventas_Completas_Dto>>(ventasUsuario);


            var resultVentasPlanes = (from v in _Progress_gymEntities.tbl_ventas_clientes
                                      join c in _Progress_gymEntities.tbl_pro_Clientes on v.Id_Cliente equals c.Id_Cliente
                                      join u in _Progress_gymEntities.tbl_pro_Usuarios on c.Id_Usuario equals u.Id_Usuario
                                      join p in _Progress_gymEntities.tbl_Plan on v.Id_Plan equals p.Id_Plan
                                      where (v.Fecha >= dates.Fecha_Inicial && v.Fecha <= dates.Fecha_Final) && u.Id_Usuario == dates.idUsuario
                                      select new
                                      {
                                          Ventas_Cliente = v,
                                          Cliente = c,
                                          Plan = p,
                                          Usuario = u
                                      }).ToList();

            List<Ventas_Clientes_Completo_Dto> lstVentaUsuarioPlanes = Mapper.Map<List<Ventas_Clientes_Completo_Dto>>(resultVentasPlanes);

            Ventas_usuarios_Cierre objData = new Ventas_usuarios_Cierre();

            objData.venta_completa = lstVentaUsuario;
            objData.ventas_planes_usuarios = lstVentaUsuarioPlanes;


            return Mapper.Map<Ventas_usuarios_Cierre>(objData);
        }

        public List<Ventas_Dto> GetVentasAll()
        {
            var response = _Progress_gymEntities.tbl_Ventas.ToList();
            return Mapper.Map<List<Ventas_Dto>>(response);
        }

        public bool GuardarDeuda(Deuda_Dto deuda_Dto)
        {
            var mapperData = Mapper.Map<tbl_DeudasXCliente>(deuda_Dto);
            _Progress_gymEntities.tbl_DeudasXCliente.Add(mapperData);
            _Progress_gymEntities.SaveChanges();
            return true;
        }

        public bool EliminarDeuda(int idDeuda)
        {
            var result = _Progress_gymEntities.tbl_DeudasXCliente.Where(c => c.Id_Deuda == idDeuda).FirstOrDefault();
            _Progress_gymEntities.tbl_DeudasXCliente.Remove(result);
            _Progress_gymEntities.SaveChanges();
            return true;
        }

        public List<Deuda_Completas_Dto> GetAllDeudas()
        {
            var result = (from d in _Progress_gymEntities.tbl_DeudasXCliente
                          join u in _Progress_gymEntities.tbl_pro_Usuarios on d.Id_Usuario equals u.Id_Usuario
                          join c in _Progress_gymEntities.tbl_pro_Clientes on d.Id_Cliente equals c.Id_Cliente
                          select new
                          {
                              deuda = d,
                              usuario = u,
                              cliente = c
                          }).ToList();

            return Mapper.Map<List<Deuda_Completas_Dto>>(result);
        }

        public List<Deuda_Completas_Dto> GetDuedByUser(int idCliente)
        {
            var result = (from d in _Progress_gymEntities.tbl_DeudasXCliente
                          join u in _Progress_gymEntities.tbl_pro_Usuarios on d.Id_Usuario equals u.Id_Usuario
                          join c in _Progress_gymEntities.tbl_pro_Clientes on d.Id_Cliente equals c.Id_Cliente
                          where d.Id_Cliente == idCliente
                          select new
                          {
                              deuda = d,
                              usuario = u,
                              concepto = c
                          }).ToList();

            return Mapper.Map<List<Deuda_Completas_Dto>>(result);
        }



    }
}
