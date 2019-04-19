using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hencodesu.ScryfallNet.Scryfall.Abstractions;
using Hencodesu.ScryfallNet.Scryfall.Models;
using Hencodesu.ScryfallNet.Scryfall.Models.Enums;

namespace Hencodesu.ScryfallNet.Scryfall.Categories {
	/// <inheritdoc cref="ICards"/>
	public class Cards : ICards {
		public Cards(ScryfallClient client) {
			Client = client ?? throw new ArgumentNullException(nameof(client));
		}

		private ScryfallClient Client { get; }

		/// <inheritdoc />
		public async Task<CardList> GetAllAsync(int? page = default(int?)) {
			var queryParameters = new List<string>();
			Client.AddQueryParameter(queryParameters, "page", page);

			return await Client.GetAsync<CardList>(Client.ConstructUrl("cards", queryParameters))
			                   .ConfigureAwait(false);
		}

		/// <inheritdoc />
		public async Task<CardList> SearchAsync(string q,
		                                        UniqueStrategy? unique = default(UniqueStrategy?),
		                                        SortOrder? order = default(SortOrder?),
		                                        SortDirection? dir = default(SortDirection?),
		                                        bool? includeExtras = default(bool?),
		                                        int? page = default(int?)) {
			var queryParameters = new List<string> {
				$"q={Uri.EscapeDataString(q)}"
			};
			Client.AddQueryParameter(queryParameters, "unique", unique);
			Client.AddQueryParameter(queryParameters, "order", order);
			Client.AddQueryParameter(queryParameters, "dir", dir);
			Client.AddQueryParameter(queryParameters, "include_extras", includeExtras);
			Client.AddQueryParameter(queryParameters, "page", page);

			return await Client.GetAsync<CardList>(Client.ConstructUrl("cards", queryParameters))
			                   .ConfigureAwait(false);
		}

		/// <inheritdoc />
		public async Task<Card> GetNamedAsync(string exact = default(string),
		                                      string fuzzy = default(string),
		                                      string set = default(string),
		                                      string format = default(string),
		                                      string face = default(string),
		                                      string version = default(string),
		                                      bool? pretty = default(bool?)) {
			var queryParameters = new List<string>();
			Client.AddQueryParameter(queryParameters, "exact", exact);
			Client.AddQueryParameter(queryParameters, "fuzzy", fuzzy);
			Client.AddQueryParameter(queryParameters, "set", set);
			Client.AddQueryParameter(queryParameters, "format", format);
			Client.AddQueryParameter(queryParameters, "face", face);
			Client.AddQueryParameter(queryParameters, "version", version);
			Client.AddQueryParameter(queryParameters, "pretty", pretty);

			return await Client.GetAsync<Card>(Client.ConstructUrl("cards", queryParameters))
			                   .ConfigureAwait(false);
		}

		/// <inheritdoc />
		public async Task<Catalog> AutocompleteAsync(string q) {
			var queryParameters = new List<string> {$"q={Uri.EscapeDataString(q)}"};

			return await Client.GetAsync<Catalog>(Client.ConstructUrl("cards", queryParameters))
			                   .ConfigureAwait(false);
		}

		/// <inheritdoc />
		public async Task<Card> GetRandomAsync() =>
			await Client.GetAsync<Card>(Client.ConstructUrl("cards"))
			            .ConfigureAwait(false);

		/// <inheritdoc />
		public async Task<Card> GetByMultiverseIdAsync(int id) =>
			await Client.GetAsync<Card>(Client.ConstructUrl($"cards/{Client.UrlPart(id)}"))
			            .ConfigureAwait(false);

		/// <inheritdoc />
		public async Task<Card> GetByMtgoIdAsync(int id) =>
			await Client.GetAsync<Card>(Client.ConstructUrl($"cards/{Client.UrlPart(id)}"))
			            .ConfigureAwait(false);

		/// <inheritdoc />
		public async Task<Card> GetByArenaIdAsync(int id) =>
			await Client.GetAsync<Card>(Client.ConstructUrl($"cards/{Client.UrlPart(id)}"))
			            .ConfigureAwait(false);

		/// <inheritdoc />
		public async Task<Card> GetByCodeByNumberAsync(string code, int number) =>
			await Client.GetAsync<Card>(Client.ConstructUrl($"cards/{Client.UrlPart(code)}/{Client.UrlPart(number)}"))
			            .ConfigureAwait(false);

		/// <inheritdoc />
		public async Task<Card> GetByIdAsync(Guid id) =>
			await Client.GetAsync<Card>(Client.ConstructUrl($"cards/{Client.UrlPart(id)}"))
			            .ConfigureAwait(false);
	}
}