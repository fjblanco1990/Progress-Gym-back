using Prueba.Bussines.Interfaz.Clientes;
using Prueba.Data.Interfaz.Clientes;
using Prueba.Entities.Dtos.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Bussines.Implementacion.Clientes
{
    public class Clientes_Bussines : IClientes_Bussines
    {

        private readonly IClientes_Data _IClientes_Data;

        //public Fromas_pago_Bussines(IFormas_pago_Data _IFormas_pago_Data)
        //{
        //    this._IFormas_pago_Data = _IFormas_pago_Data;
        //}
        public Clientes_Bussines(IClientes_Data iClientes_Data)
        {
            _IClientes_Data = iClientes_Data;
        }

        public bool GuardarClientes(Clientes_Dto clientes_Dto)
        {
            try
            {
                return _IClientes_Data.GuardarClientes(clientes_Dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ValidarDocumentoCliente(string documento)
        {
            try
            {
                return _IClientes_Data.ValidarDocumentoCliente(documento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        


        public List<Clientes_completo_Dto> ConsultarTodosClientes()
        {
            try
            {
                return _IClientes_Data.ConsultarTodosClientes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //public List<Clientes_Dto> ConsultarTodosClientes()
        //{
        //    try
        //    {
        //        return _IClientes_Data.ConsultarTodosClientes();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}

        public Clientes_Dto ConsultarClienteCedula(string documento)
        {
            try
            {
                return _IClientes_Data.ConsultarClienteCedula(documento);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EditarClientes(Clientes_Dto clientes_Dto)
        {
            try
            {
                
                return _IClientes_Data.EditarClientes(clientes_Dto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool EliminarCliente(int idCliente)
        {
            try
            {
                return _IClientes_Data.EliminarCliente(idCliente);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
