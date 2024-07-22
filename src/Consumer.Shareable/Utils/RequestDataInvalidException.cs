
namespace Consumer.Shareable.Utils
{
    public class RequestDataInvalidException : ApplicationException
    {
        public IEnumerable<string> Erros
        {
            get;
        }
        public RequestDataInvalidException(IDictionary<string, IEnumerable<string>> mensagens)
            : base("Dados invalídos")
        {
            Erros = mensagens.Select<KeyValuePair<string, IEnumerable<string>>, string>((KeyValuePair<string, IEnumerable<string>> m) => m.Key + ": " + string.Join(", ", m.Value));
        }



    }
}
