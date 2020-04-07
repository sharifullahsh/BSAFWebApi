using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BSAFWebApi.Migrations
{
    public partial class AddFieldtoIdentityAddRelationtoTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    LastActive = table.Column<DateTime>(nullable: false),
                    StationCode = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Beneficiaries",
                columns: table => new
                {
                    BeneficiaryID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GUID = table.Column<Guid>(nullable: false),
                    ScreeningDate = table.Column<DateTime>(nullable: false),
                    ProvinceBCP = table.Column<string>(nullable: true),
                    BorderPoint = table.Column<string>(nullable: true),
                    BeneficiaryType = table.Column<string>(nullable: true),
                    ReturnStatus = table.Column<string>(nullable: true),
                    OriginProvince = table.Column<string>(nullable: true),
                    OriginDistrict = table.Column<int>(nullable: true),
                    OriginVillage = table.Column<string>(nullable: true),
                    ReturnProvince = table.Column<string>(nullable: true),
                    ReturnDistrict = table.Column<int>(nullable: true),
                    ReturnVillage = table.Column<string>(nullable: true),
                    LeavingReason1 = table.Column<string>(nullable: true),
                    LeavingReason1Other = table.Column<string>(nullable: true),
                    LeavingReason2 = table.Column<string>(nullable: true),
                    LeavingReason2Other = table.Column<string>(nullable: true),
                    LeavingReason3 = table.Column<string>(nullable: true),
                    LeavingReason3Other = table.Column<string>(nullable: true),
                    OwnHouse = table.Column<bool>(nullable: true),
                    WhereWillLive = table.Column<string>(nullable: true),
                    RentPayForAccom = table.Column<int>(nullable: true),
                    RentPayCurrency = table.Column<string>(nullable: true),
                    AllowForJob = table.Column<bool>(nullable: true),
                    CountryOfExile = table.Column<string>(nullable: true),
                    CountryOfExilOther = table.Column<string>(nullable: true),
                    BeforReturnProvince = table.Column<int>(nullable: true),
                    BeforReturnDistrictID = table.Column<int>(nullable: true),
                    BeforReturnRemarks = table.Column<string>(nullable: true),
                    FamilyMemStayedBehind = table.Column<bool>(nullable: true),
                    FamilyMemStayedBehindNo = table.Column<int>(nullable: true),
                    LengthOfStayYears = table.Column<int>(nullable: true),
                    LengthOfStayMonths = table.Column<int>(nullable: true),
                    LengthOfStayDays = table.Column<int>(nullable: true),
                    WouldYouReturn = table.Column<bool>(nullable: true),
                    HaveFamilyBenefited = table.Column<bool>(nullable: true),
                    TransportationDate = table.Column<DateTime>(nullable: false),
                    TransportationInfo = table.Column<string>(nullable: true),
                    TransportAccompaniedBy = table.Column<string>(nullable: true),
                    TransportAccomByNo = table.Column<string>(nullable: true),
                    TopNeed1 = table.Column<string>(nullable: true),
                    TopNeed1Other = table.Column<string>(nullable: true),
                    TopNeed2 = table.Column<string>(nullable: true),
                    TopNeed2Other = table.Column<string>(nullable: true),
                    TopNeed3 = table.Column<string>(nullable: true),
                    TopNeed3Other = table.Column<string>(nullable: true),
                    IntendToDo = table.Column<string>(nullable: true),
                    IntendToReturnToHostReason = table.Column<string>(nullable: true),
                    ProfessionInHostCountry = table.Column<string>(nullable: true),
                    ProfessionInHostCountryOther = table.Column<string>(nullable: true),
                    HoHCanReadWrite = table.Column<bool>(nullable: true),
                    HoHEducationLevel = table.Column<string>(nullable: true),
                    HoHEducationLevelOther = table.Column<string>(nullable: true),
                    NumHHHaveTaskira = table.Column<int>(nullable: true),
                    NumHHHavePassport = table.Column<int>(nullable: true),
                    NumHHHaveDocOther = table.Column<int>(nullable: true),
                    DoHaveSecureLivelihood = table.Column<bool>(nullable: true),
                    DidChildrenGoToSchoole = table.Column<bool>(nullable: true),
                    NumChildrenAttendedSchoole = table.Column<int>(nullable: true),
                    InsertedBy = table.Column<string>(nullable: true),
                    InsertedDate = table.Column<DateTime>(nullable: false),
                    LastUpdatedBy = table.Column<string>(nullable: true),
                    LastUpdatedDate = table.Column<DateTime>(nullable: true),
                    IsSubmitted = table.Column<bool>(nullable: false),
                    IsCardIssued = table.Column<bool>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beneficiaries", x => x.BeneficiaryID);
                });

            migrationBuilder.CreateTable(
                name: "BorderCrossingPoints",
                columns: table => new
                {
                    BCPId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BCPCode = table.Column<string>(nullable: true),
                    VillageId = table.Column<int>(nullable: false),
                    DistrictCode = table.Column<string>(nullable: true),
                    ProvinceCode = table.Column<string>(nullable: true),
                    NeighCountryCode = table.Column<string>(nullable: true),
                    EnName = table.Column<string>(nullable: true),
                    DrName = table.Column<string>(nullable: true),
                    PaName = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BorderCrossingPoints", x => x.BCPId);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    DistrictId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DistrictCode = table.Column<int>(nullable: false),
                    ProvinceCode = table.Column<string>(nullable: true),
                    EnName = table.Column<string>(nullable: true),
                    DrName = table.Column<string>(nullable: true),
                    PaName = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.DistrictId);
                });

            migrationBuilder.CreateTable(
                name: "HostCountryDistricts",
                columns: table => new
                {
                    DistrictId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProvinceId = table.Column<int>(nullable: false),
                    EnName = table.Column<string>(nullable: true),
                    DrName = table.Column<string>(nullable: true),
                    PaName = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HostCountryDistricts", x => x.DistrictId);
                });

            migrationBuilder.CreateTable(
                name: "HostCountryProvinces",
                columns: table => new
                {
                    ProvinceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CountryCode = table.Column<string>(nullable: true),
                    EnName = table.Column<string>(nullable: true),
                    DrName = table.Column<string>(nullable: true),
                    PaName = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HostCountryProvinces", x => x.ProvinceId);
                });

            migrationBuilder.CreateTable(
                name: "LookupTypes",
                columns: table => new
                {
                    LookupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LookupCode = table.Column<string>(nullable: true),
                    EnName = table.Column<string>(nullable: true),
                    DrName = table.Column<string>(nullable: true),
                    PaName = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupTypes", x => x.LookupId);
                });

            migrationBuilder.CreateTable(
                name: "LookupValues",
                columns: table => new
                {
                    ValueId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LookupCode = table.Column<string>(nullable: true),
                    ValueCode = table.Column<string>(nullable: true),
                    EnName = table.Column<string>(nullable: true),
                    DrName = table.Column<string>(nullable: true),
                    PaName = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookupValues", x => x.ValueId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false),
                    UserId1 = table.Column<int>(nullable: true),
                    RoleId1 = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId1",
                        column: x => x.RoleId1,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId1",
                        column: x => x.UserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BenefitedFromOrgs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeneficiaryID = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    ProvinceCode = table.Column<string>(nullable: true),
                    DistrictID = table.Column<int>(nullable: true),
                    Village = table.Column<string>(nullable: true),
                    OrgCode = table.Column<string>(nullable: false),
                    AssistanceProvided = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BenefitedFromOrgs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BenefitedFromOrgs_Beneficiaries_BeneficiaryID",
                        column: x => x.BeneficiaryID,
                        principalTable: "Beneficiaries",
                        principalColumn: "BeneficiaryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BroughtItems",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeneficiaryID = table.Column<int>(nullable: true),
                    ItemCode = table.Column<string>(nullable: true),
                    ItemOther = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BroughtItems", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BroughtItems_Beneficiaries_BeneficiaryID",
                        column: x => x.BeneficiaryID,
                        principalTable: "Beneficiaries",
                        principalColumn: "BeneficiaryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Determinations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeneficiaryID = table.Column<int>(nullable: true),
                    DeterminationCode = table.Column<string>(nullable: true),
                    AnswerCode = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Determinations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Determinations_Beneficiaries_BeneficiaryID",
                        column: x => x.BeneficiaryID,
                        principalTable: "Beneficiaries",
                        principalColumn: "BeneficiaryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HostCountrySchool",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeneficiaryID = table.Column<int>(nullable: false),
                    SchoolTypeCode = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HostCountrySchool", x => x.ID);
                    table.ForeignKey(
                        name: "FK_HostCountrySchool_Beneficiaries_BeneficiaryID",
                        column: x => x.BeneficiaryID,
                        principalTable: "Beneficiaries",
                        principalColumn: "BeneficiaryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Individuals",
                columns: table => new
                {
                    IndividualID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeneficiaryID = table.Column<int>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    DrName = table.Column<string>(nullable: true),
                    FName = table.Column<string>(nullable: true),
                    DrFName = table.Column<string>(nullable: true),
                    GenderCode = table.Column<string>(nullable: true),
                    MaritalStatusCode = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: true),
                    IDTypeCode = table.Column<string>(nullable: true),
                    IDNo = table.Column<string>(nullable: true),
                    RelationshipCode = table.Column<string>(nullable: true),
                    ContactNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individuals", x => x.IndividualID);
                    table.ForeignKey(
                        name: "FK_Individuals_Beneficiaries_BeneficiaryID",
                        column: x => x.BeneficiaryID,
                        principalTable: "Beneficiaries",
                        principalColumn: "BeneficiaryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LivelihoodEmpNeeds",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NeedCode = table.Column<string>(nullable: false),
                    BeneficiaryID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LivelihoodEmpNeeds", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LivelihoodEmpNeeds_Beneficiaries_BeneficiaryID",
                        column: x => x.BeneficiaryID,
                        principalTable: "Beneficiaries",
                        principalColumn: "BeneficiaryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MainConcerns",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeneficiaryID = table.Column<int>(nullable: false),
                    ConcernCode = table.Column<string>(nullable: false),
                    Other = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainConcerns", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MainConcerns_Beneficiaries_BeneficiaryID",
                        column: x => x.BeneficiaryID,
                        principalTable: "Beneficiaries",
                        principalColumn: "BeneficiaryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoneySources",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeneficiaryID = table.Column<int>(nullable: true),
                    MoneySourceCode = table.Column<string>(nullable: true),
                    MoneySourceOther = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoneySources", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MoneySources_Beneficiaries_BeneficiaryID",
                        column: x => x.BeneficiaryID,
                        principalTable: "Beneficiaries",
                        principalColumn: "BeneficiaryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "NeedTools",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeneficiaryID = table.Column<int>(nullable: false),
                    ToolCode = table.Column<string>(nullable: false),
                    Other = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NeedTools", x => x.ID);
                    table.ForeignKey(
                        name: "FK_NeedTools_Beneficiaries_BeneficiaryID",
                        column: x => x.BeneficiaryID,
                        principalTable: "Beneficiaries",
                        principalColumn: "BeneficiaryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostArrivalNeeds",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeneficiaryID = table.Column<int>(nullable: true),
                    NeedCode = table.Column<string>(nullable: true),
                    Provided = table.Column<bool>(nullable: true),
                    ProvidedDate = table.Column<DateTime>(nullable: false),
                    Comment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostArrivalNeeds", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PostArrivalNeeds_Beneficiaries_BeneficiaryID",
                        column: x => x.BeneficiaryID,
                        principalTable: "Beneficiaries",
                        principalColumn: "BeneficiaryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    ProvinceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ProvinceCode = table.Column<string>(nullable: true),
                    MapCode = table.Column<string>(nullable: true),
                    EnName = table.Column<string>(nullable: true),
                    DrName = table.Column<string>(nullable: true),
                    PaName = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    BeneficiaryID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ProvinceId);
                    table.ForeignKey(
                        name: "FK_Provinces_Beneficiaries_BeneficiaryID",
                        column: x => x.BeneficiaryID,
                        principalTable: "Beneficiaries",
                        principalColumn: "BeneficiaryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PSN",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeneficiaryID = table.Column<int>(nullable: true),
                    PSNCode = table.Column<string>(nullable: true),
                    PSNOther = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PSN", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PSN_Beneficiaries_BeneficiaryID",
                        column: x => x.BeneficiaryID,
                        principalTable: "Beneficiaries",
                        principalColumn: "BeneficiaryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ReturnReasons",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeneficiaryID = table.Column<int>(nullable: false),
                    ReasonCode = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReturnReasons", x => x.ID);
                    table.ForeignKey(
                        name: "FK_ReturnReasons_Beneficiaries_BeneficiaryID",
                        column: x => x.BeneficiaryID,
                        principalTable: "Beneficiaries",
                        principalColumn: "BeneficiaryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transportations",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeneficiaryID = table.Column<int>(nullable: true),
                    TypedCode = table.Column<string>(nullable: true),
                    Other = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transportations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Transportations_Beneficiaries_BeneficiaryID",
                        column: x => x.BeneficiaryID,
                        principalTable: "Beneficiaries",
                        principalColumn: "BeneficiaryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId1",
                table: "AspNetUserRoles",
                column: "RoleId1");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId1",
                table: "AspNetUserRoles",
                column: "UserId1");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BenefitedFromOrgs_BeneficiaryID",
                table: "BenefitedFromOrgs",
                column: "BeneficiaryID");

            migrationBuilder.CreateIndex(
                name: "IX_BroughtItems_BeneficiaryID",
                table: "BroughtItems",
                column: "BeneficiaryID");

            migrationBuilder.CreateIndex(
                name: "IX_Determinations_BeneficiaryID",
                table: "Determinations",
                column: "BeneficiaryID");

            migrationBuilder.CreateIndex(
                name: "IX_HostCountrySchool_BeneficiaryID",
                table: "HostCountrySchool",
                column: "BeneficiaryID");

            migrationBuilder.CreateIndex(
                name: "IX_Individuals_BeneficiaryID",
                table: "Individuals",
                column: "BeneficiaryID");

            migrationBuilder.CreateIndex(
                name: "IX_LivelihoodEmpNeeds_BeneficiaryID",
                table: "LivelihoodEmpNeeds",
                column: "BeneficiaryID");

            migrationBuilder.CreateIndex(
                name: "IX_MainConcerns_BeneficiaryID",
                table: "MainConcerns",
                column: "BeneficiaryID");

            migrationBuilder.CreateIndex(
                name: "IX_MoneySources_BeneficiaryID",
                table: "MoneySources",
                column: "BeneficiaryID");

            migrationBuilder.CreateIndex(
                name: "IX_NeedTools_BeneficiaryID",
                table: "NeedTools",
                column: "BeneficiaryID");

            migrationBuilder.CreateIndex(
                name: "IX_PostArrivalNeeds_BeneficiaryID",
                table: "PostArrivalNeeds",
                column: "BeneficiaryID");

            migrationBuilder.CreateIndex(
                name: "IX_Provinces_BeneficiaryID",
                table: "Provinces",
                column: "BeneficiaryID");

            migrationBuilder.CreateIndex(
                name: "IX_PSN_BeneficiaryID",
                table: "PSN",
                column: "BeneficiaryID");

            migrationBuilder.CreateIndex(
                name: "IX_ReturnReasons_BeneficiaryID",
                table: "ReturnReasons",
                column: "BeneficiaryID");

            migrationBuilder.CreateIndex(
                name: "IX_Transportations_BeneficiaryID",
                table: "Transportations",
                column: "BeneficiaryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BenefitedFromOrgs");

            migrationBuilder.DropTable(
                name: "BorderCrossingPoints");

            migrationBuilder.DropTable(
                name: "BroughtItems");

            migrationBuilder.DropTable(
                name: "Determinations");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "HostCountryDistricts");

            migrationBuilder.DropTable(
                name: "HostCountryProvinces");

            migrationBuilder.DropTable(
                name: "HostCountrySchool");

            migrationBuilder.DropTable(
                name: "Individuals");

            migrationBuilder.DropTable(
                name: "LivelihoodEmpNeeds");

            migrationBuilder.DropTable(
                name: "LookupTypes");

            migrationBuilder.DropTable(
                name: "LookupValues");

            migrationBuilder.DropTable(
                name: "MainConcerns");

            migrationBuilder.DropTable(
                name: "MoneySources");

            migrationBuilder.DropTable(
                name: "NeedTools");

            migrationBuilder.DropTable(
                name: "PostArrivalNeeds");

            migrationBuilder.DropTable(
                name: "Provinces");

            migrationBuilder.DropTable(
                name: "PSN");

            migrationBuilder.DropTable(
                name: "ReturnReasons");

            migrationBuilder.DropTable(
                name: "Transportations");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Beneficiaries");
        }
    }
}
