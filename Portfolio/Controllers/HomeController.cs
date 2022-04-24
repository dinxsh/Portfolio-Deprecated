using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public void Index()
        {
            Response.Redirect("/User/Home.aspx");
        }
    }
}