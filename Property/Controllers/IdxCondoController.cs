using Property.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Property.Controllers
{
    public class IdxCondoController : Controller
    {
        private IIdxCondoService _IdxCondoService { get; set; }

        public IdxCondoController(IIdxCondoService IdxCondoService)
        {
            this._IdxCondoService = IdxCondoService;
        }

        
        // GET: /IdxCondo/
        public ActionResult GetAllCondo()
        {
            var hjg = _IdxCondoService.GetCondos();
            var CondoData = _IdxCondoService.GetIdxCondos();
            if (CondoData!=null)
            {
               CondoData= CondoData.Take(50).ToList();
            }
            return View(CondoData);
        }

        public ActionResult GetSingleProperty(String MLS)
        {
            var CondoData = _IdxCondoService.GetIdxCondos();
            if (CondoData != null)
            {
                CondoData = CondoData.Take(50).ToList();
            }
            return View(CondoData);
        }
	}
}