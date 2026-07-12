namespace ClientesAPI.Entities;

public class Client
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty; // se a info não for passada, irá como "" para o banco (mas não permite nulo)
    public string Email { get; set; } = string.Empty;
    public string Address { get; set; }
    public string Phone { get; set; }
}