namespace Consumer.Shareable.Response
{
    public record GetClienteResponse(
        Guid Id,
        string Nome,
        string Email,
        string Telefone,
        string Celular, 
        DateTime DataNascimento
       );
}
