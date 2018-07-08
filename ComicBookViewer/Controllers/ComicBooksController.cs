using System.Web.Mvc;
using ComicBookViewer.Data;
using ComicBookViewer.Models;

namespace ComicBookViewer.Controllers
{
    public class ComicBooksController : Controller
    {
        private ComicBookRepository _comicBookRepository = null;

        public ComicBooksController()
        {
            _comicBookRepository = new ComicBookRepository();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var comicBook = _comicBookRepository.GetComicBook(id.Value); // When using a nullable type, you need to use the Value property to get to the underlying value, or cast it explicitly to the correct type ((int) id)
            return View(comicBook);
        }
    }
}