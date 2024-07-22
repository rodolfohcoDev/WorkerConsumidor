using Consumer.Shareable.Response;
using MediatR;
using OperationResult;

namespace Consumer.Shareable.Request
{
    public record ClienteRequest(
        string Nome, 
        string Email, 
        string Telefone, 
        string Celular, DateTime DataNascimento
      
      ) : IRequest<Result<int>>;

}
