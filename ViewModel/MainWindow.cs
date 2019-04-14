using System.Collections.Generic;
using System.Collections.ObjectModel;
using HencoDesu.RaphApi.WPF.ViewModel;

namespace HencoDesu.MtgCollection.ViewModel {
	public class MainWindow : RaphViewModel{
		public IEnumerable<Card> Cards { get; } = new ObservableCollection<Card>() {
			new Card(455080),
			new Card(454913),
			new Card(454974),
			new Card(454975),
			new Card(454981),
			new Card(454947),
		};
	}
}