using Property.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Property.Controllers
{
    public class VoxCondoController : Controller
    {
        //
         private IVoxCondoService _VoxCondoService { get; set; }

        public VoxCondoController(IVoxCondoService VoxCondoService)
        {
            this._VoxCondoService = VoxCondoService;
        }

        //
        // GET: /VoxCondo/
        public ActionResult GetAllCondo()
        {
            
            var CondoData = _VoxCondoService.GetVoxCondos();
            return View();
        }
	}
}