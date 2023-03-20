using Microsoft.EntityFrameworkCore;
using Colmado.Server.Models;

namespace Colmado.Server.Context;

public interface IMyDbContext
{
    DbSet<UsuarioRol> UsuariosRoles { get; set; }
    DbSet<Usuario> Usuarios { get; set; }
    DbSet<Cliente> Clientes { set; get; }
    DbSet<Listaventas> Listas { set; get; }
    DbSet<Productos> Producto { set; get; }

    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}

public class MyDbContext : DbContext, IMyDbContext
{
    private readonly IConfiguration config;

    public MyDbContext(IConfiguration _config)
    {
        config = _config;
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(config.GetConnectionString("Colmado"));
    }

    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return base.SaveChangesAsync(cancellationToken);
    }

    #region Tablas de mi Base de Datos
    public DbSet<UsuarioRol> UsuariosRoles { get; set; } = null!;
    public DbSet<Usuario> Usuarios { get; set; } = null!;
    public DbSet<Cliente> Clientes { set; get; } = null!;
    public DbSet<Listaventas> Listas { set; get; } = null!;
    public DbSet<Productos> Producto { set; get; } = null!;
    #endregion

}