using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_ProjectLibrary.ViewComponents.Summary
{
    public class ShowcaseSummary : ViewComponent
    {
        BookSummaryManager booksummng = new BookSummaryManager(new EfBookSummaryDal());

        public IViewComponentResult Invoke()
        {
            var value = booksummng.GetById(7);
            return View(value);
        }
    }
}
