using ExercicioEFCoreCodeFirst.BLL.Daos;
using ExercicioEFCoreCodeFirst.PL;
using System;
using System.Collections.Generic;

namespace ExercicioEFCoreCodeFirst.BLL.Facades
{
    public class GenreFacade
    {
        private GenreDAO GenreDAO;

        public GenreFacade()
        {
            GenreDAO = new GenreDAO();
        }

        public List<Genre> ListAllGenres()
        {
            return GenreDAO.ListAll();
        }

        public Genre DetailsGenreById(int? id)
        {
            return GenreDAO.DetailsById(id);
        }

        public void CreateGenre(Genre genre)
        {
            GenreDAO.Create(genre);
        }

        public Genre EditGenre(int? id)
        {
            return GenreDAO.EditById(id);
        }

        public Genre EditGenre(int id, Genre genre)
        {
            return GenreDAO.EditByIdAndObject(id, genre);
        }

        public Genre GetToDeleteGenreById(int? id)
        {
            return GenreDAO.GetToDeleteById(id);
        }

        public void DeleteById(int? id)
        {
            GenreDAO.DeleteById(id);
        }
    }
}

