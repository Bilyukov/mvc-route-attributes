﻿using System.Web.Mvc;

namespace MvcRoutingExamples.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return new EmptyResult();
        }
    }
}