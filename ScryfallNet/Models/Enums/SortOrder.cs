using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Hencodesu.ScryfallNet.Models.Enums {
	/// <summary>
	/// Defines values for SortOrder.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SortOrder {
		[EnumMember(Value = "name")]
		Name,

		[EnumMember(Value = "set")]
		Set,

		[EnumMember(Value = "released")]
		Released,

		[EnumMember(Value = "rarity")]
		Rarity,

		[EnumMember(Value = "color")]
		Color,

		[EnumMember(Value = "usd")]
		Usd,

		[EnumMember(Value = "tix")]
		Tix,

		[EnumMember(Value = "eur")]
		Eur,

		[EnumMember(Value = "cmc")]
		Cmc,

		[EnumMember(Value = "power")]
		Power,

		[EnumMember(Value = "toughness")]
		Toughness,

		[EnumMember(Value = "edhrec")]
		Edhrec,

		[EnumMember(Value = "artist")]
		Artist
	}

	internal static class SortOrderEnumExtension {
		internal static string ToSerializedValue(this SortOrder? value) {
			return value?.ToSerializedValue();
		}

		private static string ToSerializedValue(this SortOrder value) {
			switch (value) {
				case SortOrder.Name:
					return "name";
				case SortOrder.Set:
					return "set";
				case SortOrder.Released:
					return "released";
				case SortOrder.Rarity:
					return "rarity";
				case SortOrder.Color:
					return "color";
				case SortOrder.Usd:
					return "usd";
				case SortOrder.Tix:
					return "tix";
				case SortOrder.Eur:
					return "eur";
				case SortOrder.Cmc:
					return "cmc";
				case SortOrder.Power:
					return "power";
				case SortOrder.Toughness:
					return "toughness";
				case SortOrder.Edhrec:
					return "edhrec";
				case SortOrder.Artist:
					return "artist";
			}

			return null;
		}

		internal static SortOrder? ParseSortOrder(this string value) {
			switch (value) {
				case "name":
					return SortOrder.Name;
				case "set":
					return SortOrder.Set;
				case "released":
					return SortOrder.Released;
				case "rarity":
					return SortOrder.Rarity;
				case "color":
					return SortOrder.Color;
				case "usd":
					return SortOrder.Usd;
				case "tix":
					return SortOrder.Tix;
				case "eur":
					return SortOrder.Eur;
				case "cmc":
					return SortOrder.Cmc;
				case "power":
					return SortOrder.Power;
				case "toughness":
					return SortOrder.Toughness;
				case "edhrec":
					return SortOrder.Edhrec;
				case "artist":
					return SortOrder.Artist;
			}

			return null;
		}
	}
}