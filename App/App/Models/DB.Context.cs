﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace App.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class dbAppEntities1 : DbContext
    {
        public dbAppEntities1()
            : base("name=dbAppEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Factura> Facturas { get; set; }
        public virtual DbSet<FacturaProducto> FacturaProductoes { get; set; }
        public virtual DbSet<Imagen> Imagens { get; set; }
        public virtual DbSet<Persona> Personas { get; set; }
        public virtual DbSet<Producto> Productoes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
