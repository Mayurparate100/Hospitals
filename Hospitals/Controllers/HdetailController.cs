using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hospitals.Models;

namespace Hospitals
{
    public class HdetailController : Controller
    {
        // GET: Hdetail
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SaveHdetail(HdetailModel model)
        {
            try
            {
                return Json(new { message = (new HdetailModel().SaveHdetail(model)) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception Ex)
            {
                return Json(new { model = Ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
        public ActionResult GetHdetailList()
        {
            try
            {
                return Json(new { model = (new HdetailModel().GetHdetailList()) }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}