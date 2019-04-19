using System.Threading.Tasks;
using Hencodesu.ScryfallNet.Models;

namespace Hencodesu.ScryfallNet.Abstractions {
	public interface ICatalogOperations {
		Task<Catalog> GetCardNamesAsync();

		Task<Catalog> GetWordBankAsync();

		Task<Catalog> GetCreatureTypesAsync();

		Task<Catalog> GetPlaneswalkerTypesAsync();
		
		Task<Catalog> GetLandTypesAsync();

		Task<Catalog> GetArtifactTypesAsync();

		Task<Catalog> GetEnchantmentTypesAsync();

		Task<Catalog> GetSpellTypesAsync();

		Task<Catalog> GetPowersAsync();

		Task<Catalog> GetToughnessesAsync();

		Task<Catalog> GetLoyaltiesAsync();

		Task<Catalog> GetWatermarksAsync();
	}
}