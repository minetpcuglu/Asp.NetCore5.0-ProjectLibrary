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
        BookManager bookManager = new BookManager(new EfBookDal());
        UserManager userManager = new UserManager(new EfUserDal());


        public IActionResult FeaturedSummary(int id) /*vitrindeki öne çıkan özet sayfası */
        {
            var value =bookSummaryManager.GetListWithBook().FirstOrDefault(x=>x.SummaryId==id);

            return View(value);
        }
        public IActionResult SummaryAll()   // side bar Kitap Özetleri sekmesinde kitapları alt alta getirir
        {
            var value = bookManager.GetListWithWriter();
            return View(value);
        }
        public IActionResult SummaryBook(int id)  //side barda kitap özetin içinde kitaplara ait özetleri açar.
        {
         
            var value = bookSummaryManager.GetBookIdWithUser(id);
            return View(value);
        }
        public IActionResult Edit(int id)
        {
            var value = bookSummaryManager.GetById(id);
            return PartialView(value);
        }
      
     
    }
}
