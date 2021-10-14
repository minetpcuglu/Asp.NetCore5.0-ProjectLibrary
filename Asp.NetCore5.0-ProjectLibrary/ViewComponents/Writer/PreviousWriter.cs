using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCore5._0_ProjectLibrary.ViewComponents.Writer
{
    public class PreviousWriter:ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterDal());
        public IViewComponentResult Invoke()
        {
            var values = wm.GetList();
            return View(values);
        }
    }
}
