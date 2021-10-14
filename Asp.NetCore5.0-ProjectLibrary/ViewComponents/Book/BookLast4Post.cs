using Asp.NetCore5._0_ProjectLibrary.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_ProjectLibrary.ViewComponents.Book
{
    public class BookLast4Post : ViewComponent
    {
        BookManager bm = new BookManager(new EfBookDal());
        public IViewComponentResult Invoke()
        {
            var values = bm.GetLast4Book();
            return View(values);
        }
    }
}
