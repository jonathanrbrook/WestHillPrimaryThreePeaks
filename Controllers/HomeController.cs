using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ThreePeaksMvc.Models;
using ThreePeaksMvc.Service;


namespace ThreePeaksMvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new CalendarItemsViewModel {CalendarItems = new CalendarService().GetFutureEvents(5)};

            return View(model);
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Challenge()
        {
            return View();
        }

        public ActionResult Map()
        {
            return View();
        }

        public ActionResult ThreeDMaps()
        {
            return View();
        }

        public ActionResult Sponsorship()
        {
            return View();
        }

        public ActionResult Training()
        {
            return View();
        }

        public ActionResult Weather()
        {
            return View();
        }

        public ActionResult TrainingPhotos()
        {
            return View();
        }
        public ActionResult TrainingSlideShow()
        {
            return View();
        }
        public ActionResult TrainingDates()
        {
            return View();
        }

        public ActionResult ReceptionDesign()
        {
            return View();
        }
    }
}
