using System;
using System.Threading.Tasks;
using Hencodesu.ScryfallNet.Models;
using Hencodesu.ScryfallNet.Models.Enums;

namespace Hencodesu.ScryfallNet.Abstractions {
	/// <summary>
	/// Cards operations.
	/// </summary>
	public interface ICards {
		Task<CardList> GetAllAsync(int? page = default(int?));

		Task<CardList> SearchAsync(string q,
		                           UniqueStrategy? unique = default(UniqueStrategy?),
		                           SortOrder? order = default(SortOrder?),
		                           SortDirection? dir = default(SortDirection?),
		                           bool? includeExtras = default(bool?),
		                           int? page = default(int?));

		Task<Card> GetNamedAsync(string exact = default(string),
		                         string fuzzy = default(string),
		                         string set = default(string),
		                         string format = default(string),
		                         string face = default(string),
		                         string version = default(string),
		                         bool? pretty = default(bool?));

		Task<Catalog> AutocompleteAsync(string q);

		Task<Card> GetRandomAsync();

		Task<Card> GetByMultiverseIdAsync(int id);

		Task<Card> GetByMtgoIdAsync(int id);

		Task<Card> GetByArenaIdAsync(int id);

		Task<Card> GetByCodeByNumberAsync(string code, int number);

		Task<Card> GetByIdAsync(Guid id);
	}
}