namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    [Serializer(SerializerFormat.JSON)]
    public sealed class Image
    {
        public string ImageUrl { get; set; }
        public string ImageName { get; set; }
        public int FileId { get; set; }
    }
}
