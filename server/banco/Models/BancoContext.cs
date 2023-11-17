﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace banco.Models;

public partial class BancoContext : DbContext
{
    public BancoContext()
    {
    }

    public BancoContext(DbContextOptions<BancoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Banco> Bancos { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<ClienteXcuentum> ClienteXcuenta { get; set; }

    public virtual DbSet<Cuentum> Cuenta { get; set; }

    public virtual DbSet<Direccion> Direccions { get; set; }

    public virtual DbSet<Localidad> Localidads { get; set; }

    public virtual DbSet<Pai> Pais { get; set; }

    public virtual DbSet<Provincium> Provincia { get; set; }

    public virtual DbSet<TipoCuentum> TipoCuenta { get; set; }

    public virtual DbSet<TipoTransaccion> TipoTransaccions { get; set; }

    public virtual DbSet<Transaccion> Transaccions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Password=402010;Username=postgres;Database=Banco;Host=localhost");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Banco>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Banco_pkey");

            entity.ToTable("Banco");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 9999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.Nombre)
                .HasColumnType("char")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Cliente_pkey");

            entity.ToTable("Cliente");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 9999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.Alta).HasColumnName("alta");
            entity.Property(e => e.Cuil).HasColumnName("cuil");
            entity.Property(e => e.DireccionId).HasColumnName("direccion_id");
            entity.Property(e => e.RazonSocial)
                .HasColumnType("char")
                .HasColumnName("razon_social");

            entity.HasOne(d => d.Direccion).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.DireccionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("direccion_id");
        });

        modelBuilder.Entity<ClienteXcuentum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("ClienteXCuenta_pkey");

            entity.ToTable("ClienteXCuenta");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 9999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.Alta).HasColumnName("alta");
            entity.Property(e => e.ClienteId).HasColumnName("cliente_id");
            entity.Property(e => e.CuentaId).HasColumnName("cuenta_id");
            entity.Property(e => e.Rol)
                .HasColumnType("char")
                .HasColumnName("rol");

            entity.HasOne(d => d.Cliente).WithMany(p => p.ClienteXcuenta)
                .HasForeignKey(d => d.ClienteId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cliente_id");

            entity.HasOne(d => d.Cuenta).WithMany(p => p.ClienteXcuenta)
                .HasForeignKey(d => d.CuentaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cuenta_id");
        });

        modelBuilder.Entity<Cuentum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Cuenta_pkey");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 9999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.BancoId).HasColumnName("banco_id");
            entity.Property(e => e.Cbu).HasColumnName("cbu");
            entity.Property(e => e.NumeroCuenta).HasColumnName("numero_cuenta");
            entity.Property(e => e.TipoCuentaId).HasColumnName("tipoCuenta_id");

            entity.HasOne(d => d.Banco).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.BancoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("banco_id");

            entity.HasOne(d => d.TipoCuenta).WithMany(p => p.Cuenta)
                .HasForeignKey(d => d.TipoCuentaId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tipoCuenta_id");
        });

        modelBuilder.Entity<Direccion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Direccion_pkey");

            entity.ToTable("Direccion");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 9999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.Calle)
                .HasColumnType("char")
                .HasColumnName("calle");
            entity.Property(e => e.Departamento)
                .HasColumnType("char")
                .HasColumnName("departamento");
            entity.Property(e => e.LocalidadId).HasColumnName("localidad_id");
            entity.Property(e => e.Numero)
                .HasColumnType("char")
                .HasColumnName("numero");

            entity.HasOne(d => d.Localidad).WithMany(p => p.Direccions)
                .HasForeignKey(d => d.LocalidadId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("localidad_id");
        });

        modelBuilder.Entity<Localidad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Localidad_pkey");

            entity.ToTable("Localidad");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 9999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.Cp).HasColumnName("cp");
            entity.Property(e => e.Nombre)
                .HasColumnType("char")
                .HasColumnName("nombre");
            entity.Property(e => e.PaisId).HasColumnName("pais_id");

            entity.HasOne(d => d.Pais).WithMany(p => p.Localidads)
                .HasForeignKey(d => d.PaisId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("pais_id");
        });

        modelBuilder.Entity<Pai>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Pais_pkey");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 9999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.Nombre)
                .HasColumnType("char")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Provincium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Provincia_pkey");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 9999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.Nombre)
                .HasColumnType("char")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TipoCuentum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TipoCuenta_pkey");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 9999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.Alta).HasColumnName("alta");
            entity.Property(e => e.Nombre)
                .HasColumnType("char")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<TipoTransaccion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("TipoTransaccion_pkey");

            entity.ToTable("TipoTransaccion");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 9999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.Nombre)
                .HasColumnType("char")
                .HasColumnName("nombre");
        });

        modelBuilder.Entity<Transaccion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("Transaccion_pkey");

            entity.ToTable("Transaccion");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasIdentityOptions(null, null, null, 9999L, null, null)
                .HasColumnName("ID");
            entity.Property(e => e.CuentaDestinoId).HasColumnName("cuentaDestino_id");
            entity.Property(e => e.CuentaOrigenId).HasColumnName("cuentaOrigen_id");
            entity.Property(e => e.Fecha).HasColumnName("fecha");
            entity.Property(e => e.Monto).HasColumnName("monto");
            entity.Property(e => e.NumeroOperacion).HasColumnName("numero_operacion");
            entity.Property(e => e.TipoTransaccionId).HasColumnName("tipoTransaccion_id");

            entity.HasOne(d => d.CuentaDestino).WithMany(p => p.TransaccionCuentaDestinos)
                .HasForeignKey(d => d.CuentaDestinoId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cuentaDestino_id");

            entity.HasOne(d => d.CuentaOrigen).WithMany(p => p.TransaccionCuentaOrigens)
                .HasForeignKey(d => d.CuentaOrigenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("cuentaOrigen_id");

            entity.HasOne(d => d.TipoTransaccion).WithMany(p => p.Transaccions)
                .HasForeignKey(d => d.TipoTransaccionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("tipoTransaccion_id");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}