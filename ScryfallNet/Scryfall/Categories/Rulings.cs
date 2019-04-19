using System;
using System.Threading.Tasks;
using Hencodesu.ScryfallNet.Scryfall.Abstractions;
using Hencodesu.ScryfallNet.Scryfall.Models;

namespace Hencodesu.ScryfallNet.Scryfall.Categories {
	public class Rulings : IRulings {
		public Rulings(ScryfallClient client) {
			Client = client ?? throw new ArgumentNullException(nameof(client));
		}

		private ScryfallClient Client { get; }

		public async Task<RulingList> GetByMultiverseIdAsync(int id) =>
			await Client.GetAsync<RulingList>(Client.ConstructUrl($"cards/multiverse/{Client.UrlPart(id)}/rulings"))
			            .ConfigureAwait(false);

		public async Task<RulingList> GetByMtgoIdAsync(int id) =>
			await Client.GetAsync<RulingList>(Client.ConstructUrl($"cards/mtgo/{Client.UrlPart(id)}/rulings"))
			            .ConfigureAwait(false);

		public async Task<RulingList> GetByCodeByNumberIdAsync(string code, int number) =>
			await Client
			      .GetAsync<RulingList>(
				      Client.ConstructUrl($"cards/{Client.UrlPart(code)}/{Client.UrlPart(number)}/rulings"))
			      .ConfigureAwait(false);

		public async Task<RulingList> GetByIdAsync(Guid id) =>
			await Client.GetAsync<RulingList>(Client.ConstructUrl($"cards/{Client.UrlPart(id)}/rulings"))
			            .ConfigureAwait(false);
	}
}