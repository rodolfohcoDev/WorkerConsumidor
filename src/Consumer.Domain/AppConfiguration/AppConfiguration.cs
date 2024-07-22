namespace Consumer.Domain.Config
{
    public class AppConfiguration
    {
        public RefitConfig RefitConfig { get; set; }
        public EntityFrameworkConfig EntityFrameworkConfig { get; set; }
        public RabbitMqConfig RabbitMqConfig { get; set; }
        public RedisConfig RedisConfig { get; set; }

        public ElasticConfig elasticConfig { get; set; }
    }

}
