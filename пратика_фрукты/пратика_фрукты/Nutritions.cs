using Newtonsoft.Json;

public class Nutritions
{
    [JsonProperty("calories")]
    public decimal Calories { get; set; }

    [JsonProperty("fat")]
    public decimal Fat { get; set; }

    [JsonProperty("sugar")]
    public decimal Sugar { get; set; }

    [JsonProperty("carbohydrates")]
    public decimal Carbohydrates { get; set; }

    [JsonProperty("protein")]
    public decimal Protein { get; set; }

}