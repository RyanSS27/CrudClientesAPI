using ClientesAPI.Database;
using ClientesAPI.Dtos;
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

    public async Task<bool> DeleteClient(Guid id)
    {
        Client? client = await _context.Clients.FindAsync(id);

        if (client != null)
        {
            _context.Clients.Remove(client);
            await _context.SaveChangesAsync();
            return true;
        }

        return false;
    }
    
    public async Task<ClientOutDto?> UpdateClient(Guid id, ClientInputDto client)
    {
        var searchResult = await _context.Clients.FindAsync(id);
        if (searchResult ==  null)
            return null;

        searchResult.Name = client.Name;
        searchResult.Address = client.Address;
        searchResult.Phone = client.Phone;
        searchResult.Email = client.Email;
        _context.Clients.Update(searchResult);
        await _context.SaveChangesAsync();
        return new ClientOutDto(searchResult);
    }
}