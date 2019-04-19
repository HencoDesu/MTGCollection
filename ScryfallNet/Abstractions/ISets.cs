using System.Threading.Tasks;
using Hencodesu.ScryfallNet.Models;

namespace Hencodesu.ScryfallNet.Abstractions {
	public interface ISets {
		Task<SetList> GetAllAsync();

		Task<Set> GetByCodeAsync(string code);
	}
}