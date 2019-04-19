using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hencodesu.ScryfallNet.Scryfall.Abstractions;
using Hencodesu.ScryfallNet.Scryfall.Models;

namespace Hencodesu.ScryfallNet.Scryfall.Categories {
	public class Symbology : ISymbology {
		public Symbology(ScryfallClient client) {
			Client = client ?? throw new ArgumentNullException(nameof(client));
		}

		private ScryfallClient Client { get; }

		public async Task<CardSymbolList> GetAllAsync() =>
			await Client.GetAsync<CardSymbolList>(Client.ConstructUrl("symbology"))
			            .ConfigureAwait(false);

		public async Task<ManaCost> ParseManaAsync(string cost) {
			var queryParameters = new List<string> {$"cost={Uri.EscapeDataString(cost)}"};
			
			return await Client.GetAsync<ManaCost>(Client.ConstructUrl("symbology/parse-mana"))
			                   .ConfigureAwait(false);
		}
	}
}