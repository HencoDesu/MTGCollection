using System.Collections.Generic;
using Newtonsoft.Json;

namespace Hencodesu.ScryfallNet.Models {
	public class Error {
		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "status")]
		public int? Status { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "code")]
		public string Code { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "details")]
		public string Details { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "type")]
		public string Type { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "warnings")]
		public IList<string> Warnings { get; set; }
	}
}