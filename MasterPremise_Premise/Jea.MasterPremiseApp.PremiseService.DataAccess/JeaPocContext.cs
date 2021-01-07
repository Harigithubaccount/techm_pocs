using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Jea.MasterPremiseApp.PremiseService.Specification.Model;

#nullable disable

namespace Jea.MasterPremiseApp.PremiseService.DataAccess
{
    public partial class JeaPocContext : DbContext
    {
        public JeaPocContext()
        {
        }

        public JeaPocContext(DbContextOptions<JeaPocContext> options)
            : base(options)
        {
        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<CityCode> CityCodes { get; set; }
        public virtual DbSet<County> Counties { get; set; }
        public virtual DbSet<MasterPremise> MasterPremises { get; set; }
        public virtual DbSet<MasterServicePoint> MasterServicePoints { get; set; }
        public virtual DbSet<StreetType> StreetTypes { get; set; }
        public virtual DbSet<UnitToSptypeXref> UnitnoSptypeXrefs { get; set; }
        public virtual DbSet<ValidStreetName> ValidStreetNames { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=INHYIZLP06901\\MSSQLSERVER2016;Initial Catalog=JeaPoc;Integrated Security=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<City>(entity =>
            {
                entity.ToTable("CITY");

                entity.Property(e => e.CityId).HasColumnName("CITY_ID");

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("CITY_NAME");
            });

            modelBuilder.Entity<CityCode>(entity =>
            {
                entity.ToTable("CITY_CODE");

                entity.Property(e => e.CityCodeId)
                    .HasMaxLength(2)
                    .HasColumnName("CITY_CODE_ID")
                    .IsFixedLength(true);

                entity.Property(e => e.CityCodeName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CITY_CODE_NAME");
            });

            modelBuilder.Entity<County>(entity =>
            {
                entity.ToTable("COUNTY");

                entity.Property(e => e.CountyId).HasColumnName("COUNTY_ID");

                entity.Property(e => e.CountyName)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("COUNTY_NAME");
            });

            modelBuilder.Entity<MasterPremise>(entity =>
            {
                entity.HasKey(e => e.PremiseId);

                entity.ToTable("MASTER_PREMISE");

                entity.Property(e => e.PremiseId).HasColumnName("PREMISE_ID");

                entity.Property(e => e.Address1)
                    .HasMaxLength(64)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS1");

                entity.Property(e => e.BzId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("BZ_ID");

                entity.Property(e => e.CisPremId)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CIS_PREM_ID");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CITY");

                entity.Property(e => e.CityCode)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("CITY_CODE");

                entity.Property(e => e.CityCodeChgFlag)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("CITY_CODE_CHG_FLAG");

                entity.Property(e => e.Country)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY");

                entity.Property(e => e.County)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("COUNTY");

                entity.Property(e => e.DateCityCodeChg)
                    .HasColumnType("date")
                    .HasColumnName("DATE_CITY_CODE_CHG");

                entity.Property(e => e.DateCreatedBz)
                    .HasColumnType("date")
                    .HasColumnName("DATE_CREATED_BZ");

                entity.Property(e => e.DateCreatedFms)
                    .HasColumnType("date")
                    .HasColumnName("DATE_CREATED_FMS");

                entity.Property(e => e.DateCreatedGis)
                    .HasColumnType("date")
                    .HasColumnName("DATE_CREATED_GIS");

                entity.Property(e => e.DateCreatedWeb)
                    .HasColumnType("date")
                    .HasColumnName("DATE_CREATED_WEB");

                entity.Property(e => e.DateModifiedBz)
                    .HasColumnType("date")
                    .HasColumnName("DATE_MODIFIED_BZ");

                entity.Property(e => e.DateModifiedFms)
                    .HasColumnType("date")
                    .HasColumnName("DATE_MODIFIED_FMS");

                entity.Property(e => e.DateModifiedG3m)
                    .HasColumnType("date")
                    .HasColumnName("DATE_MODIFIED_G3M");

                entity.Property(e => e.DateModifiedGis)
                    .HasColumnType("date")
                    .HasColumnName("DATE_MODIFIED_GIS");

                entity.Property(e => e.DateModifiedWeb)
                    .HasColumnType("date")
                    .HasColumnName("DATE_MODIFIED_WEB");

                entity.Property(e => e.DescriptionNotes)
                    .HasMaxLength(240)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION_NOTES");

                entity.Property(e => e.G3mMessage)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("G3M_MESSAGE");

                entity.Property(e => e.GisOwnerId).HasColumnName("GIS_OWNER_ID");

                entity.Property(e => e.GisStreetName)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("GIS_STREET_NAME");

                entity.Property(e => e.HouseNo)
                    .IsRequired()
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("HOUSE_NO");

                entity.Property(e => e.InactiveDate)
                    .HasColumnType("date")
                    .HasColumnName("INACTIVE_DATE");

                entity.Property(e => e.InactiveFlag)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("INACTIVE_FLAG");

                entity.Property(e => e.JeaProjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("JEA_PROJECT_NAME");

                entity.Property(e => e.JeaProjectNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("JEA_PROJECT_NUMBER");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LATITUDE");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("LONGITUDE");

                entity.Property(e => e.MapNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MAP_NUMBER");

                entity.Property(e => e.Postal)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("POSTAL");

                entity.Property(e => e.PremTypeCd)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("PREM_TYPE_CD");

                entity.Property(e => e.PrevStreetCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PREV_STREET_CODE");

                entity.Property(e => e.SewerDistrict)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("SEWER_DISTRICT");

                entity.Property(e => e.State)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("STATE");

                entity.Property(e => e.StreetCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("STREET_CODE");

                entity.Property(e => e.StreetDir)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("STREET_DIR");

                entity.Property(e => e.StreetName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("STREET_NAME");

                entity.Property(e => e.StreetType)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("STREET_TYPE");

                entity.Property(e => e.UnitNo)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("UNIT_NO");

                entity.Property(e => e.UserCreatedGis)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USER_CREATED_GIS");

                entity.Property(e => e.UserCreatedWeb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USER_CREATED_WEB");

                entity.Property(e => e.UserModifiedGis)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USER_MODIFIED_GIS");

                entity.Property(e => e.UserModifiedWeb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USER_MODIFIED_WEB");

                entity.Property(e => e.WaterDistrict)
                    .HasMaxLength(36)
                    .IsUnicode(false)
                    .HasColumnName("WATER_DISTRICT");

                entity.Property(e => e.XCoordinate)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("X_COORDINATE");

                entity.Property(e => e.YCoordinate)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("Y_COORDINATE");
            });

            modelBuilder.Entity<MasterServicePoint>(entity =>
            {
                entity.HasKey(e => e.ServicePntId);

                entity.ToTable("MASTER_SERVICE_POINT");

                entity.Property(e => e.ServicePntId).HasColumnName("SERVICE_PNT_ID");

                entity.Property(e => e.CisPremId)
                    .HasMaxLength(10)
                    .HasColumnName("CIS_PREM_ID");

                entity.Property(e => e.DateCreatedBz)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATED_BZ");

                entity.Property(e => e.DateCreatedFms)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATED_FMS");

                entity.Property(e => e.DateCreatedGis)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATED_GIS");

                entity.Property(e => e.DateCreatedWeb)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATED_WEB");

                entity.Property(e => e.DateModifiedFms)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_MODIFIED_FMS");

                entity.Property(e => e.DateModifiedG3m)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_MODIFIED_G3M");

                entity.Property(e => e.DateModifiedGis)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_MODIFIED_GIS");

                entity.Property(e => e.DateModifiedWeb)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_MODIFIED_WEB");

                entity.Property(e => e.DescriptionNotes)
                    .HasMaxLength(240)
                    .HasColumnName("DESCRIPTION_NOTES");

                entity.Property(e => e.G3mMessage)
                    .HasMaxLength(100)
                    .HasColumnName("G3M_MESSAGE");

                entity.Property(e => e.GisOwnerId).HasColumnName("GIS_OWNER_ID");

                entity.Property(e => e.InstallDt)
                    .HasColumnType("datetime")
                    .HasColumnName("INSTALL_DT");

                entity.Property(e => e.Latitude)
                    .HasMaxLength(20)
                    .HasColumnName("LATITUDE");

                entity.Property(e => e.Longitude)
                    .HasMaxLength(20)
                    .HasColumnName("LONGITUDE");

                entity.Property(e => e.PremiseId).HasColumnName("PREMISE_ID");

                entity.Property(e => e.SewerDistrict)
                    .HasMaxLength(36)
                    .HasColumnName("SEWER_DISTRICT");

                entity.Property(e => e.SewerLateralOid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("SEWER_LATERAL_OID");

                entity.Property(e => e.SewerMainOid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("SEWER_MAIN_OID");

                entity.Property(e => e.SpId)
                    .HasMaxLength(10)
                    .HasColumnName("SP_ID");

                entity.Property(e => e.SpSrcStatusFlg)
                    .HasMaxLength(2)
                    .HasColumnName("SP_SRC_STATUS_FLG");

                entity.Property(e => e.SpStatusFlg)
                    .HasMaxLength(2)
                    .HasColumnName("SP_STATUS_FLG");

                entity.Property(e => e.SpTypeCd)
                    .HasMaxLength(8)
                    .HasColumnName("SP_TYPE_CD");

                entity.Property(e => e.SvcTypeCd)
                    .HasMaxLength(2)
                    .HasColumnName("SVC_TYPE_CD");

                entity.Property(e => e.TransformerAddress)
                    .HasMaxLength(40)
                    .HasColumnName("TRANSFORMER_ADDRESS");

                entity.Property(e => e.TransformerId)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("TRANSFORMER_ID");

                entity.Property(e => e.UserCreatedGis)
                    .HasMaxLength(10)
                    .HasColumnName("USER_CREATED_GIS");

                entity.Property(e => e.UserCreatedWeb)
                    .HasMaxLength(10)
                    .HasColumnName("USER_CREATED_WEB");

                entity.Property(e => e.UserModifiedGis)
                    .HasMaxLength(10)
                    .HasColumnName("USER_MODIFIED_GIS");

                entity.Property(e => e.UserModifiedWeb)
                    .HasMaxLength(10)
                    .HasColumnName("USER_MODIFIED_WEB");

                entity.Property(e => e.WaterDistrict)
                    .HasMaxLength(36)
                    .HasColumnName("WATER_DISTRICT");

                entity.Property(e => e.WaterLateralOid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("WATER_LATERAL_OID");

                entity.Property(e => e.WaterMainOid)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("WATER_MAIN_OID");

                entity.Property(e => e.XCoordinate)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("X_COORDINATE");

                entity.Property(e => e.YCoordinate)
                    .HasColumnType("decimal(10, 0)")
                    .HasColumnName("Y_COORDINATE");

                entity.HasOne(d => d.Premise)
                    .WithMany(p => p.MasterServicePoints)
                    .HasForeignKey(d => d.PremiseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MASTER_SERVICE_POINT_MASTER_PREMISE");
            });

            modelBuilder.Entity<StreetType>(entity =>
            {
                entity.ToTable("STREET_TYPE");

                entity.Property(e => e.StreetTypeId)
                    .HasMaxLength(50)
                    .HasColumnName("STREET_TYPE_ID");

                entity.Property(e => e.StreetTypeName)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("STREET_TYPE_NAME");
            });

            modelBuilder.Entity<UnitToSptypeXref>(entity =>
            {
                entity.HasKey(e => e.UnsptpxrefId);

                entity.ToTable("UNITNO_SPTYPE_XREF");

                entity.Property(e => e.UnsptpxrefId).HasColumnName("UNSPTPXREF_ID");

                entity.Property(e => e.AllowMr)
                    .HasMaxLength(10)
                    .HasColumnName("ALLOW_MR");

                entity.Property(e => e.DateCreatedWeb)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATED_WEB");

                entity.Property(e => e.DateModifiedWeb)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_MODIFIED_WEB");

                entity.Property(e => e.DescriptionValue)
                    .HasMaxLength(100)
                    .HasColumnName("DESCRIPTION_VALUE");

                entity.Property(e => e.SpType)
                    .HasMaxLength(25)
                    .HasColumnName("SP_TYPE");

                entity.Property(e => e.SpTypeProfCd)
                    .HasMaxLength(25)
                    .HasColumnName("SP_TYPE_PROF_CD");

                entity.Property(e => e.SvcType)
                    .HasMaxLength(10)
                    .HasColumnName("SVC_TYPE");

                entity.Property(e => e.UnitCode)
                    .HasMaxLength(25)
                    .HasColumnName("UNIT_CODE");

                entity.Property(e => e.UserCreatedWeb)
                    .HasMaxLength(10)
                    .HasColumnName("USER_CREATED_WEB");

                entity.Property(e => e.UserModifiedWeb)
                    .HasMaxLength(10)
                    .HasColumnName("USER_MODIFIED_WEB");
            });

            modelBuilder.Entity<ValidStreetName>(entity =>
            {
                entity.ToTable("VALID_STREET_NAME");

                entity.Property(e => e.ValidStreetNameId).HasColumnName("VALID_STREET_NAME_ID");

                entity.Property(e => e.City)
                    .HasMaxLength(30)
                    .HasColumnName("CITY");

                entity.Property(e => e.CityCode)
                    .HasMaxLength(2)
                    .HasColumnName("CITY_CODE");

                entity.Property(e => e.DateCreatedBz)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATED_BZ");

                entity.Property(e => e.DateCreatedWeb)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_CREATED_WEB");

                entity.Property(e => e.DateModifiedBz)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_MODIFIED_BZ");

                entity.Property(e => e.DateModifiedWeb)
                    .HasColumnType("datetime")
                    .HasColumnName("DATE_MODIFIED_WEB");

                entity.Property(e => e.GisStreetName)
                    .HasMaxLength(32)
                    .HasColumnName("GIS_STREET_NAME");

                entity.Property(e => e.HighRange).HasColumnName("HIGH_RANGE");

                entity.Property(e => e.LowRange).HasColumnName("LOW_RANGE");

                entity.Property(e => e.StreetCode)
                    .HasMaxLength(10)
                    .HasColumnName("STREET_CODE");

                entity.Property(e => e.StreetDir)
                    .HasMaxLength(2)
                    .HasColumnName("STREET_DIR");

                entity.Property(e => e.StreetName)
                    .HasMaxLength(30)
                    .HasColumnName("STREET_NAME");

                entity.Property(e => e.StreetType)
                    .HasMaxLength(5)
                    .HasColumnName("STREET_TYPE");

                entity.Property(e => e.UserCreatedWeb)
                    .HasMaxLength(10)
                    .HasColumnName("USER_CREATED_WEB");

                entity.Property(e => e.UserModifiedWeb)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("USER_MODIFIED_WEB");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
