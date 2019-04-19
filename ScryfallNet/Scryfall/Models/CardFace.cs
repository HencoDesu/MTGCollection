using System;
using System.Collections.Generic;
using Hencodesu.ScryfallNet.Scryfall.Models.Enums;
using Newtonsoft.Json;

namespace Hencodesu.ScryfallNet.Scryfall.Models {
	public class CardFace {
		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "type_line")]
		public string TypeLine { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "oracle_text")]
		public string OracleText { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "mana_cost")]
		public string ManaCost { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "colors")]
		public IList<Colors?> Colors { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "color_indicator")]
		public IList<Colors?> ColorIndicator { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "power")]
		public string Power { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "toughness")]
		public string Toughness { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "loyalty")]
		public string Loyalty { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "flavor_text")]
		public string FlavorText { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "illustration_id")]
		public Guid? IllustrationId { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "image_uris")]
		public ImageUri ImageUris { get; set; }
	}
}