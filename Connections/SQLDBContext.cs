using Domain.Models.Externo;
using Domain.Models.ListasContactos;
using Domain.Models.Personas;
using Domain.Models.Reportes;
using Microsoft.EntityFrameworkCore;

namespace Domain.Models.Connections
{
  public class SQLDBContext : DbContext
  {
    public SQLDBContext(DbContextOptions<SQLDBContext> options) : base(options) { }
    
    /*analizar los siguiente para threads*/
    //public SQLDBContext() { }
    //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){ }
    //protected override void OnModelCreating(ModelBuilder modelBuilder){ }

    // Entities 
    public DbSet<Cupo> Cupo { get; set; }
    public DbSet<Contacto> Contacto { get; set; }
    public DbSet<ListaContactos> ListaContactos { get; set; }
    public DbSet<TipoContacto> TipoContacto { get; set; }
    public DbSet<Centro> Centro { get; set; }
    public DbSet<Cuenta> Cuenta { get; set; }
    public DbSet<Persona> Persona { get; set; }
    public DbSet<ZonaComercial> ZonaComercial { get; set; }
    public DbSet<Rol> Rol { get; set; }
    public DbSet<InstanciaReporte> InstanciaReporte { get; set; }
    public DbSet<Parametro> Parametro { get; set; }
    public DbSet<Reporte> Reporte { get; set; }
    
  }
}
