using System;
using System.Collections.Generic;

#nullable disable

namespace Jea.MasterPremiseApp.PremiseService.Specification.Model
{
    public partial class ValidStreetName
    {
        public int ValidStreetNameId { get; set; }
        public string StreetName { get; set; }
        public string StreetType { get; set; }
        public string StreetDir { get; set; }
        public string GisStreetName { get; set; }
        public string CityCode { get; set; }
        public string City { get; set; }
        public string StreetCode { get; set; }
        public int? LowRange { get; set; }
        public int? HighRange { get; set; }
        public DateTime? DateCreatedWeb { get; set; }
        public DateTime? DateCreatedBz { get; set; }
        public string UserCreatedWeb { get; set; }
        public DateTime? DateModifiedWeb { get; set; }
        public DateTime? DateModifiedBz { get; set; }
        public string UserModifiedWeb { get; set; }
    }
}
