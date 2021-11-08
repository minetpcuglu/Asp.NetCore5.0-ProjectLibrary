using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBookService:IGenericService<Book>
    {
    
        List<Book> GetListWithWriter();
        List<Book> GetListWithWriterGetLast4Book();
        List<Book> GetListWithWriterGetList16Book();

    }
}
