using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Hencodesu.ScryfallNet.Models.Enums {
	/// <summary>
	/// Defines values for Colors.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Colors {
		[EnumMember(Value = "W")]
		W,

		[EnumMember(Value = "U")]
		U,

		[EnumMember(Value = "B")]
		B,

		[EnumMember(Value = "R")]
		R,

		[EnumMember(Value = "G")]
		G
	}

	internal static class ColorsEnumExtension {
		internal static string ToSerializedValue(this Colors? value) {
			return value?.ToSerializedValue();
		}

		private static string ToSerializedValue(this Colors value) {
			switch (value) {
				case Colors.W:
					return "W";
				case Colors.U:
					return "U";
				case Colors.B:
					return "B";
				case Colors.R:
					return "R";
				case Colors.G:
					return "G";
			}

			return null;
		}

		internal static Colors? ParseColors(this string value) {
			switch (value) {
				case "W":
					return Colors.W;
				case "U":
					return Colors.U;
				case "B":
					return Colors.B;
				case "R":
					return Colors.R;
				case "G":
					return Colors.G;
			}

			return null;
		}
	}
}