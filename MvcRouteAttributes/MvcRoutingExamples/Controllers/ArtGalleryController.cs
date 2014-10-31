using System.Web.Mvc;

namespace MvcRoutingExamples.Controllers
{
    //common prefix for the entire controller
    // www.foo.com/modern-art
    [RoutePrefix("modern-art")]
    //default action
    // www.foo.com/modern-art points to Index action
    [Route("{action=index}")]
    public class ArtGalleryController : Controller
    {
        public ActionResult Index()
        {
            return new EmptyResult();
        }

        //artist is an optional parameter
        //adding ? means that the parameter is not required
        // www.foo.com/modern-art/paintings
        // www.foo.com/modern-art/paintings/Auerbach
        [Route("paintings/{artist?}")]
        public ActionResult Paintings(string artist)
        {
            return new EmptyResult();
        }

        //tilde (~) override the main route prefix
        // www.foo.com/gallery/12
        [Route("~/gallery/{key}")]
        public ActionResult Gallery(string key)
        {
            return new EmptyResult();
        }
    }
}