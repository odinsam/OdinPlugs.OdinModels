namespace OdinPlugs.OdinModels.ConfigModel.RabbitMQ
{
    public class ExchangeModel
    {
        public string ExchangeName { get; set; }
        public string ExchangeType { get; set; }
        public bool Durability { get; set; } = true;
        public bool AutoDelete { get; set; } = false;
        public ArgumentsModel[] Arguments { get; set; }
        public QueuesModel[] Queues { get; set; }
    }
}