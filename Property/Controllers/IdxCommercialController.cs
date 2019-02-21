using Property.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Property.Controllers
{
    public class IdxCommercialController : Controller
    {
        private IIdxCommercialService _IdxCommercialService { get; set; }

        public IdxCommercialController(IIdxCommercialService IdxCommercialService)
        {
            this._IdxCommercialService = IdxCommercialService;
        }

        //
        // GET: /IdxCommercial/
        public ActionResult GetAllCommercial()
        {
            var CommercialData = _IdxCommercialService.GetCommercials();
            return View(CommercialData.Take(10));
        }
    }
}