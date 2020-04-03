using System;
using System.ComponentModel.DataAnnotations;
namespace BSAF.Models
{


    public partial class BenefitedFromOrg
    {
        public int ID { get; set; }

        public int BeneficiaryID { get; set; }

        public DateTime Date { get; set; }

        public string ProvinceCode { get; set; }

        public int? DistrictID { get; set; }

        public string Village { get; set; }

        [Required]
        public string OrgCode { get; set; }

        public string AssistanceProvided { get; set; }
    }
}
