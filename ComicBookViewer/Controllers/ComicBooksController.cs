using System.Web.Mvc;
using ComicBookViewer.Models;

namespace ComicBookViewer.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            return View(comicBook);
        }
    }
}