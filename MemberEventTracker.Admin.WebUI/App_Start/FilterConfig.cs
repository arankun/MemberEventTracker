﻿using System.Web;
using System.Web.Mvc;

namespace MemberEventTracker.Admin.WebUI {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
