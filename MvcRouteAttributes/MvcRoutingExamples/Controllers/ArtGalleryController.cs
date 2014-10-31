using System.Web.Mvc;

namespace MvcRoutingExamples.Controllers
{
    public class ArtGalleryController : Controller
    {
        public ActionResult Index()
        {
            return new EmptyResult();
        }
    }
}