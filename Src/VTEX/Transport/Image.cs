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

    [Serializer(SerializerFormat.JSON)]
    public sealed class PostImage
    {
        public bool IsMain { get; set; }
        public string Label { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public string Url { get; set; }
    }

    [Serializer(SerializerFormat.JSON)]
    public sealed class ResponseImage
    {
        public int Id { get; set; }
        public int ArchiveId { get; set; }
        public int SkuId { get; set; }
        public string Name { get; set; }
        public bool IsMain { get; set; }
        public string Label { get; set; }
    }
}
