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

    public async Task<List<Client>> ListClients()
    {
        return await _context.Clients.ToListAsync();
    }

    public async Task<Client> GetClientById(Guid id)
    {
        return await _context.Clients.FindAsync(id);
    }

    public async Task AddClient(Client client)
    {
        await _context.Clients.AddAsync(client);
        await _context.SaveChangesAsync();
    }
}