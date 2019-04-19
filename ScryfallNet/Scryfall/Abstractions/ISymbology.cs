using System.Threading.Tasks;
using Hencodesu.ScryfallNet.Scryfall.Models;

namespace Hencodesu.ScryfallNet.Scryfall.Abstractions {
	public interface ISymbology {
		Task<CardSymbolList> GetAllAsync();

		Task<ManaCost> ParseManaAsync(string cost);
	}
}