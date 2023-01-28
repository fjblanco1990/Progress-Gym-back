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

        public bool GuardarConcepto( Conceptos_Dto concepto)
        {
            var resultMap = Mapper.Map<tbl_Conceptos>(concepto);
            _Pogress_gymEntities.tbl_Conceptos.Add(resultMap);
            _Pogress_gymEntities.SaveChanges();
            return true;
        }

        public bool EditarConcepto(Conceptos_Dto concepto)
        {
            var resultConcepto = _Pogress_gymEntities.tbl_Conceptos.Where(c => c.Id_Concepto == concepto.Id_Concepto).FirstOrDefault();

            resultConcepto.Descripcion = concepto.Descripcion;
            resultConcepto.valor_concepto = concepto.valor_concepto;

            _Pogress_gymEntities.SaveChanges();
            return true;
        }

        public bool EliminarConcepto(int idConcepto)
        {
            var resultConcepto = _Pogress_gymEntities.tbl_Conceptos.Where(c => c.Id_Concepto == idConcepto).FirstOrDefault();
            _Pogress_gymEntities.tbl_Conceptos.Remove(resultConcepto);
            return true;
        }
    }
}
