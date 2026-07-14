using System.ComponentModel.DataAnnotations;
using ClientesAPI.Entities;

namespace ClientesAPI.Dtos;

public record ClientInputDto
{
    [Required]
    public string Name { get; init; } // Transformado em Propriedade com 'init'
    
    public string? Address { get; init; } // Interrogação caso não seja obrigatório
    
    [EmailAddress]
    public string? Email { get; init; }
    
    [Required]
    public string Phone { get; init; }
};