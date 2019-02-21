using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using Property.Entity;
using Dapper;
using System.IO;
using System.Web;


namespace Property.Service
{
    public interface IGenrateLatLongFromAddressServices
    {
        // Main Functions
        List<PropertiesLatLongs> GetPropertiesLatLongs();
        //List<PropertiesLatLongs> GetActiveMls();
        PropertiesLatLongs InsertPropertiesLatLongs(PropertiesLatLongs model);

        string DeletePropertiesLatLongs();

    }
    public class GenrateLatLongFromAddressServices : BaseRepository, IGenrateLatLongFromAddressServices
    {
        ErrorLogging errLog;
        public GenrateLatLongFromAddressServices()
        {
            //errLog = new ErrorLogging();
        }
        public List<PropertiesLatLongs> GetPropertiesLatLongs()
        {
            try
            {
                using (IDbConnection _db = OpenConnection())
                {
                    string query = "SELECT top 100 * FROM PropertiesLatLong";
                    List<PropertiesLatLongs> IdxCondoList = _db.Query<PropertiesLatLongs>(query).ToList();
                    return IdxCondoList;
                }
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public string DeletePropertiesLatLongs()
        {
            try
            {
                using (IDbConnection _db = OpenConnection())
                {
                    string query = "DELETE FROM [dbo].[PropertiesLatLong] where RTRIM(LTRIM(MLSID)) NOT IN(SELECT MLSID FROM [ActiveMLSIDS]);";
                  return  _db.Query<string>(query).FirstOrDefault();
                    
                }
            }
            catch (Exception ex)
            {
                return "";
            }

        }



        public PropertiesLatLongs InsertPropertiesLatLongs(PropertiesLatLongs model)
        {
            try
            {
                using (IDbConnection _db = OpenConnection())
                {
                    string query = "insert into PropertiesLatLong values(@MLSID,@Address,@latitude,@longitude)";
                    PropertiesLatLongs PropertiesLatLong = _db.Query<PropertiesLatLongs>(query, new { Address = model.Address, MLSID = model.MLSID, latitude = model.latitude, longitude = model.longitude }).FirstOrDefault();
                    return PropertiesLatLong;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }


       

    }

}

