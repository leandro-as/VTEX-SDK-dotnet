namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    [Serializer(SerializerFormat.JSON)]
    public sealed class Sku
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public bool IsActive { get; set; }
        public string ImageUrl { get; set; }
        public Dimension Dimension { get; set; }
        public Image[] Images { get; set; }
    }
}
