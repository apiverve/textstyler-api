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
        /// The style you want to apply to the text. Allowed styles: strikeThrough, wingdings, vaporwave, typewriter, analucia, tildeStrikeThrough, underline, doubleUnderline, slashThrough, sparrow, heartsBetween, arrowBelow, crossAboveBelow, creepify, bubbles, mirror, squares, roundsquares, flip, tiny
        /// Example: hello world
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// The style you want to apply to the text. Allowed styles: strikeThrough, wingdings, vaporwave, typewriter, analucia, tildeStrikeThrough, underline, doubleUnderline, slashThrough, sparrow, heartsBetween, arrowBelow, crossAboveBelow, creepify, bubbles, mirror, squares, roundsquares, flip, tiny
        /// Example: bubbles
        /// </summary>
        [JsonProperty("style")]
        public string Style { get; set; }
    }
}
