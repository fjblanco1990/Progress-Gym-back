using Prueba.Entities.Dtos.Conceptos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Bussines.Interfaz.Conceptos
{
    public interface IConceptos_Bussines
    {
        List<Conceptos_Dto> getConceptos();

        bool GuardarConcepto(Conceptos_Dto concepto);

        bool EditarConcepto(Conceptos_Dto concepto);

        bool EliminarConcepto(int idConcepto);
    }
}
