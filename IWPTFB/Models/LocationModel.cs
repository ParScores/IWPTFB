using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IWPTFB.Models
{
    public class LocationModel
    {
        public Guid LocationId { get; set; }
        public string Description { get; set; }
        public Guid LocationTypeId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }
        public string Postcode { get; set; }
        public string Latitude { get; set; } //What datatype?
        public string Longitude { get; set; } //What datatype?
        public DateTime AvailableFrom { get; set; }
        public DateTime AvailableTo { get; set; }
    }
}