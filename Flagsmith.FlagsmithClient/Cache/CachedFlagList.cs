#nullable enable

using System.Collections.Generic;
using Newtonsoft.Json;

namespace Flagsmith.Cache
{
    /// <summary>
    /// What the SDK stores for one cache entry: the flag list, plus the identity traits Flagsmith was
    /// known to hold when that list was fetched. Written as JSON so that any <c>HybridCache</c> backing
    /// store can hold it without the host having to register a serializer for SDK types.
    /// </summary>
    internal class CachedFlagList
    {
        [JsonProperty("flags")]
        public List<Flag> Flags { get; set; } = new List<Flag>();

        /// <summary>
        /// Trait key to a fingerprint of the trait as it was last sent to Flagsmith.
        /// </summary>
        [JsonProperty("traits")]
        public Dictionary<string, string> Traits { get; set; } = new Dictionary<string, string>();
    }
}
