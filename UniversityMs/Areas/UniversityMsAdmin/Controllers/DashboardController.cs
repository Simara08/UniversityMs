﻿using UniversityMs.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UniversityMs.Areas.UniversityMsAdmin.Controllers
{
    //[Authorize(Roles = nameof(Role.RoleType.Admin))]
    [Area("UniversityMsAdmin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
