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
            return _bookDal.GetAll();
        }

        public void Update(Book book)
        {
            _bookDal.Update(book);
        }
    }
}
