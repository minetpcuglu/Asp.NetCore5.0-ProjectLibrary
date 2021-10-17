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
    public class BookSummaryManager : IBookSummaryService
    {
        IBookSummaryDal _bookSummaryDal;

        public BookSummaryManager(IBookSummaryDal bookSummaryDal)
        {
            _bookSummaryDal = bookSummaryDal;
        }

        public void Add(BookSummary bookSummary)
        {
            _bookSummaryDal.Insert(bookSummary);
        }

        public void Delete(BookSummary bookSummary)
        {
            _bookSummaryDal.Delete(bookSummary);
        }

        public List<BookSummary> GetBookIdWithUser(int id)
        {
            return _bookSummaryDal.GetBookIdWithUser(id);
        }

        public BookSummary GetById(int id)
        {
          return  _bookSummaryDal.GetById(id);
        }

        public List<BookSummary> GetList()
        {
          return  _bookSummaryDal.GetListAll();
        }

        public List<BookSummary> GetListWithBook() /*mine buraya bakar mısın*/
        {
            return _bookSummaryDal.GetListWithBook();
        }

        public List<BookSummary> GetListWithBookId(int id)
        {
            return _bookSummaryDal.GetListAll(x => x.BookId == id);
        }

        public void Update(BookSummary bookSummary)
        {
            _bookSummaryDal.Update(bookSummary);
        }
    
    }
}
