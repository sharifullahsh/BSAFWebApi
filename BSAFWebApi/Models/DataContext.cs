using BSAF.Models;
using BSAFWebApi.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BSAFWebApi.Models
{
    public class DataContext: IdentityDbContext<User,Role,int,
        IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>,
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Beneficiary> Beneficiaries { get; set; }
        public DbSet<BenefitedFromOrg> BenefitedFromOrgs { get; set; }
        public DbSet<BorderCrossingPoint> BorderCrossingPoints { get; set; }
        public DbSet<BroughtItem> BroughtItems { get; set; }
        public DbSet<Determination> Determinations { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<HostCountryDistrict> HostCountryDistricts { get; set; }
        public DbSet<HostCountryProvince> HostCountryProvinces { get; set; }
        public DbSet<HostCountrySchool> HostCountrySchools { get; set; }
        public DbSet<Individual> Individuals { get; set; }
        public DbSet<LivelihoodEmpNeed> LivelihoodEmpNeeds { get; set; }
        public DbSet<LookupType> LookupTypes { get; set; }
        public DbSet<LookupValue> LookupValues { get; set; }
        public DbSet<MainConcern> MainConcerns { get; set; }
        public DbSet<MoneySource> MoneySources { get; set; }
        public DbSet<NeedTool> NeedTools { get; set; }
        public DbSet<PostArrivalNeed> PostArrivalNeeds { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<PSN> PSNs { get; set; }
        public DbSet<Transportation> Transportations { get; set; }
        public DbSet<ReturnReason> ReturnReasons { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
