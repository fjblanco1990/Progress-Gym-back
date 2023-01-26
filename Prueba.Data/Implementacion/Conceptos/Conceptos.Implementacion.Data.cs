using AutoMapper;
using Prueba.Data.Interfaz.Conceptos;
using Prueba.Entities;
using Prueba.Entities.Dtos.Conceptos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Data.Implementacion.Conceptos
{
    public class Conceptos_Data: IConceptos_Data
    {
        private Pogress_gymEntities _Pogress_gymEntities = new Pogress_gymEntities();

        public List<Conceptos_Dto> getConceptos()
        {
            var resultFormas = _Pogress_gymEntities.tbl_Conceptos.ToList();
            return Mapper.Map<List<Conceptos_Dto>>(resultFormas);
        }
    }
}
