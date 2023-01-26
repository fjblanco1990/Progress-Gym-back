using Prueba.Entities.Dtos.Fromas_Pago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Bussines.Interfaz.Formas_pago
{
    public interface IFormas_pago_Bussines
    {
        List<Formas_pago_Dto> GetFormasPago();
    }
}
