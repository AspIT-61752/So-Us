using Microsoft.EntityFrameworkCore;
using SoUs.Entity;

namespace SoUs.DataAccess
{
    public class SoUsDbContext : DbContext
    {
        #region Fields
        #endregion

        #region Constructors

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SoUsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";

            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer(connectionString);
            }
        }

        public SoUsDbContext(DbContextOptions<SoUsDbContext> options) : base(options)
        {
        }

        public SoUsDbContext()
        {

        }

        #endregion

        #region Properties

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<CareCenter> CareCenters { get; set; }
        public DbSet<Diagnosis> Diagnoses { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Medicine> Medicine { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Resident> Residents { get; set; }
        public DbSet<Role> Roles { get; set; }

        #endregion

        #region Methods

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            #region Address

            // Use of lambda expressions
            //modelBuilder.Entity<Address>(entity =>
            //{
            //    entity.HasKey(e => e.AddressId);
            //    entity.Property(e => e.AddressId)
            //    .ValueGeneratedOnAdd();

            //    entity.Property(e => e.Street)
            //    .IsRequired()
            //    .HasMaxLength(256);

            //    entity.Property(e => e.City)
            //    .IsRequired()
            //    .HasMaxLength(256);

            //    entity.Property(e => e.State)
            //    .IsRequired()
            //    .HasMaxLength(128);

            //    entity.Property(e => e.Zip)
            //    .IsRequired()
            //    .HasMaxLength(32);

            //});

            #endregion

            #region Assignment
            /*
            modelBuilder.Entity<Assignment>(entity =>
            {
                entity.HasKey(e => e.AssignmentId);
                entity.Property(e => e.AssignmentId)
                .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(64);

                entity.Property(e => e.TimeStart)
                .IsRequired();

                entity.Property(e => e.TimeEnd)
                .IsRequired();

                entity.HasOne(e => e.Resident);

                entity.HasMany(e => e.Employee)
                .WithMany(e => e.Assignments)
                .UsingEntity(j => j.ToTable("EmployeeAssignments"));
            });
            */
            #endregion

            #region CareCenter
            /*
            modelBuilder.Entity<CareCenter>(entity =>
            {
                entity.HasKey(e => e.CareCenterId);
                entity.Property(e => e.CareCenterId)
                .ValueGeneratedOnAdd();
            });
            */
            #endregion

            #region Diagnosis
            /*
            modelBuilder.Entity<Diagnosis>(entity =>
            {
                entity.HasKey(e => e.DiagnosisId);
                entity.Property(e => e.DiagnosisId)
                .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(128);

                entity.Property(e => e.Description)
                .HasMaxLength(1024);
            });
            */
            #endregion

            #region Employee
            /*
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeId);
                entity.Property(e => e.EmployeeId)
                .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(128);

                entity.HasOne(e => e.CareCenter);

                entity.HasMany(e => e.Role)
                .WithMany(e => e.Employees)
                .UsingEntity(j => j.ToTable("EmployeeRoles"));
            });
            */
            #endregion

            #region Medicine
            /*
            modelBuilder.Entity<Medicine>(entity =>
            {
                entity.HasKey();
                entity.Property(e => e.MedicineId)
                .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(128);

                entity.Property(e => e.Dosage)
                .IsRequired();

                entity.Property(e => e.Unit)
                .IsRequired()
                .HasMaxLength(8);

                entity.Property(e => e.Administered)
                .IsRequired();
            });
            */
            #endregion

            #region Prescription
            /*
            modelBuilder.Entity<Prescription>(entity =>
            {
                entity.HasKey();
                entity.Property(e => e.PrescriptionId)
                .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(128);

                entity.Property(e => e.Dosage)
                .IsRequired();

                entity.Property(e => e.Unit)
                .IsRequired()
                .HasMaxLength(8);
            });
            */
            #endregion

            #region Resident
            /*
            modelBuilder.Entity<Resident>(entity =>
            {
                entity.HasKey();
                entity.Property(e => e.ResidentId)
                .ValueGeneratedOnAdd();

                entity.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(128);

                entity.Property(e => e.RoomNumber)
                .IsRequired()
                .HasMaxLength(16);

                //entity.Property(e => e.Diagnosis);

                //entity.Property(e => e.Prescriptions);

                //entity.Property(e => e.Notes);

            });
            */
            #endregion

            #region Role
            modelBuilder.Entity<Role>()
           .HasMany(r => r.Employees);
            /*
            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey();
                entity.Property(e => e.RoleId)
                .ValueGeneratedOnAdd();

                entity.Property(e => e.RoleName)
                .IsRequired()
                .HasMaxLength(128);

                //entity.Property(e => e.Employees);
            });
            */
            #endregion
        }

        #endregion
    }
}
