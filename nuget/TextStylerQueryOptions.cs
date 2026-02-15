using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace APIVerve.API.TextStyler
{
    /// <summary>
    /// Query options for the Text Styler API
    /// </summary>
    public class TextStylerQueryOptions
    {
        /// <summary>
        /// The text to style
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// The style to apply
        /// </summary>
        [JsonProperty("style")]
        public string Style { get; set; }
    }
}
