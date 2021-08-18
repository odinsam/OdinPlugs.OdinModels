using System.Collections.Generic;

namespace OdinPlugs.OdinModels.ConfigModel.RedisModels
{
    public class RedisModel
    {
        // public bool Enable { get; set; }
        public string RedisIp { get; set; }
        public int RedisPort { get; set; }
        public string RedisPassword { get; set; }
        public List<string> ConnectionStrings { get; set; }
        public int DefaultDatabase { get; set; } = 0;
        // public string InstanceName { get; set; }
    }
    public class RedisOption
    {
        public List<string> ConnectionString { get; set; }
        public string InstanceName { get; set; }
    }
}