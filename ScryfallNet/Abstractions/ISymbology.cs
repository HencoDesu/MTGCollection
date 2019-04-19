using System.Threading.Tasks;
using Hencodesu.ScryfallNet.Models;

namespace Hencodesu.ScryfallNet.Abstractions {
	public interface ISymbology {
		Task<CardSymbolList> GetAllAsync();

		Task<ManaCost> ParseManaAsync(string cost);
	}
}