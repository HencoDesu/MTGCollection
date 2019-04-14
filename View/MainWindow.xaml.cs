using System;
using System.Windows;
using System.Windows.Data;

namespace HencoDesu.MtgCollection.View {
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow {
		public MainWindow() {
			InitializeComponent();
		}

		private void RaphWindow_OnSizeChanged(object sender, SizeChangedEventArgs e) {
			CardsGrid.Rows = (int)Math.Floor(CardsGrid.Height / 360);
			CardsGrid.Columns = (int)Math.Floor(CardsGrid.Width / 220);

			if (CardsGrid.Children.Count != CardsGrid.Rows * CardsGrid.Columns) {
				CardsGrid.Children.Clear();

				var index = 0;
				for (var row = 0; row < CardsGrid.Rows; row++) {
					for (var column = 0; column < CardsGrid.Columns; column++) {
						var CardView = new Card {
							Margin = new Thickness(5),
							DataContext = (DataContext as ViewModel.MainWindow).Cards[index++]
						};
						CardsGrid.Children.Add(CardView);
					}
				}
			}
		}
	}
}