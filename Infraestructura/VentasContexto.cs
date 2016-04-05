
using System;
using DiagramaClases;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructura
{
    public class VentasContexto : DbContext, IDisposable
    {
        public VentasContexto() : base("Conexion")
        {
            Database.SetInitializer<VentasContexto>(new InicializadorBD());
        }

        public DbSet<D_categoria> Categorias { get; set; }
        public DbSet<D_cliente> Clientes { get; set; }
        public DbSet<D_detalle> Detalles { get; set; }

        public DbSet<D_producto> Productos { get; set; }
        public DbSet<D_usuario> usuarios { get; set; }
        public DbSet<D_venta> Ventas { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<D_categoria>().HasKey(k => k.ID_categoria);
            modelBuilder.Entity<D_cliente>().HasKey(k => k.ID_usuario);
            modelBuilder.Entity<D_detalle>().HasKey(k => k.ID_detalle);
            modelBuilder.Entity<D_producto>().HasKey(k => k.ID_producto);
            modelBuilder.Entity<D_usuario>().HasKey(k => k.ID_usuario);
            modelBuilder.Entity<D_venta>().HasKey(k => k.ID_venta);
        }

    }
}
