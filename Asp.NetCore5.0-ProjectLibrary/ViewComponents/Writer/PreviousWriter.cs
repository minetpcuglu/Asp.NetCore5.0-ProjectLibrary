﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_ProjectLibrary.ViewComponents.Writer
{
    public class PreviousWriter:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}