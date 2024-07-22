using Consumer.Shareable.Response;
using MediatR;
using OperationResult;
 

namespace Consumer.Shareable.Request
{
    public record WebHookRequest(
        DateOnly DateTime,
        string servico,
        string data

     ) : IRequest<Result<WebHookResponse>>;

}
