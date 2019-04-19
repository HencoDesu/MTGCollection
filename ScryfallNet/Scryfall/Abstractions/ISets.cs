using System.Threading.Tasks;
using Hencodesu.ScryfallNet.Scryfall.Models;

namespace Hencodesu.ScryfallNet.Scryfall.Abstractions {
	public interface ISets {
		Task<SetList> GetAllAsync();

		Task<Set> GetByCodeAsync(string code);
	}
}