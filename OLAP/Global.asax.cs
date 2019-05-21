﻿using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using OLAP.App_Start;

namespace OLAP
{
    // Note: For instructions on enabling IIS9 or IIS10 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.DefaultConnectionFactory = new SqlConnectionFactory(@"Data Source=(localdb)\v11.0; Integrated Security=True; MultipleActiveResultSets=True; charset = utf8;");
            AreaRegistration.RegisterAllAreas();
            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}