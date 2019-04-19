using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hencodesu.ScryfallNet.Models {
	public class SetList {
		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "data")]
		public IList<Set> Data { get; set; }
	}
}