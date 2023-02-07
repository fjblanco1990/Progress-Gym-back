using AutoMapper;
using Prueba.Data.Interfaz.Clientes;
using Prueba.Entities;
using Prueba.Entities.Dtos.Clientes;
using Prueba.Entities.Dtos.Ingresos;
using Prueba.Entities.Dtos.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Data.Implementacion.Clientes
{
    public class Clientes_Data: IClientes_Data
    {
        private Pogress_gymEntities _Pogress_gymEntities  = new  Pogress_gymEntities();

        public bool GuardarClientes(Clientes_Dto clientes_Dto)
        {
            var mapperData = Mapper.Map<tbl_pro_Clientes>(clientes_Dto);
            _Pogress_gymEntities.tbl_pro_Clientes.Add(mapperData);
            _Pogress_gymEntities.SaveChanges();

            VentasClientes_Dto ventas_Dto = new VentasClientes_Dto();

            ventas_Dto.Id_Plan = clientes_Dto.Id_Plan;
            ventas_Dto.Valor_Venta = _Pogress_gymEntities.tbl_Plan.Where(c => c.Id_Plan == clientes_Dto.Id_Plan).FirstOrDefault().Valor_Plan;
            ventas_Dto.Fecha = clientes_Dto.Fecha_registro;
            ventas_Dto.Hora_Venta_Cliente = clientes_Dto.Hora_Registro;
            ventas_Dto.Id_Cliente = _Pogress_gymEntities.tbl_pro_Clientes.Where(cl => cl.Documento_identitdad.Equals(clientes_Dto.Documento_identitdad)).FirstOrDefault().Id_Cliente;

            var mapperVentas = Mapper.Map<tbl_ventas_clientes>(ventas_Dto);
            _Pogress_gymEntities.tbl_ventas_clientes.Add(mapperVentas);
            _Pogress_gymEntities.SaveChanges();

            return true;
        }

        public int ValidarDocumentoCliente(string documento)
        {
            return _Pogress_gymEntities.tbl_pro_Clientes.Where(c => c.Documento_identitdad.Equals(documento)).Count();
        }

        public List<Clientes_completo_Dto> ConsultarTodosClientes()
        {

            var listClient = (from c in _Pogress_gymEntities.tbl_pro_Clientes
                             join p in _Pogress_gymEntities.tbl_Plan on c.Id_Plan equals p.Id_Plan
                             join fp in _Pogress_gymEntities.tbl_Forma_Pago on c.Id_Forma_pago equals fp.Id_Forma_Pago
                             join us in _Pogress_gymEntities.tbl_pro_Usuarios on c.Id_Usuario equals us.Id_Usuario
                             select new
                             {
                                cliente = c,
                                plan = p,
                                forma_pago = fp,
                                usuario = us
                             }).ToList();

            //var ListaCliente = _Pogress_gymEntities.tbl_pro_Clientes.ToList();
            return Mapper.Map<List<Clientes_completo_Dto>>(listClient);
        }

        public Clientes_Dto ConsultarClienteCedula(string documento)
        {
            var client = _Pogress_gymEntities.tbl_pro_Clientes.Where(c => c.Documento_identitdad.Equals(documento)).FirstOrDefault();
            return Mapper.Map<Clientes_Dto>(client);
        }

        public bool EditarClientes(Clientes_Dto clientes_Dto)
        {
            tbl_pro_Clientes tblClientes  = _Pogress_gymEntities.tbl_pro_Clientes.Where(c => c.Id_Cliente == clientes_Dto.Id_Cliente).FirstOrDefault();
            tblClientes.Nombres = clientes_Dto.Nombres;
            tblClientes.Apellidos = clientes_Dto.Apellidos;
            tblClientes.Celular = clientes_Dto.Celular;
            tblClientes.Fecha_nacimiento = clientes_Dto.Fecha_nacimiento;
            tblClientes.Id_Plan = clientes_Dto.Id_Plan;
            tblClientes.Id_Forma_pago = clientes_Dto.Id_Forma_pago;
            tblClientes.Estado = clientes_Dto.Estado;
            tblClientes.Fecha_inicio = clientes_Dto.Fecha_inicio;
            tblClientes.Fecha_fin = clientes_Dto.Fecha_fin;
            tblClientes.Fecha_Actualizacion = clientes_Dto.Fecha_Actualizacion;
            _Pogress_gymEntities.SaveChanges();

            //aqui si el estado es es activo de nuevo elimina los registros de ingreso, pero se  valida si es para un reingreso o edicion normal 
            if (clientes_Dto.Reingreso)
            {
                VentasClientes_Dto ventas_Dto = new VentasClientes_Dto();

                ventas_Dto.Id_Plan = clientes_Dto.Id_Plan;
                ventas_Dto.Valor_Venta = _Pogress_gymEntities.tbl_Plan.Where(c => c.Id_Plan == clientes_Dto.Id_Plan).FirstOrDefault().Valor_Plan;
                ventas_Dto.Fecha = clientes_Dto.Fecha_Actualizacion;

                var mapperVentas = Mapper.Map<tbl_ventas_clientes>(ventas_Dto);
                _Pogress_gymEntities.tbl_ventas_clientes.Add(mapperVentas);
                _Pogress_gymEntities.SaveChanges();

                var ingresosXcliente = _Pogress_gymEntities.tbl_IngresosXCliente.Where(c => c.Id_Cliente == clientes_Dto.Id_Cliente).ToList();

                if (ingresosXcliente.Count > 0)
                {
                    foreach (var ingresos in ingresosXcliente)
                    {
                        _Pogress_gymEntities.tbl_IngresosXCliente.Remove(ingresos);
                        _Pogress_gymEntities.SaveChanges();
                    } 
                }
            }
            return true;
            
        }

        public bool EliminarCliente(int idCliente)
        {
            var cliente = _Pogress_gymEntities.tbl_pro_Clientes.Where(c => c.Id_Cliente == idCliente).FirstOrDefault();
            _Pogress_gymEntities.tbl_pro_Clientes.Remove(cliente);
            _Pogress_gymEntities.SaveChanges();
            return true;
        }
    }
}
