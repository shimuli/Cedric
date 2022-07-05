using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Cedric.Models.SchoolDB
{
    public partial class SCHOOLSYSTEMContext : DbContext
    {
        public SCHOOLSYSTEMContext()
        {
        }

        public SCHOOLSYSTEMContext(DbContextOptions<SCHOOLSYSTEMContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Branch> Branches { get; set; }
        public virtual DbSet<Class> Classes { get; set; }
        public virtual DbSet<ClassStream> ClassStreams { get; set; }
        public virtual DbSet<ClassSubject> ClassSubjects { get; set; }
        public virtual DbSet<Parent> Parents { get; set; }
        public virtual DbSet<ParentStudent> ParentStudents { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<SchoolDetail> SchoolDetails { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<StudentEmergyDetail> StudentEmergyDetails { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<SubjectUnit> SubjectUnits { get; set; }
        public virtual DbSet<Supportstaff> Supportstaffs { get; set; }
        public virtual DbSet<Systemdefault> Systemdefaults { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<TeacherClass> TeacherClasses { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserBranch> UserBranches { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Name=School");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.HasKey(e => e.Bcode)
                    .HasName("PK__Branches__8933904D0B194760");

                entity.Property(e => e.Bcode).HasColumnName("bcode");

                entity.Property(e => e.BranchhName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Class>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Stream)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.StreamId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Classes__StreamI__41EDCAC5");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__Classes__Teacher__45F365D3");
            });

            modelBuilder.Entity<ClassStream>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<ClassSubject>(entity =>
            {
                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ClassSubjects)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__ClassSubj__Class__46E78A0C");

                entity.HasOne(d => d.Subejct)
                    .WithMany(p => p.ClassSubjects)
                    .HasForeignKey(d => d.SubejctId)
                    .HasConstraintName("FK__ClassSubj__Subej__47DBAE45");
            });

            modelBuilder.Entity<Parent>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Identification)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NationalId)
                    .IsRequired()
                    .HasColumnName("NationalID");

                entity.Property(e => e.Occupation)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PassportPhoto).IsRequired();

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Relation)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<ParentStudent>(entity =>
            {
                entity.ToTable("ParentStudent");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.ParentStudents)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK__ParentStu__Paren__48CFD27E");

                entity.HasOne(d => d.Student)
                    .WithMany(p => p.ParentStudents)
                    .HasForeignKey(d => d.StudentId)
                    .HasConstraintName("FK__ParentStu__Stude__49C3F6B7");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<SchoolDetail>(entity =>
            {
                entity.Property(e => e.SchoolCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SchoolName)
                    .IsRequired()
                    .HasMaxLength(1000);
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.Property(e => e.Bcode).HasColumnName("bcode");

                entity.Property(e => e.BloodGroup).HasMaxLength(100);

                entity.Property(e => e.Citizenship)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.DisabilityType).HasMaxLength(100);

                entity.Property(e => e.DoA).HasColumnType("datetime");

                entity.Property(e => e.Dob).HasColumnType("datetime");

                entity.Property(e => e.DoctorContact)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.DoctorName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EmergencyPhone)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.EnrollmentType)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.EntryMark)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("FName");

                entity.Property(e => e.FormerSchool)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.HomeCounty)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.HospitalName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("LName");

                entity.Property(e => e.Mname)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("MName");

                entity.Property(e => e.ParentsStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Religion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Residence)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.ScholarshipType).HasMaxLength(100);

                entity.Property(e => e.SchoolCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SpecialNeeds).HasMaxLength(100);

                entity.Property(e => e.SponsorContactPerson).HasMaxLength(100);

                entity.Property(e => e.SponsorDetails).HasMaxLength(100);

                entity.Property(e => e.SponsorLocation).HasMaxLength(100);

                entity.Property(e => e.SponsorPhone).HasMaxLength(100);

                entity.Property(e => e.StudentEmail).HasMaxLength(100);

                entity.Property(e => e.StudentPhone).HasMaxLength(100);

                entity.Property(e => e.StudentRegNum)
                    .IsRequired()
                    .HasMaxLength(1000);

                entity.Property(e => e.SubCounty).HasMaxLength(100);

                entity.HasOne(d => d.BcodeNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Bcode)
                    .HasConstraintName("FK__Students__bcode__4AB81AF0");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__Students__ClassI__4BAC3F29");

                entity.HasOne(d => d.Emergency)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.EmergencyId)
                    .HasConstraintName("FK__Students__Emerge__4CA06362");
            });

            modelBuilder.Entity<StudentEmergyDetail>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Identification)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.InfoProvidedBy)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Occupation)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PostalCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Relation)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Subject>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.SubjectCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SubjectIntials)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SubjectName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Type).HasMaxLength(200);
            });

            modelBuilder.Entity<SubjectUnit>(entity =>
            {
                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.UnitsCode)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.UnitsIntials)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.UnitsName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.Subject)
                    .WithMany(p => p.SubjectUnits)
                    .HasForeignKey(d => d.SubjectId)
                    .HasConstraintName("FK__SubjectUn__Subje__4D94879B");
            });

            modelBuilder.Entity<Supportstaff>(entity =>
            {
                entity.ToTable("SUPPORTSTAFF");

                entity.Property(e => e.AdditionalInfo).IsRequired();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Bcode).HasColumnName("bcode");

                entity.Property(e => e.Citizenship)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ContractType)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DisabilityType).HasMaxLength(100);

                entity.Property(e => e.Dob).HasColumnType("datetime");

                entity.Property(e => e.Doe)
                    .HasColumnType("datetime")
                    .HasColumnName("DOE");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("FName");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IdNumber)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("LName");

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mname)
                    .HasMaxLength(200)
                    .HasColumnName("MName");

                entity.Property(e => e.NationalIdcopy)
                    .IsRequired()
                    .HasColumnName("NationalIDCopy");

                entity.Property(e => e.NextKinAdditionalInfo)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NextKinAddress)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NextKinEmail)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NextKinFullName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NextKinPhone)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PassportPhoto)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Pinnumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PINNUmber");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Qualification).HasMaxLength(200);

                entity.Property(e => e.Religion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TeacherNumber)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.BcodeNavigation)
                    .WithMany(p => p.Supportstaffs)
                    .HasForeignKey(d => d.Bcode)
                    .HasConstraintName("FK__SUPPORTSTAFF__bcode__5070F446");
            });

            modelBuilder.Entity<Systemdefault>(entity =>
            {
                entity.ToTable("SYSTEMDEFAULTS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Logo).HasColumnName("logo");

                entity.Property(e => e.SchoolName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Smskey)
                    .IsRequired()
                    .HasColumnName("SMSKey");

                entity.Property(e => e.Smsname).HasColumnName("SMSName");

                entity.Property(e => e.SmsuserId)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("SMSUserId");

                entity.Property(e => e.StaffInitials)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.StudentInitials)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.TeacherInitials)
                    .IsRequired()
                    .HasMaxLength(5);
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.ToTable("TEACHERS");

                entity.Property(e => e.AdditionalInfo).IsRequired();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Bcode).HasColumnName("bcode");

                entity.Property(e => e.Citizenship)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.ContractType)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CredentialCertificate).IsRequired();

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.DisabilityType).HasMaxLength(100);

                entity.Property(e => e.Dob).HasColumnType("datetime");

                entity.Property(e => e.Doe)
                    .HasColumnType("datetime")
                    .HasColumnName("DOE");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Fname)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("FName");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.IdNumber)
                    .IsRequired()
                    .HasMaxLength(15);

                entity.Property(e => e.Knutmember).HasColumnName("KNUTMember");

                entity.Property(e => e.Knutnumber)
                    .HasMaxLength(50)
                    .HasColumnName("KNUTNumber");

                entity.Property(e => e.Kuppetmember).HasColumnName("KUPPETMember");

                entity.Property(e => e.Kuppetnumber)
                    .HasMaxLength(50)
                    .HasColumnName("KUPPETNumber");

                entity.Property(e => e.Lname)
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnName("LName");

                entity.Property(e => e.MaritalStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Mname)
                    .HasMaxLength(200)
                    .HasColumnName("MName");

                entity.Property(e => e.NationalIdcopy)
                    .IsRequired()
                    .HasColumnName("NationalIDCopy");

                entity.Property(e => e.NextKinAdditionalInfo)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NextKinAddress)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NextKinEmail)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NextKinFullName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.NextKinPhone)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PassportPhoto)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Pinnumber)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("PINNUmber");

                entity.Property(e => e.Position)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Qualification)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Religion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TeacherNumber)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Tscemployee).HasColumnName("TSCEmployee");

                entity.Property(e => e.Tscletter).HasColumnName("TSCLetter");

                entity.Property(e => e.Tscnumber)
                    .HasMaxLength(50)
                    .HasColumnName("TSCNumber");

                entity.HasOne(d => d.BcodeNavigation)
                    .WithMany(p => p.Teachers)
                    .HasForeignKey(d => d.Bcode)
                    .HasConstraintName("FK__TEACHERS__bcode__5070F446");
            });

            modelBuilder.Entity<TeacherClass>(entity =>
            {
                entity.ToTable("TeacherClass");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.TeacherClasses)
                    .HasForeignKey(d => d.ClassId)
                    .HasConstraintName("FK__TeacherCl__Class__4E88ABD4");

                entity.HasOne(d => d.Teacher)
                    .WithMany(p => p.TeacherClasses)
                    .HasForeignKey(d => d.TeacherId)
                    .HasConstraintName("FK__TeacherCl__Teach__4F7CD00D");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DateUpdated).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Password).IsRequired();

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.HasOne(d => d.School)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.SchoolId)
                    .HasConstraintName("FK__Users__SchoolId__2A4B4B5E");
            });

            modelBuilder.Entity<UserBranch>(entity =>
            {
                entity.ToTable("UserBranch");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.UserBranches)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserBranc__Branc__66603565");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserBranches)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserBranc__UserI__656C112C");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
