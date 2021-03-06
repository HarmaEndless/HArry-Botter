// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Bot.Connector
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// A response containing a resource
    /// </summary>
    public partial class ConversationResourceResponse
    {
        /// <summary>
        /// Initializes a new instance of the ConversationResourceResponse
        /// class.
        /// </summary>
        public ConversationResourceResponse() { }

        /// <summary>
        /// Initializes a new instance of the ConversationResourceResponse
        /// class.
        /// </summary>
        public ConversationResourceResponse(string activityId = default(string), string id = default(string))
        {
            ActivityId = activityId;
            Id = id;
        }

        /// <summary>
        /// Id of the Activity (if one was created)
        /// </summary>
        [JsonProperty(PropertyName = "activityId")]
        public string ActivityId { get; set; }

        /// <summary>
        /// Id of the resource
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}
