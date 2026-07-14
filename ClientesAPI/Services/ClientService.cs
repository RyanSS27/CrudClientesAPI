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

    public async Task<ClientOutDto> AddClient(ClientInputDto clientInputDto)
    {
        var client = new Client(
            clientInputDto.Name,
            clientInputDto.Address,
            clientInputDto.Phone,
            clientInputDto.Email);
        
        _context.Clients.Add(client);
        await _context.SaveChangesAsync();
        /*
            anteriormente, estava utilizando o comando:    
                await _context.Clients.AddAsync(client);    
            
            minha dúvida era: "Se estamos fazendo essa alteração em memória, por que o await 
            e o Async no "addAsync"?"
            resposta: Realmente era desnecessário. Esse Async seriviria caso precisassemos ir
            ao banco  para saber qual seria o próximo Id. Se estou usando o Guid, então o C# 
            gera um Id novo ou, caso esteja usando um autoincrement no banco, ele já fará isso
        */
        return new ClientOutDto(client);
    }

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