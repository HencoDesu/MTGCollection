using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hencodesu.ScryfallNet.Scryfall.Models {
	public class Catalog {
		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "total_items")]
		public int? TotalItems { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "data")]
		public IList<string> Data { get; set; }
	}
}