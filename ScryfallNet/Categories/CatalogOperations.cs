using System;
using System.Threading.Tasks;
using Hencodesu.ScryfallNet.Abstractions;
using Hencodesu.ScryfallNet.Models;

namespace Hencodesu.ScryfallNet.Categories {
	public class CatalogOperations : ICatalogOperations {
		public CatalogOperations(ScryfallClient client) {
			Client = client ?? throw new ArgumentNullException(nameof(client));
		}

		private ScryfallClient Client { get; }

		public async Task<Catalog> GetCardNamesAsync() =>
			await Client.GetAsync<Catalog>(Client.BuildUri("catalog/card-names"))
			            .ConfigureAwait(false);


		public async Task<Catalog> GetWordBankAsync() =>
			await Client.GetAsync<Catalog>(Client.BuildUri("catalog/word-bank"))
			            .ConfigureAwait(false);

		public async Task<Catalog> GetCreatureTypesAsync() =>
			await Client.GetAsync<Catalog>(Client.BuildUri("catalog/creature-types"))
			            .ConfigureAwait(false);


		public async Task<Catalog> GetPlaneswalkerTypesAsync() =>
			await Client.GetAsync<Catalog>(Client.BuildUri("catalog/planeswalker-types"))
			            .ConfigureAwait(false);

		public async Task<Catalog> GetLandTypesAsync() =>
			await Client.GetAsync<Catalog>(Client.BuildUri("catalog/land-types"))
			            .ConfigureAwait(false);

		public async Task<Catalog> GetArtifactTypesAsync() =>
			await Client.GetAsync<Catalog>(Client.BuildUri("catalog/artifact-types"))
			            .ConfigureAwait(false);

		public async Task<Catalog> GetEnchantmentTypesAsync() =>
			await Client.GetAsync<Catalog>(Client.BuildUri("catalog/enchantment-types"))
			            .ConfigureAwait(false);

		public async Task<Catalog> GetSpellTypesAsync() =>
			await Client.GetAsync<Catalog>(Client.BuildUri("catalog/spell-types"))
			            .ConfigureAwait(false);

		public async Task<Catalog> GetPowersAsync() =>
			await Client.GetAsync<Catalog>(Client.BuildUri("catalog/powers"))
			            .ConfigureAwait(false);

		public async Task<Catalog> GetToughnessesAsync() =>
			await Client.GetAsync<Catalog>(Client.BuildUri("catalog/thoughnesses"))
			            .ConfigureAwait(false);

		public async Task<Catalog> GetLoyaltiesAsync() =>
			await Client.GetAsync<Catalog>(Client.BuildUri("catalog/loyalties"))
			            .ConfigureAwait(false);

		public async Task<Catalog> GetWatermarksAsync() =>
			await Client.GetAsync<Catalog>(Client.BuildUri("catalog/watermarks"))
			            .ConfigureAwait(false);
	}
}