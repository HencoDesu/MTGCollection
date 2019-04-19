using System;
using System.Threading.Tasks;
using Hencodesu.ScryfallNet.Abstractions;
using Hencodesu.ScryfallNet.Models;

namespace Hencodesu.ScryfallNet.Categories {
	public class Sets : ISets {
		public Sets(ScryfallClient client) {
			Client = client ?? throw new ArgumentNullException(nameof(client));
		}

		private ScryfallClient Client { get; }

		public async Task<SetList> GetAllAsync() =>
			await Client.GetAsync<SetList>(Client.BuildUri("sets"))
			            .ConfigureAwait(false);

		public async Task<Set> GetByCodeAsync(string code) =>
			await Client.GetAsync<Set>(Client.BuildUri($"sets/{code}"))
			            .ConfigureAwait(false);
	}
}