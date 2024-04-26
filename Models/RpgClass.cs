using System.Text.Json.Serialization;

namespace net_RPG.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight = 1,
        Wizard = 2,
        Tank = 3,
        Rogue = 4,

    }
}