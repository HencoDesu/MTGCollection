using System;
using System.Threading.Tasks;
using Hencodesu.ScryfallNet.Abstractions;
using Hencodesu.ScryfallNet.Models;
using RaphApi.Core.RestApi;

namespace Hencodesu.ScryfallNet.Categories {
	public class Symbology : ISymbology {
		public Symbology(ScryfallClient client) {
			Client = client ?? throw new ArgumentNullException(nameof(client));
		}

		private ScryfallClient Client { get; }

		public async Task<CardSymbolList> GetAllAsync() =>
			await Client.GetAsync<CardSymbolList>(Client.BuildUri("symbology"))
			            .ConfigureAwait(false);

		public async Task<ManaCost> ParseManaAsync(string cost) {
			var parameters = new RequestParameters();
			parameters.AddParameter("cost", cost);
			
			return await Client.GetAsync<ManaCost>(Client.BuildUri("symbology/parse-mana", parameters))
			                   .ConfigureAwait(false);
		}
	}
}