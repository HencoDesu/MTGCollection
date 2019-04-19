using System;
using System.Threading.Tasks;
using Hencodesu.ScryfallNet.Scryfall.Abstractions;
using Hencodesu.ScryfallNet.Scryfall.Models;

namespace Hencodesu.ScryfallNet.Scryfall.Categories {
	public class CatalogOperations : ICatalogOperations {
		public CatalogOperations(ScryfallClient client) {
			Client = client ?? throw new ArgumentNullException(nameof(client));
		}

		private ScryfallClient Client { get; }

		public async Task<Catalog> GetCardNamesAsync() =>
			await Client.GetAsync<Catalog>(Client.ConstructUrl("catalog/card-names"))
			            .ConfigureAwait(false);


		public async Task<Catalog> GetWordBankAsync() =>
			await Client.GetAsync<Catalog>(Client.ConstructUrl("catalog/word-bank"))
			            .ConfigureAwait(false);

		public async Task<Catalog> GetCreatureTypesAsync() =>
			await Client.GetAsync<Catalog>(Client.ConstructUrl("catalog/creature-types"))
			            .ConfigureAwait(false);


		public async Task<Catalog> GetPlaneswalkerTypesAsync() =>
			await Client.GetAsync<Catalog>(Client.ConstructUrl("catalog/planeswalker-types"))
			            .ConfigureAwait(false);

		public async Task<Catalog> GetLandTypesAsync() =>
			await Client.GetAsync<Catalog>(Client.ConstructUrl("catalog/land-types"))
			            .ConfigureAwait(false);

		public async Task<Catalog> GetArtifactTypesAsync() =>
			await Client.GetAsync<Catalog>(Client.ConstructUrl("catalog/artifact-types"))
			            .ConfigureAwait(false);

		public async Task<Catalog> GetEnchantmentTypesAsync() =>
			await Client.GetAsync<Catalog>(Client.ConstructUrl("catalog/enchantment-types"))
			            .ConfigureAwait(false);

		public async Task<Catalog> GetSpellTypesAsync() =>
			await Client.GetAsync<Catalog>(Client.ConstructUrl("catalog/spell-types"))
			            .ConfigureAwait(false);

		public async Task<Catalog> GetPowersAsync() =>
			await Client.GetAsync<Catalog>(Client.ConstructUrl("catalog/powers"))
			            .ConfigureAwait(false);

		public async Task<Catalog> GetToughnessesAsync() =>
			await Client.GetAsync<Catalog>(Client.ConstructUrl("catalog/thoughnesses"))
			            .ConfigureAwait(false);

		public async Task<Catalog> GetLoyaltiesAsync() =>
			await Client.GetAsync<Catalog>(Client.ConstructUrl("catalog/loyalties"))
			            .ConfigureAwait(false);

		public async Task<Catalog> GetWatermarksAsync() =>
			await Client.GetAsync<Catalog>(Client.ConstructUrl("catalog/watermarks"))
			            .ConfigureAwait(false);
	}
}