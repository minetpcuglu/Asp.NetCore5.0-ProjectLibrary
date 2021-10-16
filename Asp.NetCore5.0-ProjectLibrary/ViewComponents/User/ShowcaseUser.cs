using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_ProjectLibrary.ViewComponents.User
{
    public class ShowcaseUser:ViewComponent
    {
        UserManager userManager = new UserManager(new EfUserDal());
        public IViewComponentResult Invoke()
        {
            var values = userManager.GetListWithBookSummary();
            return View(values);
        }
    }
}
