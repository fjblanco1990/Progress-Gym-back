﻿using Prueba.Entities.Dtos.Clientes;
using Prueba.Entities.Dtos.Planes;
using Prueba.Entities.Dtos.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Prueba.Entities.Dtos.Ventas
{
    public class VentasClientes_Dto
    {
        public int Id_Ventas_Cliente { get; set; }
        public int Id_Plan { get; set; }
        public int Valor_Venta { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora_Venta_Cliente { get; set; }
        public int Id_Cliente { get; set; }
    }

    public class VentasClientesCompleto
    {
        public VentasClientes_Dto Ventas_Cliente { get; set; }
        public Clientes_Dto Cliente { get; set; }
        public Planes_Dto Id_Plan { get; set; }
    }

    public class Ventas_Clientes_Completo_Dto
    {
        public VentasClientes_Dto Ventas_Cliente { get; set; }
        public Clientes_Dto Cliente { get; set; }
        public Planes_Dto Plan { get; set; }
        public Usuarios_Dto Usuario { get; set; }
    }
}