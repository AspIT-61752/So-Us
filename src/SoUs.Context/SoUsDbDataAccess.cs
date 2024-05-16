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

        public DbSet<Address> Address { get; set; }
        public DbSet<Assignment> Assignment { get; set; }
        public DbSet<CareCenter> CareCenter { get; set; }
        public DbSet<Diagnosis> Diagnosis { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Medicine> Medicine { get; set; }
        public DbSet<Prescription> Prescription { get; set; }
        public DbSet<Resident> Resident { get; set; }
        public DbSet<Role> role { get; set; }

        #endregion

        #region Methods
        #endregion
    }
}
