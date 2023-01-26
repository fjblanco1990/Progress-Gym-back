using Prueba.Bussines.Interfaz.Conceptos;
using Prueba.Data.Interfaz.Conceptos;
using Prueba.Entities.Dtos.Conceptos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Bussines.Implementacion.Conceptos
{
    public class Conceptos_Bussines: IConceptos_Bussines
    {
        private readonly IConceptos_Data _IConceptos_Data;
        public Conceptos_Bussines(IConceptos_Data iConceptos_Data)
        {
            _IConceptos_Data = iConceptos_Data;
        }

        public List<Conceptos_Dto> getConceptos()
        {
            try
            {
                return _IConceptos_Data.getConceptos();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
