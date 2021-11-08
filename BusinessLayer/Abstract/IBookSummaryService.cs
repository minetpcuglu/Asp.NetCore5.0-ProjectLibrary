using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public interface IBookSummaryService:IGenericService<BookSummary>
    {
    
   
        List<BookSummary> GetListWithBook();
        List<BookSummary> GetListWithBookId(int id);
        List<BookSummary> GetBookIdWithUser(int id);

    }
}
