using Hencodesu.ScryfallNet.Models.Enums;
using Newtonsoft.Json;

namespace Hencodesu.ScryfallNet.Models {
	public class ManaCost {
		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "cost")]
		public string Cost { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "cmc")]
		public double? Cmc { get; set; }

		/// <summary>
		/// Gets or sets possible values include: 'W', 'U', 'B', 'R', 'G'
		/// </summary>
		[JsonProperty(PropertyName = "colors")]
		public Colors? Colors { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "colorless")]
		public bool? Colorless { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "monocolored")]
		public bool? Monocolored { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "multicolored")]
		public bool? Multicolored { get; set; }
	}
}