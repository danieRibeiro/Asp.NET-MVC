﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace projetoStrata
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "teste",
                "teste",
                defaults: new { controller = "Servicos", action = "Teste" }
            );

            routes.MapRoute(
                "sobre",
                "sobre",
                defaults: new { controller = "Home", action = "About" }
            );

            routes.MapRoute(
                "contato",
                "contato",
                defaults: new { controller = "Home", action = "Contact" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
