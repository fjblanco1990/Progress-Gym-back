using Prueba.Bussines.Implementacion.Clientes;
using Prueba.Bussines.Implementacion.Conceptos;
using Prueba.Bussines.Implementacion.Formas_Pago;
using Prueba.Bussines.Implementacion.Ingresos;
using Prueba.Bussines.Implementacion.Planes;
using Prueba.Bussines.Implementacion.Ventas;
using Prueba.Bussines.Interfaz.Clientes;
using Prueba.Bussines.Interfaz.Conceptos;
using Prueba.Bussines.Interfaz.Formas_pago;
using Prueba.Bussines.Interfaz.Ingresos;
using Prueba.Bussines.Interfaz.Planes;
using Prueba.Bussines.Interfaz.Ventas;
using Prueba.Data.Implementacion.Clientes;
using Prueba.Data.Implementacion.Conceptos;
using Prueba.Data.Implementacion.Formas_Pago;
using Prueba.Data.Implementacion.Ingresos;
using Prueba.Data.Implementacion.Planes;
using Prueba.Data.Implementacion.Ventas;
using Prueba.Data.Interfaz.Clientes;
using Prueba.Data.Interfaz.Conceptos;
using Prueba.Data.Interfaz.Formas_pago;
using Prueba.Data.Interfaz.Ingresos;
using Prueba.Data.Interfaz.Planes;
using Prueba.Data.Interfaz.Ventas;
using System.Web.Http;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace Prueba_Api
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            container.RegisterType<IClientes_Bussines, Clientes_Bussines>();
            container.RegisterType<IClientes_Data, Clientes_Data>();

            container.RegisterType<IIngresos_Bussines, Ingresos_bussines>();
            container.RegisterType<IIngresos_Data, Ingresos_Data>();

            container.RegisterType<IPlanes_Bussines, Planes_Bussines>();
            container.RegisterType<IPlanes_Data, Planes_Data>();

            container.RegisterType<IFormas_pago_Bussines, Fromas_pago_Bussines>();
            container.RegisterType<IFormas_pago_Data, Formas_Pago_Data>();

            container.RegisterType<IConceptos_Bussines, Conceptos_Bussines>();
            container.RegisterType<IConceptos_Data, Conceptos_Data>();

            container.RegisterType<IVentas_Bussines, Ventas_Bussines>();
            container.RegisterType<IVentas_Data, Ventas_Data>();

            //container.RegisterType<IAvionInterfazData, AvionImplementacionData>();
            //container.RegisterType<IAvionInterfazBussines, AvionImplementacionBussines>();

            //container.RegisterType<IIntinerarioInterfazData, IntinerarioImplementacionData>();
            //container.RegisterType<IIntinerarioInterfazBussines, IntinerarioImplementacionBussines>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            System.Web.Http.GlobalConfiguration.Configuration.DependencyResolver = new Unity.WebApi.UnityDependencyResolver(container);
        }
    }
}