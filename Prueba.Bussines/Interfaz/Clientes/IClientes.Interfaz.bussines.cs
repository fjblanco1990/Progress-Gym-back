using Prueba.Entities.Dtos.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Bussines.Interfaz.Clientes
{
    public interface IClientes_Bussines
    {
        bool GuardarClientes(Clientes_Dto clientes_Dto);

        int ValidarDocumentoCliente(string documento);

        List<Clientes_completo_Dto> ConsultarTodosClientes();

        Clientes_Dto ConsultarClienteCedula(string documento);

        bool EditarClientes(Clientes_Dto clientes_Dto);

        bool EliminarCliente(int idCliente);
    }
}
