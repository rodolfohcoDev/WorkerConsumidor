using Consumer.Shareable.Request;
using MediatR;
using OperationResult;

namespace Consumer.Domain.Handler.Client
{

    public class ClientCommandHandler : IRequestHandler<ClienteRequest, Result<int>>
    {
        public ClientCommandHandler()
        {
        }

        public Task<Result<int>> Handle(ClienteRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
