﻿using MyFirstMVCAppSCAGT.Auth;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCAppSCAGT
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new CusomErrorAttribute());
        }
    }
}
