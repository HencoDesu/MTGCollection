using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hencodesu.ScryfallNet.Models
{
    public class CardSymbolList
    {
        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public IList<CardSymbol> Data { get; set; }

    }
}
