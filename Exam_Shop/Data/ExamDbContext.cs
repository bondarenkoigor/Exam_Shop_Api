
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Exam_Shop.Models;

public partial class ExamDbContext : IdentityDbContext<IdentityUser>
{
    public ExamDbContext() : base()
    {

    }

    public ExamDbContext(DbContextOptions<ExamDbContext> options)
        : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>(entity =>
        {
            entity.Property(e => e.Model)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.Picture)
                .HasMaxLength(1024)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-TH5F2DH;Database=examDb;Trusted_Connection=True;TrustServerCertificate=True;");


    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
