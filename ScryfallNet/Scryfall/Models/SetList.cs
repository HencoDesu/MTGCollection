using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hencodesu.ScryfallNet.Scryfall.Models {
	public class SetList {
		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "data")]
		public IList<Set> Data { get; set; }
	}
}