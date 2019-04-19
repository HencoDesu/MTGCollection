using System;
using System.Threading.Tasks;
using Hencodesu.ScryfallNet.Scryfall.Abstractions;
using Hencodesu.ScryfallNet.Scryfall.Models;

namespace Hencodesu.ScryfallNet.Scryfall.Categories {
	public class Sets : ISets {
		public Sets(ScryfallClient client) {
			Client = client ?? throw new ArgumentNullException(nameof(client));
		}

		private ScryfallClient Client { get; }

		public async Task<SetList> GetAllAsync() =>
			await Client.GetAsync<SetList>(Client.ConstructUrl("sets"))
			            .ConfigureAwait(false);

		public async Task<Set> GetByCodeAsync(string code) =>
			await Client.GetAsync<Set>(Client.ConstructUrl($"sets/{Client.UrlPart(code)}"))
			            .ConfigureAwait(false);
	}
}