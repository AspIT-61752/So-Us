using Microsoft.EntityFrameworkCore;
using SoUs.Entity;

namespace SoUs.DataAccess
{
    public class SoUsDbDataAccess : DbContext
    {
        #region Fields
        #endregion

        #region Constructors

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SoUsDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
            optionsBuilder.UseSqlServer(connectionString);
        }

        public SoUsDbDataAccess(DbContextOptions<SoUsDbDataAccess> options) : base(options)
        {
        }

        //public SoUsDbContext(DbContextOptions<SoUsDbContext> options) : base(options)
        //{
        //}

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
        #endregion
    }
}
