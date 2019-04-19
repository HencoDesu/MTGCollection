using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Hencodesu.ScryfallNet.Models.Enums {
	/// <summary>
	/// Defines values for SortDirection.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SortDirection {
		[EnumMember(Value = "auto")]
		Auto,

		[EnumMember(Value = "asc")]
		Asc,

		[EnumMember(Value = "desc")]
		Desc
	}

	internal static class SortDirectionEnumExtension {
		internal static string ToSerializedValue(this SortDirection? value) {
			return value?.ToSerializedValue();
		}

		private static string ToSerializedValue(this SortDirection value) {
			switch (value) {
				case SortDirection.Auto:
					return "auto";
				case SortDirection.Asc:
					return "asc";
				case SortDirection.Desc:
					return "desc";
			}

			return null;
		}

		internal static SortDirection? ParseSortDirection(this string value) {
			switch (value) {
				case "auto":
					return SortDirection.Auto;
				case "asc":
					return SortDirection.Asc;
				case "desc":
					return SortDirection.Desc;
			}

			return null;
		}
	}
}