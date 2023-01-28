using AutoMapper;
using Prueba.Data.Interfaz.Ingresos;
using Prueba.Entities;
using Prueba.Entities.Dtos.Ingresos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Data.Implementacion.Ingresos
{
    public class Ingresos_Data: IIngresos_Data
    {
        private Pogress_gymEntities _Progress_gymEntities = new Pogress_gymEntities();

        public bool GuardarIngreso(Ingresos_Dto ingresos_Dto)
        {
            Ingresos_log_Dto ingresos_log_Dto = new Ingresos_log_Dto();

            ingresos_log_Dto.Id_Cliente = ingresos_Dto.Id_Cliente;
            ingresos_log_Dto.Id_Ingreso = ingresos_Dto.Id_Ingreso;
            ingresos_log_Dto.Fecha_Ingreso = ingresos_Dto.Fecha_Ingreso;
            ingresos_log_Dto.Hora_Ingreso = ingresos_Dto.Hora_Ingreso;

            var mapperData = Mapper.Map<tbl_IngresosXCliente>(ingresos_Dto);

            //se debe mapear para guardar la hora de ingreso
            var mapperDataLog = Mapper.Map<tbl_LOG_IngresosXCliente>(ingresos_log_Dto);


            _Progress_gymEntities.tbl_LOG_IngresosXCliente.Add(mapperDataLog);
            _Progress_gymEntities.SaveChanges();
            _Progress_gymEntities.tbl_IngresosXCliente.Add(mapperData);
            _Progress_gymEntities.SaveChanges();
            return true;
        }

        public List<Ingresos_Completo_Dto> ConsultarTodosIngresos()
        {

            var listClient = (from c in _Progress_gymEntities.tbl_pro_Clientes
                              join i in _Progress_gymEntities.tbl_IngresosXCliente on c.Id_Cliente equals i.Id_Cliente
                              select new
                              {
                                  cliente = c,
                                  ingreso = i,
                              }).ToList();

            //var ListaCliente = _Pogress_gymEntities.tbl_pro_Clientes.ToList();
            return Mapper.Map<List<Ingresos_Completo_Dto>>(listClient);
        }

        public List<Ingresos_log_Completo_Dto> ConsultarTodosIngresosLog()
        {

            var listClient = (from c in _Progress_gymEntities.tbl_pro_Clientes
                              join i in _Progress_gymEntities.tbl_LOG_IngresosXCliente on c.Id_Cliente equals i.Id_Cliente
                              select new
                              {
                                  cliente = c,
                                  ingreso = i,
                              }).ToList();

            //var ListaCliente = _Pogress_gymEntities.tbl_pro_Clientes.ToList();
            return Mapper.Map<List<Ingresos_log_Completo_Dto>>(listClient);
        }

        public List<Ingresos_Completo_Dto> ConsultarIngresoId(int idIngreso)
        {
            var client = (from c in _Progress_gymEntities.tbl_pro_Clientes
                          join i in _Progress_gymEntities.tbl_IngresosXCliente on c.Id_Cliente equals i.Id_Cliente
                          where i.Id_Cliente == idIngreso
                         select new
                         {
                             cliente = c,
                             ingreso = i
                         }).ToList();

            return Mapper.Map<List<Ingresos_Completo_Dto>>(client);
        }

        public List<Ingresos_log_Completo_Dto> ConsultarIngresoLogId(int idIngreso)
        {
            var client = (from c in _Progress_gymEntities.tbl_pro_Clientes
                          join i in _Progress_gymEntities.tbl_LOG_IngresosXCliente on c.Id_Cliente equals i.Id_Cliente
                          where i.Id_Cliente == idIngreso
                          select new
                          {
                              cliente = c,
                              ingreso = i
                          }).ToList();

            return Mapper.Map<List<Ingresos_log_Completo_Dto>>(client);
        }

        public bool EditarIngreso(Ingresos_Dto ingreso_dto)
        {
            tbl_IngresosXCliente tblIngreso = _Progress_gymEntities.tbl_IngresosXCliente.Where(c => c.Id_Ingreso == ingreso_dto.Id_Ingreso).FirstOrDefault();
            tblIngreso.Id_Cliente = ingreso_dto.Id_Cliente;
            tblIngreso.Fecha_Ingreso = ingreso_dto.Fecha_Ingreso;
          
            _Progress_gymEntities.SaveChanges();
            return true;
        }

        public bool EliminarIngreso(int idIngreso)
        {
            var ingreso = _Progress_gymEntities.tbl_IngresosXCliente.Where(c => c.Id_Ingreso == idIngreso).FirstOrDefault();
            _Progress_gymEntities.tbl_IngresosXCliente.Remove(ingreso);
            _Progress_gymEntities.SaveChanges();
            return true;
        }
    }
}
