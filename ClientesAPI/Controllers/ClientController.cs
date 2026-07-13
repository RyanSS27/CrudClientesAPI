using ClientesAPI.Entities;
using ClientesAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClientesAPI.Controllers;

[Route("api/clients")]
[ApiController]
public class ClientController(IClientService clientService) : ControllerBase
{
    private readonly IClientService _clientService = clientService;

    {
        _clientService = clientService;
    }
    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetClientById(Guid id)
    {
    }
    [HttpPost]
    public async Task<IActionResult> CreateClient(Client client)
    {
        await _clientService.AddClient(client);
        return CreatedAtAction(nameof(GetClientById), new { id = client.Id }, client);
    }
    // preciso entender melhor sobre o porquê desse nameof
}