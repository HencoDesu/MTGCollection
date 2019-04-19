using System;
using System.Threading.Tasks;
using Hencodesu.ScryfallNet.Abstractions;
using Hencodesu.ScryfallNet.Models;

namespace Hencodesu.ScryfallNet.Categories {
	public class Rulings : IRulings {
		public Rulings(ScryfallClient client) {
			Client = client ?? throw new ArgumentNullException(nameof(client));
		}

		private ScryfallClient Client { get; }

		public async Task<RulingList> GetByMultiverseIdAsync(int id) =>
			await Client.GetAsync<RulingList>(Client.BuildUri($"cards/multiverse/{id}/rulings"))
			            .ConfigureAwait(false);

		public async Task<RulingList> GetByMtgoIdAsync(int id) =>
			await Client.GetAsync<RulingList>(Client.BuildUri($"cards/mtgo/{id}/rulings"))
			            .ConfigureAwait(false);

		public async Task<RulingList> GetByCodeByNumberIdAsync(string code, int number) =>
			await Client.GetAsync<RulingList>(Client.BuildUri($"cards/{code}/{number}/rulings"))
			            .ConfigureAwait(false);

		public async Task<RulingList> GetByIdAsync(Guid id) =>
			await Client.GetAsync<RulingList>(Client.BuildUri($"cards/{id}/rulings"))
			            .ConfigureAwait(false);
	}
}