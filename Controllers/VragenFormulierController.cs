using System;
using System.Collections.Generic;
using BKDKinderboekenDBWebApp.Models;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BKDKinderboekenDBWebApp.Controllers
{
    public class VragenFormulierController : Controller
    {
        // GET: VragenFormulier
        public ActionResult Index()
        {
            return View();
        }

        // Create context for database
        Context db = new Context();
        {

        }
}