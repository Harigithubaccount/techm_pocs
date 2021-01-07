using System;
using System.Collections.Generic;

#nullable disable

namespace Jea.MasterPremiseApp.PremiseService.Specification.Model
{
    public partial class MasterServicePoint
    {
        public int ServicePntId { get; set; }
        public int PremiseId { get; set; }
        public string CisPremId { get; set; }
        public string SpId { get; set; }
        public string SpTypeCd { get; set; }
        public string SpStatusFlg { get; set; }
        public DateTime? InstallDt { get; set; }
        public string SpSrcStatusFlg { get; set; }
        public string DescriptionNotes { get; set; }
        public DateTime? DateModifiedG3m { get; set; }
        public DateTime? DateModifiedGis { get; set; }
        public DateTime? DateModifiedWeb { get; set; }
        public DateTime? DateCreatedBz { get; set; }
        public DateTime? DateCreatedWeb { get; set; }
        public string UserModifiedGis { get; set; }
        public string UserModifiedWeb { get; set; }
        public string UserCreatedWeb { get; set; }
        public string G3mMessage { get; set; }
        public string SvcTypeCd { get; set; }
        public decimal? TransformerId { get; set; }
        public string WaterDistrict { get; set; }
        public string SewerDistrict { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public decimal? XCoordinate { get; set; }
        public decimal? YCoordinate { get; set; }
        public int? GisOwnerId { get; set; }
        public string TransformerAddress { get; set; }
        public DateTime? DateCreatedFms { get; set; }
        public DateTime? DateModifiedFms { get; set; }
        public DateTime? DateCreatedGis { get; set; }
        public string UserCreatedGis { get; set; }
        public decimal? WaterMainOid { get; set; }
        public decimal? WaterLateralOid { get; set; }
        public decimal? SewerMainOid { get; set; }
        public decimal? SewerLateralOid { get; set; }

        public virtual MasterPremise Premise { get; set; }
    }
}
