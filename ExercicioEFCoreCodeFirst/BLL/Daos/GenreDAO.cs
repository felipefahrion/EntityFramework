using ExercicioEFCoreCodeFirst.BLL.Exceptions;
using ExercicioEFCoreCodeFirst.PL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<List<Genre>> ListAll() => await _context.Genres.ToListAsync();

        public async Task<Genre> DetailsById(int? id)
        {
            return await _context.Genres.FirstOrDefaultAsync(m => m.GenreID == id);
        }

        public async Task Create(Genre genre)
        {
            _context.Add(genre);
            await _context.SaveChangesAsync();
        }

        public async Task<Genre> EditById(int? id)
        {
            return await _context.Genres.FindAsync(id);
        }

        public async Task<Genre> EditByIdAndObject(int id, Genre genre)
        {
            _context.Update(genre);
            await _context.SaveChangesAsync();

            return genre;
        }

        public async Task<Genre> GetToDeleteById(int? id)
        {
            var genre = await _context.Genres.FirstOrDefaultAsync(m => m.GenreID == id);

            return genre;
        }

        public async Task DeleteById(int? id)
        {
            var genre = await _context.Genres.FirstOrDefaultAsync(m => m.GenreID == id);
            _context.Genres.Remove(genre);
            await _context.SaveChangesAsync();
        }
    }
}