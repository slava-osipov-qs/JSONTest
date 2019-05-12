using System;
using Newtonsoft.Json;

namespace JSONTest
{
    public abstract class LogEntry1
    {
        protected LogEntry1(DateTime? timeStamp = null)
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
        public DateTime TimeStamp { get; private set; } // with setter

        public static LogEntry1 Deserialize(string json)
        {
            return JsonConvert.DeserializeObject(json, new JsonSerializerSettings()
            {
                TypeNameHandling = TypeNameHandling.All
            }) as LogEntry1;
        }

        public abstract void SomeFunc();
    }

    public class LE1 : LogEntry1
    {
        public override void SomeFunc()
        {
            
        }
    }
}
