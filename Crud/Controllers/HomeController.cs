using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Infrastructure;

namespace Crud.Controllers
{
    public class HomeController : Controller
    {
        private readonly CreditCardDbContext _dbcontext;

        public HomeController(CreditCardDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult DbConnection()
        {
            _dbcontext.Database.CreateIfNotExists();
            return Content($"Base de datos: {_dbcontext.Database.Connection.Database}");
        }
    }
}
