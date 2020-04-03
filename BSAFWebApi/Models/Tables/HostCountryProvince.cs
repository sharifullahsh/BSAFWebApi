using System.ComponentModel.DataAnnotations;
namespace BSAF.Models
{




    public partial class HostCountryProvince
    {
        [Key]
        public int ProvinceId { get; set; }

        public string CountryCode { get; set; }

        public string EnName { get; set; }

        public string DrName { get; set; }

        public string PaName { get; set; }

        public bool IsActive { get; set; }
    }
}
