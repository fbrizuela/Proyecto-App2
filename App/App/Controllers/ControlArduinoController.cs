using App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using FireSharp.Config;
using FireSharp.Interfaces;
using System.Configuration;
using App.Models.ViewModels;
using System.Net;
using System.IO;
using System.Web.Script.Serialization;

namespace App.Controllers
{
    public class ControlArduinoController : Controller
    {
        //ParaVisualStudio
        //public string mvcMainPagePath = "https://localhost:44354/";//ruta de debug para prebas

        //Github
        public string mvcMainPagePath = "https://fbrizuela.github.io/";

        //FireBase
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = ConfigurationManager.AppSettings["AuthSecret"],
            BasePath = ConfigurationManager.AppSettings["BasePath"]
        };                                                                          
        IFirebaseClient clientfb;

        // GET: Led
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.mvcMainPagePath = mvcMainPagePath;
            return View(ViewBag);
        }

        [HttpPost]
        public ActionResult ModificarLed(NotificationViewModel notification)
        {
            try
            {
                clientfb = new FireSharp.FirebaseClient(config);

                var resUpdate = clientfb.Update(@"Notifications/" + "1", new {
                                                                                Id = notification.Id,
                                                                                R = notification.R,
                                                                                G = notification.G,
                                                                                B = notification.B,
                                                                                Cargado = 0
                                                                            });
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index");
            }

            return View("Index");
        }

        [HttpPost]
        public ActionResult SetearRele(NotificationViewModel notification)
        {
            try
            {
                clientfb = new FireSharp.FirebaseClient(config);

                var resUpdate = clientfb.Update(@"Notifications/" + "1", new
                {
                    Id = notification.Id,
                    R = notification.R,
                    G = notification.G,
                    B = notification.B,
                    Cargado = 0
                });
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public void AddItem(FormCollection data)
        {
            String userName = data["username"];
            String userPassword = data["password"];

            
        }

       
    }
}