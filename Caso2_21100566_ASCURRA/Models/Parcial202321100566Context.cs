using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Caso2_21100566_ASCURRA.Models;

public partial class Parcial202321100566Context : DbContext
{
    public Parcial202321100566Context()
    {
    }

    public Parcial202321100566Context(DbContextOptions<Parcial202321100566Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Team> Team { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-APOQDV2\\SQLEXPRESS;Database=PARCIAL202321100566;Integrated Security=true;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Team>(entity =>
        {
            entity.Property(e => e.Country)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
