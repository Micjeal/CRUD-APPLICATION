using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD_APPLICATION.Models;

namespace CRUD_APPLICATION.Controllers
{
    public class HOMEController : Controller
    {

        crudDBEntities1 DatabaseEFObject = new crudDBEntities1();
        // GET: HOME
        public ActionResult Index()
        {
            var IndexData = DatabaseEFObject.Employeetbls.ToList();
            return View(IndexData);
        }
    }
}