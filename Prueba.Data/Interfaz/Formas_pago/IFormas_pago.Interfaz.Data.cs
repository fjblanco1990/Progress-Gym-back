using Prueba.Entities.Dtos.Fromas_Pago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Data.Interfaz.Formas_pago
{
    public interface IFormas_pago_Data
    {
        List<Formas_pago_Dto> getFormasPago();
    }
}
