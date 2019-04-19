using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Hencodesu.ScryfallNet.Scryfall.Models.Enums {
	/// <summary>
	/// Defines values for UniqueStrategy.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum UniqueStrategy {
		[EnumMember(Value = "cards")]
		Cards,

		[EnumMember(Value = "art")]
		Art,

		[EnumMember(Value = "prints")]
		Prints
	}

	internal static class UniqueStrategyEnumExtension {
		internal static string ToSerializedValue(this UniqueStrategy? value) {
			return value?.ToSerializedValue();
		}

		private static string ToSerializedValue(this UniqueStrategy value) {
			switch (value) {
				case UniqueStrategy.Cards:
					return "cards";
				case UniqueStrategy.Art:
					return "art";
				case UniqueStrategy.Prints:
					return "prints";
			}

			return null;
		}

		internal static UniqueStrategy? ParseUniqueStrategy(this string value) {
			switch (value) {
				case "cards":
					return UniqueStrategy.Cards;
				case "art":
					return UniqueStrategy.Art;
				case "prints":
					return UniqueStrategy.Prints;
			}

			return null;
		}
	}
}