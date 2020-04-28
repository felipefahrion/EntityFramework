using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExercicioEFCoreCodeFirst.PL;
using Microsoft.EntityFrameworkCore;
using ExercicioEFCoreCodeFirst.BLL.Facades;

namespace MoviesWeb.Controllers
{
    public class GenresController : Controller
    {
        private GenreFacade GenreFacade;

        public GenresController()
        {
            GenreFacade = new GenreFacade();
        }

        // GET: Genres
        public async Task<IActionResult> Index()
        {
            return View(GenreFacade.ListAllGenres());
        }

        // GET: Genres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genre = GenreFacade.DetailsGenreById(id);

            if (genre == null)
            {
                return NotFound();
            }

            return View(genre);
        }

        // GET: Genres/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Genres/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GenreID,Name,Description")] Genre genre)
        {
            if (ModelState.IsValid)
            {
                GenreFacade.CreateGenre(genre);
                return RedirectToAction(nameof(Index));
            }
            return View(genre);
        }

        // GET: Genres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genre = GenreFacade.EditGenre(id);

            if (genre == null)
            {
                return NotFound();
            }
            return View(genre);
        }

        // POST: Genres/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GenreID,Name,Description")] Genre genre)
        {
            if (id != genre.GenreID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    GenreFacade.EditGenre(id, genre);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GenreExists(genre.GenreID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(genre);
        }

        // GET: Genres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var genre = GenreFacade.GetToDeleteGenreById(id);

            if (genre == null)
            {
                return NotFound();
            }

            return View(genre);
        }

        // POST: Genres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            GenreFacade.DeleteById(id);
            return RedirectToAction(nameof(Index));
        }
        
        private bool GenreExists(int id)
        {
            return new MovieContext().Genres.Any(e => e.GenreID == id);
        }
    }
}
