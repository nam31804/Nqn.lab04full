﻿using System.Web;
using System.Web.Mvc;

namespace Nqn.lab04._1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
