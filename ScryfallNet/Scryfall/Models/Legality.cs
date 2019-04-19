using Hencodesu.ScryfallNet.Scryfall.Models.Enums;
using Newtonsoft.Json;

namespace Hencodesu.ScryfallNet.Scryfall.Models {
	public class Legality {
		/// <summary>
		/// Gets or sets possible values include: 'legal', 'not_legal',
		/// 'restricted', 'banned'
		/// </summary>
		[JsonProperty(PropertyName = "standard")]
		public LegalStatus? Standard { get; set; }

		/// <summary>
		/// Gets or sets possible values include: 'legal', 'not_legal',
		/// 'restricted', 'banned'
		/// </summary>
		[JsonProperty(PropertyName = "future")]
		public LegalStatus? Future { get; set; }

		/// <summary>
		/// Gets or sets possible values include: 'legal', 'not_legal',
		/// 'restricted', 'banned'
		/// </summary>
		[JsonProperty(PropertyName = "frontier")]
		public LegalStatus? Frontier { get; set; }

		/// <summary>
		/// Gets or sets possible values include: 'legal', 'not_legal',
		/// 'restricted', 'banned'
		/// </summary>
		[JsonProperty(PropertyName = "modern")]
		public LegalStatus? Modern { get; set; }

		/// <summary>
		/// Gets or sets possible values include: 'legal', 'not_legal',
		/// 'restricted', 'banned'
		/// </summary>
		[JsonProperty(PropertyName = "legacy")]
		public LegalStatus? Legacy { get; set; }

		/// <summary>
		/// Gets or sets possible values include: 'legal', 'not_legal',
		/// 'restricted', 'banned'
		/// </summary>
		[JsonProperty(PropertyName = "pauper")]
		public LegalStatus? Pauper { get; set; }

		/// <summary>
		/// Gets or sets possible values include: 'legal', 'not_legal',
		/// 'restricted', 'banned'
		/// </summary>
		[JsonProperty(PropertyName = "vintage")]
		public LegalStatus? Vintage { get; set; }

		/// <summary>
		/// Gets or sets possible values include: 'legal', 'not_legal',
		/// 'restricted', 'banned'
		/// </summary>
		[JsonProperty(PropertyName = "penny")]
		public LegalStatus? Penny { get; set; }

		/// <summary>
		/// Gets or sets possible values include: 'legal', 'not_legal',
		/// 'restricted', 'banned'
		/// </summary>
		[JsonProperty(PropertyName = "commander")]
		public LegalStatus? Commander { get; set; }

		/// <summary>
		/// Gets or sets possible values include: 'legal', 'not_legal',
		/// 'restricted', 'banned'
		/// </summary>
		[JsonProperty(PropertyName = "1v1")]
		public LegalStatus? OnevOne { get; set; }

		/// <summary>
		/// Gets or sets possible values include: 'legal', 'not_legal',
		/// 'restricted', 'banned'
		/// </summary>
		[JsonProperty(PropertyName = "duel")]
		public LegalStatus? Duel { get; set; }

		/// <summary>
		/// Gets or sets possible values include: 'legal', 'not_legal',
		/// 'restricted', 'banned'
		/// </summary>
		[JsonProperty(PropertyName = "brawl")]
		public LegalStatus? Brawl { get; set; }
	}
}