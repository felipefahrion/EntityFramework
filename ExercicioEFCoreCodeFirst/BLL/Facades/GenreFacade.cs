using ExercicioEFCoreCodeFirst.BLL.Daos;
using ExercicioEFCoreCodeFirst.PL;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExercicioEFCoreCodeFirst.BLL.Facades
{
    public class GenreFacade
    {
        private GenreDAO GenreDAO;

        public GenreFacade()
        {
            GenreDAO = new GenreDAO();
        }

        public Task<List<Genre>> ListAllGenres()
        {
            return GenreDAO.ListAll();
        }

        public Task<Genre> DetailsGenreById(int? id)
        {
            return GenreDAO.DetailsById(id);
        }

        public async Task CreateGenre(Genre genre)
        {
            await GenreDAO.Create(genre);
        }

        public Task<Genre> EditGenre(int? id)
        {
            return GenreDAO.EditById(id);
        }

        public Task<Genre> EditGenre(int id, Genre genre)
        {
            return GenreDAO.EditByIdAndObject(id, genre);
        }

        public Task<Genre> GetToDeleteGenreById(int? id)
        {
            return GenreDAO.GetToDeleteById(id);
        }

        public async Task DeleteById(int? id)
        {
            await GenreDAO.DeleteById(id);
        }
    }
}

