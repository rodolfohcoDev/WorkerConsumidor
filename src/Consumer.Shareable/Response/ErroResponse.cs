using Consumer.Shareable.Utils;


namespace Consumer.Shareable.Response
{
    public record ErroResponse
    {
        public ErroResponse(AppException appException)
            => Mensagem = appException.Message;

        public string Mensagem { get; init; }
    }
}
