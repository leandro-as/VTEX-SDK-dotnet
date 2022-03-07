namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;


    [Serializer(SerializerFormat.JSON)]
    public sealed class Complement
    {
        public Complement() { }

        public int Id { get; set; }
        public int SkuId { get; set; }
        public int ParentSkuId { get; set; }
        public int ComplementTypeId { get; set; }
    }
}
