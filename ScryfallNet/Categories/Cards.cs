using System;
using System.Threading.Tasks;
using Hencodesu.ScryfallNet.Abstractions;
using Hencodesu.ScryfallNet.Models;
using Hencodesu.ScryfallNet.Models.Enums;
using RaphApi.Core.RestApi;

namespace Hencodesu.ScryfallNet.Categories {
	/// <inheritdoc cref="ICards"/>
	public class Cards : ICards {
		public Cards(ScryfallClient client) {
			Client = client ?? throw new ArgumentNullException(nameof(client));
		}

		private ScryfallClient Client { get; }

		/// <inheritdoc />
		public async Task<CardList> GetAllAsync(int? page = default(int?)) {
			var parameters = new RequestParameters();
			parameters.AddParameter("page", page);

			return await Client.GetAsync<CardList>(Client.BuildUri("cards", parameters))
			                   .ConfigureAwait(false);
		}

		/// <inheritdoc />
		public async Task<CardList> SearchAsync(string q,
		                                        UniqueStrategy? unique = default(UniqueStrategy?),
		                                        SortOrder? order = default(SortOrder?),
		                                        SortDirection? dir = default(SortDirection?),
		                                        bool? includeExtras = default(bool?),
		                                        int? page = default(int?)) {
			var parameters = new RequestParameters();
			parameters.AddParameter("q", q);
			parameters.AddParameter("unique", unique);
			parameters.AddParameter("order", order);
			parameters.AddParameter("dir", dir);
			parameters.AddParameter("include_extras", includeExtras);
			parameters.AddParameter("page", page);

			return await Client.GetAsync<CardList>(Client.BuildUri("cards/search", parameters))
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
			var parameters = new RequestParameters();
			parameters.AddParameter("exact", exact);
			parameters.AddParameter("fuzzy", fuzzy);
			parameters.AddParameter("set", set);
			parameters.AddParameter("format", format);
			parameters.AddParameter("face", face);
			parameters.AddParameter("version", version);
			parameters.AddParameter("pretty", pretty);

			return await Client.GetAsync<Card>(Client.BuildUri("cards/named", parameters))
			                   .ConfigureAwait(false);
		}

		/// <inheritdoc />
		public async Task<Catalog> AutocompleteAsync(string q) {
			var parameters = new RequestParameters();
			parameters.AddParameter("q", q);
			return await Client.GetAsync<Catalog>(Client.BuildUri("cards/autocomplete", parameters))
			                   .ConfigureAwait(false);
		}

		/// <inheritdoc />
		public async Task<Card> GetRandomAsync() =>
			await Client.GetAsync<Card>(Client.BuildUri("cards/random"))
			            .ConfigureAwait(false);

		/// <inheritdoc />
		public async Task<Card> GetByMultiverseIdAsync(int id) =>
			await Client.GetAsync<Card>(Client.BuildUri($"cards/multiverse/{id}"))
			            .ConfigureAwait(false);

		/// <inheritdoc />
		public async Task<Card> GetByMtgoIdAsync(int id) =>
			await Client.GetAsync<Card>(Client.BuildUri($"cards/mtgo/{id}"))
			            .ConfigureAwait(false);

		/// <inheritdoc />
		public async Task<Card> GetByArenaIdAsync(int id) =>
			await Client.GetAsync<Card>(Client.BuildUri($"cards/arena/{id}"))
			            .ConfigureAwait(false);

		/// <inheritdoc />
		public async Task<Card> GetByCodeByNumberAsync(string code, int number) =>
			await Client.GetAsync<Card>(Client.BuildUri($"cards/{code}/{number}"))
			            .ConfigureAwait(false);

		/// <inheritdoc />
		public async Task<Card> GetByIdAsync(Guid id) =>
			await Client.GetAsync<Card>(Client.BuildUri($"cards/{id}"))
			            .ConfigureAwait(false);
	}
}