using ClientesAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ClientesAPI.Services;

public interface IClientService
{
    public Task<List<Client>> ListClients();
    // o async não aparece aqui, pois é um detalhe de implementação
    // que não se deve conter em interfaces
    public Task<Client?> GetClientById(Guid id);
    
    public Task AddClient(Client client);
}