using System.Collections.Generic;
using Hencodesu.ScryfallNet.Abstractions;
using Hencodesu.ScryfallNet.Categories;
using Microsoft.Rest.Serialization;
using Newtonsoft.Json;
using RaphApi.Core.RestApi;

namespace Hencodesu.ScryfallNet {
	public sealed class ScryfallClient : RaphRestClient {
		/// <summary>
		/// Gets the ISets.
		/// </summary>
		public ISets Sets { get; }

		/// <summary>
		/// Gets the ICards.
		/// </summary>
		public ICards Cards { get; }

		/// <summary>
		/// Gets the IRulings.
		/// </summary>
		public IRulings Rulings { get; }

		/// <summary>
		/// Gets the ISymbology.
		/// </summary>
		public ISymbology Symbology { get; }

		/// <summary>
		/// Gets the ICatalogOperations.
		/// </summary>
		public ICatalogOperations Catalog { get; }
		
		/// <summary>
		/// Initializes a new instance of the ScryfallClient.
		/// </summary>
		public ScryfallClient() : base("https://api.scryfall.com") {
			Sets = new Sets(this);
			Cards = new Cards(this);
			Rulings = new Rulings(this);
			Symbology = new Symbology(this);
			Catalog = new CatalogOperations(this);
			
			SerializationSettings = new JsonSerializerSettings {
				Formatting = Formatting.Indented,
				DateFormatHandling = DateFormatHandling.IsoDateFormat,
				DateTimeZoneHandling = DateTimeZoneHandling.Utc,
				NullValueHandling = NullValueHandling.Ignore,
				ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
				ContractResolver = new ReadOnlyJsonContractResolver(),
				Converters = new List<JsonConverter> {
					new Iso8601TimeSpanConverter()
				}
			};
			DeserializationSettings = new JsonSerializerSettings {
				DateFormatHandling = DateFormatHandling.IsoDateFormat,
				DateTimeZoneHandling = DateTimeZoneHandling.Utc,
				NullValueHandling = NullValueHandling.Ignore,
				ReferenceLoopHandling = ReferenceLoopHandling.Serialize,
				ContractResolver = new ReadOnlyJsonContractResolver(),
				Converters = new List<JsonConverter> {
					new Iso8601TimeSpanConverter()
				}
			};
		}
	}
}