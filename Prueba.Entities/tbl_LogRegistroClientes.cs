//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Prueba.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_LogRegistroClientes
    {
        public int Id_LogRegistro { get; set; }
        public int Id_Usuario { get; set; }
        public System.DateTime Fecha_registro { get; set; }
        public string Accion { get; set; }
        public string info_data { get; set; }
    }
}
