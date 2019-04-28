using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using HencoDesu.MtgCollection.Model;
using HencoDesu.ScryfallNet;
using HencoDesu.RaphApi.WPF.ViewModel;
using HencoDesu.ScryfallNet.Models;

namespace HencoDesu.MtgCollection.ViewModel {
	public class Collection : RaphViewModel {
		public IList<Card> Cards { get; } = new ObservableCollection<Card>();

		public int StartIndex {
			get => _startIndex;
			set => UpdateProperty(ref _startIndex, value);
		}
		private int _startIndex;

		public int PageSize {
			get => _pageSize;
			set => UpdateProperty(ref _pageSize, value);
		}
		private int _pageSize;
		
		public ICommand PreviousPage => new RaphCommand(obj =>
			StartIndex = StartIndex < PageSize ? 0 : StartIndex - PageSize
		);
		public ICommand NextPage => new RaphCommand(obj => 
			                                            StartIndex = StartIndex >= Cards.Count ? Cards.Count - PageSize 
				                                            : StartIndex + PageSize);

		private static readonly ScryfallClient ScryfallClient = new ScryfallClient();
		
		public Collection() {
			var cards = ScryfallClient.Cards.SearchAsync("lang:ru f:standard unique:cards").Result;
			foreach (var card in cards) {
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