namespace BSAF.Models
{    public partial class Transportation
    {
        public int ID { get; set; }

        public int? BeneficiaryID { get; set; }

        public string TypedCode { get; set; }

        public string Other { get; set; }
    }
}
