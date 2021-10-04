using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_ProjectLibrary.ViewComponents.Book
{
    
    public class BookList:ViewComponent
    {
        BookManager bookManager = new BookManager(new EfBookDal());

        public IViewComponentResult Invoke()
        {
            var Value = bookManager.GetList();
            return View(Value);
        }
    }
}
