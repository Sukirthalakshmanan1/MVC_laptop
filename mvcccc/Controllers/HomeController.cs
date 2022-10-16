using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcccc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Have an enjoyment with Lots of offers Amazon today announced it plans to create 1 million new jobs in India by 2025 through continued investments in technology, infrastructure, and its logistics network. The jobs – created both directly and indirectly – will be across industries, including information technology, skill development, content creation, retail, logistics, and manufacturing, and are in addition to the 700,000 jobs Amazon’s investments have enabled over the last six years in India. On Wednesday, Amazon Founder and CEO Jeff Bezos also announced that the company plans to invest US $1B to help bring 10 million traders and micro, small, and medium-sized businesses (MSMEs) across India online, enabling US $10B in cumulative exports by 2025 and supporting India’s economic diversification.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Make Money with Us\r\nSell on Amazon\r\nSell under Amazon Accelerator\r\nAmazon Global Selling\r\nBecome an Affiliate\r\nFulfilment by Amazon\r\nAdvertise Your Products\r\nAmazon Pay on Merchants";

            return View();
        }
    }
}