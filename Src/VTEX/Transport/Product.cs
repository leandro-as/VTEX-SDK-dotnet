namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    [Serializer(SerializerFormat.JSON)]
    public sealed class Product
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }

        public int DepartmentId { get; set; }

        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string LinkId { get; set; }
        public string RefId { get; set; }
        public bool IsVisible { get; set; }
        public string Description { get; set; }
        public string DescriptionShort { get; set; }
        public string ReleaseDate { get; set; }
        public string Keywords { get; set; }
        public string Title { get; set; }
        public bool IsActive { get; set; }
        public string TaxCode { get; set; }
        public string MetaTagDescription { get; set; }
        public string SupplierId { get; set; }
        public bool ShowWithoutStock { get; set; }
        public int[] ListStoreId { get; set; }
    }
}
