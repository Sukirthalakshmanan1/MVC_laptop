using BAL;
using Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace mvcccc.Controllers
{
    public class PayController : Controller
    {
        // GET: Pay

        Helperclass helper = null;
        public PayController()
        {
            helper = new Helperclass();
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            Credit bal = new Credit();
            bal.Cardno = Convert.ToInt32(Request["Cardno"]);
            bal.name = Request["name"].ToString();
            bal.CVV = Convert.ToInt32(Request["CVV"]);
           



            bool ans = helper.Add(bal);
            if (ans)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

    }
}