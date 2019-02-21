using Property.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Property.Controllers
{
    public class VoxCommercialController : Controller
    {
        //
        private IVoxCommercialService _VoxCommercialService { get; set; }

        public VoxCommercialController(IVoxCommercialService VoxCommercialService)
        {
            this._VoxCommercialService = VoxCommercialService;
        }

        //
        // GET: /VoxCommercial/
        public ActionResult GetAllCommercial()
        {
            var CommercialData = _VoxCommercialService.GetVoxCommercials();
            return View();
        }
	}
}