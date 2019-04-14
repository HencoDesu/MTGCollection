using System;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using HencoDesu.RaphApi.WPF.ViewModel;

namespace HencoDesu.MtgCollection.ViewModel {
	public class Card : RaphViewModel {

		public Card(int multiverseId) {
			_multiverseId = multiverseId;
		}

		private readonly int _multiverseId;
		public ImageSource Image => new BitmapImage(
			new Uri($"https://gatherer.wizards.com/Handlers/Image.ashx?multiverseid={_multiverseId}&type=card"));

		private int _amount = 0;

		public int Amount {
			get => _amount;
			set => UpdateProperty(ref _amount, value);
		}

		public ICommand Increment {
			get => new RaphCommand((obj) => Amount++);
		}

		public ICommand Decrement {
			get => new RaphCommand(
				(obj) => Amount--,
				(obj) => Amount > 0);
		}
	}
}