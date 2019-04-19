using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Hencodesu.ScryfallNet.Scryfall.Models.Enums {
	/// <summary>
	/// Defines values for Rarity.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Rarity {
		[EnumMember(Value = "common")]
		Common,

		[EnumMember(Value = "uncommon")]
		Uncommon,

		[EnumMember(Value = "rare")]
		Rare,

		[EnumMember(Value = "mythic")]
		Mythic
	}

	internal static class RarityEnumExtension {
		internal static string ToSerializedValue(this Rarity? value) {
			return value?.ToSerializedValue();
		}

		private static string ToSerializedValue(this Rarity value) {
			switch (value) {
				case Rarity.Common:
					return "common";
				case Rarity.Uncommon:
					return "uncommon";
				case Rarity.Rare:
					return "rare";
				case Rarity.Mythic:
					return "mythic";
			}

			return null;
		}

		internal static Rarity? ParseRarity(this string value) {
			switch (value) {
				case "common":
					return Rarity.Common;
				case "uncommon":
					return Rarity.Uncommon;
				case "rare":
					return Rarity.Rare;
				case "mythic":
					return Rarity.Mythic;
			}

			return null;
		}
	}
}