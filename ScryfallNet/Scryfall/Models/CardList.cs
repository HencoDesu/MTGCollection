using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hencodesu.ScryfallNet.Scryfall.Models {
	public class CardList {
		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "total_cards")]
		public int? TotalCards { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "has_more")]
		public bool? HasMore { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "next_page")]
		public string NextPage { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "data")]
		public IList<Card> Data { get; set; }
	}
}