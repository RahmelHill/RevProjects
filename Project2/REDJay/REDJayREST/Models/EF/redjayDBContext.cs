using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace REDJayREST.Models.EF
{
    public partial class redjayDBContext : DbContext
    {
        public redjayDBContext()
        {
        }

        public redjayDBContext(DbContextOptions<redjayDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Boot> Boots { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Condition> Conditions { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<FullPieceSuit> FullPieceSuits { get; set; } = null!;
        public virtual DbSet<JacketsCoat> JacketsCoats { get; set; } = null!;
        public virtual DbSet<Jean> Jeans { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<Sandal> Sandals { get; set; } = null!;
        public virtual DbSet<Shirt> Shirts { get; set; } = null!;
        public virtual DbSet<ShoeSize> ShoeSizes { get; set; } = null!;
        public virtual DbSet<Short> Shorts { get; set; } = null!;
        public virtual DbSet<Size> Sizes { get; set; } = null!;
        public virtual DbSet<SizeSuit> SizeSuits { get; set; } = null!;
        public virtual DbSet<Sneaker> Sneakers { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;
        public virtual DbSet<StoreLocation> StoreLocations { get; set; } = null!;
        public virtual DbSet<SuitBottom> SuitBottoms { get; set; } = null!;
        public virtual DbSet<SuitTop> SuitTops { get; set; } = null!;
        public virtual DbSet<Sweat> Sweats { get; set; } = null!;
        public virtual DbSet<TankTop> TankTops { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserBoot> UserBoots { get; set; } = null!;
        public virtual DbSet<UserFullPieceSuit> UserFullPieceSuits { get; set; } = null!;
        public virtual DbSet<UserJacketsCoat> UserJacketsCoats { get; set; } = null!;
        public virtual DbSet<UserJean> UserJeans { get; set; } = null!;
        public virtual DbSet<UserRole> UserRoles { get; set; } = null!;
        public virtual DbSet<UserSandal> UserSandals { get; set; } = null!;
        public virtual DbSet<UserShirt> UserShirts { get; set; } = null!;
        public virtual DbSet<UserShort> UserShorts { get; set; } = null!;
        public virtual DbSet<UserSneaker> UserSneakers { get; set; } = null!;
        public virtual DbSet<UserSuitBottom> UserSuitBottoms { get; set; } = null!;
        public virtual DbSet<UserSuitTop> UserSuitTops { get; set; } = null!;
        public virtual DbSet<UserSweat> UserSweats { get; set; } = null!;
        public virtual DbSet<UserTShirt> UserTShirts { get; set; } = null!;
        public virtual DbSet<UserTankTop> UserTankTops { get; set; } = null!;
        public virtual DbSet<UserUpload> UserUploads { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=tcp:p2project.database.windows.net;database=redjayDB;User id=project2;Password=Password@4567");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Boot>(entity =>
            {
                entity.HasKey(e => e.PkBootsId)
                    .HasName("PK__Boots__0109F669B17C3AE0");

                entity.Property(e => e.PkBootsId).HasColumnName("PK_boots_ID");

                entity.Property(e => e.BootName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("boot_Name");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brand_Name");

                entity.Property(e => e.FkConditionId).HasColumnName("FK_condition_ID");

                entity.Property(e => e.FkShoeSizeId).HasColumnName("FK_shoe_Size_ID");

                entity.Property(e => e.InStock).HasColumnName("In_Stock");

                entity.HasOne(d => d.FkCondition)
                    .WithMany(p => p.Boots)
                    .HasForeignKey(d => d.FkConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Boots__FK_condit__2E70E1FD");

                entity.HasOne(d => d.FkShoeSize)
                    .WithMany(p => p.Boots)
                    .HasForeignKey(d => d.FkShoeSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Boots__FK_shoe_S__2D7CBDC4");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.PkCityId)
                    .HasName("PK__City__236A640989905AB0");

                entity.ToTable("City");

                entity.Property(e => e.PkCityId).HasColumnName("PK_city_ID");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("city_Name");
            });

            modelBuilder.Entity<Condition>(entity =>
            {
                entity.HasKey(e => e.PkConditionId)
                    .HasName("PK__Conditio__6B0C0F27D7A262B5");

                entity.ToTable("Condition");

                entity.Property(e => e.PkConditionId).HasColumnName("PK_condition_ID");

                entity.Property(e => e.ItemCondition)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("item_Condition");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.PkCountryId)
                    .HasName("PK__Country__9919EC4E434F09F0");

                entity.ToTable("Country");

                entity.Property(e => e.PkCountryId).HasColumnName("PK_country_ID");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("country_Name");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.PkCustomerId)
                    .HasName("PK__Customer__08B63AFD6D0A4D7B");

                entity.Property(e => e.PkCustomerId).HasColumnName("PK_customer_ID");

                entity.Property(e => e.CustomerAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_Address");

                entity.Property(e => e.CustomerEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_Email");

                entity.Property(e => e.CustomerFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_First_Name");

                entity.Property(e => e.CustomerLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("customer_Last_Name");

                entity.Property(e => e.FkCityId).HasColumnName("FK_city_ID");

                entity.Property(e => e.FkCountryId).HasColumnName("FK_country_ID");

                entity.Property(e => e.FkStateId).HasColumnName("FK_state_ID");

                entity.Property(e => e.FkUsernameId).HasColumnName("FK_username_ID");

                entity.Property(e => e.LoginDateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("login_Date_Created")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.HasOne(d => d.FkCity)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.FkCityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customers__FK_ci__0C50D423");

                entity.HasOne(d => d.FkCountry)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.FkCountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customers__FK_co__0E391C95");

                entity.HasOne(d => d.FkState)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.FkStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customers__FK_st__0D44F85C");

                entity.HasOne(d => d.FkUsername)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.FkUsernameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customers__FK_us__0B5CAFEA");
            });

            modelBuilder.Entity<FullPieceSuit>(entity =>
            {
                entity.HasKey(e => e.PkFullSuit)
                    .HasName("PK__Full_Pie__6D6E24D425BF6365");

                entity.ToTable("Full_Piece_Suit");

                entity.Property(e => e.PkFullSuit).HasColumnName("PK_full_Suit");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brand_Name");

                entity.Property(e => e.FkConditionId).HasColumnName("FK_condition_ID");

                entity.Property(e => e.FkSuitSizeId).HasColumnName("FK_suit_Size_ID");

                entity.Property(e => e.InStock).HasColumnName("in_Stock");

                entity.Property(e => e.StyleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("style_Name");

                entity.HasOne(d => d.FkCondition)
                    .WithMany(p => p.FullPieceSuits)
                    .HasForeignKey(d => d.FkConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Full_Piec__FK_co__4CF5691D");

                entity.HasOne(d => d.FkSuitSize)
                    .WithMany(p => p.FullPieceSuits)
                    .HasForeignKey(d => d.FkSuitSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Full_Piec__FK_su__4C0144E4");
            });

            modelBuilder.Entity<JacketsCoat>(entity =>
            {
                entity.HasKey(e => e.PkJacketCoatId)
                    .HasName("PK__Jackets___8F9511065F41DDA4");

                entity.ToTable("Jackets_Coats");

                entity.Property(e => e.PkJacketCoatId).HasColumnName("PK_jacket_coat_ID");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brand_Name");

                entity.Property(e => e.FkConditionId).HasColumnName("FK_condition_ID");

                entity.Property(e => e.FkSizeId).HasColumnName("FK_size_ID");

                entity.Property(e => e.InStock)
                    .HasColumnName("in_Stock")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StyleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("style_Name");

                entity.HasOne(d => d.FkCondition)
                    .WithMany(p => p.JacketsCoats)
                    .HasForeignKey(d => d.FkConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Jackets_C__FK_co__1B5E0D89");

                entity.HasOne(d => d.FkSize)
                    .WithMany(p => p.JacketsCoats)
                    .HasForeignKey(d => d.FkSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Jackets_C__FK_si__1975C517");
            });

            modelBuilder.Entity<Jean>(entity =>
            {
                entity.HasKey(e => e.PkJeansId)
                    .HasName("PK__Jeans__0903547FAD529DF4");

                entity.Property(e => e.PkJeansId).HasColumnName("PK_jeans_ID");

                entity.Property(e => e.FkConditionId).HasColumnName("FK_condition_ID");

                entity.Property(e => e.FkSizeId).HasColumnName("FK_size_ID");

                entity.Property(e => e.JeanBrand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("jean_Brand");

                entity.Property(e => e.JeanStyle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("jean_Style");

                entity.HasOne(d => d.FkCondition)
                    .WithMany(p => p.Jeans)
                    .HasForeignKey(d => d.FkConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Jeans__FK_condit__1F2E9E6D");

                entity.HasOne(d => d.FkSize)
                    .WithMany(p => p.Jeans)
                    .HasForeignKey(d => d.FkSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Jeans__FK_size_I__1E3A7A34");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.PkRoleId)
                    .HasName("PK__Roles__D934B1F23FC3D860");

                entity.Property(e => e.PkRoleId).HasColumnName("PK_role_ID");

                entity.Property(e => e.RoleDescription)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("role_description");
            });

            modelBuilder.Entity<Sandal>(entity =>
            {
                entity.HasKey(e => e.PkSandalsId)
                    .HasName("PK__Sandals__C7F925A61A835E33");

                entity.Property(e => e.PkSandalsId).HasColumnName("PK_sandals_ID");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brand_Name");

                entity.Property(e => e.FkConditionId).HasColumnName("FK_condition_ID");

                entity.Property(e => e.FkShoeSizeId).HasColumnName("FK_shoe_Size_ID");

                entity.Property(e => e.InStock).HasColumnName("in_Stock");

                entity.Property(e => e.SandalName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sandal_Name");

                entity.HasOne(d => d.FkCondition)
                    .WithMany(p => p.Sandals)
                    .HasForeignKey(d => d.FkConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sandals__FK_cond__2AA05119");

                entity.HasOne(d => d.FkShoeSize)
                    .WithMany(p => p.Sandals)
                    .HasForeignKey(d => d.FkShoeSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sandals__FK_shoe__29AC2CE0");
            });

            modelBuilder.Entity<Shirt>(entity =>
            {
                entity.HasKey(e => e.PkShirtId)
                    .HasName("PK__Shirts__11DE12A3ADF39E4C");

                entity.Property(e => e.PkShirtId).HasColumnName("PK_shirt_ID");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brand_Name");

                entity.Property(e => e.FkConditionId).HasColumnName("FK_condition_ID");

                entity.Property(e => e.FkSizeId).HasColumnName("FK_size_ID");

                entity.Property(e => e.InStock)
                    .IsRequired()
                    .HasColumnName("in_Stock")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StyleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("style_Name");

                entity.HasOne(d => d.FkCondition)
                    .WithMany(p => p.Shirts)
                    .HasForeignKey(d => d.FkConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Shirts__FK_condi__30242045");

                entity.HasOne(d => d.FkSize)
                    .WithMany(p => p.Shirts)
                    .HasForeignKey(d => d.FkSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Shirts__FK_size___3118447E");
            });

            modelBuilder.Entity<ShoeSize>(entity =>
            {
                entity.HasKey(e => e.PkShoeSizeId)
                    .HasName("PK__Shoe_Siz__F1C354F8372CCE9F");

                entity.ToTable("Shoe_Size");

                entity.Property(e => e.PkShoeSizeId).HasColumnName("PK_shoe_Size_ID");

                entity.Property(e => e.ShoeSize1)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("shoe_Size");
            });

            modelBuilder.Entity<Short>(entity =>
            {
                entity.HasKey(e => e.PkShortsId)
                    .HasName("PK__Shorts__13BF5CCE80FA2A9D");

                entity.Property(e => e.PkShortsId).HasColumnName("PK_shorts_ID");

                entity.Property(e => e.FkConditionId).HasColumnName("FK_condition_ID");

                entity.Property(e => e.FkSizeId).HasColumnName("FK_size_ID");

                entity.Property(e => e.ShortsBrand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("shorts_Brand");

                entity.Property(e => e.ShortsStyle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("shorts_Style");

                entity.HasOne(d => d.FkCondition)
                    .WithMany(p => p.Shorts)
                    .HasForeignKey(d => d.FkConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Shorts__FK_condi__26CFC035");

                entity.HasOne(d => d.FkSize)
                    .WithMany(p => p.Shorts)
                    .HasForeignKey(d => d.FkSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Shorts__FK_size___25DB9BFC");
            });

            modelBuilder.Entity<Size>(entity =>
            {
                entity.HasKey(e => e.PkSizeId)
                    .HasName("PK__size__0D07727EC289609B");

                entity.ToTable("size");

                entity.Property(e => e.PkSizeId).HasColumnName("PK_size_ID");

                entity.Property(e => e.ClothingSize)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("clothing_size");
            });

            modelBuilder.Entity<SizeSuit>(entity =>
            {
                entity.HasKey(e => e.PkSuitSizeId)
                    .HasName("PK__Size_Sui__73DB646F86248A0C");

                entity.ToTable("Size_Suit");

                entity.Property(e => e.PkSuitSizeId).HasColumnName("PK_suit_Size_ID");

                entity.Property(e => e.SuitSize)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("suit_Size");
            });

            modelBuilder.Entity<Sneaker>(entity =>
            {
                entity.HasKey(e => e.PkSneakerId)
                    .HasName("PK__Sneakers__C69977CF85A1F545");

                entity.Property(e => e.PkSneakerId).HasColumnName("PK_sneaker_ID");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brand_Name");

                entity.Property(e => e.FkConditionId).HasColumnName("FK_condition_ID");

                entity.Property(e => e.FkShoeSizeId).HasColumnName("FK_shoe_Size_ID");

                entity.Property(e => e.InStock).HasColumnName("in_Stock");

                entity.Property(e => e.SneakerName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sneaker_Name");

                entity.HasOne(d => d.FkCondition)
                    .WithMany(p => p.Sneakers)
                    .HasForeignKey(d => d.FkConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sneakers__FK_con__324172E1");

                entity.HasOne(d => d.FkShoeSize)
                    .WithMany(p => p.Sneakers)
                    .HasForeignKey(d => d.FkShoeSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sneakers__FK_sho__314D4EA8");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => e.PkStateId)
                    .HasName("PK__State__C004ABC74F89029C");

                entity.ToTable("State");

                entity.Property(e => e.PkStateId).HasColumnName("PK_state_ID");

                entity.Property(e => e.StateName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("state_Name");
            });

            modelBuilder.Entity<StoreLocation>(entity =>
            {
                entity.HasKey(e => e.PkStoreLocationId)
                    .HasName("PK__Store_Lo__E60F980B12B78537");

                entity.ToTable("Store_Location");

                entity.Property(e => e.PkStoreLocationId).HasColumnName("PK_Store_Location_ID");

                entity.Property(e => e.FkCityId).HasColumnName("FK_city_ID");

                entity.Property(e => e.FkCountryId).HasColumnName("FK_country_ID");

                entity.Property(e => e.FkStateId).HasColumnName("FK_state_ID");

                entity.Property(e => e.StoreAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("store_Address");

                entity.Property(e => e.StoreName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("store_Name");

                entity.HasOne(d => d.FkCity)
                    .WithMany(p => p.StoreLocations)
                    .HasForeignKey(d => d.FkCityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Store_Loc__FK_ci__6E01572D");

                entity.HasOne(d => d.FkCountry)
                    .WithMany(p => p.StoreLocations)
                    .HasForeignKey(d => d.FkCountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Store_Loc__FK_co__6FE99F9F");

                entity.HasOne(d => d.FkState)
                    .WithMany(p => p.StoreLocations)
                    .HasForeignKey(d => d.FkStateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Store_Loc__FK_st__6EF57B66");
            });

            modelBuilder.Entity<SuitBottom>(entity =>
            {
                entity.HasKey(e => e.PkSuitBottom)
                    .HasName("PK__Suit_Bot__ACE17E2DE25F20F7");

                entity.ToTable("Suit_Bottom");

                entity.Property(e => e.PkSuitBottom).HasColumnName("PK_suit_Bottom");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brand_Name");

                entity.Property(e => e.FkConditionId).HasColumnName("FK_condition_ID");

                entity.Property(e => e.FkSuitSizeId).HasColumnName("FK_suit_Size_ID");

                entity.Property(e => e.InStock).HasColumnName("in_Stock");

                entity.Property(e => e.StyleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("style_Name");

                entity.HasOne(d => d.FkCondition)
                    .WithMany(p => p.SuitBottoms)
                    .HasForeignKey(d => d.FkConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Suit_Bott__FK_co__50C5FA01");

                entity.HasOne(d => d.FkSuitSize)
                    .WithMany(p => p.SuitBottoms)
                    .HasForeignKey(d => d.FkSuitSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Suit_Bott__FK_su__4FD1D5C8");
            });

            modelBuilder.Entity<SuitTop>(entity =>
            {
                entity.HasKey(e => e.PkSuitTop)
                    .HasName("PK__Suit_Top__BAAC18FD152F24CF");

                entity.ToTable("Suit_Top");

                entity.Property(e => e.PkSuitTop).HasColumnName("PK_suit_Top");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brand_Name");

                entity.Property(e => e.FkConditionId).HasColumnName("FK_condition_ID");

                entity.Property(e => e.FkSuitSizeId).HasColumnName("FK_suit_Size_ID");

                entity.Property(e => e.InStock).HasColumnName("in_Stock");

                entity.Property(e => e.StyleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("style_Name");

                entity.HasOne(d => d.FkCondition)
                    .WithMany(p => p.SuitTops)
                    .HasForeignKey(d => d.FkConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Suit_Top__FK_con__54968AE5");

                entity.HasOne(d => d.FkSuitSize)
                    .WithMany(p => p.SuitTops)
                    .HasForeignKey(d => d.FkSuitSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Suit_Top__FK_sui__53A266AC");
            });

            modelBuilder.Entity<Sweat>(entity =>
            {
                entity.HasKey(e => e.PkSweatsId)
                    .HasName("PK__Sweats__85A7A273D6029859");

                entity.Property(e => e.PkSweatsId).HasColumnName("PK_sweats_ID");

                entity.Property(e => e.FkConditionId).HasColumnName("FK_condition_ID");

                entity.Property(e => e.FkSizeId).HasColumnName("FK_size_ID");

                entity.Property(e => e.SweatsBrand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sweats_Brand");

                entity.Property(e => e.SweatsStyle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sweats_Style");

                entity.HasOne(d => d.FkCondition)
                    .WithMany(p => p.Sweats)
                    .HasForeignKey(d => d.FkConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sweats__FK_condi__22FF2F51");

                entity.HasOne(d => d.FkSize)
                    .WithMany(p => p.Sweats)
                    .HasForeignKey(d => d.FkSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Sweats__FK_size___220B0B18");
            });

            modelBuilder.Entity<TankTop>(entity =>
            {
                entity.HasKey(e => e.PkTankTopId)
                    .HasName("PK__Tank_Top__2935E59DE77C6837");

                entity.ToTable("Tank_Tops");

                entity.Property(e => e.PkTankTopId).HasColumnName("PK_tank_top_ID");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("brand_Name");

                entity.Property(e => e.FkConditionId).HasColumnName("FK_condition_ID");

                entity.Property(e => e.FkSizeId).HasColumnName("FK_size_ID");

                entity.Property(e => e.InStock)
                    .IsRequired()
                    .HasColumnName("in_Stock")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.StyleName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("style_Name");

                entity.HasOne(d => d.FkCondition)
                    .WithMany(p => p.TankTops)
                    .HasForeignKey(d => d.FkConditionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Tank_Tops__FK_co__34E8D562");

                entity.HasOne(d => d.FkSize)
                    .WithMany(p => p.TankTops)
                    .HasForeignKey(d => d.FkSizeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Tank_Tops__FK_si__35DCF99B");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.PkUserId)
                    .HasName("PK__Users__2868646C4121598A");

                entity.HasIndex(e => e.UserName, "UQ__Users__591D27A51E36FE48")
                    .IsUnique();

                entity.HasIndex(e => e.Password, "UQ__Users__6E2DBEDE9787855F")
                    .IsUnique();

                entity.Property(e => e.PkUserId).HasColumnName("PK_user_ID");

                entity.Property(e => e.LoginDateCreated)
                    .HasColumnType("datetime")
                    .HasColumnName("login_Date_Created")
                    .HasDefaultValueSql("(sysdatetime())");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("user_Name");
            });

            modelBuilder.Entity<UserBoot>(entity =>
            {
                entity.HasKey(e => e.PkBootsId)
                    .HasName("PK__User_Boo__0109F669BD1C2CB4");

                entity.ToTable("User_Boots");

                entity.Property(e => e.PkBootsId).HasColumnName("PK_boots_ID");

                entity.Property(e => e.AdminApproval).HasColumnName("admin_approval");

                entity.Property(e => e.InStock)
                    .IsRequired()
                    .HasColumnName("in_Stock")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UploadBrand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Brand");

                entity.Property(e => e.UploadCondition).HasColumnName("upload_Condition");

                entity.Property(e => e.UploadSize).HasColumnName("upload_Size");

                entity.Property(e => e.UploadStyle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Style");
            });

            modelBuilder.Entity<UserFullPieceSuit>(entity =>
            {
                entity.HasKey(e => e.PkFullSuit)
                    .HasName("PK__User_Ful__6D6E24D4C5E7DD82");

                entity.ToTable("User_Full_Piece_Suit");

                entity.Property(e => e.PkFullSuit).HasColumnName("PK_full_Suit");

                entity.Property(e => e.AdminApproval).HasColumnName("admin_approval");

                entity.Property(e => e.InStock)
                    .IsRequired()
                    .HasColumnName("in_Stock")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UploadBrand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Brand");

                entity.Property(e => e.UploadCondition).HasColumnName("upload_Condition");

                entity.Property(e => e.UploadSize).HasColumnName("upload_Size");

                entity.Property(e => e.UploadStyle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Style");
            });

            modelBuilder.Entity<UserJacketsCoat>(entity =>
            {
                entity.HasKey(e => e.PkJacketCoatId)
                    .HasName("PK__User_Jac__8F951106E9FE2204");

                entity.ToTable("User_Jackets_Coats");

                entity.Property(e => e.PkJacketCoatId).HasColumnName("PK_jacket_coat_ID");

                entity.Property(e => e.AdminApproval).HasColumnName("admin_approval");

                entity.Property(e => e.InStock)
                    .IsRequired()
                    .HasColumnName("in_Stock")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UploadBrand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Brand");

                entity.Property(e => e.UploadCondition).HasColumnName("upload_Condition");

                entity.Property(e => e.UploadSize).HasColumnName("upload_Size");

                entity.Property(e => e.UploadStyle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Style");
            });

            modelBuilder.Entity<UserJean>(entity =>
            {
                entity.HasKey(e => e.PkJeansId)
                    .HasName("PK__User_Jea__0903547FE7ECD100");

                entity.ToTable("User_Jeans");

                entity.Property(e => e.PkJeansId).HasColumnName("PK_jeans_ID");

                entity.Property(e => e.AdminApproval).HasColumnName("admin_approval");

                entity.Property(e => e.InStock)
                    .IsRequired()
                    .HasColumnName("in_Stock")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UploadBrand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Brand");

                entity.Property(e => e.UploadCondition).HasColumnName("upload_Condition");

                entity.Property(e => e.UploadSize).HasColumnName("upload_Size");

                entity.Property(e => e.UploadStyle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Style");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("User_Roles");

                entity.Property(e => e.FkRoleId).HasColumnName("FK_role_ID");

                entity.Property(e => e.FkUserId).HasColumnName("FK_user_ID");

                entity.HasOne(d => d.FkRole)
                    .WithMany()
                    .HasForeignKey(d => d.FkRoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__User_Role__FK_ro__70A8B9AE");

                entity.HasOne(d => d.FkUser)
                    .WithMany()
                    .HasForeignKey(d => d.FkUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__User_Role__FK_us__6FB49575");
            });

            modelBuilder.Entity<UserSandal>(entity =>
            {
                entity.HasKey(e => e.PkSandalsId)
                    .HasName("PK__User_San__C7F925A6A75949A6");

                entity.ToTable("User_Sandals");

                entity.Property(e => e.PkSandalsId).HasColumnName("PK_sandals_ID");

                entity.Property(e => e.AdminApproval).HasColumnName("admin_approval");

                entity.Property(e => e.InStock)
                    .IsRequired()
                    .HasColumnName("in_Stock")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UploadBrand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Brand");

                entity.Property(e => e.UploadCondition).HasColumnName("upload_Condition");

                entity.Property(e => e.UploadSize).HasColumnName("upload_Size");

                entity.Property(e => e.UploadStyle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Style");
            });

            modelBuilder.Entity<UserShirt>(entity =>
            {
                entity.HasKey(e => e.PkShirtId)
                    .HasName("PK__User_Shi__11DE12A3456F120F");

                entity.ToTable("User_Shirts");

                entity.Property(e => e.PkShirtId).HasColumnName("PK_shirt_ID");

                entity.Property(e => e.AdminApproval).HasColumnName("admin_approval");

                entity.Property(e => e.InStock)
                    .IsRequired()
                    .HasColumnName("in_Stock")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UploadBrand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Brand");

                entity.Property(e => e.UploadCondition).HasColumnName("upload_Condition");

                entity.Property(e => e.UploadSize).HasColumnName("upload_Size");

                entity.Property(e => e.UploadStyle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Style");
            });

            modelBuilder.Entity<UserShort>(entity =>
            {
                entity.HasKey(e => e.PkShortsId)
                    .HasName("PK__User_Sho__13BF5CCE46473AEB");

                entity.ToTable("User_Shorts");

                entity.Property(e => e.PkShortsId).HasColumnName("PK_shorts_ID");

                entity.Property(e => e.AdminApproval).HasColumnName("admin_approval");

                entity.Property(e => e.InStock)
                    .IsRequired()
                    .HasColumnName("in_Stock")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UploadBrand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Brand");

                entity.Property(e => e.UploadCondition).HasColumnName("upload_Condition");

                entity.Property(e => e.UploadSize).HasColumnName("upload_Size");

                entity.Property(e => e.UploadStyle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Style");
            });

            modelBuilder.Entity<UserSneaker>(entity =>
            {
                entity.HasKey(e => e.PkSneakerId)
                    .HasName("PK__User_Sne__C69977CFF4599470");

                entity.ToTable("User_Sneakers");

                entity.Property(e => e.PkSneakerId).HasColumnName("PK_sneaker_ID");

                entity.Property(e => e.AdminApproval).HasColumnName("admin_approval");

                entity.Property(e => e.InStock)
                    .IsRequired()
                    .HasColumnName("in_Stock")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UploadBrand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Brand");

                entity.Property(e => e.UploadCondition).HasColumnName("upload_Condition");

                entity.Property(e => e.UploadSize).HasColumnName("upload_Size");

                entity.Property(e => e.UploadStyle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Style");
            });

            modelBuilder.Entity<UserSuitBottom>(entity =>
            {
                entity.HasKey(e => e.PkSuitBottom)
                    .HasName("PK__User_Sui__ACE17E2DCFAFEA6C");

                entity.ToTable("User_Suit_Bottom");

                entity.Property(e => e.PkSuitBottom).HasColumnName("PK_suit_Bottom");

                entity.Property(e => e.AdminApproval).HasColumnName("admin_approval");

                entity.Property(e => e.InStock)
                    .IsRequired()
                    .HasColumnName("in_Stock")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UploadBrand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Brand");

                entity.Property(e => e.UploadCondition).HasColumnName("upload_Condition");

                entity.Property(e => e.UploadSize).HasColumnName("upload_Size");

                entity.Property(e => e.UploadStyle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Style");
            });

            modelBuilder.Entity<UserSuitTop>(entity =>
            {
                entity.HasKey(e => e.PkSuitTop)
                    .HasName("PK__User_Sui__BAAC18FDA9E2B59F");

                entity.ToTable("User_Suit_Top");

                entity.Property(e => e.PkSuitTop).HasColumnName("PK_suit_Top");

                entity.Property(e => e.AdminApproval).HasColumnName("admin_approval");

                entity.Property(e => e.InStock)
                    .IsRequired()
                    .HasColumnName("in_Stock")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UploadBrand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Brand");

                entity.Property(e => e.UploadCondition).HasColumnName("upload_Condition");

                entity.Property(e => e.UploadSize).HasColumnName("upload_Size");

                entity.Property(e => e.UploadStyle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Style");
            });

            modelBuilder.Entity<UserSweat>(entity =>
            {
                entity.HasKey(e => e.PkSweatsId)
                    .HasName("PK__User_Swe__85A7A27312C6990C");

                entity.ToTable("User_Sweats");

                entity.Property(e => e.PkSweatsId).HasColumnName("PK_sweats_ID");

                entity.Property(e => e.AdminApproval).HasColumnName("admin_approval");

                entity.Property(e => e.InStock)
                    .IsRequired()
                    .HasColumnName("in_Stock")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UploadBrand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Brand");

                entity.Property(e => e.UploadCondition).HasColumnName("upload_Condition");

                entity.Property(e => e.UploadSize).HasColumnName("upload_Size");

                entity.Property(e => e.UploadStyle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Style");
            });

            modelBuilder.Entity<UserTShirt>(entity =>
            {
                entity.HasKey(e => e.PkTShirtId)
                    .HasName("PK__User_T_S__DDB078304853BC9C");

                entity.ToTable("User_T_Shirts");

                entity.Property(e => e.PkTShirtId).HasColumnName("PK_t_shirt_ID");

                entity.Property(e => e.AdminApproval).HasColumnName("admin_approval");

                entity.Property(e => e.InStock)
                    .IsRequired()
                    .HasColumnName("in_Stock")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UploadCondition).HasColumnName("upload_Condition");

                entity.Property(e => e.UploadSize).HasColumnName("upload_Size");
            });

            modelBuilder.Entity<UserTankTop>(entity =>
            {
                entity.HasKey(e => e.PkTankTopId)
                    .HasName("PK__User_Tan__2935E59D7D992600");

                entity.ToTable("User_Tank_Tops");

                entity.Property(e => e.PkTankTopId).HasColumnName("PK_tank_top_ID");

                entity.Property(e => e.AdminApproval).HasColumnName("admin_approval");

                entity.Property(e => e.InStock)
                    .IsRequired()
                    .HasColumnName("in_Stock")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UploadBrand)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Brand");

                entity.Property(e => e.UploadCondition).HasColumnName("upload_Condition");

                entity.Property(e => e.UploadSize).HasColumnName("upload_Size");

                entity.Property(e => e.UploadStyle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("upload_Style");
            });

            modelBuilder.Entity<UserUpload>(entity =>
            {
                entity.HasKey(e => e.PkCartId)
                    .HasName("PK__User_Upl__5E1428BB7D7620EE");

                entity.ToTable("User_Upload");

                entity.Property(e => e.PkCartId).HasColumnName("PK_cart_ID");

                entity.Property(e => e.FkBootsId).HasColumnName("FK_boots_ID");

                entity.Property(e => e.FkCustomerId).HasColumnName("FK_customer_ID");

                entity.Property(e => e.FkFullSuit).HasColumnName("FK_full_Suit");

                entity.Property(e => e.FkJacketCoatId).HasColumnName("FK_jacket_coat_ID");

                entity.Property(e => e.FkJeansId).HasColumnName("FK_jeans_ID");

                entity.Property(e => e.FkSandalsId).HasColumnName("FK_sandals_ID");

                entity.Property(e => e.FkShirtId).HasColumnName("FK_shirt_ID");

                entity.Property(e => e.FkShortsId).HasColumnName("FK_shorts_ID");

                entity.Property(e => e.FkSneakerId).HasColumnName("FK_sneaker_ID");

                entity.Property(e => e.FkSuitBottom).HasColumnName("FK_suit_Bottom");

                entity.Property(e => e.FkSuitTop).HasColumnName("FK_suit_Top");

                entity.Property(e => e.FkSweatsId).HasColumnName("FK_sweats_ID");

                entity.Property(e => e.FkTankTopId).HasColumnName("FK_tank_top_ID");

                entity.HasOne(d => d.FkBoots)
                    .WithMany(p => p.UserUploads)
                    .HasForeignKey(d => d.FkBootsId)
                    .HasConstraintName("FK__User_Uplo__FK_bo__269AB60B");

                entity.HasOne(d => d.FkCustomer)
                    .WithMany(p => p.UserUploads)
                    .HasForeignKey(d => d.FkCustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__User_Uplo__FK_cu__20E1DCB5");

                entity.HasOne(d => d.FkFullSuitNavigation)
                    .WithMany(p => p.UserUploads)
                    .HasForeignKey(d => d.FkFullSuit)
                    .HasConstraintName("FK__User_Uplo__FK_fu__297722B6");

                entity.HasOne(d => d.FkJacketCoat)
                    .WithMany(p => p.UserUploads)
                    .HasForeignKey(d => d.FkJacketCoatId)
                    .HasConstraintName("FK__User_Uplo__FK_ja__21D600EE");

                entity.HasOne(d => d.FkJeans)
                    .WithMany(p => p.UserUploads)
                    .HasForeignKey(d => d.FkJeansId)
                    .HasConstraintName("FK__User_Uplo__FK_je__22CA2527");

                entity.HasOne(d => d.FkSandals)
                    .WithMany(p => p.UserUploads)
                    .HasForeignKey(d => d.FkSandalsId)
                    .HasConstraintName("FK__User_Uplo__FK_sa__25A691D2");

                entity.HasOne(d => d.FkShirt)
                    .WithMany(p => p.UserUploads)
                    .HasForeignKey(d => d.FkShirtId)
                    .HasConstraintName("FK__User_Uplo__FK_sh__2B5F6B28");

                entity.HasOne(d => d.FkShorts)
                    .WithMany(p => p.UserUploads)
                    .HasForeignKey(d => d.FkShortsId)
                    .HasConstraintName("FK__User_Uplo__FK_sh__24B26D99");

                entity.HasOne(d => d.FkSneaker)
                    .WithMany(p => p.UserUploads)
                    .HasForeignKey(d => d.FkSneakerId)
                    .HasConstraintName("FK__User_Uplo__FK_sn__278EDA44");

                entity.HasOne(d => d.FkSuitBottomNavigation)
                    .WithMany(p => p.UserUploads)
                    .HasForeignKey(d => d.FkSuitBottom)
                    .HasConstraintName("FK__User_Uplo__FK_su__2882FE7D");

                entity.HasOne(d => d.FkSuitTopNavigation)
                    .WithMany(p => p.UserUploads)
                    .HasForeignKey(d => d.FkSuitTop)
                    .HasConstraintName("FK__User_Uplo__FK_su__2A6B46EF");

                entity.HasOne(d => d.FkSweats)
                    .WithMany(p => p.UserUploads)
                    .HasForeignKey(d => d.FkSweatsId)
                    .HasConstraintName("FK__User_Uplo__FK_sw__23BE4960");

                entity.HasOne(d => d.FkTankTop)
                    .WithMany(p => p.UserUploads)
                    .HasForeignKey(d => d.FkTankTopId)
                    .HasConstraintName("FK__User_Uplo__FK_ta__2C538F61");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
