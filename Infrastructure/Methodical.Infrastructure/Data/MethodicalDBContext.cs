using Methodical.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Methodical.Infrastructure.Data
{
    public partial class MethodicalDBContext : DbContext
    {
        public MethodicalDBContext()
        {
        }

        public MethodicalDBContext(DbContextOptions<MethodicalDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AllImportedUniversitiesPipeline1> AllImportedUniversitiesPipeline1s { get; set; }
        public virtual DbSet<AllImportedUniversitiesPipeline2> AllImportedUniversitiesPipeline2s { get; set; }
        public virtual DbSet<AllImportedUniversitiesRollup> AllImportedUniversitiesRollups { get; set; }
        public virtual DbSet<AllImportedUniversitiesUnion> AllImportedUniversitiesUnions { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<PathSample> PathSamples { get; set; }
        public virtual DbSet<Portfolio> Portfolios { get; set; }
        public virtual DbSet<TimeshighereducationEmergingEconomies2022> TimeshighereducationEmergingEconomies2022s { get; set; }
        public virtual DbSet<TimeshighereducationLatinAmerica2021> TimeshighereducationLatinAmerica2021s { get; set; }
        public virtual DbSet<TimeshighereducationWorld2022> TimeshighereducationWorld2022s { get; set; }
        public virtual DbSet<TimeshighereducationWorldRegional2021> TimeshighereducationWorldRegional2021s { get; set; }
        public virtual DbSet<TimeshighereducationYoungUniversities2022> TimeshighereducationYoungUniversities2022s { get; set; }
        public virtual DbSet<University> Universities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer(System.Environment.GetEnvironmentVariable("MethodicalDBConnection"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AllImportedUniversitiesPipeline1>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("all-imported-universities-pipeline-1");

                entity.Property(e => e.CitationsScore).HasColumnName("citationsScore");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.DetailLink)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("detailLink");

                entity.Property(e => e.IndustryIncomeScore).HasColumnName("industryIncomeScore");

                entity.Property(e => e.InternationalOutlookScore).HasColumnName("internationalOutlookScore");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.ResearchScore).HasColumnName("researchScore");

                entity.Property(e => e.TeachingScore).HasColumnName("teachingScore");
            });

            modelBuilder.Entity<AllImportedUniversitiesPipeline2>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("all-imported-universities-pipeline-2");

                entity.Property(e => e.CitationsScore).HasColumnName("citationsScore");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.DetailLink)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("detailLink");

                entity.Property(e => e.IndustryIncomeScore).HasColumnName("industryIncomeScore");

                entity.Property(e => e.InternationalOutlookScore).HasColumnName("internationalOutlookScore");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.ResearchScore).HasColumnName("researchScore");

                entity.Property(e => e.TeachingScore).HasColumnName("teachingScore");
            });

            modelBuilder.Entity<AllImportedUniversitiesRollup>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("all-imported-universities-rollup");

                entity.Property(e => e.BlendedScore).HasColumnName("blended-score");

                entity.Property(e => e.CitationsScore).HasColumnName("citationsScore");

                entity.Property(e => e.DetailLink)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("detailLink");

                entity.Property(e => e.IndustryIncomeScore).HasColumnName("industryIncomeScore");

                entity.Property(e => e.InternationalOutlookScore).HasColumnName("internationalOutlookScore");

                entity.Property(e => e.Iso3166Alpha2)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ISO-3166-alpha-2");

                entity.Property(e => e.Iso3166Alpha3)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ISO-3166-alpha-3");

                entity.Property(e => e.Iso3166Numeric).HasColumnName("ISO-3166-numeric");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.ResearchScore).HasColumnName("researchScore");

                entity.Property(e => e.TeachingScore).HasColumnName("teachingScore");
            });

            modelBuilder.Entity<AllImportedUniversitiesUnion>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("all-imported-universities-union");

                entity.Property(e => e.CitationsScore)
                    .HasMaxLength(50)
                    .HasColumnName("citationsScore");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.DetailLink)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("detailLink");

                entity.Property(e => e.IndustryIncomeScore)
                    .HasMaxLength(50)
                    .HasColumnName("industryIncomeScore");

                entity.Property(e => e.InternationalOutlookScore)
                    .HasMaxLength(50)
                    .HasColumnName("internationalOutlookScore");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.OverallScore)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("overallScore");

                entity.Property(e => e.Rank)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("rank");

                entity.Property(e => e.ResearchScore)
                    .HasMaxLength(50)
                    .HasColumnName("researchScore");

                entity.Property(e => e.TeachingScore)
                    .HasMaxLength(50)
                    .HasColumnName("teachingScore");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.CountryGuid);

                entity.ToTable("countries");

                entity.ToTable(tb => tb.IsTemporal(ttb =>
                {
                    ttb.UseHistoryTable("countries_history", "dbo");
                    ttb
                        .HasPeriodStart("SysStartTime")
                        .HasColumnName("SysStartTime");
                    ttb
                        .HasPeriodEnd("SysEndTime")
                        .HasColumnName("SysEndTime");
                }
));

                entity.Property(e => e.CountryGuid)
                    .HasColumnName("country-guid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Characters)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("characters")
                    .HasDefaultValueSql("('ascii')");

                entity.Property(e => e.Iso3166Alpha2)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ISO-3166-alpha-2");

                entity.Property(e => e.Iso3166Alpha3)
                    .IsRequired()
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ISO-3166-alpha-3");

                entity.Property(e => e.Iso3166Numeric).HasColumnName("ISO-3166-numeric");

                entity.Property(e => e.Iso6391)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ISO-639-1")
                    .HasDefaultValueSql("('en')");

                entity.Property(e => e.Semantic)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("semantic")
                    .HasDefaultValueSql("('official')");

                entity.Property(e => e.Spelling)
                    .IsRequired()
                    .HasMaxLength(80)
                    .HasColumnName("spelling");
            });

            modelBuilder.Entity<PathSample>(entity =>
            {
                entity.HasKey(e => e.SampleGuid)
                    .HasName("PK_path_samples");

                entity.ToTable("path-samples");

                entity.ToTable(tb => tb.IsTemporal(ttb =>
                {
                    ttb.UseHistoryTable("path-samples_history", "dbo");
                    ttb
                        .HasPeriodStart("SysStartTime")
                        .HasColumnName("SysStartTime");
                    ttb
                        .HasPeriodEnd("SysEndTime")
                        .HasColumnName("SysEndTime");
                }
));

                entity.Property(e => e.SampleGuid)
                    .HasColumnName("sample-guid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CostAllocation)
                    .HasColumnType("money")
                    .HasColumnName("cost-allocation");

                entity.Property(e => e.FromNode).HasColumnName("from-node");

                entity.Property(e => e.PathFingerprint)
                    .HasMaxLength(128)
                    .IsUnicode(false)
                    .HasColumnName("path-fingerprint");

                entity.Property(e => e.PathStrength).HasColumnName("path-strength");

                entity.Property(e => e.TenantGuid)
                    .HasColumnName("tenant-guid")
                    .HasDefaultValueSql("('00000000-0000-0000-0000-000000000001')");

                entity.Property(e => e.ToNode).HasColumnName("to-node");
            });

            modelBuilder.Entity<Portfolio>(entity =>
            {
                entity.HasKey(e => e.PortfolioGuid);

                entity.ToTable("portfolios");

                entity.ToTable(tb => tb.IsTemporal(ttb =>
                {
                    ttb.UseHistoryTable("portfolios_history", "dbo");
                    ttb
                        .HasPeriodStart("SysStartTime")
                        .HasColumnName("SysStartTime");
                    ttb
                        .HasPeriodEnd("SysEndTime")
                        .HasColumnName("SysEndTime");
                }
));

                entity.Property(e => e.PortfolioGuid)
                    .ValueGeneratedNever()
                    .HasColumnName("portfolio-guid");

                entity.Property(e => e.PortfolioCost)
                    .HasColumnType("money")
                    .HasColumnName("portfolio-cost");

                entity.Property(e => e.TenantGuid).HasColumnName("tenant-guid");

                entity.Property(e => e.UserLabel)
                    .HasMaxLength(255)
                    .HasColumnName("user-label");
            });

            modelBuilder.Entity<TimeshighereducationEmergingEconomies2022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("timeshighereducation-emerging-economies-2022");

                entity.Property(e => e.CitationsScore)
                    .HasMaxLength(50)
                    .HasColumnName("citationsScore");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.DetailLink)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("detailLink");

                entity.Property(e => e.IndustryIncomeScore)
                    .HasMaxLength(50)
                    .HasColumnName("industryIncomeScore");

                entity.Property(e => e.InternationalOutlookScore)
                    .HasMaxLength(50)
                    .HasColumnName("internationalOutlookScore");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.OverallScore)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("overallScore");

                entity.Property(e => e.Rank)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("rank");

                entity.Property(e => e.ResearchScore)
                    .HasMaxLength(50)
                    .HasColumnName("researchScore");

                entity.Property(e => e.TeachingScore)
                    .HasMaxLength(50)
                    .HasColumnName("teachingScore");
            });

            modelBuilder.Entity<TimeshighereducationLatinAmerica2021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("timeshighereducation-latin-america-2021");

                entity.Property(e => e.CitationsScore)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("citationsScore");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.DetailLink)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("detailLink");

                entity.Property(e => e.IndustryIncomeScore)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("industryIncomeScore");

                entity.Property(e => e.InternationalOutlookScore)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("internationalOutlookScore");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.OverallScore)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("overallScore");

                entity.Property(e => e.Rank)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("rank");

                entity.Property(e => e.ResearchScore)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("researchScore");

                entity.Property(e => e.TeachingScore)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("teachingScore");
            });

            modelBuilder.Entity<TimeshighereducationWorld2022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("timeshighereducation-world-2022");

                entity.Property(e => e.CitationsScore)
                    .HasMaxLength(50)
                    .HasColumnName("citationsScore");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.DetailLink)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("detailLink");

                entity.Property(e => e.IndustryIncomeScore)
                    .HasMaxLength(50)
                    .HasColumnName("industryIncomeScore");

                entity.Property(e => e.InternationalOutlookScore)
                    .HasMaxLength(50)
                    .HasColumnName("internationalOutlookScore");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.OverallScore)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("overallScore");

                entity.Property(e => e.Rank)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("rank");

                entity.Property(e => e.ResearchScore)
                    .HasMaxLength(50)
                    .HasColumnName("researchScore");

                entity.Property(e => e.TeachingScore)
                    .HasMaxLength(50)
                    .HasColumnName("teachingScore");
            });

            modelBuilder.Entity<TimeshighereducationWorldRegional2021>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("timeshighereducation-world-regional-2021");

                entity.Property(e => e.CitationsScore)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("citationsScore");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.DetailLink)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("detailLink");

                entity.Property(e => e.IndustryIncomeScore)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("industryIncomeScore");

                entity.Property(e => e.InternationalOutlookScore)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("internationalOutlookScore");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.OverallScore)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("overallScore");

                entity.Property(e => e.Rank)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("rank");

                entity.Property(e => e.ResearchScore)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("researchScore");

                entity.Property(e => e.TeachingScore)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("teachingScore");
            });

            modelBuilder.Entity<TimeshighereducationYoungUniversities2022>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("timeshighereducation-young-universities-2022");

                entity.Property(e => e.CitationsScore)
                    .HasMaxLength(50)
                    .HasColumnName("citationsScore");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.DetailLink)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("detailLink");

                entity.Property(e => e.IndustryIncomeScore)
                    .HasMaxLength(50)
                    .HasColumnName("industryIncomeScore");

                entity.Property(e => e.InternationalOutlookScore)
                    .HasMaxLength(50)
                    .HasColumnName("internationalOutlookScore");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.OverallScore)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("overallScore");

                entity.Property(e => e.Rank)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("rank");

                entity.Property(e => e.ResearchScore)
                    .HasMaxLength(50)
                    .HasColumnName("researchScore");

                entity.Property(e => e.TeachingScore)
                    .HasMaxLength(50)
                    .HasColumnName("teachingScore");
            });

            modelBuilder.Entity<University>(entity =>
            {
                entity.HasKey(e => e.UniversityGuid);

                entity.ToTable("universities");

                entity.ToTable(tb => tb.IsTemporal(ttb =>
                {
                    ttb.UseHistoryTable("universities_history", "dbo");
                    ttb
                        .HasPeriodStart("SysStartTime")
                        .HasColumnName("SysStartTime");
                    ttb
                        .HasPeriodEnd("SysEndTime")
                        .HasColumnName("SysEndTime");
                }
));

                entity.Property(e => e.UniversityGuid)
                    .HasColumnName("university-guid")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.AuthorityUrl)
                    .HasMaxLength(320)
                    .HasColumnName("authority-url");

                entity.Property(e => e.Iso6391)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("ISO-639-1");

                entity.Property(e => e.Locale)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("locale")
                    .HasDefaultValueSql("('en')");

                entity.Property(e => e.SiteUrl)
                    .HasMaxLength(320)
                    .HasColumnName("site-url");

                entity.Property(e => e.Spelling)
                    .IsRequired()
                    .HasMaxLength(160)
                    .HasColumnName("spelling");

                entity.Property(e => e.ThecitationsScore).HasColumnName("THEcitationsScore");

                entity.Property(e => e.TheindustryIncomeScore).HasColumnName("THEindustryIncomeScore");

                entity.Property(e => e.TheinternationalOutlookScore).HasColumnName("THEinternationalOutlookScore");

                entity.Property(e => e.TheresearchScore).HasColumnName("THEresearchScore");

                entity.Property(e => e.TheteachingScore).HasColumnName("THEteachingScore");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    }
}
