using System.Collections.Generic;
using System.Collections.ObjectModel;
using HencoDesu.RaphApi.WPF.ViewModel;

namespace HencoDesu.MtgCollection.ViewModel {
	public class MainWindow : RaphViewModel{
		public IList<Card> Cards { get; } = new ObservableCollection<Card> {
			new Card(455080),
			new Card(454913),
			new Card(454974),
			new Card(454975),
			new Card(454981),
			new Card(454947),
			new Card(435152),
			new Card(437266),
			new Card(437423),
			new Card(437335),
			new Card(437247),
			new Card(437319),
			new Card(437249),
			new Card(437250),
			new Card(459399),
			new Card(459367),
			new Card(459217),
			new Card(459372),
		};
	}
}