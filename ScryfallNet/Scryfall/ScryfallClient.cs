using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Hencodesu.ScryfallNet.Scryfall.Abstractions;
using Hencodesu.ScryfallNet.Scryfall.Categories;
using Microsoft.Rest.Serialization;
using Newtonsoft.Json;

namespace Hencodesu.ScryfallNet.Scryfall {
	public class ScryfallClient {
		/// <summary>
		/// Gets the ISets.
		/// </summary>
		public virtual ISets Sets { get; }

		/// <summary>
		/// Gets the ICards.
		/// </summary>
		public virtual ICards Cards { get; }

		/// <summary>
		/// Gets the IRulings.
		/// </summary>
		public virtual IRulings Rulings { get; }

		/// <summary>
		/// Gets the ISymbology.
		/// </summary>
		public virtual ISymbology Symbology { get; }

		/// <summary>
		/// Gets the ICatalogOperations.
		/// </summary>
		public virtual ICatalogOperations Catalog { get; }
		
		/// <summary>
		/// Initializes a new instance of the ScryfallClient.
		/// </summary>
		public ScryfallClient() {
			Sets = new Sets(this);
			Cards = new Cards(this);
			Rulings = new Rulings(this);
			Symbology = new Symbology(this);
			Catalog = new CatalogOperations(this);
			BaseUri = new Uri("https://api.scryfall.com");
			
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
		
		/// <summary>
		/// The base URI of the service.
		/// </summary>
		private Uri BaseUri { get; }

		/// <summary>
		/// Gets or sets json serialization settings.
		/// </summary>
		private JsonSerializerSettings SerializationSettings { get; }

		/// <summary>
		/// Gets or sets json deserialization settings.
		/// </summary>
		private JsonSerializerSettings DeserializationSettings { get; }

		/// <summary>
		/// Sends HttpGet request
		/// </summary>
		/// <param name="url">Url to send request</param>
		/// <typeparam name="T">Type to return</typeparam>
		internal async Task<T> GetAsync<T>(Uri url) {
			var response = await RequestAsync(
				new HttpRequestMessage(HttpMethod.Get, url)).ConfigureAwait(false);

			return HandleResponse<T>(response);
		}

		/// <summary>
		/// Generates full Url fo request
		/// </summary>
		/// <param name="relativeUrl">Relative url</param>
		/// <param name="requestParameters">Request params</param>
		/// <returns></returns>
		internal Uri ConstructUrl(string relativeUrl, IReadOnlyCollection<string> requestParameters = null) {
			var url = BaseUri + relativeUrl;
			if (requestParameters?.Count > 0) {
				url += "?" + string.Join("&", requestParameters);
			}

			return new Uri(url);
		}

		internal string UrlPart<T>(T value) {
			var valueString = value as string;
			
			return Uri.EscapeDataString(valueString != null
				                            ? valueString.Trim('"')
				                            : SafeJsonConvert.SerializeObject(value, SerializationSettings).Trim('"'));
		}
		
		/// <summary>
		/// Adds request parameter
		/// </summary>
		/// <param name="requestParameters">Parameters collection</param>
		/// <param name="parameter">Parameter name</param>
		/// <param name="value">Parameter value</param>
		/// <typeparam name="T">Parameter type</typeparam>
		internal void AddQueryParameter<T>(ICollection<string> requestParameters, string parameter, T value) {
			if (value == null) return;
			requestParameters.Add(parameter + UrlPart(value));
		}

		private T HandleResponse<T>(string response) {
			try {
				return JsonConvert.DeserializeObject<T>(response, DeserializationSettings);
			}
			catch (JsonSerializationException ex) {
				return default(T);
			}
		}

		private async Task<string> RequestAsync(HttpRequestMessage request) {
			HttpResponseMessage response;
			using (var client = new HttpClient()) {
				response = await client.SendAsync(request).ConfigureAwait(false);
			}

			if (response.IsSuccessStatusCode) {
				return await response.Content.ReadAsStringAsync().ConfigureAwait(false);
			}
			else {
				return null;
			}
		}
	}
}