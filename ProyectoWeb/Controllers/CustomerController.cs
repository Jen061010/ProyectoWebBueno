using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dominio;
using Infraestructura;
using Logica;

namespace ProyectoWeb.Controllers
{
    public class CustomerController : Controller
    {
        readonly ICustomerService _service;

        public CustomerController(ICustomerService service)
        {
            if (null == _service)
            {
                throw new ArgumentNullException("service");
            }
            _service = service;


        }
        //
        // GET: /Customer/

        public ActionResult Index(string name)
        {
            var customers = _service.GetAll(name);
            return View(customers);
        }


        protected override void Dispose(bool disposing)
        {
            _service.Dispose();
            base.Dispose(disposing);
        }
    }
}