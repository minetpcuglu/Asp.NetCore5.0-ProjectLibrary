using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public interface IBookSummaryService
    {
        void Add(BookSummary bookSummary);
        void Delete(BookSummary bookSummary);
        void Update(BookSummary bookSummary);
        List<BookSummary> GetList();
        List<BookSummary> GetListWithBook();
        BookSummary GetById(int id);
    }
}
