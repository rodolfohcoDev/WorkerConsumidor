
using Consumer.Shareable.Response;
using MediatR;
using OperationResult;

namespace Consumer.Request;

public record GetClienteRequest(Guid? id) : IRequest<Result<GetClienteResponse>>;
