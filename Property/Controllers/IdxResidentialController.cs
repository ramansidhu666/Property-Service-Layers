using Property.Core.UtilityManager;
using Property.Entity;
using Property.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace Property.Controllers
{
    public class IdxResidentialController : Controller
    {
        public IIdxResidentialService _IdxResidentialService { get; set; }
        public IGenrateLatLongFromAddressServices _GenrateLatLongFromAddressServices { get; set; }

        public IdxResidentialController(IIdxResidentialService IdxResidentialService, IGenrateLatLongFromAddressServices GenrateLatLongFromAddressServices)
        {
            this._IdxResidentialService = IdxResidentialService;
            this._GenrateLatLongFromAddressServices = GenrateLatLongFromAddressServices;
        }
        
        //
        // GET: /IdxResidential/
        public ActionResult GetAllResidential(int? draw, int? start, int? length)
        {
            var hnjhg=_IdxResidentialService.GetResidentials("Rajpal","11");
            var ghgh = hnjhg.Select(f => f.exist != null).ToList();
            var MlsIds = _GenrateLatLongFromAddressServices.GetPropertiesLatLongs().Select(c => c.MLSID).ToList();
            var ResidentialData = _IdxResidentialService.GetIdxResidentials().Skip(5).Take(10);

            //UpdatePropetyLatLong(ResidentialData);
            return View(ResidentialData.ToList());
        }

         // GET: /IdxResidential/
        public ActionResult GetSingleProperty()
        {
            
            string mls = "S3844399";
            var ResidentialData = _IdxResidentialService.GetSingleProperty(mls);


            return View(ResidentialData);
        }

        public void UpdatePropetyLatLong(List<PropertyModel> PropertiesList)
        {
            try
            {
                PropertiesLatLongs model = new PropertiesLatLongs();
                var MlsIds = _GenrateLatLongFromAddressServices.GetPropertiesLatLongs().Select(c => c.MLSID).ToList();
                var Properties = PropertiesList.Where(c => !MlsIds.Contains(c.MLS));
                int CheckCount = 1;
                foreach (var property in Properties)
                {

                    if (property.Address != null && property.Address != "")
                    {
                        if (CheckCount < 2500)
                        {
                            property.Address += "," + property.Community + "," + property.Municipality;
                            var latlong = GoogleOperation.GetLongitudeAndLatitude(property.Address, "false");
                            if (latlong != "")
                            {
                                var splitstr = latlong.Split(',');
                                model.longitude = Convert.ToDecimal(splitstr[0]);
                                model.latitude = Convert.ToDecimal(splitstr[1]);
                                model.MLSID = property.MLS;
                                model.Address = property.Address;
                                _GenrateLatLongFromAddressServices.InsertPropertiesLatLongs(model);
                            }
                            CheckCount = CheckCount + 1;
                        }


                    }
                }
            }
            catch (Exception ex)
            {
                
                throw;
            }
            
           
        }


       
	}
}