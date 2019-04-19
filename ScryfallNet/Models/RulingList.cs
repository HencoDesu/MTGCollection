using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hencodesu.ScryfallNet.Models {
	public class RulingList {
		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "data")]
		public IList<Ruling> Data { get; set; }
	}
}