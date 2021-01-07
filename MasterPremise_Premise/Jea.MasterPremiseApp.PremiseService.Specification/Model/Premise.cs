using System;
using System.Collections.Generic;
using System.Text;

namespace Jea.MasterPremiseApp.PremiseService.Specification.Model
{
    public class Premise
    {
        public int PremiseId { get; set; }
        public string CisPremId { get; set; }
        public int? GisOwnerId { get; set; }
        public string BzId { get; set; }
        public string InactiveFlag { get; set; }
        public DateTime? InactiveDate { get; set; }
        public string CityCode { get; set; }
        public string StreetCode { get; set; }
        public string PrevStreetCode { get; set; }
        public string MapNumber { get; set; }
        public string PremTypeCd { get; set; }
        public string HouseNo { get; set; }
        public string StreetName { get; set; }
        public string StreetType { get; set; }
        public string StreetDir { get; set; }
        public string UnitNo { get; set; }
        public string Address1 { get; set; }
        public string GisStreetName { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string State { get; set; }
        public string Postal { get; set; }
        public string Country { get; set; }
        public string DescriptionNotes { get; set; }
        public string JeaProjectName { get; set; }
        public string JeaProjectNumber { get; set; }
        public decimal? XCoordinate { get; set; }
        public decimal? YCoordinate { get; set; }
        public DateTime? DateModifiedG3m { get; set; }
        public DateTime? DateModifiedGis { get; set; }
        public DateTime? DateModifiedWeb { get; set; }
        public DateTime? DateModifiedBz { get; set; }
        public DateTime? DateCreatedBz { get; set; }
        public DateTime? DateCreatedWeb { get; set; }
        public string UserModifiedGis { get; set; }
        public string UserModifiedWeb { get; set; }
        public string UserCreatedWeb { get; set; }
        public string G3mMessage { get; set; }
        public string WaterDistrict { get; set; }
        public string SewerDistrict { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public DateTime? DateCreatedFms { get; set; }
        public DateTime? DateModifiedFms { get; set; }
        public DateTime? DateCreatedGis { get; set; }
        public string UserCreatedGis { get; set; }
        public DateTime? DateCityCodeChg { get; set; }
        public string CityCodeChgFlag { get; set; }
    }
}




