using System.Web.Mvc;

namespace MvcRoutingExamples.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return new EmptyResult();
        }

        //catch-all route URL segment - wildcard (*) as a parameter prefix
        //this route matches everything after "content-item" part of the URL
        // www.foo.com/content-item/sitecore/content/gallery/paintings/mona-lisa
        //in this example the value of path parameter will be "sitecore/content/gallery/paintings/mona-lisa"
        [Route("content-item/{*path}")]
        public ActionResult ContentItem(string path)
        {
            return new EmptyResult();
        }

        //route range constraint - the age param must be integer number between 18 and 99
        // www.foo.com/customers/25 - valid
        // www.foo.com/customers/110  - not valid (404)
        [Route("customers/{age:range(18,99)}")]
        public ActionResult Customers(int age)
        {
            return new EmptyResult();
        }


    }
}