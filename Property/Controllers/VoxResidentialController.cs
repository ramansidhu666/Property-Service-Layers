using Property.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Property.Controllers
{
    public class VoxResidentialController : Controller
    {
        //
         private IVoxResidentialService _VoxResidentialService { get; set; }

        public VoxResidentialController(IVoxResidentialService VoxResidentialService)
        {
            this._VoxResidentialService = VoxResidentialService;
        }

        //
        // GET: /VoxResidential/
        public ActionResult GetAllResidential()
        {
            var ResidentialData = _VoxResidentialService.GetVoxResidentials();
            return View();
        }
	}
}