using System.ComponentModel.DataAnnotations;
using ClientesAPI.Dtos;

namespace ClientesAPI.Entities;

public class Client
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    [Required]
    public string Name { get; set; }
    
    public string? Address { set; get; }

    [EmailAddress]
    public string? Email { get; set; } = string.Empty;  // se a info não for passada, irá como "" para o banco (mas não permite nulo)

    [Required]
    public string Phone { get; set; }
    
    private Client(){}

    public Client(string name, string? address, string? email, string phone)
    {
        Name = name;
        Address = address;
        Email = email ?? string.Empty;
        Phone = phone;
    }
}