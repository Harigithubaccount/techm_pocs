using System;
using System.Collections.Generic;

#nullable disable

namespace Jea.MasterPremiseApp.PremiseService.Specification.Model
{
    public partial class UnitToSptypeXref
    {
        public int UnsptpxrefId { get; set; }
        public string UnitCode { get; set; }
        public string SpType { get; set; }
        public string DescriptionValue { get; set; }
        public string SvcType { get; set; }
        public string SpTypeProfCd { get; set; }
        public string AllowMr { get; set; }
        public DateTime? DateModifiedWeb { get; set; }
        public DateTime? DateCreatedWeb { get; set; }
        public string UserCreatedWeb { get; set; }
        public string UserModifiedWeb { get; set; }
    }
}
