using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PharmacyManagement.Entites;

namespace PharmacyManagement.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext()
    {
    }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Medicine> Medicines { get; set; }

    public virtual DbSet<Pepole> Pepoles { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("server=DESKTOP-I3NIFAB;database =Pharmacy;Encrypt=false;Integrated Security = true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Medicine>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Medicine__3214EC27A5DC53D4");

            entity.ToTable("Medicine");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Edate).HasColumnName("EDate");
            entity.Property(e => e.Image).HasColumnType("image");
            entity.Property(e => e.MDate).HasColumnName("mDate");
            entity.Property(e => e.Name).HasMaxLength(50);
            entity.Property(e => e.PricePerUnit).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Pepole>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK__Pepole__AA2FFB859C929317");

            entity.ToTable("Pepole");

            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.BirthDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Image).HasColumnType("image");
            entity.Property(e => e.Name).HasMaxLength(80);
            entity.Property(e => e.Phone).HasMaxLength(20);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.HasIndex(e => e.UserName, "UserNameIndex").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Password).HasMaxLength(80);
            entity.Property(e => e.PersonId).HasColumnName("PersonID");
            entity.Property(e => e.Role).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);

            entity.HasOne(d => d.Person).WithMany(p => p.Users)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Pepole");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
