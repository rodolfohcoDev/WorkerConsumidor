using System.Text;
using System.Text.Json;
using Consumer.Domain.Config;
using Consumer.Shareable.Request;
using RabbitMQ.Client;


namespace Consumer.Domain.pub.Client
{
    public class ClientPubMessenger : IClientePubMessenger
    {
        
        private readonly AppConfiguration _AppConfiguration;

        public ClientPubMessenger(AppConfiguration appConfiguration)
        {
            _AppConfiguration = appConfiguration;
        }


        public async Task<bool> SendMessager(ClienteRequest Model)
        {
            var queueName = "queueTeste";
            var modelNew = new DetailsModel();


            modelNew.Details = JsonSerializer.Serialize(Model);


            var factory = new ConnectionFactory()
            {
                Uri = new Uri(_AppConfiguration.RabbitMqConfig.UrlBase)
            };
            using var connection = factory.CreateConnection();
            using var channel = connection.CreateModel();

            channel.QueueDeclare(queue: queueName,
                                    durable: false,
                                    exclusive: false,
                                    autoDelete: false,
                                    arguments: null);

            {


                channel.BasicPublish(exchange: "",
                                     routingKey: queueName,
                                     basicProperties: null,
                                     body: Encoding.UTF8.GetBytes(JsonSerializer.Serialize(modelNew)));
                return true;
            }
            return false;

        }
    }
}
