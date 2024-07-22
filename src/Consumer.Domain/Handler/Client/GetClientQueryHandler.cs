using Consumer.Request;
using Consumer.Shareable.Response;
using MediatR;
using OperationResult;

namespace Consumer.Domain.Handler.Client
{

    public class GetClientQueryHandler : IRequestHandler<GetClienteRequest, Result<GetClienteResponse>>
    {
        public Task<Result<GetClienteResponse>> Handle(GetClienteRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
