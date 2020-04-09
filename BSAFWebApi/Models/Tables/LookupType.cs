using System.ComponentModel.DataAnnotations;
namespace BSAF.Models
{

    public class LookupType
    {
        [Key]
        public int LookupId { get; set; }

        public string LookupCode { get; set; }

        public string EnName { get; set; }

        public string DrName { get; set; }

        public string PaName { get; set; }

        public bool IsActive { get; set; }
    }
}
