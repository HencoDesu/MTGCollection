using System;
using System.Collections.Generic;
using Hencodesu.ScryfallNet.Scryfall.Models.Enums;
using Newtonsoft.Json;

namespace Hencodesu.ScryfallNet.Scryfall.Models {
	public class Card {
		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "id")]
		public Guid? Id { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "oracle_id")]
		public Guid? OracleId { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "multiverse_ids")]
		public IList<int?> MultiverseIds { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "mtgo_id")]
		public int? MtgoId { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "arena_id")]
		public int? ArenaId { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "mtgo_foil_id")]
		public int? MtgoFoilId { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "uri")]
		public string Uri { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "scryfall_uri")]
		public string ScryfallUri { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "prints_search_uri")]
		public string PrintsSearchUri { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "rulings_uri")]
		public string RulingsUri { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		/// <summary>
		/// Gets or sets possible values include: 'normal', 'split', 'flip',
		/// 'transform', 'meld', 'leveler', 'saga', 'planar', 'scheme',
		/// 'vanguard', 'token', 'double_faced_token', 'emblem', 'augment',
		/// 'host'
		/// </summary>
		[JsonProperty(PropertyName = "layout")]
		public Layouts? Layout { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "cmc")]
		public double? Cmc { get; set; }

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
		[JsonProperty(PropertyName = "life_modifier")]
		public string LifeModifier { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "hand_modifier")]
		public string HandModifier { get; set; }

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
		[JsonProperty(PropertyName = "color_identity")]
		public IList<Colors?> ColorIdentity { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "all_parts")]
		public IList<RelatedCards> AllParts { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "card_faces")]
		public IList<CardFace> CardFaces { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "legalities")]
		public Legality Legalities { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "reserved")]
		public bool? Reserved { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "edhrec_rank")]
		public int? EdhrecRank { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "set")]
		public string Set { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "set_name")]
		public string SetName { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "collector_number")]
		public string CollectorNumber { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "set_search_uri")]
		public string SetSearchUri { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "scryfall_set_uri")]
		public string ScryfallSetUri { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "image_uris")]
		public ImageUri ImageUris { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "highres_image")]
		public bool? HighresImage { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "reprint")]
		public bool? Reprint { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "digital")]
		public bool? Digital { get; set; }

		/// <summary>
		/// Gets or sets possible values include: 'common', 'uncommon', 'rare',
		/// 'mythic'
		/// </summary>
		[JsonProperty(PropertyName = "rarity")]
		public Rarity? Rarity { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "flavor_text")]
		public string FlavorText { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "artist")]
		public string Artist { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "illustration_id")]
		public Guid? IllustrationId { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "frame")]
		public string Frame { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "full_art")]
		public bool? FullArt { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "watermark")]
		public string Watermark { get; set; }

		/// <summary>
		/// Gets or sets possible values include: 'black', 'borderless',
		/// 'gold', 'silver', 'white'
		/// </summary>
		[JsonProperty(PropertyName = "border_color")]
		public BorderColors? BorderColor { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "story_spotlight_number")]
		public int? StorySpotlightNumber { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "story_spotlight_uri")]
		public string StorySpotlightUri { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "timeshifted")]
		public bool? Timeshifted { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "colorshifted")]
		public bool? Colorshifted { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "futureshifted")]
		public bool? Futureshifted { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "purchase_uris")]
		public IDictionary<string, string> PurchaseUris { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "related_uris")]
		public IDictionary<string, string> RelatedUris { get; set; }
	}
}