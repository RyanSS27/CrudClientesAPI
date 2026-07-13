using ClientesAPI.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ClientesAPI.Services;

public interface IClientService
{
    
    public Task AddClient(Client client);
}