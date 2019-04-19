using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Hencodesu.ScryfallNet.Scryfall.Models.Enums {
	/// <summary>
	/// Defines values for BorderColors.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum BorderColors {
		[EnumMember(Value = "black")]
		Black,

		[EnumMember(Value = "borderless")]
		Borderless,

		[EnumMember(Value = "gold")]
		Gold,

		[EnumMember(Value = "silver")]
		Silver,

		[EnumMember(Value = "white")]
		White
	}

	internal static class BorderColorsEnumExtension {
		internal static string ToSerializedValue(this BorderColors? value) {
			return value?.ToSerializedValue();
		}

		private static string ToSerializedValue(this BorderColors value) {
			switch (value) {
				case BorderColors.Black:
					return "black";
				case BorderColors.Borderless:
					return "borderless";
				case BorderColors.Gold:
					return "gold";
				case BorderColors.Silver:
					return "silver";
				case BorderColors.White:
					return "white";
			}

			return null;
		}

		internal static BorderColors? ParseBorderColors(this string value) {
			switch (value) {
				case "black":
					return BorderColors.Black;
				case "borderless":
					return BorderColors.Borderless;
				case "gold":
					return BorderColors.Gold;
				case "silver":
					return BorderColors.Silver;
				case "white":
					return BorderColors.White;
				default:
					return null;
			}
		}
	}
}