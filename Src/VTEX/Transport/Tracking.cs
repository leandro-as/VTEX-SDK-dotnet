namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// Class Tracking. This class cannot be inherited.
    /// </summary>
    [Serializer(SerializerFormat.JSON)]
    public sealed class Tracking
    {
        /// <summary>
        /// Gets or sets the order identifier.
        /// </summary>
        /// <value>
        /// The order identifier.
        /// </value>
        [JsonIgnore]
        public string OrderId { get; set; }

        /// <summary>
        /// Gets or sets the invoice.
        /// </summary>
        /// <value>
        /// The invoice.
        /// </value>
        [JsonIgnore]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is delivered.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is delivered; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("isDelivered")]
        public bool IsDelivered { get; set; }

        /// <summary>
        /// Gets or sets the events.
        /// </summary>
        /// <value>
        /// The events.
        /// </value>
        [JsonProperty("events", NullValueHandling = NullValueHandling.Ignore)]
        public TrackingEvent[] Events { get; set; }

        /// <summary>
        /// Gets or sets the devlivered date
        /// </summary>
        /// <value>
        /// The DeliveredDate
        /// </value>
        [JsonProperty("deliveredDate", NullValueHandling = NullValueHandling.Ignore)]
        public string DeliveredDate { get; set; }
    }
}
