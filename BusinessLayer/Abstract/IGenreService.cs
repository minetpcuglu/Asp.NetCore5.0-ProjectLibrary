using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IGenreService
    {
        void Add( Genre  genre);
        void Delete(Genre genre);
        void Update(Genre genre);
        List<Genre> GetList();
        Genre GetById(int id);
    }
}
