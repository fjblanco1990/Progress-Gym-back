using AutoMapper;
using Prueba.Entities;
using Prueba.Entities.Dtos.Clientes;
using Prueba.Entities.Dtos.Ingresos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Prueba_Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Serialize;
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore;
            GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings.PreserveReferencesHandling = Newtonsoft.Json.PreserveReferencesHandling.Objects;

            GlobalConfiguration.Configuration.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            UnityConfig.RegisterComponents();

            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<tbl_pro_Clientes, Clientes_Dto>().ForMember(g => g.Reingreso, opt => opt.Ignore());

                cfg.CreateMap<tbl_LOG_IngresosXCliente, Ingresos_log_Dto>();
                cfg.CreateMap<Ingresos_log_Dto, tbl_LOG_IngresosXCliente>();

                cfg.CreateMap<tbl_IngresosXCliente, Ingresos_Dto>().ForMember(g => g.Hora_Ingreso, opt => opt.Ignore());
                 


                //cfg.CreateMap<tbl_Avion, AvionDto>();

                //cfg.CreateMap<IntinerarioDto, tbl_VuelosXAvion>().ForMember(g => g.tbl_Ciudades, opt => opt.Ignore())
                //                                                 .ForMember(g => g.tbl_Ciudades1, opt => opt.Ignore())
                //                                                 .ForMember(g => g.tbl_Avion, opt => opt.Ignore());
                //cfg.CreateMap<tbl_VuelosXAvion, IntinerarioDto>();
            });
        }
    }
}
