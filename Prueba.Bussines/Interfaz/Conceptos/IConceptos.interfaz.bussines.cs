﻿using Prueba.Entities.Dtos.Conceptos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Bussines.Interfaz.Conceptos
{
    public interface IConceptos_Bussines
    {
        List<Concepto_Dto> getConceptos();

        bool GuardarConcepto(Concepto_Dto concepto);

        bool EditarConcepto(Concepto_Dto concepto);

        bool EliminarConcepto(int idConcepto);
    }
}
