using AutoMapper;
using Prueba.Data.Interfaz.Formas_pago;
using Prueba.Entities;
using Prueba.Entities.Dtos.Fromas_Pago;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Data.Implementacion.Formas_Pago
{
    public class Formas_Pago_Data: IFormas_pago_Data
    {
        private Pogress_gymEntities _Pogress_gymEntities = new Pogress_gymEntities();

        public List<Formas_pago_Dto> getFormasPago()
        {
            var resultFormas = _Pogress_gymEntities.tbl_Forma_Pago.ToList();
            return Mapper.Map<List<Formas_pago_Dto>>(resultFormas);
        }
    }
}
