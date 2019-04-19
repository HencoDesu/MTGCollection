using System;
using Newtonsoft.Json;

namespace Hencodesu.ScryfallNet.Scryfall.Models {
	public class RelatedCards {
		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "id")]
		public Guid? Id { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "name")]
		public string Name { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "uri")]
		public string Uri { get; set; }
	}
}