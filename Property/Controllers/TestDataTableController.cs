using LinqKit;
using Property.Entity;
using Property.Entity.DatatableModel;
using Property.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace Property.Controllers
{
    public class TestDataTableController : Controller
    {
           public IIdxResidentialService _IdxResidentialService { get; set; }

           public TestDataTableController(IIdxResidentialService IdxResidentialService)
        {
            this._IdxResidentialService = IdxResidentialService;
        }
        //
        // GET: /TestDataTable/
        public ActionResult Index()
        {
            return View();
        }

        


        [HttpPost]
        public ActionResult LoadData()
        {

            var draw = Request.Form.GetValues("draw").FirstOrDefault();
            var start = Request.Form.GetValues("start").FirstOrDefault();
            var length = Request.Form.GetValues("length").FirstOrDefault();
            //Find Order Column
            var sortColumn = Request.Form.GetValues("columns[" + Request.Form.GetValues("order[0][column]").FirstOrDefault() + "][name]").FirstOrDefault();
            var sortColumnDir = Request.Form.GetValues("order[0][dir]").FirstOrDefault();


            int pageSize = length != null ? Convert.ToInt32(length) : 0;
            int skip = start != null ? Convert.ToInt32(start) : 0;
            int recordsTotal = 0;
            var datalist = _IdxResidentialService.GetIdxResidentials();
           
                datalist = datalist.OrderBy(x => x.MLS).ToList();

                recordsTotal = datalist.Count();
                var data = datalist.Skip(skip).Take(pageSize).ToList();
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data }, JsonRequestBehavior.AllowGet);
            
        }
	}
}