using Hencodesu.ScryfallNet.Scryfall.Models.Enums;
using Newtonsoft.Json;

namespace Hencodesu.ScryfallNet.Scryfall.Models {
	public class CardSymbol {
		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "symbol")]
		public string Symbol { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "loose_variant")]
		public string LooseVariant { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "english")]
		public string English { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "transposable")]
		public bool? Transposable { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "represents_mana")]
		public bool? RepresentsMana { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "cmc")]
		public double? Cmc { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "appears_in_mana_costs")]
		public bool? AppearsInManaCosts { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "funny")]
		public bool? Funny { get; set; }

		/// <summary>
		/// Gets or sets possible values include: 'W', 'U', 'B', 'R', 'G'
		/// </summary>
		[JsonProperty(PropertyName = "colors")]
		public Colors? Colors { get; set; }
	}
}