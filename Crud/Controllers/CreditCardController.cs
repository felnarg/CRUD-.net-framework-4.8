using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using Domain.Models;

namespace Crud.Controllers
{
    public class CreditCardController : Controller
    {
        // GET: CreditCard
        public ActionResult GetAll()
        {

            return Ok();
        }

        // GET: CreditCard/Details/5
        public ActionResult GetById(Guid id)
        {
            return View();
        }

        // GET: CreditCard/Create
        public ActionResult Save()
        {
            return View();
        }

        // POST: CreditCard/Create


        // GET: CreditCard/Edit/5
        public ActionResult Update(CreditCard creditCard)
        {
            return View();
        }

        // POST: CreditCard/Edit/5
        [HttpPost]        
        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}
