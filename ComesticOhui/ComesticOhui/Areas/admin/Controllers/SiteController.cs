using ComesticOhui.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ComesticOhui.Models.DTO;
namespace ComesticOhui.Areas.admin.Controllers
{
    public class SiteController : Controller
    {

        BmsContext db = new BmsContext();
        //
        // GET: /admin/Site/
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult demo()
        {
            string str = "";
            return View();
        }
	}
}