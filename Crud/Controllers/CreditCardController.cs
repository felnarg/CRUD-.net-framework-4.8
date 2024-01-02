using System;
using System.Web.Mvc;
using Application.Querys;
using Domain.Models;
using Application.Interfaces;
using System.Web.Http;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using RouteAttribute = System.Web.Http.RouteAttribute;

namespace Crud.Controllers
{
    [Route("[controller]")]
    public class CreditCardController : Controller
    {
        private readonly ICreditCardServices _creditCardServices;
        public CreditCardController(CreditCardServices creditCardServices)
        {
            _creditCardServices = creditCardServices;
        }

        [HttpGet]
        public ActionResult GetAll()
        {
            _creditCardServices.GetAll();
            return Json(new { mensaje = "Operación exitosa" }, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetById(Guid id)
        {
            _creditCardServices.GetById(id);
            return Json(new { mensaje = "Operación exitosa" }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Save([FromBody] CreditCard entity)
        {
            _creditCardServices.SaveEntity(entity);
            return Json(new { mensaje = "Operación exitosa" }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Update(CreditCard creditCard)
        {
            _creditCardServices.Update(creditCard);
            return Json(new { mensaje = "Operación exitosa" }, JsonRequestBehavior.AllowGet);
        }
        
        [HttpPost]        
        public ActionResult Delete(Guid id)
        {
            _creditCardServices.Delete(id);
            return Json(new { mensaje = "Operación exitosa" }, JsonRequestBehavior.AllowGet);
        }
    }
}
