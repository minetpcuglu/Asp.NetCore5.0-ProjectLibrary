using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void Add(Book book)
        {
            _bookDal.Insert(book);
        }

        public void Delete(Book book)
        {
            _bookDal.Delete(book);
        }

        public Book GetById(int id)
        {
           return _bookDal.GetById(id);
        }

        public List<Book> GetList()
        {
            return _bookDal.GetListAll();
        }

        public List<Book> GetLast4Book()
        {
            return _bookDal.GetListAll().Take(4).ToList();
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }

        public List<Book> GetListWithWriter()
        {
            return _bookDal.GetListWithBook().ToList();
        }

        public List<Book> GetListWithWriterGetLast4Book()
        {
            return _bookDal.GetListWithBook().Take(4).ToList();
        }

        public List<Book> GetListWithWriterGetList16Book()
        {
            return _bookDal.GetListWith16Book().Take(16).ToList();
        }
    }
}
