using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using HencoDesu.MtgCollection.Model;
using HencoDesu.ScryfallNet;
using HencoDesu.RaphApi.WPF.ViewModel;

namespace HencoDesu.MtgCollection.ViewModel {
	public class Collection : RaphViewModel {
		public IList<Card> Cards { get; } = new ObservableCollection<Card>();

		private static readonly ScryfallClient ScryfallClient = new ScryfallClient();

		public Collection() {
			var cards = ScryfallClient.Cards.SearchAsync("f:standard").Result;
			foreach (var card in cards.Data) {
				if (!CollectionDb.Instance.Contains(card)) {
					CollectionDb.Instance.Collection.Add(new Model.Card {
						SetCode = card.Set,
						CardCode = card.CollectorNumber,
						Amount = 0
					});
					CollectionDb.Instance.SaveChanges();
				}
				
				var cardView = new Card(card) {
					Amount = CollectionDb.Instance.First(card).Amount
				};
				cardView.PropertyChanged += (sender, e) => {
					if (e.PropertyName != nameof(Card.Amount)) return;
					
					CollectionDb.Instance.First(card).Amount = cardView.Amount;
					CollectionDb.Instance.SaveChanges();
				};
				Cards.Add(cardView);
			}
		}
	}
}