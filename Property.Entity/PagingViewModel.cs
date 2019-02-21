using Property.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Property.Models
{

    public class PagingViewModel
        {
            public List<PropertyModel> Items { get; set; }
            public Pager Pager { get; set; }
        }

   
}