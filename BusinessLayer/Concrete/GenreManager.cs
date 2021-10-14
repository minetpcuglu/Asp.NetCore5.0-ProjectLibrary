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
    public class GenreManager : IGenreService
    {
        IGenreDal _genreDal;

        public GenreManager(IGenreDal genreDal)
        {
            _genreDal = genreDal;
        }

        public void Add(Genre genre)
        {
            _genreDal.Insert(genre);
        }

        public void Delete(Genre genre)
        {
            _genreDal.Delete(genre);
        }

        public Genre GetById(int id)
        {
          return  _genreDal.GetById(id);
        }

        public List<Genre> GetList()
        {
            return _genreDal.GetListAll();
        }

        public void Update(Genre genre)
        {
            _genreDal.Update(genre);
        }
    }
}
