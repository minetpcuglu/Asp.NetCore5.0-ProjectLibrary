using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBookSummaryDal : GenericRepository<BookSummary>, IBookSummaryDal
    {
        public List<BookSummary> GetBookIdWithUser(int id)
        {
            //throw new NotImplementedException();
            using(var c=new Context())
            {
                return c.BookSummaries.Include(x => x.User).Where(y => y.BookId == id).ToList();
            }
        }

        public List<BookSummary> GetListWithBook()
        {
            using (var c = new Context())
            {
                return c.BookSummaries.Include(x => x.Book ).Include(y=>y.User).ToList();
            }
        }

    }
}
