using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IWPTFB.Models
{
    public class LocationTypeModel
    {
        public Guid LocationTypeId { get; set; }
        public string Description { get; set; }
        public DateTime AvailableFrom { get; set; }
        public DateTime AvailableTo { get; set; }
    }
}