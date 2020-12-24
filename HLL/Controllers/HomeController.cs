using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Models;
namespace HLL.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetAll(int pageIndex=1,int pageSize=10)
        {
            return Json(StudentBLL.QueryAll(pageIndex,pageSize),JsonRequestBehavior.AllowGet);
        }
    }
}