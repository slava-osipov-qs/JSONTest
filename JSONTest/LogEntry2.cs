using System;
using Newtonsoft.Json;

namespace JSONTest
{
    public abstract class LogEntry2
    {
        protected LogEntry2(DateTime? timeStamp = null)
        {
            TimeStamp = timeStamp??DateTime.Now;
        }

        public virtual string Serialize()
        {
            return JsonConvert.SerializeObject(this, 
                new JsonSerializerSettings()
                {
                    TypeNameHandling = TypeNameHandling.All
                });
        }

        [JsonProperty(nameof(TimeStamp))]
        public DateTime TimeStamp { get; } // without setter

        public static LogEntry2 Deserialize(string json)
        {
            return JsonConvert.DeserializeObject(json, new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All
            }) as LogEntry2;
        }

        public abstract void SomeFunc();
    }

    public class LE2 : LogEntry2
    {
        public override void SomeFunc()
        {
            
        }
    }
}
