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

        //Defining route artists with name "GalleryArtists"
        // www.foo.com/modern-art/artists
        [Route("{artists}", Name = "GalleryArtists")]
        public ActionResult Artists()
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

        //tilde (~) overrides the main route prefix
        // www.foo.com/gallery/12
        [Route("~/gallery/{key}")]
        public ActionResult Gallery(string key)
        {
            return new EmptyResult();
        }

        //route integer constraint - the passed id must be integer number, outherwise the route will not much
        // www.foo.com/painting/345
        // www.foo.com/painting/mona-lisa - not valid (404)
        [Route("painting/{id:int}")]
        public ActionResult Painting(int id)
        {
            return new EmptyResult();            
        }


    }
}