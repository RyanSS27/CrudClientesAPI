using ClientesAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace ClientesAPI.Controllers;

[Route("api/client")]
[Controller]
public class ClientController : Controller
{
    private readonly IClientService _clientService;

    public ClientController(IClientService clientService)
    {
        _clientService = clientService;
    }
}