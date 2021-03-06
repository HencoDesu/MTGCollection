using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Hencodesu.ScryfallNet.Models.Enums {
	/// <summary>
	/// Defines values for SetTypes.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SetTypes {
		[EnumMember(Value = "core")]
		Core,

		[EnumMember(Value = "expansion")]
		Expansion,

		[EnumMember(Value = "masters")]
		Masters,

		[EnumMember(Value = "masterpiece")]
		Masterpiece,

		[EnumMember(Value = "from_the_vault")]
		FromTheVault,

		[EnumMember(Value = "spellbook")]
		Spellbook,

		[EnumMember(Value = "premium_deck")]
		PremiumDeck,

		[EnumMember(Value = "duel_deck")]
		DuelDeck,

		[EnumMember(Value = "commander")]
		Commander,

		[EnumMember(Value = "planechase")]
		Planechase,

		[EnumMember(Value = "conspiracy")]
		Conspiracy,

		[EnumMember(Value = "archenemy")]
		Archenemy,

		[EnumMember(Value = "vanguard")]
		Vanguard,

		[EnumMember(Value = "funny")]
		Funny,

		[EnumMember(Value = "starter")]
		Starter,

		[EnumMember(Value = "box")]
		Box,

		[EnumMember(Value = "promo")]
		Promo,

		[EnumMember(Value = "token")]
		Token,

		[EnumMember(Value = "memorabilia")]
		Memorabilia,

		[EnumMember(Value = "treasure_chest")]
		TreasureChest
	}

	internal static class SetTypesEnumExtension {
		internal static string ToSerializedValue(this SetTypes? value) {
			return value?.ToSerializedValue();
		}

		private static string ToSerializedValue(this SetTypes value) {
			switch (value) {
				case SetTypes.Core:
					return "core";
				case SetTypes.Expansion:
					return "expansion";
				case SetTypes.Masters:
					return "masters";
				case SetTypes.Masterpiece:
					return "masterpiece";
				case SetTypes.FromTheVault:
					return "from_the_vault";
				case SetTypes.Spellbook:
					return "spellbook";
				case SetTypes.PremiumDeck:
					return "premium_deck";
				case SetTypes.DuelDeck:
					return "duel_deck";
				case SetTypes.Commander:
					return "commander";
				case SetTypes.Planechase:
					return "planechase";
				case SetTypes.Conspiracy:
					return "conspiracy";
				case SetTypes.Archenemy:
					return "archenemy";
				case SetTypes.Vanguard:
					return "vanguard";
				case SetTypes.Funny:
					return "funny";
				case SetTypes.Starter:
					return "starter";
				case SetTypes.Box:
					return "box";
				case SetTypes.Promo:
					return "promo";
				case SetTypes.Token:
					return "token";
				case SetTypes.Memorabilia:
					return "memorabilia";
				case SetTypes.TreasureChest:
					return "treasure_chest";
			}

			return null;
		}

		internal static SetTypes? ParseSetTypes(this string value) {
			switch (value) {
				case "core":
					return SetTypes.Core;
				case "expansion":
					return SetTypes.Expansion;
				case "masters":
					return SetTypes.Masters;
				case "masterpiece":
					return SetTypes.Masterpiece;
				case "from_the_vault":
					return SetTypes.FromTheVault;
				case "spellbook":
					return SetTypes.Spellbook;
				case "premium_deck":
					return SetTypes.PremiumDeck;
				case "duel_deck":
					return SetTypes.DuelDeck;
				case "commander":
					return SetTypes.Commander;
				case "planechase":
					return SetTypes.Planechase;
				case "conspiracy":
					return SetTypes.Conspiracy;
				case "archenemy":
					return SetTypes.Archenemy;
				case "vanguard":
					return SetTypes.Vanguard;
				case "funny":
					return SetTypes.Funny;
				case "starter":
					return SetTypes.Starter;
				case "box":
					return SetTypes.Box;
				case "promo":
					return SetTypes.Promo;
				case "token":
					return SetTypes.Token;
				case "memorabilia":
					return SetTypes.Memorabilia;
				case "treasure_chest":
					return SetTypes.TreasureChest;
			}

			return null;
		}
	}
}