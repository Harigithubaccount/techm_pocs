using System;
using System.Collections.Generic;
using System.Text;

namespace Jea.MasterPremiseApp.PremiseService.Specification.Dto
{
    public class MasterPremiseDto
    {
        public int PremiseId { get; set; }
        public string Address { get; set; }

        // TODO - to be removed out of this DTO
        public string ServicePoints { get; set; } 
    }
}
