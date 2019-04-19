using Newtonsoft.Json;

namespace Hencodesu.ScryfallNet.Models {
	public class ImageUri {
		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "small")]
		public string Small { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "normal")]
		public string Normal { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "large")]
		public string Large { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "png")]
		public string Png { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "art_crop")]
		public string ArtCrop { get; set; }

		/// <summary>
		/// </summary>
		[JsonProperty(PropertyName = "border_crop")]
		public string BorderCrop { get; set; }
	}
}