using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App.BLL;
using App.Models;

namespace App.Web.Controllers
{
    public class SysSampleController : Controller
    {
        // GET: SysSample
        public ActionResult Index()
        {
            SysSampleBLL bll = new SysSampleBLL();
            List<SysSample> list = bll.GetList();
            return View(list);
        }
    }
}