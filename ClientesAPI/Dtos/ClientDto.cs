using ClientesAPI.Entities;

namespace ClientesAPI.Dtos;

public record ClientDto
{
    private Guid Id;
    private string Name;
    private string Email;
    private string Address;
    private string Phone;

    public ClientDto(Client client)
    {
        Id = client.Id;
        Name = client.Name;
        Email = client.Email;
        Address = client.Address;
        Phone = client.Phone;
    }
}