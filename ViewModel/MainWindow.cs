using HencoDesu.RaphApi.WPF.ViewModel;

namespace HencoDesu.MtgCollection.ViewModel {
	public class MainWindow : RaphViewModel{
		public Collection Collection { get; } = new Collection();
	}
}