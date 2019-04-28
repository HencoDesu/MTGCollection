using System.Data.Entity;
using System.Linq;

namespace HencoDesu.MtgCollection.Model {
	public class CollectionDb : DbContext {
		public static CollectionDb Instance => _instance ?? (_instance = new CollectionDb());

		private static CollectionDb _instance;

		private CollectionDb() : base("DefaultConnection") {
			Collection.Load();
		}
		
		public DbSet<Card> Collection { get; set; }

		public bool Contains(ScryfallNet.Models.Card card) =>
			Collection.Any(x => x.SetCode == card.Set && x.CardCode == card.CollectorNumber);

		public Card First(ScryfallNet.Models.Card card) =>
			Collection.First(x => x.SetCode == card.Set && x.CardCode == card.CollectorNumber);
	}
}