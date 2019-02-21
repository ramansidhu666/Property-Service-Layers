using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Property.Entity
{
   public class MainModel
    {
        public List<PropertyModel> PropertiesModel { get; set; }
        public List<PropertyModel> FeaturedPropertiesModel { get; set; }
        public List<PropertyImages> PropertyImagesModel { get; set; }
        public List<SearchModel> SearchModel { get; set; }
        public Pager Pager { get; set; }
        public string CurrentPropertyType { get; set; }
    }
   public class Pager
   {
       public Pager(int totalItems, int? page, int pageSize = 10)
       {
           // calculate total, start and end pages
           var totalPages = (int)Math.Ceiling((decimal)totalItems / (decimal)pageSize);
           var currentPage = page != null ? (int)page : 1;
           var startPage = currentPage - 2;
           var endPage = currentPage + 2;
           if (startPage <= 0)
           {
               endPage -= (startPage - 1);
               startPage = 1;
           }
           if (endPage > totalPages)
           {
               endPage = totalPages;
               if (endPage > 10)
               {
                   startPage = endPage - 9;
               }
           }

           TotalItems = totalItems;
           CurrentPage = currentPage;
           PageSize = pageSize;
           TotalPages = totalPages;
           StartPage = startPage;
           EndPage = endPage;
       }

       public int TotalItems { get; private set; }
       public int CurrentPage { get; private set; }
       public int PageSize { get; private set; }
       public int TotalPages { get; private set; }
       public int StartPage { get; private set; }
       public int EndPage { get; private set; }
   }
}
