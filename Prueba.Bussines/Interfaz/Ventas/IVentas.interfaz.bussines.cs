﻿using Prueba.Entities.Dtos.Ventas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba.Bussines.Interfaz.Ventas
{
    public interface IVentas_Bussines
    {
        bool GuardarVenta(Ventas_Dto venta_Dto);
        List<Ventas_Completas_Dto> GetVentasUnicasDiarias(DateTime dateInitial, DateTime dateFinish);

        List<Ventas_Dto> GetVentasAll();
    }
}
