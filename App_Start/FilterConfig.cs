﻿using System.Web;
using System.Web.Mvc;

namespace Eclerx.Nursery
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
