using System;
using Hencodesu.ScryfallNet.Models.Enums;
using Microsoft.Rest.Serialization;
using Newtonsoft.Json;

namespace Hencodesu.ScryfallNet.Models {
	public class Set {
		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "code")]
		public string Code { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "mtgo_code")]
		public string MtgoCode { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets possible values include: 'core', 'expansion',
		/// 'masters', 'masterpiece', 'from_the_vault', 'spellbook',
		/// 'premium_deck', 'duel_deck', 'commander', 'planechase',
		/// 'conspiracy', 'archenemy', 'vanguard', 'funny', 'starter', 'box',
		/// 'promo', 'token', 'memorabilia', 'treasure_chest'
		/// </summary>
		[JsonProperty(PropertyName = "set_type")]
		public SetTypes? SetType { get; set; }

		/// <summary>
		/// </summary>
		[JsonConverter(typeof(DateJsonConverter))]
		[JsonProperty(PropertyName = "released_at")]
		public DateTime? ReleasedAt { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "block_code")]
		public string BlockCode { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "block")]
		public string Block { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "parent_set_code")]
		public string ParentSetCode { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "card_count")]
		public int? CardCount { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "digital")]
		public bool? Digital { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "foil")]
		public bool? Foil { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "icon_svg_uri")]
		public string IconSvgUri { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "search_uri")]
		public string SearchUri { get; set; }
	}
}