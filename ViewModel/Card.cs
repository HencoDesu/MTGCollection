using System;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using HencoDesu.RaphApi.WPF.ViewModel;

namespace HencoDesu.MtgCollection.ViewModel {
	public class Card : RaphViewModel {
		public Card(HencoDesu.ScryfallNet.Models.Card card) {
			_card = card;
		}
		
		private readonly HencoDesu.ScryfallNet.Models.Card _card;

		public string CardName => _card.Name;

		public ImageSource Image => new BitmapImage(new Uri(_card.ImageUris.Png));

		private int _amount;
		public int Amount {
			get => _amount;
			set => UpdateProperty(ref _amount, value);
		}

		public ICommand Increment => new RaphCommand((obj) => Amount++);

		public ICommand Decrement => new RaphCommand((obj) => Amount--,
		                                             (obj) => Amount > 0);
	}
}