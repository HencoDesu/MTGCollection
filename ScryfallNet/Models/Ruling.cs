using System;
using Microsoft.Rest.Serialization;
using Newtonsoft.Json;

namespace Hencodesu.ScryfallNet.Models {
	public class Ruling {
		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "source")]
		public string Source { get; set; }

		/// <summary>
		/// </summary>
		[JsonConverter(typeof(DateJsonConverter))]
		[JsonProperty(PropertyName = "published_at")]
		public DateTime? PublishedAt { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "comment")]
		public string Comment { get; set; }
	}
}