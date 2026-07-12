using Microsoft.EntityFrameworkCore;

namespace ClientesAPI.Services;

public class ClientService : IClientService
{
    private readonly DbContext _context;
    public ClientService(DbContext context)
    {
        _context = context;
    }
}