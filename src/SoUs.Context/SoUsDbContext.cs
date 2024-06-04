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
                optionsBuilder.UseSqlServer(connectionString, b => b.MigrationsAssembly("SoUs.DataAccess"));
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

            modelBuilder.Entity<Address>().HasData(new Address
            {
                AddressId = 1,
                City = "Vejle",
                State = "Region Syddanmark",
                Street = "Boulevarden 48",
                Zip = 7100
            });

            modelBuilder.Entity<CareCenter>().HasData(new
            {
                CareCenterId = 1,
                Name = "Vejle Kommune - Alderdomshjem",
                AddressId = 1
            });

            modelBuilder.Entity<Diagnosis>().HasData(new Diagnosis
            (
                1,
                "ADHD",
                "Attention Deficit Hyperactivity Disorder"
            ));

            modelBuilder.Entity<Diagnosis>().HasData(new Diagnosis
            (
                2,
                "Autisme",
                "Autism Spectrum Disorder"
            ));

            modelBuilder.Entity<Employee>().HasData(new
            {
                EmployeeId = 1,
                Name = "Mads Mikkelsen",
                CareCenterId = 1
            });

            modelBuilder.Entity<Employee>().HasData(new
            {
                EmployeeId = 2,
                Name = "Morten Bossen",
                CareCenterId = 1
            });

            modelBuilder.Entity<Employee>().HasData(new
            {
                EmployeeId = 3,
                Name = "Michael Jensen",
                CareCenterId = 1
            });

            modelBuilder.Entity<Resident>().HasData(new
            {
                ResidentId = 1,
                Name = "Jens Hansen",
                RoomNumber = "A1",
                DiagnosisId = 1,
                Notes = "Jens er en stille og rolig mand, der elsker at læse bøger. Han har brug for hjælp til at komme ud af sengen og til at komme i bad.",
                CareCenterId = 1
            });

            modelBuilder.Entity<Assignment>().HasData(new
            {
                AssignmentId = 1,
                Name = "Hjælp til at komme ud af sengen",
                TimeStart = DateTime.Now,
                TimeEnd = DateTime.Now.AddMinutes(15),
                ResidentId = 1,
                EmployeeId = 1,
                IsComplete = false
            });

            modelBuilder.Entity<Assignment>().HasData(new
            {
                AssignmentId = 2,
                Name = "Hjælp til at komme i bad",
                TimeStart = DateTime.Now.AddMinutes(15),
                TimeEnd = DateTime.Now.AddMinutes(30),
                ResidentId = 1,
                EmployeeId = 2,
                IsComplete = false
            });

            modelBuilder.Entity<Assignment>().HasData(new
            {
                AssignmentId = 3,
                Name = "Give medicin",
                TimeStart = DateTime.Now.AddMinutes(30),
                TimeEnd = DateTime.Now.AddMinutes(40),
                ResidentId = 1,
                EmployeeId = 1,
                IsComplete = false
            });

            modelBuilder.Entity<Medicine>().HasData(new
            {
                MedicineId = 1,
                Name = "Panodil",
                Dosage = 1,
                Unit = "stk",
                Administered = false,
                AssignmentId = 3
            });

            base.OnModelCreating(modelBuilder);
        }

        #endregion
    }
}
