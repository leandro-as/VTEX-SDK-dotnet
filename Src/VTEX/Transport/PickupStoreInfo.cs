﻿namespace VTEX.Transport
{
    using CrispyWaffle.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The pickup store info class
    /// </summary>
    public sealed class PickupStoreInfo
    {
        /// <summary>
        /// Gets or sets the additional information.
        /// </summary>
        /// <value>
        /// The additional information.
        /// </value>
        [JsonProperty("additionalInfo")]
        public string AdditionalInfo { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// Gets or sets the dock identifier.
        /// </summary>
        /// <value>
        /// The dock identifier.
        /// </value>
        [JsonProperty("dockId")]
        public string DockId { get; set; }

        /// <summary>
        /// Gets or sets the name of the friendly.
        /// </summary>
        /// <value>
        /// The name of the friendly.
        /// </value>
        [JsonProperty("friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is pickup store.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is pickup store; otherwise, <c>false</c>.
        /// </value>
        [JsonProperty("isPickupStore")]
        public bool IsPickupStore { get; set; }
    }
}
