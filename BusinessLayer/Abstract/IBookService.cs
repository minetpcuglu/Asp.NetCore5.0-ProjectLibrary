using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBookService
    {
        void Add(Book book);
        void Delete(Book book);
        void Update(Book book);
        List<Book> GetList();
        List<Book> GetListWithWriter();
        List<Book> GetListWithWriterGetLast4Book();
        Book GetById(int id);
    }
}
