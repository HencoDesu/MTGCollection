using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Hencodesu.ScryfallNet.Models.Enums {
	/// <summary>
	/// Defines values for Layouts.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Layouts {
		[EnumMember(Value = "normal")]
		Normal,

		[EnumMember(Value = "split")]
		Split,

		[EnumMember(Value = "flip")]
		Flip,

		[EnumMember(Value = "transform")]
		Transform,

		[EnumMember(Value = "meld")]
		Meld,

		[EnumMember(Value = "leveler")]
		Leveler,

		[EnumMember(Value = "saga")]
		Saga,

		[EnumMember(Value = "planar")]
		Planar,

		[EnumMember(Value = "scheme")]
		Scheme,

		[EnumMember(Value = "vanguard")]
		Vanguard,

		[EnumMember(Value = "token")]
		Token,

		[EnumMember(Value = "double_faced_token")]
		DoubleFacedToken,

		[EnumMember(Value = "emblem")]
		Emblem,

		[EnumMember(Value = "augment")]
		Augment,

		[EnumMember(Value = "host")]
		Host
	}

	internal static class LayoutsEnumExtension {
		internal static string ToSerializedValue(this Layouts? value) {
			return value?.ToSerializedValue();
		}

		private static string ToSerializedValue(this Layouts value) {
			switch (value) {
				case Layouts.Normal:
					return "normal";
				case Layouts.Split:
					return "split";
				case Layouts.Flip:
					return "flip";
				case Layouts.Transform:
					return "transform";
				case Layouts.Meld:
					return "meld";
				case Layouts.Leveler:
					return "leveler";
				case Layouts.Saga:
					return "saga";
				case Layouts.Planar:
					return "planar";
				case Layouts.Scheme:
					return "scheme";
				case Layouts.Vanguard:
					return "vanguard";
				case Layouts.Token:
					return "token";
				case Layouts.DoubleFacedToken:
					return "double_faced_token";
				case Layouts.Emblem:
					return "emblem";
				case Layouts.Augment:
					return "augment";
				case Layouts.Host:
					return "host";
			}

			return null;
		}

		internal static Layouts? ParseLayouts(this string value) {
			switch (value) {
				case "normal":
					return Layouts.Normal;
				case "split":
					return Layouts.Split;
				case "flip":
					return Layouts.Flip;
				case "transform":
					return Layouts.Transform;
				case "meld":
					return Layouts.Meld;
				case "leveler":
					return Layouts.Leveler;
				case "saga":
					return Layouts.Saga;
				case "planar":
					return Layouts.Planar;
				case "scheme":
					return Layouts.Scheme;
				case "vanguard":
					return Layouts.Vanguard;
				case "token":
					return Layouts.Token;
				case "double_faced_token":
					return Layouts.DoubleFacedToken;
				case "emblem":
					return Layouts.Emblem;
				case "augment":
					return Layouts.Augment;
				case "host":
					return Layouts.Host;
			}

			return null;
		}
	}
}