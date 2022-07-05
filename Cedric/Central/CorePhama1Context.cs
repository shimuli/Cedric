using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Cedric.Central
{
    public partial class CorePhama1Context : DbContext
    {
        public CorePhama1Context()
        {
        }

        public CorePhama1Context(DbContextOptions<CorePhama1Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountClass> AccountClasses { get; set; }
        public virtual DbSet<AccountType> AccountTypes { get; set; }
        public virtual DbSet<Acct> Accts { get; set; }
        public virtual DbSet<AcctCategory> AcctCategories { get; set; }
        public virtual DbSet<Acctcategory1> Acctcategories1 { get; set; }
        public virtual DbSet<Bank> Banks { get; set; }
        public virtual DbSet<BiAuditTrail> BiAuditTrails { get; set; }
        public virtual DbSet<BiRole> BiRoles { get; set; }
        public virtual DbSet<BiRolesright> BiRolesrights { get; set; }
        public virtual DbSet<BiSystemright> BiSystemrights { get; set; }
        public virtual DbSet<BiSystemuser> BiSystemusers { get; set; }
        public virtual DbSet<BiUsersrole> BiUsersroles { get; set; }
        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Cashbookcustomer> Cashbookcustomers { get; set; }
        public virtual DbSet<Closedtran> Closedtrans { get; set; }
        public virtual DbSet<Companydef> Companydefs { get; set; }
        public virtual DbSet<Credcont> Credconts { get; set; }
        public virtual DbSet<CreditCategory> CreditCategories { get; set; }
        public virtual DbSet<CsCategory> CsCategories { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<CusContact> CusContacts { get; set; }
        public virtual DbSet<Cusstockprice> Cusstockprices { get; set; }
        public virtual DbSet<CustCategory> CustCategories { get; set; }
        public virtual DbSet<CustItemdiscount> CustItemdiscounts { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerMember> CustomerMembers { get; set; }
        public virtual DbSet<InvGroup> InvGroups { get; set; }
        public virtual DbSet<InvPackage> InvPackages { get; set; }
        public virtual DbSet<InvSubgroup> InvSubgroups { get; set; }
        public virtual DbSet<Invbcode> Invbcodes { get; set; }
        public virtual DbSet<Invbcodedet> Invbcodedets { get; set; }
        public virtual DbSet<Invclass> Invclasses { get; set; }
        public virtual DbSet<Inventory> Inventories { get; set; }
        public virtual DbSet<Invform> Invforms { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<PaymentsHd> PaymentsHds { get; set; }
        public virtual DbSet<Payterm> Payterms { get; set; }
        public virtual DbSet<Prodclass> Prodclasses { get; set; }
        public virtual DbSet<ProfileGroup> ProfileGroups { get; set; }
        public virtual DbSet<Province> Provinces { get; set; }
        public virtual DbSet<ReceiptsHd> ReceiptsHds { get; set; }
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; }
        public virtual DbSet<Route> Routes { get; set; }
        public virtual DbSet<Saletran> Saletrans { get; set; }
        public virtual DbSet<SpCategory> SpCategories { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<SuppContact> SuppContacts { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Sysdefault> Sysdefaults { get; set; }
        public virtual DbSet<Sysmodule> Sysmodules { get; set; }
        public virtual DbSet<Sysnextnumber> Sysnextnumbers { get; set; }
        public virtual DbSet<TaxType> TaxTypes { get; set; }
        public virtual DbSet<Thebranch> Thebranches { get; set; }
        public virtual DbSet<Till> Tills { get; set; }
        public virtual DbSet<Town> Towns { get; set; }
        public virtual DbSet<Trackcollect> Trackcollects { get; set; }
        public virtual DbSet<Trackcollectdispatch> Trackcollectdispatches { get; set; }
        public virtual DbSet<Trackdeliver> Trackdelivers { get; set; }
        public virtual DbSet<Trackdoc> Trackdocs { get; set; }
        public virtual DbSet<Trackstore> Trackstores { get; set; }
        public virtual DbSet<Trackstoremultisel> Trackstoremultisels { get; set; }
        public virtual DbSet<Trackverify> Trackverifies { get; set; }
        public virtual DbSet<Trackverifytwo> Trackverifytwos { get; set; }
        public virtual DbSet<Transtime> Transtimes { get; set; }
        public virtual DbSet<Tx001> Tx001s { get; set; }
        public virtual DbSet<UserGroup> UserGroups { get; set; }
        public virtual DbSet<UsergroupRight> UsergroupRights { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=Phamabi");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AccountClass>(entity =>
            {
                entity.HasKey(e => new { e.AcctClass, e.AcctType });

                entity.Property(e => e.AcctClass).HasMaxLength(2);

                entity.Property(e => e.AcctType).HasMaxLength(4);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.HasOne(d => d.AcctTypeNavigation)
                    .WithMany(p => p.AccountClasses)
                    .HasForeignKey(d => d.AcctType);
            });

            modelBuilder.Entity<AccountType>(entity =>
            {
                entity.HasKey(e => e.AcctType);

                entity.Property(e => e.AcctType).HasMaxLength(4);

                entity.Property(e => e.Description).HasMaxLength(100);
            });

            modelBuilder.Entity<Acct>(entity =>
            {
                entity.HasKey(e => e.Acct1);

                entity.ToTable("ACCT");

                entity.Property(e => e.Acct1)
                    .HasMaxLength(10)
                    .HasColumnName("ACCT");

                entity.Property(e => e.Acctcatgcode).HasColumnName("ACCTCATGCODE");

                entity.Property(e => e.Bank).HasColumnName("bank");

                entity.Property(e => e.Bcode).HasColumnName("BCODE");

                entity.Property(e => e.Bdgtcat)
                    .HasMaxLength(4)
                    .HasColumnName("BDGTCAT");

                entity.Property(e => e.Blocked).HasColumnName("blocked");

                entity.Property(e => e.Class)
                    .HasMaxLength(2)
                    .HasColumnName("CLASS");

                entity.Property(e => e.Controlacct).HasColumnName("CONTROLACCT");

                entity.Property(e => e.Des)
                    .HasMaxLength(60)
                    .HasColumnName("DES");

                entity.Property(e => e.Hassubacct).HasColumnName("hassubacct");

                entity.Property(e => e.Motheracct).HasColumnName("motheracct");

                entity.Property(e => e.Mthacct)
                    .HasMaxLength(10)
                    .HasColumnName("mthacct");

                entity.Property(e => e.Rptcat)
                    .HasMaxLength(20)
                    .HasColumnName("RPTCAT");

                entity.Property(e => e.Subacct).HasColumnName("subacct");

                entity.Property(e => e.Tillgl).HasColumnName("tillgl");

                entity.Property(e => e.Type)
                    .HasMaxLength(4)
                    .HasColumnName("TYPE");
            });

            modelBuilder.Entity<AcctCategory>(entity =>
            {
                entity.HasKey(e => e.Acctcatgcode);

                entity.ToTable("ACCT_CATEGORY");

                entity.Property(e => e.Acctcatgcode)
                    .ValueGeneratedNever()
                    .HasColumnName("ACCTCATGCODE");

                entity.Property(e => e.Acctcatgname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ACCTCATGNAME");

                entity.Property(e => e.Bcode).HasColumnName("BCODE");

                entity.Property(e => e.Endacct).HasColumnName("ENDACCT");

                entity.Property(e => e.Startacct).HasColumnName("STARTACCT");
            });

            modelBuilder.Entity<Acctcategory1>(entity =>
            {
                entity.HasKey(e => e.Rptcat);

                entity.ToTable("ACCTCATEGORIES");

                entity.Property(e => e.Rptcat)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("RPTCAT");

                entity.Property(e => e.Bcode).HasColumnName("BCODE");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");
            });

            modelBuilder.Entity<Bank>(entity =>
            {
                entity.HasKey(e => e.BankAcct);

                entity.ToTable("BANKS");

                entity.Property(e => e.BankAcct)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("bank_acct");

                entity.Property(e => e.BankGl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("bank_gl");

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bank_name");

                entity.Property(e => e.Banksystem).HasColumnName("banksystem");

                entity.Property(e => e.Bcode).HasColumnName("bcode");

                entity.Property(e => e.Blocked).HasColumnName("blocked");

                entity.Property(e => e.Cashlimit).HasColumnName("cashlimit");

                entity.Property(e => e.Cbstyle).HasColumnName("cbstyle");

                entity.Property(e => e.Currencycode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCYCODE");

                entity.Property(e => e.Isbank).HasColumnName("ISBANK");

                entity.Property(e => e.Pettycash).HasColumnName("pettycash");

                entity.Property(e => e.Postdated).HasColumnName("POSTDATED");
            });

            modelBuilder.Entity<BiAuditTrail>(entity =>
            {
                entity.ToTable("BI_AUDIT_TRAIL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Activity)
                    .IsRequired()
                    .HasColumnName("ACTIVITY");

                entity.Property(e => e.Machineip)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("MACHINEIP");

                entity.Property(e => e.Machinename)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("MACHINENAME");

                entity.Property(e => e.Sysdate)
                    .HasColumnType("datetime")
                    .HasColumnName("SYSDATE");

                entity.Property(e => e.Userid)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("USERID");
            });

            modelBuilder.Entity<BiRole>(entity =>
            {
                entity.HasKey(e => e.Roleid);

                entity.ToTable("BI_ROLES");

                entity.Property(e => e.Roleid).HasColumnName("ROLEID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Roledescription).HasColumnName("ROLEDESCRIPTION");

                entity.Property(e => e.Rolename)
                    .IsRequired()
                    .HasColumnName("ROLENAME");

                entity.Property(e => e.Sysdate)
                    .HasColumnType("datetime")
                    .HasColumnName("SYSDATE");

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<BiRolesright>(entity =>
            {
                entity.HasKey(e => new { e.Roleid, e.Rightid });

                entity.ToTable("BI_ROLESRIGHTS");

                entity.Property(e => e.Roleid).HasColumnName("ROLEID");

                entity.Property(e => e.Rightid).HasColumnName("RIGHTID");

                entity.Property(e => e.Status).HasColumnName("STATUS");
            });

            modelBuilder.Entity<BiSystemright>(entity =>
            {
                entity.HasKey(e => e.Rightid);

                entity.ToTable("BI_SYSTEMRIGHTS");

                entity.Property(e => e.Rightid).HasColumnName("RIGHTID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Isvalidated).HasColumnName("ISVALIDATED");

                entity.Property(e => e.Rightdesc)
                    .IsRequired()
                    .HasColumnName("RIGHTDESC");

                entity.Property(e => e.Rightname)
                    .IsRequired()
                    .HasColumnName("RIGHTNAME");
            });

            modelBuilder.Entity<BiSystemuser>(entity =>
            {
                entity.HasKey(e => e.Userid);

                entity.ToTable("BI_SYSTEMUSERS");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Active).HasColumnName("ACTIVE");

                entity.Property(e => e.Isloggedin).HasColumnName("ISLOGGEDIN");

                entity.Property(e => e.Lastactivitydate)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTACTIVITYDATE");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("PASSWORD");

                entity.Property(e => e.Registeredby)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("REGISTEREDBY");

                entity.Property(e => e.Timeout).HasColumnName("TIMEOUT");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<BiUsersrole>(entity =>
            {
                entity.HasKey(e => new { e.Roleid, e.Userid });

                entity.ToTable("BI_USERSROLES");

                entity.Property(e => e.Roleid).HasColumnName("ROLEID");

                entity.Property(e => e.Userid).HasColumnName("USERID");

                entity.Property(e => e.Status).HasColumnName("STATUS");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(e => e.Bcode);

                entity.ToTable("BRANCH");

                entity.Property(e => e.Bcode)
                    .ValueGeneratedNever()
                    .HasColumnName("bcode");

                entity.Property(e => e.Acct).HasColumnName("acct");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NAME");

                entity.Property(e => e.Branchcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHCODE");

                entity.Property(e => e.Enabled).HasColumnName("ENABLED");

                entity.Property(e => e.Mainbranch).HasColumnName("MAINBRANCH");

                entity.Property(e => e.Showallcustomer).HasColumnName("SHOWALLCUSTOMER");

                entity.Property(e => e.Showallcustomertrans).HasColumnName("SHOWALLCUSTOMERTRANS");
            });

            modelBuilder.Entity<Cashbookcustomer>(entity =>
            {
                entity.HasKey(e => new { e.Rptdocnum, e.Rptbcode, e.Modulecode });

                entity.ToTable("CASHBOOKCUSTOMER");

                entity.Property(e => e.Rptdocnum).HasColumnName("RPTDOCNUM");

                entity.Property(e => e.Rptbcode).HasColumnName("RPTBCODE");

                entity.Property(e => e.Modulecode).HasColumnName("MODULECODE");

                entity.Property(e => e.Cashbookid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CASHBOOKID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cashbookname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CASHBOOKNAME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cashtotal)
                    .HasColumnName("CASHTOTAL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Chequetotal)
                    .HasColumnName("CHEQUETOTAL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Credcontcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CREDCONTCODE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Credcontname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CREDCONTNAME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Credtotal)
                    .HasColumnName("CREDTOTAL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Crudmode)
                    .HasColumnName("crudmode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Crudorder).HasColumnName("crudorder");

                entity.Property(e => e.Cuscode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CUSCODE");

                entity.Property(e => e.Cusname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CUSNAME");

                entity.Property(e => e.Docpaymode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOCPAYMODE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Docref)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DOCREF")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Doctnarration)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DOCTNARRATION")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Doctype)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("DOCTYPE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Doctypename)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DOCTYPENAME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Kahtocode)
                    .HasColumnName("kahtocode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Matchdocnumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MATCHDOCNUMBER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Matchtotal)
                    .HasColumnName("MATCHTOTAL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Matchtype)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MATCHTYPE");

                entity.Property(e => e.Mpesatotal)
                    .HasColumnName("MPESATOTAL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Myperiod)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MYPERIOD");

                entity.Property(e => e.Routecode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ROUTECODE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Routename)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ROUTENAME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Rptbranch)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RPTBRANCH");

                entity.Property(e => e.Rptcuramount).HasColumnName("RPTCURAMOUNT");

                entity.Property(e => e.Rptcurcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RPTCURCODE");

                entity.Property(e => e.Rptcurexchrate)
                    .HasColumnName("RPTCUREXCHRATE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Rptcurname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RPTCURNAME");

                entity.Property(e => e.Rptdeptcode).HasColumnName("RPTDEPTCODE");

                entity.Property(e => e.Rptdeptname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RPTDEPTNAME");

                entity.Property(e => e.Rptdocdate)
                    .HasColumnType("datetime")
                    .HasColumnName("RPTDOCDATE");

                entity.Property(e => e.Rpttotal).HasColumnName("RPTTOTAL");

                entity.Property(e => e.Rtgtotal)
                    .HasColumnName("RTGTOTAL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Towncode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TOWNCODE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Townname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TOWNNAME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Tttotal)
                    .HasColumnName("TTTOTAL")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Closedtran>(entity =>
            {
                entity.HasKey(e => new { e.Bcode, e.Modulecode, e.Transperiod });

                entity.ToTable("CLOSEDTRANS");

                entity.Property(e => e.Bcode).HasColumnName("BCODE");

                entity.Property(e => e.Modulecode).HasColumnName("MODULECODE");

                entity.Property(e => e.Transperiod)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("TRANSPERIOD");

                entity.Property(e => e.Modulename)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MODULENAME");

                entity.Property(e => e.Transcount)
                    .HasColumnName("TRANSCOUNT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Transdate)
                    .HasColumnType("date")
                    .HasColumnName("TRANSDATE");

                entity.Property(e => e.Transposted)
                    .HasColumnName("TRANSPOSTED")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Companydef>(entity =>
            {
                entity.HasKey(e => e.Companyname);

                entity.ToTable("COMPANYDEF");

                entity.Property(e => e.Companyname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COMPANYNAME");

                entity.Property(e => e.Cusagedate)
                    .HasColumnType("date")
                    .HasColumnName("CUSAGEDATE");

                entity.Property(e => e.Finenddate)
                    .HasColumnType("date")
                    .HasColumnName("FINENDDATE");

                entity.Property(e => e.Finendperiod)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FINENDPERIOD");

                entity.Property(e => e.Finstartdate)
                    .HasColumnType("date")
                    .HasColumnName("FINSTARTDATE");

                entity.Property(e => e.Finstartperiod)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("FINSTARTPERIOD");

                entity.Property(e => e.Suppagedate)
                    .HasColumnType("date")
                    .HasColumnName("SUPPAGEDATE");
            });

            modelBuilder.Entity<Credcont>(entity =>
            {
                entity.HasKey(e => e.Credccode);

                entity.ToTable("CREDCONT");

                entity.Property(e => e.Credccode).HasColumnName("credccode");

                entity.Property(e => e.Credcname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("credcname");
            });

            modelBuilder.Entity<CreditCategory>(entity =>
            {
                entity.HasKey(e => e.CreditCode);

                entity.ToTable("CREDIT_CATEGORY");

                entity.Property(e => e.CreditCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CREDIT_CODE");

                entity.Property(e => e.Awardpoints).HasColumnName("awardpoints");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Discount).HasColumnName("DISCOUNT");

                entity.Property(e => e.ExpiryDate)
                    .HasColumnType("datetime")
                    .HasColumnName("EXPIRY_DATE");

                entity.Property(e => e.Pricemarkup).HasColumnName("pricemarkup");
            });

            modelBuilder.Entity<CsCategory>(entity =>
            {
                entity.HasKey(e => e.CscatgCode);

                entity.ToTable("CS_CATEGORY");

                entity.Property(e => e.CscatgCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CSCATG_CODE");

                entity.Property(e => e.CscatgGl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CSCATG_GL");

                entity.Property(e => e.CscatgName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CSCATG_NAME");
            });

            modelBuilder.Entity<Currency>(entity =>
            {
                entity.HasKey(e => e.Currencycode);

                entity.ToTable("CURRENCIES");

                entity.Property(e => e.Currencycode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("currencycode");

                entity.Property(e => e.Default).HasColumnName("DEFAULT");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Symbol)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SYMBOL");
            });

            modelBuilder.Entity<CusContact>(entity =>
            {
                entity.HasKey(e => new { e.CcontNum, e.CusCode });

                entity.ToTable("CUS_CONTACTS");

                entity.Property(e => e.CcontNum)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CCONT_NUM");

                entity.Property(e => e.CusCode)
                    .HasMaxLength(10)
                    .HasColumnName("CUS_CODE");

                entity.Property(e => e.Cellcountry)
                    .HasMaxLength(200)
                    .HasColumnName("CELLCOUNTRY");

                entity.Property(e => e.Cellname)
                    .HasMaxLength(100)
                    .HasColumnName("CELLNAME");

                entity.Property(e => e.Cellnumber)
                    .HasMaxLength(50)
                    .HasColumnName("CELLNUMBER");

                entity.Property(e => e.Cellphone)
                    .HasMaxLength(40)
                    .HasColumnName("CELLPHONE");

                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .HasColumnName("CONTACT");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fax)
                    .HasMaxLength(32)
                    .HasColumnName("FAX");

                entity.Property(e => e.Phyaddress)
                    .HasMaxLength(200)
                    .HasColumnName("PHYADDRESS");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(40)
                    .HasColumnName("TELEPHONE");
            });

            modelBuilder.Entity<Cusstockprice>(entity =>
            {
                entity.HasKey(e => new { e.CusCode, e.InvCode });

                entity.ToTable("CUSSTOCKPRICE");

                entity.Property(e => e.CusCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CUS_CODE");

                entity.Property(e => e.InvCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INV_CODE");

                entity.Property(e => e.Stkprice).HasColumnName("STKPRICE");

                entity.Property(e => e.Stkpricenum).HasColumnName("STKPRICENUM");
            });

            modelBuilder.Entity<CustCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryCode);

                entity.ToTable("CUST_CATEGORY");

                entity.Property(e => e.CategoryCode).HasColumnName("CATEGORY_CODE");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Notregister)
                    .IsRequired()
                    .HasColumnName("NOTREGISTER")
                    .HasDefaultValueSql("(CONVERT([bit],(0)))");
            });

            modelBuilder.Entity<CustItemdiscount>(entity =>
            {
                entity.HasKey(e => new { e.CusCode, e.InvCode });

                entity.ToTable("CUST_ITEMDISCOUNTS");

                entity.Property(e => e.CusCode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("CUS_CODE");

                entity.Property(e => e.InvCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("inv_code");

                entity.Property(e => e.CashDiscount).HasColumnName("CASH_DISCOUNT");

                entity.Property(e => e.CashinvoiceDiscount).HasColumnName("cashinvoice_discount");

                entity.Property(e => e.InvoiceDiscount).HasColumnName("INVOICE_DISCOUNT");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.CusCode);

                entity.ToTable("CUSTOMER");

                entity.Property(e => e.CusCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CUS_CODE");

                entity.Property(e => e.Address)
                    .HasMaxLength(150)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Attachanymemberonsale).HasColumnName("attachanymemberonsale");

                entity.Property(e => e.Bcode).HasColumnName("bcode");

                entity.Property(e => e.Blocked).HasColumnName("BLOCKED");

                entity.Property(e => e.CategoryCode).HasColumnName("CATEGORY_CODE");

                entity.Property(e => e.Cellcountry)
                    .HasMaxLength(255)
                    .HasColumnName("cellcountry");

                entity.Property(e => e.Cellname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cellname");

                entity.Property(e => e.Cellnumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cellnumber");

                entity.Property(e => e.Companyfax)
                    .HasMaxLength(50)
                    .HasColumnName("COMPANYFAX");

                entity.Property(e => e.Copayperc).HasColumnName("COPAYPERC");

                entity.Property(e => e.Credccode).HasColumnName("credccode");

                entity.Property(e => e.Creddiscounts).HasColumnName("CREDDISCOUNTS");

                entity.Property(e => e.CreditCode)
                    .HasMaxLength(5)
                    .HasColumnName("CREDIT_CODE");

                entity.Property(e => e.Creditlimit).HasColumnName("CREDITLIMIT");

                entity.Property(e => e.Crudorder).HasColumnName("crudorder");

                entity.Property(e => e.CscatgCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("CSCATG_CODE");

                entity.Property(e => e.Currencycode)
                    .HasMaxLength(50)
                    .HasColumnName("CURRENCYCODE");

                entity.Property(e => e.CusDesc)
                    .HasMaxLength(150)
                    .HasColumnName("CUS_DESC");

                entity.Property(e => e.Cusbcodelist)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CUSBCODELIST");

                entity.Property(e => e.Cusbcodenamelist)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CUSBCODENAMELIST");

                entity.Property(e => e.Cuscategcode).HasColumnName("CUSCATEGCODE");

                entity.Property(e => e.Cuscategname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CUSCATEGNAME");

                entity.Property(e => e.Cuscode1)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CUSCODE");

                entity.Property(e => e.Cusname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CUSNAME");

                entity.Property(e => e.Cussmcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CUSSMCODE");

                entity.Property(e => e.Cussmname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CUSSMNAME");

                entity.Property(e => e.Customermargin).HasColumnName("customermargin");

                entity.Property(e => e.Defcashinvoice).HasColumnName("defcashinvoice");

                entity.Property(e => e.Defcustominvoice).HasColumnName("defcustominvoice");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .HasColumnName("email");

                entity.Property(e => e.EnforceTerms).HasColumnName("ENFORCE_TERMS");

                entity.Property(e => e.Forcemember).HasColumnName("forcemember");

                entity.Property(e => e.Issmart).HasColumnName("issmart");

                entity.Property(e => e.Issmartbalancecash).HasColumnName("ISSMARTBALANCECASH");

                entity.Property(e => e.Issmartcopay).HasColumnName("ISSMARTCOPAY");

                entity.Property(e => e.Membercopayexcess).HasColumnName("membercopayexcess");

                entity.Property(e => e.Membercorpcashexists).HasColumnName("membercorpcashexists");

                entity.Property(e => e.Memberlimitcumulate).HasColumnName("memberlimitcumulate");

                entity.Property(e => e.Memberlimitdayamt).HasColumnName("memberlimitdayamt");

                entity.Property(e => e.Memberlimitdaymonth).HasColumnName("memberlimitdaymonth");

                entity.Property(e => e.Memberlimitmonthamt).HasColumnName("memberlimitmonthamt");

                entity.Property(e => e.Memberlimitmonthend).HasColumnName("memberlimitmonthend");

                entity.Property(e => e.Memberlimitmonthstart).HasColumnName("memberlimitmonthstart");

                entity.Property(e => e.Memberlimitpercamt).HasColumnName("memberlimitpercamt");

                entity.Property(e => e.Memberlimittrack).HasColumnName("memberlimittrack");

                entity.Property(e => e.Nonregistered).HasColumnName("nonregistered");

                entity.Property(e => e.Oldaccount)
                    .HasMaxLength(50)
                    .HasColumnName("oldaccount");

                entity.Property(e => e.Paytermcode).HasColumnName("PAYTERMCODE");

                entity.Property(e => e.Phone)
                    .HasMaxLength(150)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Physicaladd)
                    .HasMaxLength(150)
                    .HasColumnName("PHYSICALADD");

                entity.Property(e => e.Regncode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("REGNCODE");

                entity.Property(e => e.Regnname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REGNNAME");

                entity.Property(e => e.Routecode).HasColumnName("routecode");

                entity.Property(e => e.Rutcode).HasColumnName("RUTCODE");

                entity.Property(e => e.Rutname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RUTNAME");

                entity.Property(e => e.Salebelowmin).HasColumnName("salebelowmin");

                entity.Property(e => e.Salebelowminlastset)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("salebelowminlastset");

                entity.Property(e => e.TempCreditlimit).HasColumnName("TEMP_CREDITLIMIT");

                entity.Property(e => e.Town)
                    .HasMaxLength(150)
                    .HasColumnName("TOWN");

                entity.Property(e => e.TownCode).HasColumnName("town_code");

                entity.Property(e => e.Twncode).HasColumnName("TWNCODE");

                entity.Property(e => e.Twnname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TWNNAME");
            });

            modelBuilder.Entity<CustomerMember>(entity =>
            {
                entity.HasKey(e => new { e.Memberno, e.Kahtocode });

                entity.ToTable("CUSTOMER_MEMBERS");

                entity.Property(e => e.Memberno)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MEMBERNO");

                entity.Property(e => e.Kahtocode).HasColumnName("kahtocode");

                entity.Property(e => e.Address)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Allergies)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("ALLERGIES")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Blocked)
                    .HasColumnName("BLOCKED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cellcountry)
                    .HasMaxLength(255)
                    .HasColumnName("cellcountry")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cellname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cellname")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Cellnumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cellnumber")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Contact)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Contactphone)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CONTACTPHONE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CusCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CUS_CODE");

                entity.Property(e => e.Doctor)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DOCTOR")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Doctorphone)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("DOCTORPHONE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FNAME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Lname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("LNAME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Membername)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("MEMBERNAME");

                entity.Property(e => e.Memidno)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MEMIDNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mempointsbal)
                    .HasColumnName("MEMPOINTSBAL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mempointsbuy)
                    .HasColumnName("MEMPOINTSBUY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mempointsredeem)
                    .HasColumnName("MEMPOINTSREDEEM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("mobile")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NoCopayLimit).HasDefaultValueSql("((0))");

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("NOTES")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SaluteCode).HasColumnName("SALUTE_CODE");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.TownCode).HasColumnName("TOWN_CODE");
            });

            modelBuilder.Entity<InvGroup>(entity =>
            {
                entity.HasKey(e => e.InvGroupcode);

                entity.ToTable("INV_GROUP");

                entity.Property(e => e.InvGroupcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("INV_GROUPCODE");

                entity.Property(e => e.CostofsalesGl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("COSTOFSALES_GL");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.InvadjustmentGl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("INVADJUSTMENT_GL");

                entity.Property(e => e.InventoryGl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("inventory_gl");

                entity.Property(e => e.SalesGl)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SALES_GL");
            });

            modelBuilder.Entity<InvPackage>(entity =>
            {
                entity.HasKey(e => e.PackageCode);

                entity.ToTable("INV_PACKAGE");

                entity.Property(e => e.PackageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PACKAGE_CODE");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");
            });

            modelBuilder.Entity<InvSubgroup>(entity =>
            {
                entity.HasKey(e => e.InvSubgroupcode);

                entity.ToTable("INV_SUBGROUP");

                entity.Property(e => e.InvSubgroupcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("INV_SUBGROUPCODE");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.InvGroupcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("INV_GROUPCODE");

                entity.Property(e => e.M1from).HasColumnName("M1FROM");

                entity.Property(e => e.M1to).HasColumnName("M1TO");

                entity.Property(e => e.M2from).HasColumnName("M2FROM");

                entity.Property(e => e.M2to).HasColumnName("M2TO");

                entity.Property(e => e.M3from).HasColumnName("M3FROM");

                entity.Property(e => e.M3to).HasColumnName("M3TO");
            });

            modelBuilder.Entity<Invbcode>(entity =>
            {
                entity.HasKey(e => new { e.InvCode, e.Bcode });

                entity.ToTable("INVBCODE");

                entity.Property(e => e.InvCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INV_CODE");

                entity.Property(e => e.Bcode).HasColumnName("bcode");

                entity.Property(e => e.ActiveIngredient)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("active_ingredient")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Blocked)
                    .HasColumnName("blocked")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Branchname)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Calcpw)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("calcpw")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Calcqty)
                    .HasColumnName("calcqty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Calcqtyopen)
                    .HasColumnName("calcqtyopen")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CalcqtyopenPw)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("calcqtyopenPW")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Crudmode)
                    .HasColumnName("crudmode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Crudorder).HasColumnName("crudorder");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.InvAvgcost)
                    .HasColumnName("INV_AVGCOST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvAvgsellcost)
                    .HasColumnName("INV_AVGSELLCOST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvBrandgeneric)
                    .HasColumnName("INV_BRANDGENERIC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvCostprice)
                    .HasColumnName("INV_COSTPRICE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvLastunitcost)
                    .HasColumnName("INV_LASTUNITCOST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvMinprice)
                    .HasColumnName("INV_MINPRICE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvPhysicalitem)
                    .HasColumnName("INV_PHYSICALITEM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvRetailprice)
                    .HasColumnName("INV_RETAILPRICE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvSpecialprice)
                    .HasColumnName("INV_SPECIALPRICE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvStrength)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("inv_strength")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InvSubgroupcode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("INV_SUBGROUPCODE");

                entity.Property(e => e.InvTradeprice)
                    .HasColumnName("INV_TRADEPRICE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INV_UNIT")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.InvWsaleprice)
                    .HasColumnName("INV_WSALEPRICE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Invbcodedetref)
                    .HasColumnName("INVBCODEDETREF")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Kahtocode).HasColumnName("kahtocode");

                entity.Property(e => e.Lastupdate)
                    .HasColumnType("datetime")
                    .HasColumnName("LASTUPDATE");

                entity.Property(e => e.ManufacturerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MANUFACTURER_CODE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PackQty)
                    .HasColumnName("PACK_QTY")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Reqty)
                    .HasColumnName("reqty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Stkrolevel)
                    .HasColumnName("stkrolevel")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Stkroqty)
                    .HasColumnName("stkroqty")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TAX_CODE")
                    .HasDefaultValueSql("('00')");

                entity.Property(e => e.Valqty)
                    .HasColumnName("valqty")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Invbcodedet>(entity =>
            {
                entity.HasKey(e => new { e.InvCode, e.Bcode, e.Storeid, e.Stockbatchnum, e.Invbcodedetref });

                entity.ToTable("INVBCODEDET");

                entity.Property(e => e.InvCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INV_CODE");

                entity.Property(e => e.Bcode).HasColumnName("BCODE");

                entity.Property(e => e.Storeid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STOREID");

                entity.Property(e => e.Stockbatchnum)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STOCKBATCHNUM");

                entity.Property(e => e.Invbcodedetref).HasColumnName("INVBCODEDETREF");

                entity.Property(e => e.Crudmode)
                    .HasColumnName("crudmode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Crudorder).HasColumnName("crudorder");

                entity.Property(e => e.Invbcodedetrowz)
                    .HasColumnName("INVBCODEDETROWZ")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Kahtocode).HasColumnName("kahtocode");

                entity.Property(e => e.Stockexpiry)
                    .HasColumnType("datetime")
                    .HasColumnName("STOCKEXPIRY");

                entity.Property(e => e.Stockqty)
                    .HasColumnName("STOCKQTY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Storename)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STORENAME");
            });

            modelBuilder.Entity<Invclass>(entity =>
            {
                entity.HasKey(e => e.Classcode);

                entity.ToTable("INVCLASS");

                entity.Property(e => e.Classcode)
                    .ValueGeneratedNever()
                    .HasColumnName("CLASSCODE");

                entity.Property(e => e.Classname)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("CLASSNAME")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Inventory>(entity =>
            {
                entity.HasKey(e => e.InvCode);

                entity.ToTable("INVENTORY");

                entity.Property(e => e.InvCode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("INV_CODE");

                entity.Property(e => e.ActiveIngredient)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("ACTIVE_INGREDIENT");

                entity.Property(e => e.AltCode)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ALT_CODE");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BARCODE");

                entity.Property(e => e.Bcode).HasColumnName("bcode");

                entity.Property(e => e.Blocked).HasColumnName("BLOCKED");

                entity.Property(e => e.CashDiscount).HasColumnName("cash_discount");

                entity.Property(e => e.CashinvoiceDiscount).HasColumnName("cashinvoice_discount");

                entity.Property(e => e.Choose).HasColumnName("choose");

                entity.Property(e => e.Contsub).HasColumnName("contsub");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Fastmoving).HasColumnName("fastmoving");

                entity.Property(e => e.Formcode).HasColumnName("formcode");

                entity.Property(e => e.Forpackalter).HasColumnName("forpackalter");

                entity.Property(e => e.Forpackalterused).HasColumnName("forpackalterused");

                entity.Property(e => e.Forrefill).HasColumnName("forrefill");

                entity.Property(e => e.Highvalue).HasColumnName("highvalue");

                entity.Property(e => e.Inclusive).HasColumnName("inclusive");

                entity.Property(e => e.InvBrandgeneric).HasColumnName("INV_BRANDGENERIC");

                entity.Property(e => e.InvCostprice).HasColumnName("INV_COSTPRICE");

                entity.Property(e => e.InvInstockqty).HasColumnName("INV_INSTOCKQTY");

                entity.Property(e => e.InvMaxprice).HasColumnName("INV_MAXPRICE");

                entity.Property(e => e.InvMaxqty).HasColumnName("INV_MAXQTY");

                entity.Property(e => e.InvMinprice).HasColumnName("INV_MINPRICE");

                entity.Property(e => e.InvMinqty).HasColumnName("INV_MINQTY");

                entity.Property(e => e.InvNotes)
                    .HasMaxLength(500)
                    .HasColumnName("inv_notes");

                entity.Property(e => e.InvOpeningqty).HasColumnName("INV_OPENINGQTY");

                entity.Property(e => e.InvPhysicalitem).HasColumnName("INV_PHYSICALITEM");

                entity.Property(e => e.InvReorderqty).HasColumnName("INV_REORDERQTY");

                entity.Property(e => e.InvRetailprice).HasColumnName("INV_RETAILPRICE");

                entity.Property(e => e.InvSpecialprice).HasColumnName("INV_SPECIALPRICE");

                entity.Property(e => e.InvStrength)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("INV_STRENGTH");

                entity.Property(e => e.InvSubgroupcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("INV_SUBGROUPCODE");

                entity.Property(e => e.InvTradeprice).HasColumnName("INV_TRADEPRICE");

                entity.Property(e => e.InvUnit)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("INV_UNIT");

                entity.Property(e => e.InvWsaleprice).HasColumnName("INV_WSALEPRICE");

                entity.Property(e => e.InvoiceDiscount).HasColumnName("invoice_discount");

                entity.Property(e => e.LocCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LOC_CODE");

                entity.Property(e => e.Lockitemdiscount).HasColumnName("lockitemdiscount");

                entity.Property(e => e.Lockprice).HasColumnName("lockprice");

                entity.Property(e => e.ManufacturerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MANUFACTURER_CODE");

                entity.Property(e => e.Noexpiry).HasColumnName("noexpiry");

                entity.Property(e => e.PackQty).HasColumnName("PACK_QTY");

                entity.Property(e => e.PackageCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("PACKAGE_CODE");

                entity.Property(e => e.PackinvCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("packinv_code");

                entity.Property(e => e.PackinvName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("packinv_name");

                entity.Property(e => e.Prodclass).HasColumnName("prodclass");

                entity.Property(e => e.Spack).HasColumnName("spack");

                entity.Property(e => e.SuppCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supp_code");

                entity.Property(e => e.SuppCode2)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("supp_code2");

                entity.Property(e => e.Sweight).HasColumnName("sweight");

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TAX_CODE");

                entity.Property(e => e.UnitQty).HasColumnName("UNIT_QTY");

                entity.Property(e => e.Yeszeroprice).HasColumnName("yeszeroprice");
            });

            modelBuilder.Entity<Invform>(entity =>
            {
                entity.HasKey(e => e.Formcode);

                entity.ToTable("INVFORM");

                entity.Property(e => e.Formcode)
                    .ValueGeneratedNever()
                    .HasColumnName("FORMCODE");

                entity.Property(e => e.Formname)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("FORMNAME");
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.HasKey(e => e.ManufacturerCode);

                entity.ToTable("MANUFACTURER");

                entity.Property(e => e.ManufacturerCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("MANUFACTURER_CODE");

                entity.Property(e => e.Country)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COUNTRY");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Initial)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("initial");
            });

            modelBuilder.Entity<PaymentsHd>(entity =>
            {
                entity.HasKey(e => new { e.PayDetnum, e.Bcode });

                entity.ToTable("PAYMENTS_HD");

                entity.Property(e => e.PayDetnum).HasColumnName("pay_detnum");

                entity.Property(e => e.Bcode).HasColumnName("bcode");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Amountinwords)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("amountinwords");

                entity.Property(e => e.Amountpaid).HasColumnName("amountpaid");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.BankAcct)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("bank_acct");

                entity.Property(e => e.Batched).HasColumnName("batched");

                entity.Property(e => e.Bposted)
                    .HasColumnName("bposted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cashier)
                    .HasColumnName("cashier")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cashsale)
                    .HasColumnName("CASHSALE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChqDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CHQ_DATE");

                entity.Property(e => e.Cleared).HasColumnName("cleared");

                entity.Property(e => e.ClearingDate).HasColumnType("datetime");

                entity.Property(e => e.Clearingamount).HasColumnName("clearingamount");

                entity.Property(e => e.Cnotebcode)
                    .HasColumnName("CNOTEBCODE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cnotenum)
                    .HasColumnName("CNOTENUM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Comments)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS");

                entity.Property(e => e.Contrabcode)
                    .HasColumnName("contrabcode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Currencycode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("currencycode");

                entity.Property(e => e.CusCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cus_code");

                entity.Property(e => e.DeptCode)
                    .HasColumnName("dept_code")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.Docbanked)
                    .HasColumnName("docbanked")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Done).HasColumnName("done");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("datetime")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExchRate).HasColumnName("exch_rate");

                entity.Property(e => e.ExclAmt)
                    .HasColumnName("excl_amt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fromhistory)
                    .HasColumnName("FROMHISTORY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Frompd)
                    .HasColumnName("frompd")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Gcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GCODE");

                entity.Property(e => e.Gcs)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GCS");

                entity.Property(e => e.Homeamountpaid).HasColumnName("homeamountpaid");

                entity.Property(e => e.Matched).HasColumnName("matched");

                entity.Property(e => e.Memberno)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("memberno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mpesaentryno)
                    .HasColumnName("MPESAENTRYNO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mpesatransid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MPESATRANSID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mpickbcode)
                    .HasColumnName("MPICKBCODE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mpickno)
                    .HasColumnName("MPICKNO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Paid).HasColumnName("paid");

                entity.Property(e => e.PayDate)
                    .HasColumnType("datetime")
                    .HasColumnName("pay_date");

                entity.Property(e => e.PayNum).HasColumnName("PAY_NUM");

                entity.Property(e => e.Paycounter).HasColumnName("PAYCOUNTER");

                entity.Property(e => e.Payfor)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("payfor");

                entity.Property(e => e.Paymode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("paymode");

                entity.Property(e => e.Period)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PERIOD");

                entity.Property(e => e.Reference)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("reference");

                entity.Property(e => e.Referenceother)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("referenceother")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Revdoc)
                    .HasColumnName("revdoc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RptClearingDate)
                    .HasColumnType("datetime")
                    .HasColumnName("rptClearingDate");

                entity.Property(e => e.Savetime)
                    .HasColumnType("datetime")
                    .HasColumnName("savetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Selrec)
                    .HasColumnName("selrec")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SinvNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("sinv_number");

                entity.Property(e => e.SuppCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("supp_code");

                entity.Property(e => e.Suppcleared)
                    .HasColumnName("SUPPCLEARED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Suppclearingdate)
                    .HasColumnType("datetime")
                    .HasColumnName("SUPPCLEARINGDATE");

                entity.Property(e => e.TaxAmt)
                    .HasColumnName("tax_amt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tax_code")
                    .HasDefaultValueSql("('00')");

                entity.Property(e => e.Theircurrencycode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("theircurrencycode");

                entity.Property(e => e.Tillno)
                    .HasColumnName("TILLNO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tillsessno)
                    .HasColumnName("TILLSESSNO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Txperc)
                    .HasColumnName("TXPERC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Txtype)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TXTYPE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Updatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Using).HasColumnName("using");

                entity.Property(e => e.Whvat)
                    .HasColumnName("whvat")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Whvatamt)
                    .HasColumnName("whvatamt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Whvatcode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("whvatcode")
                    .HasDefaultValueSql("('00')")
                    .IsFixedLength(true);

                entity.Property(e => e.Whvatperc)
                    .HasColumnName("whvatperc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.XrateBalance)
                    .HasColumnName("xrate_balance")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.XrateNet)
                    .HasColumnName("xrate_net")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Payterm>(entity =>
            {
                entity.HasKey(e => e.Paytermcode);

                entity.ToTable("PAYTERMS");

                entity.Property(e => e.Paytermcode)
                    .ValueGeneratedNever()
                    .HasColumnName("PAYTERMCODE");

                entity.Property(e => e.ChargableAfter).HasColumnName("CHARGABLE_AFTER");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");

                entity.Property(e => e.Discount).HasColumnName("DISCOUNT");

                entity.Property(e => e.DiscountedDays).HasColumnName("DISCOUNTED_DAYS");

                entity.Property(e => e.InterestRate).HasColumnName("INTEREST_RATE");

                entity.Property(e => e.Numdays).HasColumnName("NUMDAYS");
            });

            modelBuilder.Entity<Prodclass>(entity =>
            {
                entity.HasKey(e => e.Prodclass1);

                entity.ToTable("PRODCLASS");

                entity.Property(e => e.Prodclass1)
                    .ValueGeneratedNever()
                    .HasColumnName("prodclass");

                entity.Property(e => e.Prodname)
                    .HasMaxLength(100)
                    .HasColumnName("prodname");
            });

            modelBuilder.Entity<ProfileGroup>(entity =>
            {
                entity.HasKey(e => e.Ventrynum);

                entity.ToTable("PROFILE_GROUPS");

                entity.Property(e => e.Ventrynum).HasColumnName("VENTRYNUM");

                entity.Property(e => e.AddM)
                    .HasColumnName("add_m")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeleteM)
                    .HasColumnName("delete_m")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.EditM)
                    .HasColumnName("edit_m")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("MODULE_NAME");

                entity.Property(e => e.ProcessM)
                    .HasColumnName("process_m")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UserGroup)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("USER_GROUP");

                entity.Property(e => e.ViewM)
                    .HasColumnName("view_m")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.HasKey(e => e.ProvinceCode);

                entity.ToTable("PROVINCES");

                entity.Property(e => e.ProvinceCode)
                    .HasMaxLength(10)
                    .HasColumnName("PROVINCE_CODE");

                entity.Property(e => e.Province1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("PROVINCE");
            });

            modelBuilder.Entity<ReceiptsHd>(entity =>
            {
                entity.HasKey(e => new { e.RptDetnum, e.Bcode })
                    .IsClustered(false);

                entity.ToTable("RECEIPTS_HD");

                entity.Property(e => e.RptDetnum).HasColumnName("RPT_detnum");

                entity.Property(e => e.Bcode).HasColumnName("bcode");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Amountinwords)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("amountinwords");

                entity.Property(e => e.Amountpaid).HasColumnName("amountpaid");

                entity.Property(e => e.Balance).HasColumnName("balance");

                entity.Property(e => e.BankAcct)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("bank_acct");

                entity.Property(e => e.BankReference)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bank_reference")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankbankAcct)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bankbank_acct")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankbankName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("bankbank_name")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.BankrptDetnum)
                    .HasColumnName("bankrpt_detnum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Banktillno)
                    .HasColumnName("banktillno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Banktillsessno)
                    .HasColumnName("banktillsessno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Batched).HasColumnName("batched");

                entity.Property(e => e.Bounced).HasColumnName("bounced");

                entity.Property(e => e.Bposted)
                    .HasColumnName("bposted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cashier)
                    .HasColumnName("cashier")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cashinv)
                    .HasColumnName("cashinv")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cashinvbcode)
                    .HasColumnName("cashinvbcode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cashinvnum)
                    .HasColumnName("cashinvnum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cashsale)
                    .HasColumnName("cashsale")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cashxbalance)
                    .HasColumnName("cashxbalance")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cashxpaid)
                    .HasColumnName("cashxpaid")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ChqDate)
                    .HasColumnType("datetime")
                    .HasColumnName("CHQ_DATE");

                entity.Property(e => e.Cleared).HasColumnName("cleared");

                entity.Property(e => e.ClearingDate).HasColumnType("datetime");

                entity.Property(e => e.Clearingamount).HasColumnName("clearingamount");

                entity.Property(e => e.Cnotebcode)
                    .HasColumnName("CNOTEBCODE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cnotenum)
                    .HasColumnName("CNOTENUM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Comments)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("COMMENTS");

                entity.Property(e => e.Contrabcode)
                    .HasColumnName("contrabcode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Csalebanked)
                    .HasColumnName("csalebanked")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Currencycode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("currencycode");

                entity.Property(e => e.CusCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cus_code");

                entity.Property(e => e.Cusjrnbcode)
                    .HasColumnName("CUSJRNBCODE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Cusjrndetnum)
                    .HasColumnName("CUSJRNDETNUM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DeptCode)
                    .HasColumnName("dept_code")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.Discount).HasColumnName("discount");

                entity.Property(e => e.Docbanked)
                    .HasColumnName("docbanked")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Docselect)
                    .HasColumnName("docselect")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Done).HasColumnName("done");

                entity.Property(e => e.Entrydate)
                    .HasColumnType("datetime")
                    .HasColumnName("entrydate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExchRate).HasColumnName("exch_rate");

                entity.Property(e => e.ExclAmt)
                    .HasColumnName("excl_amt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Fromhistory)
                    .HasColumnName("FROMHISTORY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Frompd)
                    .HasColumnName("frompd")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Gcode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GCODE");

                entity.Property(e => e.Gcs)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("GCS");

                entity.Property(e => e.Holding).HasColumnName("HOLDING");

                entity.Property(e => e.Homeamountpaid).HasColumnName("homeamountpaid");

                entity.Property(e => e.Matched).HasColumnName("matched");

                entity.Property(e => e.Memberno)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("memberno")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mpesaentryno)
                    .HasColumnName("MPESAENTRYNO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mpesatransid)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MPESATRANSID")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mpickbcode)
                    .HasColumnName("MPICKBCODE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mpickno)
                    .HasColumnName("MPICKNO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.Property(e => e.Payfor)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("payfor");

                entity.Property(e => e.Paymode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("paymode");

                entity.Property(e => e.Paymodenum)
                    .HasColumnName("paymodenum")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Paymodetype)
                    .HasColumnName("paymodetype")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Period)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PERIOD");

                entity.Property(e => e.Reference)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("reference");

                entity.Property(e => e.Referenceother)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("referenceother")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Revdoc)
                    .HasColumnName("revdoc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RptDate)
                    .HasColumnType("datetime")
                    .HasColumnName("rpt_date");

                entity.Property(e => e.RptNum).HasColumnName("RPT_NUM");

                entity.Property(e => e.RptNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Rpt_Number");

                entity.Property(e => e.RptTax)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RPT_tax");

                entity.Property(e => e.Rptcounter).HasColumnName("RPTCOUNTER");

                entity.Property(e => e.SaleinvNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("saleinv_number");

                entity.Property(e => e.Selrec)
                    .HasColumnName("selrec")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SuppCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("supp_code");

                entity.Property(e => e.Suppcleared)
                    .HasColumnName("SUPPCLEARED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Suppclearingdate)
                    .HasColumnType("datetime")
                    .HasColumnName("SUPPCLEARINGDATE");

                entity.Property(e => e.TaxAmt)
                    .HasColumnName("tax_amt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("tax_code")
                    .HasDefaultValueSql("('00')");

                entity.Property(e => e.Theircurrencycode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("theircurrencycode");

                entity.Property(e => e.Tillno)
                    .HasColumnName("TILLNO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tillsessno)
                    .HasColumnName("TILLSESSNO")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Txperc)
                    .HasColumnName("TXPERC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Txtype)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TXTYPE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Updatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Usin).HasColumnName("usin_");

                entity.Property(e => e.Whvat)
                    .HasColumnName("whvat")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Whvatamt)
                    .HasColumnName("whvatamt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Whvatcode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("whvatcode")
                    .HasDefaultValueSql("('00')")
                    .IsFixedLength(true);

                entity.Property(e => e.Whvatperc)
                    .HasColumnName("whvatperc")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.XrateBalance)
                    .HasColumnName("xrate_balance")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.XrateNet)
                    .HasColumnName("xrate_net")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<RefreshToken>(entity =>
            {
                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("USERNAME");
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.HasKey(e => e.Routecode);

                entity.ToTable("ROUTES");

                entity.Property(e => e.Routecode).HasColumnName("routecode");

                entity.Property(e => e.Routename)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("routename");
            });

            modelBuilder.Entity<Saletran>(entity =>
            {
                entity.HasKey(e => new { e.Docnum, e.Salesdocdetnum, e.Salesbcode, e.Modulecode });

                entity.ToTable("SALETRANS");

                entity.Property(e => e.Docnum).HasColumnName("DOCNUM");

                entity.Property(e => e.Salesdocdetnum).HasColumnName("SALESDOCDETNUM");

                entity.Property(e => e.Salesbcode).HasColumnName("SALESBCODE");

                entity.Property(e => e.Modulecode).HasColumnName("MODULECODE");

                entity.Property(e => e.Credcontcode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("CREDCONTCODE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Credcontname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CREDCONTNAME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Crudmode)
                    .HasColumnName("crudmode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Crudorder).HasColumnName("crudorder");

                entity.Property(e => e.Cuscode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CUSCODE");

                entity.Property(e => e.Cusname)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("CUSNAME");

                entity.Property(e => e.Docamt)
                    .HasColumnName("DOCAMT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Docnumber)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DOCNUMBER");

                entity.Property(e => e.Docref)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DOCREF")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Doctotalexc)
                    .HasColumnName("DOCTOTALEXC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Docuser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DOCUSER")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Docvat)
                    .HasColumnName("DOCVAT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Goodscost)
                    .HasColumnName("GOODSCOST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Invoicetype)
                    .HasColumnName("INVOICETYPE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Invoicetypename)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("INVOICETYPENAME");

                entity.Property(e => e.Itmcode)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ITMCODE");

                entity.Property(e => e.Itmname)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("ITMNAME");

                entity.Property(e => e.Itmpack)
                    .HasColumnName("ITMPACK")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Itmprice).HasColumnName("ITMPRICE");

                entity.Property(e => e.Itmtax).HasColumnName("ITMTAX");

                entity.Property(e => e.Itmtotalcost).HasColumnName("ITMTOTALCOST");

                entity.Property(e => e.Itmtotalexc)
                    .HasColumnName("ITMTOTALEXC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Itmtotalinc)
                    .HasColumnName("ITMTOTALINC")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Kahtocode)
                    .HasColumnName("kahtocode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Memberno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MEMBERNO")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Mempointsbuy)
                    .HasColumnName("MEMPOINTSBUY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mempointsredeem)
                    .HasColumnName("MEMPOINTSREDEEM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Myperiod)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("MYPERIOD");

                entity.Property(e => e.Pw)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PW")
                    .IsFixedLength(true);

                entity.Property(e => e.Qtysold)
                    .HasColumnName("QTYSOLD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Qtysoldpw)
                    .HasColumnName("QTYSOLDPW")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Routecode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("ROUTECODE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Routename)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ROUTENAME")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Saledate)
                    .HasColumnType("datetime")
                    .HasColumnName("SALEDATE");

                entity.Property(e => e.Salesbranch)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SALESBRANCH");

                entity.Property(e => e.Salesman)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SALESman");

                entity.Property(e => e.SalesmanCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SALESmanCODE");

                entity.Property(e => e.Saletime).HasColumnName("SALETIME");

                entity.Property(e => e.Stockpw)
                    .HasColumnName("STOCKPW")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Towncode)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TOWNCODE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Townname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TOWNNAME")
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<SpCategory>(entity =>
            {
                entity.HasKey(e => e.SpcatgCode);

                entity.ToTable("SP_CATEGORY");

                entity.Property(e => e.SpcatgCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SPCATG_CODE");

                entity.Property(e => e.SpcatgGl)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SPCATG_GL");

                entity.Property(e => e.SpcatgName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SPCATG_NAME");
            });

            modelBuilder.Entity<Stock>(entity =>
            {
                entity.HasKey(e => e.Itmcode);

                entity.ToTable("STOCK");

                entity.Property(e => e.Itmcode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ITMCODE");

                entity.Property(e => e.Classcode).HasColumnName("CLASSCODE");

                entity.Property(e => e.Classname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CLASSNAME");

                entity.Property(e => e.Crudorder).HasColumnName("crudorder");

                entity.Property(e => e.Formcode).HasColumnName("FORMCODE");

                entity.Property(e => e.Formname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FORMNAME");

                entity.Property(e => e.Gpcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GPCODE");

                entity.Property(e => e.Gpname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("GPNAME");

                entity.Property(e => e.Itmname)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ITMNAME");

                entity.Property(e => e.Mnfcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("MNFCODE");

                entity.Property(e => e.Mnfname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MNFNAME");

                entity.Property(e => e.Packqty)
                    .HasColumnName("PACKQTY")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Phyitem).HasColumnName("PHYITEM");

                entity.Property(e => e.Pkgcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PKGCODE");

                entity.Property(e => e.Pkgname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PKGNAME");

                entity.Property(e => e.Sbgpcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SBGPCODE");

                entity.Property(e => e.Sbgpname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SBGPNAME");

                entity.Property(e => e.Stockavgcost)
                    .HasColumnName("STOCKAVGCOST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Stocklastcost)
                    .HasColumnName("STOCKLASTCOST")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Stockretailprice)
                    .HasColumnName("STOCKRETAILPRICE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Stocktradeprice)
                    .HasColumnName("STOCKTRADEPRICE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Stockwsaleprice)
                    .HasColumnName("STOCKWSALEPRICE")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<SuppContact>(entity =>
            {
                entity.HasKey(e => new { e.SuppCode, e.ContNum });

                entity.ToTable("SUPP_CONTACTS");

                entity.Property(e => e.SuppCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SUPP_CODE");

                entity.Property(e => e.ContNum)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("CONT_NUM");

                entity.Property(e => e.Cellphone)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("CELLPHONE");

                entity.Property(e => e.Contact)
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasColumnName("CONTACT");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fax)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .HasColumnName("FAX");

                entity.Property(e => e.Phyaddress)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PHYADDRESS");

                entity.Property(e => e.Telephone)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TELEPHONE");
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity.HasKey(e => e.SuppCode);

                entity.ToTable("SUPPLIER");

                entity.Property(e => e.SuppCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SUPP_CODE");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Bcode).HasColumnName("bcode");

                entity.Property(e => e.Blocked).HasColumnName("BLOCKED");

                entity.Property(e => e.Cellcountry)
                    .HasMaxLength(255)
                    .HasColumnName("cellcountry");

                entity.Property(e => e.Cellname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("cellname");

                entity.Property(e => e.Cellnumber)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("cellnumber");

                entity.Property(e => e.Creditlimit).HasColumnName("CREDITLIMIT");

                entity.Property(e => e.Currencycode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CURRENCYCODE");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Fax)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("FAX");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");

                entity.Property(e => e.Physicaladd)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("PHYSICALADD");

                entity.Property(e => e.Pinno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("PINNO");

                entity.Property(e => e.SpcatgCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("SPCATG_CODE");

                entity.Property(e => e.SuppDesc)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("SUPP_DESC");

                entity.Property(e => e.Town)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("TOWN");

                entity.Property(e => e.TownCode).HasColumnName("town_code");

                entity.Property(e => e.Vatno)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("VATNO");
            });

            modelBuilder.Entity<Sysdefault>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYSDEFAULTS");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Autosbgcode)
                    .HasColumnName("AUTOSBGCODE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Autostockcode)
                    .HasColumnName("autostockcode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Bcode).HasColumnName("BCODE");

                entity.Property(e => e.Clouddb)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CLOUDDB");

                entity.Property(e => e.Cloudip)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CLOUDIP");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentEnddate)
                    .HasColumnType("datetime")
                    .HasColumnName("CURRENT_ENDDATE");

                entity.Property(e => e.CurrentPeriod)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CURRENT_PERIOD");

                entity.Property(e => e.CurrentStartdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CURRENT_STARTDATE");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Invhyphen)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("invhyphen")
                    .HasDefaultValueSql("('INV')");

                entity.Property(e => e.Itemcodestyle)
                    .HasColumnName("itemcodestyle")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Maindb)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MAINDB");

                entity.Property(e => e.Phone)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PhysicalAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Pinno)
                    .HasMaxLength(24)
                    .IsUnicode(false)
                    .HasColumnName("PINNO");

                entity.Property(e => e.Town)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Vatno)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("VATNO");

                entity.Property(e => e.Xchdb)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("XCHDB");
            });

            modelBuilder.Entity<Sysmodule>(entity =>
            {
                entity.HasKey(e => e.ModuleCode);

                entity.ToTable("SYSMODULES");

                entity.Property(e => e.ModuleCode)
                    .ValueGeneratedNever()
                    .HasColumnName("MODULE_CODE");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("AREA");

                entity.Property(e => e.Loadable).HasColumnName("LOADABLE");

                entity.Property(e => e.Modul)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("MODUL");
            });

            modelBuilder.Entity<Sysnextnumber>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("SYSNEXTNUMBERS");

                entity.Property(e => e.NextBmtNum)
                    .HasColumnName("nextBMT_num")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextBrinDetNum)
                    .HasColumnName("nextBRIN_DET_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextBrnDetNum)
                    .HasColumnName("nextBRN_DET_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextBtransDetNum)
                    .HasColumnName("nextBTRANS_DET_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextCashpricepromoentrynum)
                    .HasColumnName("nextCASHPRICEPROMOENTRYNUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextIbiDetNum)
                    .HasColumnName("nextIBI_DET_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextMnfDetNum)
                    .HasColumnName("nextMNF_DET_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextMnfNum)
                    .HasColumnName("nextMNF_num")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextMsgnum)
                    .HasColumnName("NEXT_MSGNUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextNxtstkadj)
                    .HasColumnName("nextNXTSTKADJ")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextPaymodenum)
                    .HasColumnName("nextPAYMODENUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextPrice)
                    .HasColumnName("NEXT_PRICE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextQuoDetNumon)
                    .HasColumnName("nextQUO_DET_NUMON")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextRqgCode)
                    .HasColumnName("nextRQg_code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextSppriceentrynum)
                    .HasColumnName("nextSPPRICEENTRYNUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nextacctcatgcode)
                    .HasColumnName("NEXTACCTCATGCODE")
                    .HasDefaultValueSql("((20))");

                entity.Property(e => e.NextauthNum)
                    .HasColumnName("nextauth_num")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextbRnNum)
                    .HasColumnName("nextbRN_num")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextbillNum)
                    .HasColumnName("NEXTBILL_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nextbnkcode)
                    .HasColumnName("NEXTBNKCODE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextborderDetNum)
                    .HasColumnName("nextborder_det_num")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextborderNum)
                    .HasColumnName("nextborder_num")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nextbranchcode)
                    .HasColumnName("NEXTBRANCHCODE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextbrepNum)
                    .HasColumnName("nextbrep_num")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextbtransNum)
                    .HasColumnName("nextbtrans_num")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextcashPriceentrynum)
                    .HasColumnName("nextcashPRICEENTRYNUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextcinvNum)
                    .HasColumnName("nextcinv_num")
                    .HasDefaultValueSql("((90000001))");

                entity.Property(e => e.Nextclasscode)
                    .HasColumnName("nextclasscode")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextcnoteDetNum)
                    .HasColumnName("nextcnote_det_num")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextcnoteNum)
                    .HasColumnName("NEXTCNOTE_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextcontNum)
                    .HasColumnName("nextcont_num")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextcsaleDetNum)
                    .HasColumnName("nextcsale_det_num")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextcsaleNum)
                    .HasColumnName("NEXTCSALE_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextcusCode).HasColumnName("NEXTCUS_CODE");

                entity.Property(e => e.NextdedNum)
                    .HasColumnName("NEXTDED_NUM")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.NextdeptCode)
                    .HasColumnName("NEXTDEPT_CODE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextdeptNum)
                    .HasColumnName("NEXTDEPT_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextempNum)
                    .HasColumnName("NEXTEMP_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NexternNum)
                    .HasColumnName("NEXTERN_NUM")
                    .HasDefaultValueSql("((5))");

                entity.Property(e => e.NexteventNum)
                    .HasColumnName("Nextevent_num")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nextforexentrynum)
                    .HasColumnName("nextforexentrynum")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nextformcode)
                    .HasColumnName("nextformcode")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextgljNum)
                    .HasColumnName("NEXTGLJ_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nextgljrnnum)
                    .HasColumnName("NEXTGLJRNNUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nextgp1code)
                    .HasColumnName("nextgp1code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nextgp2code)
                    .HasColumnName("nextgp2code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nextgp3code)
                    .HasColumnName("nextgp3code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nextgp4code)
                    .HasColumnName("nextgp4code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nextgpcode)
                    .HasColumnName("NEXTGPCODE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextgretNum)
                    .HasColumnName("NEXTGRET_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextgrnNum)
                    .HasColumnName("NEXTGRN_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextibiNum).HasColumnName("Nextibi_num");

                entity.Property(e => e.Nextijrnnum)
                    .HasColumnName("NEXTIJRNNUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextinvCode)
                    .HasColumnName("nextinv_code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextinvjNum)
                    .HasColumnName("NEXTINVJ_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextjournNum)
                    .HasColumnName("NEXTJOURN_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextlocCode)
                    .HasColumnName("NEXTLOC_CODE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nextmemberno)
                    .HasColumnName("NEXTMEMBERNO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nextmnfcode)
                    .HasColumnName("NEXTMNFCODE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextnoncnoteNum)
                    .HasColumnName("nextnoncnote_num")
                    .HasDefaultValueSql("((60000001))");

                entity.Property(e => e.NextnonregcashinvNum)
                    .HasColumnName("nextnonregcashinv_num")
                    .HasDefaultValueSql("((70000001))");

                entity.Property(e => e.NextnonreginvNum)
                    .HasColumnName("nextnonreginv_num")
                    .HasDefaultValueSql("((60000001))");

                entity.Property(e => e.Nextpacklist)
                    .HasColumnName("NEXTPACKLIST")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nextpayalloc)
                    .HasColumnName("nextpayalloc")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextpensNum)
                    .HasColumnName("NEXTPENS_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextpkgCode)
                    .HasColumnName("nextpkg_code")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextporderNum)
                    .HasColumnName("NEXTPORDER_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextprescNum)
                    .HasColumnName("nextpresc_num")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextquoNum)
                    .HasColumnName("NEXTQUO_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextrecurrCode)
                    .HasColumnName("NEXTRECURR_CODE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextremndNum)
                    .HasColumnName("nextremnd_num")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextreqNum)
                    .HasColumnName("NEXTreq_num")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nextrptalloc)
                    .HasColumnName("nextrptalloc")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nextrptcat)
                    .HasColumnName("NEXTRPTCAT")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextsaleinvDetNum)
                    .HasColumnName("nextsaleinv_det_num")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextsaleinvNum)
                    .HasColumnName("NEXTSALEINV_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nextsbgcode)
                    .HasColumnName("NEXTSBGCODE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextscjournNum)
                    .HasColumnName("nextscjourn_num")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextsinvNum)
                    .HasColumnName("NEXTSINV_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nextsmancode)
                    .HasColumnName("NEXTSMANCODE")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextsoNum)
                    .HasColumnName("NEXTSO_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextstkNum)
                    .HasColumnName("NEXTSTK_NUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextstkadjNum).HasColumnName("NEXTSTKADJ_NUM");

                entity.Property(e => e.NextstkoutNum).HasColumnName("NEXTSTKOUT_NUM");

                entity.Property(e => e.Nextstkpricenum)
                    .HasColumnName("NEXTSTKPRICENUM")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nextstkref)
                    .HasColumnName("nextstkref")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.NextsuppCode).HasColumnName("NEXTSUPP_CODE");

                entity.Property(e => e.Nextusertoken)
                    .HasColumnName("nextusertoken")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Userdataid)
                    .HasColumnName("userdataid")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<TaxType>(entity =>
            {
                entity.HasKey(e => e.TaxCode);

                entity.ToTable("TAX_TYPE");

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TAX_CODE");

                entity.Property(e => e.Amount).HasColumnName("AMOUNT");

                entity.Property(e => e.Description)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DESCRIPTION");
            });

            modelBuilder.Entity<Thebranch>(entity =>
            {
                entity.HasKey(e => new { e.Branchcode, e.Bcode });

                entity.ToTable("THEBRANCH");

                entity.Property(e => e.Branchcode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("BRANCHCODE");

                entity.Property(e => e.Bcode).HasColumnName("BCODE");

                entity.Property(e => e.BranchName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("BRANCH_NAME");
            });

            modelBuilder.Entity<Till>(entity =>
            {
                entity.HasKey(e => new { e.Tillno, e.Bcode });

                entity.ToTable("TILLS");

                entity.Property(e => e.Tillno).HasColumnName("TILLNO");

                entity.Property(e => e.Bcode).HasColumnName("bcode");

                entity.Property(e => e.BankAcct)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("bank_acct");

                entity.Property(e => e.Defusername)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DEFUSERNAME");

                entity.Property(e => e.Nexttillsessno).HasColumnName("NEXTTILLSESSNO");

                entity.Property(e => e.Tillactive).HasColumnName("TILLACTIVE");

                entity.Property(e => e.Tillmaximum).HasColumnName("TILLMAXIMUM");

                entity.Property(e => e.Tillname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TILLNAME");

                entity.Property(e => e.Tillsessno).HasColumnName("TILLSESSNO");

                entity.Property(e => e.Tilluser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TILLUSER");
            });

            modelBuilder.Entity<Town>(entity =>
            {
                entity.HasKey(e => e.TownCode);

                entity.ToTable("TOWNS");

                entity.Property(e => e.TownCode).HasColumnName("TOWN_CODE");

                entity.Property(e => e.ProvinceCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .HasColumnName("PROVINCE_CODE");

                entity.Property(e => e.Town1)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("TOWN");

                entity.HasOne(d => d.ProvinceCodeNavigation)
                    .WithMany(p => p.Towns)
                    .HasForeignKey(d => d.ProvinceCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Trackcollect>(entity =>
            {
                entity.HasKey(e => new { e.Collectnum, e.Bcode, e.SaleinvNum, e.Doctype })
                    .HasName("PK_TRACKCOLLECT_1");

                entity.ToTable("TRACKCOLLECT");

                entity.Property(e => e.Collectnum).HasColumnName("COLLECTNUM");

                entity.Property(e => e.Bcode).HasColumnName("BCODE");

                entity.Property(e => e.SaleinvNum).HasColumnName("SALEINV_NUM");

                entity.Property(e => e.Doctype)
                    .HasColumnName("doctype")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Batched)
                    .HasColumnName("BATCHED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CmCode).HasColumnName("CM_CODE");

                entity.Property(e => e.CmName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CM_NAME");

                entity.Property(e => e.Collectcontrol)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COLLECTCONTROL");

                entity.Property(e => e.Collectdate)
                    .HasColumnType("datetime")
                    .HasColumnName("COLLECTDATE");

                entity.Property(e => e.Collectedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("COLLECTEDBY");

                entity.Property(e => e.Collectid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COLLECTID");

                entity.Property(e => e.Collectpackages)
                    .HasColumnName("COLLECTPACKAGES")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Collectsalesman)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("COLLECTSALESMAN");

                entity.Property(e => e.Collectstartdate)
                    .HasColumnType("datetime")
                    .HasColumnName("COLLECTSTARTDATE");

                entity.Property(e => e.Collectstarttime)
                    .HasColumnType("datetime")
                    .HasColumnName("COLLECTSTARTTIME");

                entity.Property(e => e.Collecttime)
                    .HasColumnType("datetime")
                    .HasColumnName("COLLECTTIME");

                entity.Property(e => e.Collecttransporter)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("COLLECTTRANSPORTER");

                entity.Property(e => e.Collectturnaround)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("COLLECTTURNAROUND")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Collectweight)
                    .HasColumnName("COLLECTWEIGHT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Crudmode)
                    .HasColumnName("crudmode")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Crudorder).HasColumnName("crudorder");

                entity.Property(e => e.CtCode).HasColumnName("CT_CODE");

                entity.Property(e => e.CtName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CT_NAME");

                entity.Property(e => e.Dispatched)
                    .HasColumnName("DISPATCHED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Dispatchedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DISPATCHEDBY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Dispatchnum)
                    .HasColumnName("DISPATCHNUM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hrsid)
                    .HasColumnName("HRSID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hrsiddrv)
                    .HasColumnName("HRSIDDRV")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hrsname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HRSNAME");

                entity.Property(e => e.Kahtocode)
                    .HasColumnName("kahtocode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Packlistno).HasColumnName("PACKLISTNO");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.SalesCode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SALES_CODE")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Sameascontrol)
                    .HasColumnName("SAMEASCONTROL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TranspCode)
                    .HasColumnName("TRANSP_CODE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VehCode).HasColumnName("VEH_CODE");

                entity.Property(e => e.VehDeliveryid)
                    .HasColumnName("VEH_DELIVERYID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VehDriver)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VEH_DRIVER");

                entity.Property(e => e.VehDriverid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VEH_DRIVERID");

                entity.Property(e => e.VehMake)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VEH_MAKE");

                entity.Property(e => e.VehReg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VEH_REG");
            });

            modelBuilder.Entity<Trackcollectdispatch>(entity =>
            {
                entity.HasKey(e => new { e.Dispatchnum, e.SaleinvNum, e.Bcode, e.Doctype });

                entity.ToTable("TRACKCOLLECTDISPATCH");

                entity.Property(e => e.Dispatchnum).HasColumnName("DISPATCHNUM");

                entity.Property(e => e.SaleinvNum).HasColumnName("SALEINV_NUM");

                entity.Property(e => e.Bcode).HasColumnName("BCODE");

                entity.Property(e => e.Doctype).HasColumnName("DOCTYPE");

                entity.Property(e => e.Carname)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("CARNAME");

                entity.Property(e => e.Collectnum).HasColumnName("COLLECTNUM");

                entity.Property(e => e.Crudmode)
                    .HasColumnName("crudmode")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Crudorder).HasColumnName("crudorder");

                entity.Property(e => e.CtCode).HasColumnName("CT_CODE");

                entity.Property(e => e.CtName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CT_NAME");

                entity.Property(e => e.Dispatchcomments)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("DISPATCHCOMMENTS");

                entity.Property(e => e.Dispatchdate)
                    .HasColumnType("datetime")
                    .HasColumnName("DISPATCHDATE");

                entity.Property(e => e.Dispatchdetnum).HasColumnName("DISPATCHDETNUM");

                entity.Property(e => e.Dispatchnumber)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DISPATCHNUMBER");

                entity.Property(e => e.Dispatchuser)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DISPATCHUSER");

                entity.Property(e => e.Dispbatched)
                    .HasColumnName("DISPBATCHED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Drivername)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("DRIVERNAME");

                entity.Property(e => e.Hrsiddrv).HasColumnName("HRSIDDRV");

                entity.Property(e => e.Kahtocode)
                    .HasColumnName("kahtocode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Routecode).HasColumnName("ROUTECODE");

                entity.Property(e => e.Routename)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ROUTENAME");

                entity.Property(e => e.VehDeliveryid).HasColumnName("VEH_DELIVERYID");
            });

            modelBuilder.Entity<Trackdeliver>(entity =>
            {
                entity.HasKey(e => new { e.Delivernum, e.Bcode, e.SaleinvNum, e.Doctype });

                entity.ToTable("TRACKDELIVER");

                entity.Property(e => e.Delivernum).HasColumnName("DELIVERNUM");

                entity.Property(e => e.Bcode).HasColumnName("BCODE");

                entity.Property(e => e.SaleinvNum).HasColumnName("SALEINV_NUM");

                entity.Property(e => e.Doctype)
                    .HasColumnName("doctype")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Batched)
                    .HasColumnName("BATCHED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Crudmode)
                    .HasColumnName("crudmode")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Crudorder).HasColumnName("crudorder");

                entity.Property(e => e.DelCode).HasColumnName("DEL_CODE");

                entity.Property(e => e.DelName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DEL_NAME");

                entity.Property(e => e.Delivercontrol)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERCONTROL");

                entity.Property(e => e.Deliverdate)
                    .HasColumnType("datetime")
                    .HasColumnName("DELIVERDATE");

                entity.Property(e => e.Deliveredby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("DELIVEREDBY");

                entity.Property(e => e.Deliverid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERID");

                entity.Property(e => e.Deliverpackages)
                    .HasColumnName("DELIVERPACKAGES")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Deliverstartdate)
                    .HasColumnType("datetime")
                    .HasColumnName("DELIVERSTARTDATE");

                entity.Property(e => e.Deliverstarttime)
                    .HasColumnType("datetime")
                    .HasColumnName("DELIVERSTARTTIME");

                entity.Property(e => e.Delivertime)
                    .HasColumnType("datetime")
                    .HasColumnName("DELIVERTIME");

                entity.Property(e => e.Deliverturnaround)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DELIVERTURNAROUND")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Deliverweight)
                    .HasColumnName("DELIVERWEIGHT")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DstatCode).HasColumnName("DSTAT_CODE");

                entity.Property(e => e.DstatName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("DSTAT_NAME");

                entity.Property(e => e.Hrsid)
                    .HasColumnName("HRSID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hrsiddrv)
                    .HasColumnName("HRSIDDRV")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hrsname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HRSNAME");

                entity.Property(e => e.Kahtocode)
                    .HasColumnName("kahtocode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Receivedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVEDBY")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Receivedid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("RECEIVEDID");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Sameascontrol)
                    .HasColumnName("SAMEASCONTROL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VehCode).HasColumnName("VEH_CODE");

                entity.Property(e => e.VehDeliveryid)
                    .HasColumnName("VEH_DELIVERYID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VehDriver)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VEH_DRIVER");

                entity.Property(e => e.VehDriverid)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VEH_DRIVERID");

                entity.Property(e => e.VehMake)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VEH_MAKE");

                entity.Property(e => e.VehReg)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VEH_REG");
            });

            modelBuilder.Entity<Trackdoc>(entity =>
            {
                entity.HasKey(e => new { e.Docnum, e.Bcode, e.Doctype });

                entity.ToTable("TRACKDOC");

                entity.Property(e => e.Docnum).HasColumnName("DOCNUM");

                entity.Property(e => e.Bcode).HasColumnName("bcode");

                entity.Property(e => e.Doctype)
                    .HasMaxLength(10)
                    .HasColumnName("DOCTYPE")
                    .IsFixedLength(true);

                entity.Property(e => e.Crudmode)
                    .HasColumnName("crudmode")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Crudorder).HasColumnName("crudorder");

                entity.Property(e => e.Cuscode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("CUSCODE");

                entity.Property(e => e.Cusname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("CUSNAME");

                entity.Property(e => e.Docitems)
                    .HasColumnName("DOCITEMS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Docnumber)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DOCNUMBER");

                entity.Property(e => e.Invtrack)
                    .HasColumnName("invtrack")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Kahtocode)
                    .HasColumnName("kahtocode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Modulecode).HasColumnName("MODULECODE");

                entity.Property(e => e.Printcopy)
                    .HasColumnName("PRINTCOPY")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Saledate)
                    .HasColumnType("datetime")
                    .HasColumnName("SALEDATE");

                entity.Property(e => e.Salesmancode)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("SALESMANCODE");

                entity.Property(e => e.Salesmanname)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("SALESMANNAME");

                entity.Property(e => e.Saletime).HasColumnName("SALETIME");
            });

            modelBuilder.Entity<Trackstore>(entity =>
            {
                entity.HasKey(e => new { e.Storenum, e.Bcode, e.SaleinvNum, e.Doctype });

                entity.ToTable("TRACKSTORE");

                entity.Property(e => e.Storenum).HasColumnName("STORENUM");

                entity.Property(e => e.Bcode).HasColumnName("BCODE");

                entity.Property(e => e.SaleinvNum).HasColumnName("SALEINV_NUM");

                entity.Property(e => e.Doctype)
                    .HasColumnName("doctype")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Batched)
                    .HasColumnName("BATCHED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Crudmode)
                    .HasColumnName("crudmode")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Crudorder).HasColumnName("crudorder");

                entity.Property(e => e.Hrsid)
                    .HasColumnName("HRSID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hrsname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HRSNAME");

                entity.Property(e => e.Kahtocode)
                    .HasColumnName("kahtocode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Mutliselnum)
                    .HasColumnName("MUTLISELNUM")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Removedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("REMOVEDBY");

                entity.Property(e => e.Sameascontrol)
                    .HasColumnName("SAMEASCONTROL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Storecontrol)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("STORECONTROL");

                entity.Property(e => e.Storedate)
                    .HasColumnType("datetime")
                    .HasColumnName("STOREDATE");

                entity.Property(e => e.Storepackage)
                    .HasColumnName("STOREPACKAGE")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Storestartdate)
                    .HasColumnType("datetime")
                    .HasColumnName("STORESTARTDATE");

                entity.Property(e => e.Storestarttime)
                    .HasColumnType("datetime")
                    .HasColumnName("STORESTARTTIME");

                entity.Property(e => e.Storetime)
                    .HasColumnType("datetime")
                    .HasColumnName("STORETIME");

                entity.Property(e => e.Storeturnaround)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("STORETURNAROUND")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Storeweight)
                    .HasColumnName("STOREWEIGHT")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Trackstoremultisel>(entity =>
            {
                entity.HasKey(e => new { e.Multiselnum, e.Multiselnumdet, e.Bcode, e.SaleinvNum, e.Doctype });

                entity.ToTable("TRACKSTOREMULTISEL");

                entity.Property(e => e.Multiselnum).HasColumnName("MULTISELNUM");

                entity.Property(e => e.Multiselnumdet).HasColumnName("MULTISELNUMDET");

                entity.Property(e => e.Bcode).HasColumnName("BCODE");

                entity.Property(e => e.SaleinvNum).HasColumnName("SALEINV_NUM");

                entity.Property(e => e.Doctype).HasColumnName("DOCTYPE");

                entity.Property(e => e.Crudmode)
                    .HasColumnName("crudmode")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Crudorder).HasColumnName("crudorder");

                entity.Property(e => e.Kahtocode)
                    .HasColumnName("kahtocode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Multiseldate)
                    .HasColumnType("datetime")
                    .HasColumnName("MULTISELDATE")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Multiseluser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("MULTISELUSER");
            });

            modelBuilder.Entity<Trackverify>(entity =>
            {
                entity.HasKey(e => new { e.Verifnum, e.SaleinvNum, e.Bcode, e.Doctype });

                entity.ToTable("TRACKVERIFY");

                entity.Property(e => e.Verifnum).HasColumnName("VERIFNUM");

                entity.Property(e => e.SaleinvNum).HasColumnName("SALEINV_NUM");

                entity.Property(e => e.Bcode).HasColumnName("BCODE");

                entity.Property(e => e.Doctype)
                    .HasColumnName("doctype")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Batched)
                    .HasColumnName("BATCHED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Crudmode)
                    .HasColumnName("crudmode")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Crudorder).HasColumnName("crudorder");

                entity.Property(e => e.Hrsid)
                    .HasColumnName("HRSID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hrsname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HRSNAME");

                entity.Property(e => e.Kahtocode)
                    .HasColumnName("kahtocode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Packlistno).HasColumnName("PACKLISTNO");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Sameascontrol)
                    .HasColumnName("SAMEASCONTROL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Verifcontrol)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VERIFCONTROL");

                entity.Property(e => e.Verifdate)
                    .HasColumnType("datetime")
                    .HasColumnName("VERIFDATE");

                entity.Property(e => e.Verifiedby)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VERIFIEDBY");

                entity.Property(e => e.Verifpackages)
                    .HasColumnName("VERIFPACKAGES")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Verifstartdate)
                    .HasColumnType("datetime")
                    .HasColumnName("VERIFSTARTDATE");

                entity.Property(e => e.Verifstarttime)
                    .HasColumnType("datetime")
                    .HasColumnName("VERIFSTARTTIME");

                entity.Property(e => e.Veriftime)
                    .HasColumnType("datetime")
                    .HasColumnName("VERIFTIME");

                entity.Property(e => e.Verifturnaround)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VERIFTURNAROUND")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Verifweight)
                    .HasColumnName("VERIFWEIGHT")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Trackverifytwo>(entity =>
            {
                entity.HasKey(e => new { e.Veriftwonum, e.SaleinvNum, e.Bcode, e.Doctype });

                entity.ToTable("TRACKVERIFYTWO");

                entity.Property(e => e.Veriftwonum).HasColumnName("VERIFTWONUM");

                entity.Property(e => e.SaleinvNum).HasColumnName("SALEINV_NUM");

                entity.Property(e => e.Bcode).HasColumnName("BCODE");

                entity.Property(e => e.Doctype)
                    .HasColumnName("doctype")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Batched)
                    .HasColumnName("BATCHED")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Crudmode)
                    .HasColumnName("crudmode")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Crudorder).HasColumnName("crudorder");

                entity.Property(e => e.Hrsid)
                    .HasColumnName("HRSID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hrsname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("HRSNAME");

                entity.Property(e => e.Kahtocode)
                    .HasColumnName("kahtocode")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Packlistno).HasColumnName("PACKLISTNO");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("REMARKS");

                entity.Property(e => e.Sameascontrol)
                    .HasColumnName("SAMEASCONTROL")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Verifiedbytwo)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VERIFIEDBYTWO");

                entity.Property(e => e.Veriftwocontrol)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("VERIFTWOCONTROL");

                entity.Property(e => e.Veriftwodate)
                    .HasColumnType("datetime")
                    .HasColumnName("VERIFTWODATE");

                entity.Property(e => e.Veriftwopackages)
                    .HasColumnName("VERIFTWOPACKAGES")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Veriftwostartdate)
                    .HasColumnType("datetime")
                    .HasColumnName("VERIFTWOSTARTDATE");

                entity.Property(e => e.Veriftwostarttime)
                    .HasColumnType("datetime")
                    .HasColumnName("VERIFTWOSTARTTIME");

                entity.Property(e => e.Veriftwotime)
                    .HasColumnType("datetime")
                    .HasColumnName("VERIFTWOTIME");

                entity.Property(e => e.Veriftwoturnaround)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("VERIFTWOTURNAROUND")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Veriftwoweight)
                    .HasColumnName("VERIFTWOWEIGHT")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Transtime>(entity =>
            {
                entity.HasKey(e => e.Transhour);

                entity.ToTable("TRANSTIME");

                entity.Property(e => e.Transhour)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TRANSHOUR");
            });

            modelBuilder.Entity<Tx001>(entity =>
            {
                entity.HasKey(e => e.Txtype);

                entity.ToTable("TX001");

                entity.Property(e => e.Txtype)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TXTYPE")
                    .IsFixedLength(true);

                entity.Property(e => e.TaxCode)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasColumnName("TAX_CODE");

                entity.Property(e => e.Txglacct)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("TXGLACCT");

                entity.Property(e => e.Txname)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("TXNAME");

                entity.Property(e => e.Withholdvat).HasColumnName("withholdvat");
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.HasKey(e => e.UserGroup1);

                entity.ToTable("USER_GROUPS");

                entity.Property(e => e.UserGroup1)
                    .HasMaxLength(30)
                    .HasColumnName("USER_GROUP");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("DESCRIPTION");
            });

            modelBuilder.Entity<UsergroupRight>(entity =>
            {
                entity.HasKey(e => new { e.UserGroup, e.ModuleCode });

                entity.ToTable("USERGROUP_RIGHTS");

                entity.Property(e => e.UserGroup)
                    .HasMaxLength(30)
                    .HasColumnName("USER_GROUP");

                entity.Property(e => e.ModuleCode).HasColumnName("MODULE_CODE");

                entity.Property(e => e.Status).HasColumnName("STATUS");

                entity.HasOne(d => d.ModuleCodeNavigation)
                    .WithMany(p => p.UsergroupRights)
                    .HasForeignKey(d => d.ModuleCode)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.UserGroupNavigation)
                    .WithMany(p => p.UsergroupRights)
                    .HasForeignKey(d => d.UserGroup)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
