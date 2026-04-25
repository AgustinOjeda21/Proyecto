using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

public partial class CatalogoP3DbContext : DbContext
{
    public CatalogoP3DbContext()
    {
    }

    public CatalogoP3DbContext(DbContextOptions<CatalogoP3DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EntityArticulo> Articulos { get; set; }

    public virtual DbSet<EntityCategoria> Categorias { get; set; }

    public virtual DbSet<EntityImagen> Imagenes { get; set; }

    public virtual DbSet<EntityMarca> Marcas { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<EntityArticulo>(entity =>
        {
            entity.ToTable("ARTICULOS");

            entity.Property(e => e.Codigo)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Descripcion)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Precio).HasColumnType("money");
        });

        modelBuilder.Entity<EntityCategoria>(entity =>
        {
            entity.ToTable("CATEGORIAS");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EntityImagen>(entity =>
        {
            entity.ToTable("IMAGENES");
            entity.HasKey(e => e.id);
            entity.Property(e => e.id).ValueGeneratedOnAdd();
            entity.Property(e => e.imagenUrl)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EntityMarca>(entity =>
        {
            entity.ToTable("MARCAS");

            entity.Property(e => e.Descripcion)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
