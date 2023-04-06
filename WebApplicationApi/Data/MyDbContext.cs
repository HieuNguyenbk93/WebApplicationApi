using Microsoft.EntityFrameworkCore;

namespace WebApplicationApi.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> opt): base(opt)
        {

        }

        #region DbSet
        public DbSet<Department> Departments { get; set; }
        public DbSet<SetOfIndices> SetOfIndices { get; set; }
        public DbSet<Dimension> Dimensions { get; set; }
        public DbSet<DimensionsIndices> DimensionsIndices { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(e =>
            {
                e.ToTable("Department");
                e.HasKey(d => d.Id);
                e.Property(d => d.Name).IsRequired().HasMaxLength(100);
                e.Property(d => d.ParentId).IsRequired();
                e.Property(d => d.LevelDepartment).IsRequired();
                e.Property(d => d.IsActive).IsRequired();
                //e.HasMany<SetOfIndices>(d => d.SetOfIndices).WithOne(s => s.DepartmentRate).HasForeignKey(s => s.IdDepartmentRate).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<SetOfIndices>(e =>
            {
                e.ToTable("SetOfIndices");
                e.HasKey(si => si.Id);
                e.Property(si => si.Name).IsRequired().HasMaxLength(255);
                e.Property(si => si.Description).HasMaxLength(500);
                e.Property(si => si.IsRated).IsRequired();
                e.HasOne<Department>(s => s.DepartmentRate).WithMany(d => d.SetOfIndices).HasForeignKey(s => s.IdDepartmentRate);
            });

            modelBuilder.Entity<Dimension>(e =>
            {
                e.ToTable("Dimension");
                e.HasKey(d => d.Id);
                e.Property(d => d.Name).IsRequired().HasMaxLength(250);
                e.HasIndex(d => d.Name).IsUnique();
            });

            modelBuilder.Entity<DimensionsIndices>(e =>
            {
                e.HasKey(di => new { di.IdSetOfIndices, di.IdDimenssion });
                e.HasOne<SetOfIndices>(di => di.SetOfIndices).WithMany(si => si.DimensionsIndices).HasForeignKey(di => di.IdSetOfIndices).OnDelete(DeleteBehavior.Cascade);
                e.HasOne<Dimension>(di => di.Dimension).WithMany(si => si.DimensionsIndices).HasForeignKey(di => di.IdDimenssion);
                e.Property(di => di.NumOfOrder).IsRequired();
                e.Property(di => di.ViewOfOrder).IsRequired().HasMaxLength(10);
            });
        }
    }
}
