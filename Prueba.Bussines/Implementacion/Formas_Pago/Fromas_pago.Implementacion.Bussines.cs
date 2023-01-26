using Prueba.Bussines.Interfaz.Formas_pago;
using Prueba.Data.Interfaz.Formas_pago;
using Prueba.Entities;
using Prueba.Entities.Dtos.Fromas_Pago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Bussines.Implementacion.Formas_Pago
{
    public class Fromas_pago_Bussines: IFormas_pago_Bussines
    {
        private readonly IFormas_pago_Data _IFormas_pago_Data;

        public Fromas_pago_Bussines(IFormas_pago_Data _IFormas_pago_Data)
        {
            this._IFormas_pago_Data = _IFormas_pago_Data;
        }

        public List<Formas_pago_Dto> GetFormasPago()
        {
            try
            {
                return _IFormas_pago_Data.getFormasPago();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
