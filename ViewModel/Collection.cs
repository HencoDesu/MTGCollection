using System.Collections.Generic;
using System.Collections.ObjectModel;
using Hencodesu.ScryfallNet;
using HencoDesu.RaphApi.WPF.ViewModel;

namespace HencoDesu.MtgCollection.ViewModel {
	public class Collection : RaphViewModel {
		public IList<Card> Cards { get; } = new ObservableCollection<Card> {
			new Card(ScryfallClient.Cards.GetRandomAsync().Result),
			new Card(ScryfallClient.Cards.GetRandomAsync().Result),
			new Card(ScryfallClient.Cards.GetRandomAsync().Result),
			new Card(ScryfallClient.Cards.GetRandomAsync().Result),
			new Card(ScryfallClient.Cards.GetRandomAsync().Result),
			new Card(ScryfallClient.Cards.GetRandomAsync().Result),
			new Card(ScryfallClient.Cards.GetRandomAsync().Result),
			new Card(ScryfallClient.Cards.GetRandomAsync().Result),
			new Card(ScryfallClient.Cards.GetRandomAsync().Result),
			new Card(ScryfallClient.Cards.GetRandomAsync().Result),
			new Card(ScryfallClient.Cards.GetRandomAsync().Result),
			new Card(ScryfallClient.Cards.GetRandomAsync().Result),
			new Card(ScryfallClient.Cards.GetRandomAsync().Result),
			new Card(ScryfallClient.Cards.GetRandomAsync().Result),
			new Card(ScryfallClient.Cards.GetRandomAsync().Result),
			new Card(ScryfallClient.Cards.GetRandomAsync().Result),
			new Card(ScryfallClient.Cards.GetRandomAsync().Result),
			new Card(ScryfallClient.Cards.GetRandomAsync().Result),
		};

		private static readonly ScryfallClient ScryfallClient = new ScryfallClient();
	}
}