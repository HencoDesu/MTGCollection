using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Hencodesu.ScryfallNet.Scryfall.Models.Enums {
	/// <summary>
	/// Defines values for LegalStatus.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum LegalStatus {
		[EnumMember(Value = "legal")]
		Legal,

		[EnumMember(Value = "not_legal")]
		NotLegal,

		[EnumMember(Value = "restricted")]
		Restricted,

		[EnumMember(Value = "banned")]
		Banned
	}

	internal static class LegalStatusEnumExtension {
		internal static string ToSerializedValue(this LegalStatus? value) {
			return value?.ToSerializedValue();
		}

		private static string ToSerializedValue(this LegalStatus value) {
			switch (value) {
				case LegalStatus.Legal:
					return "legal";
				case LegalStatus.NotLegal:
					return "not_legal";
				case LegalStatus.Restricted:
					return "restricted";
				case LegalStatus.Banned:
					return "banned";
			}

			return null;
		}

		internal static LegalStatus? ParseLegalStatus(this string value) {
			switch (value) {
				case "legal":
					return LegalStatus.Legal;
				case "not_legal":
					return LegalStatus.NotLegal;
				case "restricted":
					return LegalStatus.Restricted;
				case "banned":
					return LegalStatus.Banned;
			}

			return null;
		}
	}
}