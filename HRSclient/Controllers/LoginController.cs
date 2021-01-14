using HRSclient.HRSref;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRSclient.Controllers
{
    public class LoginController : Controller
    {
        // GET: Default
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {

            LoginDetails L = new LoginDetails();
            return View(L);
        }
        [HttpPost]
        public ActionResult Register(LoginDetails L)
        {
            HRSref.Service1Client s = new Service1Client();
            ViewBag.msg = s.InsertLogin(L);
            return View();
        }
        //public ActionResult Booking()
        //{
        //    BookingDetails B = new BookingDetails();
        //    return View(B);
        //}
        //[HttpPost]
        //public ActionResult Booking(BookingDetails B)
        //{
        //    return View();
        //}
        //public ActionResult Payment()
        //{
        //    PaymentDetails P = new PaymentDetails();
        //    return View(P);
        //}
        //[HttpPost]
        //public ActionResult Payment(PaymentDetails P)
        //{
        //    return View();
        //}
    }
}