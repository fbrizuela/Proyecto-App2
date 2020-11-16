using App.Models;
using App.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace App.Controllers
{
    public class ComprasVueController : Controller
    {
        dbAppEntities1 db = new dbAppEntities1();
        // GET: ComprasVue
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetCompras()
        {
            List<FacturaViewModel> model;
            var message = "";
            try
            {
                model = (from fs in db.Facturas
                         select new FacturaViewModel
                         {
                             Id = fs.Id,
                             Total = fs.Total,
                             FechaCompra = fs.FechaCompra
                         }).ToList();

                message = "success";
            }
            catch (Exception e)
            {
                message = "fail: " + e.StackTrace;
                throw;
            }
            return Json(model, JsonRequestBehavior.AllowGet);
        }
    }
}