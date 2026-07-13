using ClientesAPI.Database;
using ClientesAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace ClientesAPI.Services;

public class ClientService : IClientService
{
    private readonly ApplicationDbContext _context;
    public ClientService(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task AddClient(Client client)
    {
        await _context.Clients.AddAsync(client);
        await _context.SaveChangesAsync();
    }
}