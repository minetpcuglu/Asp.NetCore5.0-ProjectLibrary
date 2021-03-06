using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_ProjectLibrary.Controllers
{
    //[AllowAnonymous]
    public class BookController : Controller
    {
        BookManager bookManager = new BookManager(new EfBookDal());
        public IActionResult Index()
        {
            var Value = bookManager.GetList();
            return View(Value);
        }   
        
        public IActionResult BookListAll()
        {
            var value = bookManager.GetListWithWriter();
            return View(value);
        }
    }
}
