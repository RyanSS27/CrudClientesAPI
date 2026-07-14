using System.ComponentModel.DataAnnotations;
using ClientesAPI.Entities;

namespace ClientesAPI.Dtos;

public record ClientOutDto
{
    public Guid Id { get; init; } 
    public string Name { get; init; }
    public string? Address { get; init; }
    public string? Email { get; init; }
    public string Phone { get; init; }

    public ClientOutDto(Client client)
    {
        Id = client.Id;
        Name = client.Name;
        Address = client.Address;
        Email = client.Email;
        Phone = client.Phone;
    }
}