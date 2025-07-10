using FruityViceApp;
using Newtonsoft.Json;

public class Fruit
{
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("family")]
    public string Family { get; set; }

    [JsonProperty("genus")]
    public string Genus { get; set; }

    [JsonProperty("nutritions")]
    public Nutritions Nutritions { get; set; }

}