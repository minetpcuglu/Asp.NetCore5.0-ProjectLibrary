using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_ProjectLibrary.Controllers
{
    public class SummaryController : Controller
    {
        BookSummaryManager bookSummaryManager = new BookSummaryManager(new EfBookSummaryDal());

        public IActionResult FeaturedSummary(int id) /*vitrindeki öne çıkan özet sayfası */
        {
            var value =bookSummaryManager.GetListWithBook().FirstOrDefault(x=>x.SummaryId==id);

            return View(value);
        }
    }
}
