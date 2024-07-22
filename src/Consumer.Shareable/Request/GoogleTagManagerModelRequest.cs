using Consumer.Shareable.Response;
using MediatR;
using OperationResult;

namespace Consumer.Shareable.Request
{
    public record GoogleTagManagerModelRequest(
       string GtmAccount

     ) : IRequest<Result<GoogleTagManagerModelResponse>>;


}
