using System;
using System.Windows;

namespace HencoDesu.MtgCollection.View {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow {
		public MainWindow() {
			InitializeComponent();
		}

		private void RaphWindow_OnSizeChanged(object sender, SizeChangedEventArgs e) {
			CardsGrid.Rows = (int)Math.Floor((Height - 32) / 360);
			CardsGrid.Columns = (int)Math.Floor(Width / 220);
		}
	}
}