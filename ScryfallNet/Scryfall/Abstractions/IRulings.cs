using System;
using System.Threading.Tasks;
using Hencodesu.ScryfallNet.Scryfall.Models;

namespace Hencodesu.ScryfallNet.Scryfall.Abstractions {
	public interface IRulings {
		Task<RulingList> GetByMultiverseIdAsync(int id);

		Task<RulingList> GetByMtgoIdAsync(int id);

		Task<RulingList> GetByCodeByNumberIdAsync(string code, int number);

		Task<RulingList> GetByIdAsync(Guid id);
	}
}