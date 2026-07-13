using ClientesAPI.Entities;
using ClientesAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClientesAPI.Controllers;

[Route("api/clients")]
[ApiController]
public class ClientController(IClientService clientService) : ControllerBase
{
    private readonly IClientService _clientService = clientService;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var clients = await _clientService.ListClients();
        if (clients is [])
            return NotFound(new { mensagem = "Contato não encontrado" });
        
        return Ok(clients);
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetClientById(Guid id)
    {
        var client = await _clientService.GetClientById(id);
        if (client is null)
            return NotFound(new {mensagem = "Cliente não encontrado"});
        
        return Ok(client);
    }

    // seguriu um [Frombody] antes do cliente
    [HttpPost]
    public async Task<IActionResult> CreateClient(Client client)
    {
        await _clientService.AddClient(client);
        return CreatedAtAction(nameof(GetClientById), new { id = client.Id }, client);
    }
    // preciso entender melhor sobre o porquê desse nameof
}