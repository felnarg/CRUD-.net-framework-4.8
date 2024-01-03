using System;
using System.Web.Http;
using System.Web.Mvc;
using Application.Interfaces;
using Domain.Models;
using HttpGetAttribute = System.Web.Http.HttpGetAttribute;
using HttpPostAttribute = System.Web.Http.HttpPostAttribute;

namespace Crud.Controllers
{
    //[Route("[api/controller]")]
    public class CreditCardController : ApiController
    {
        private readonly ICreditCardServices _creditCardServices;
        public CreditCardController(ICreditCardServices creditCardServices)
        {
            _creditCardServices = creditCardServices;
        }

        [HttpGet]
        [System.Web.Http.Route("api/creditcard/getall")]
        public IHttpActionResult GetAll()
        {
            return Ok(_creditCardServices.GetAll());
        }

        [HttpGet]
        [System.Web.Http.Route("api/creditcard/getbyid/{id}")]
        public IHttpActionResult GetById([FromUri] Guid id)
        {            
            return Ok(_creditCardServices.GetById(id));
        }

        [HttpPost]
        [System.Web.Http.Route("api/creditcard/save")]
        public IHttpActionResult Save([FromBody] CreditCard entity)
        {
            _creditCardServices.SaveEntity(entity);
            return Json(new { mensaje = "Operación exitosa" });
        }

        [HttpPost]
        [System.Web.Http.Route("api/creditcard/update")]
        public IHttpActionResult Update([FromBody] CreditCard creditCard)
        {
            _creditCardServices.Update(creditCard);
            return Json(new { mensaje = "Operación exitosa" });
        }
        
        [HttpPost]
        [System.Web.Http.Route("api/creditcard/delete/{id}")]
        public IHttpActionResult Delete([FromUri] Guid id)
        {
            _creditCardServices.Delete(id);
            return Json(new { mensaje = "Operación exitosa" });
        }
    }
}
