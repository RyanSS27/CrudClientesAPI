using ClientesAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClientesAPI.Database;

public class ApplicationDbContext : DbContext
{
    // "options" passa a string de conexão, senha e tudo mais que eu definir no program 
    // que essa conexão deva ter
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<Client> Clients { get; set; }
}