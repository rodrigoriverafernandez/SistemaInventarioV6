﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SistemaInventario.Modelos;
using System.Reflection;
using System.Text.RegularExpressions;

namespace SistemaInventario.AccesoDatos.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
       public ApplicationDbContext()   // con este constructor bacio solucione las migraciones. OJO
   
        { 

        }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Bodega> Bodegas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Producto> Productos { get; set; }

        public DbSet<UsuarioAplicacion> UsuarioAplicacion { get; set; }

        public DbSet<BodegaProducto> BodegasProductos { get; set; }

        public DbSet<Inventario> Inventarios { get; set; }

        public  DbSet<InventarioDetalle> InventarioDetalles { get; set; }

        public DbSet<KardexInventario> KardexInventarios { get; set; } // El Segundo Nombre en Plural

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

       
    }
}


