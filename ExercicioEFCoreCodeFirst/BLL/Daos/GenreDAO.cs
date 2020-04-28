using ExercicioEFCoreCodeFirst.BLL.Exceptions;
using ExercicioEFCoreCodeFirst.PL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExercicioEFCoreCodeFirst.BLL.Daos
{
    public class GenreDAO
    {
        private readonly MovieContext _context;

        public GenreDAO()
        {
            _context = new MovieContext();
        }

        public MovieContext GetContext()
        {
            return _context;
        }

        public List<Genre> ListAll()
        {
            return new List<Genre>(_context.Genres.ToList());
        }

        public Genre DetailsById(int? id)
        {
            return _context.Genres.FirstOrDefault(m => m.GenreID == id);
        }

        public void Create(Genre genre)
        {
            _context.Add(genre);
            _context.SaveChanges();
        }

        public Genre EditById(int? id)
        {
            return _context.Genres.Find(id);
        }

        public Genre EditByIdAndObject(int id, Genre genre)
        {
            _context.Update(genre);
            _context.SaveChanges();

            return genre;
        }

        public Genre GetToDeleteById(int? id)
        {
            var genre = _context.Genres.FirstOrDefault(m => m.GenreID == id);

            return genre;
        }

        public void DeleteById(int? id)
        {
            var genre = _context.Genres.FirstOrDefault(m => m.GenreID == id);
            _context.Genres.Remove(genre);
            _context.SaveChanges();
        }
    }
}