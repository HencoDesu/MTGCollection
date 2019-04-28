using System;
using System.Windows;
using System.Windows.Controls;

namespace HencoDesu.MtgCollection.View {
	public partial class Collection {
		public Collection() {
			InitializeComponent();
		}

		private void UserControl_OnSizeChanged(object sender, SizeChangedEventArgs e) {
			CardsGrid.Rows = (int)Math.Floor(CardsGrid.ActualHeight / 360);
			CardsGrid.Columns = (int)Math.Floor(CardsGrid.ActualWidth / 220);
			if (CardsGrid.Children.Count != CardsGrid.Rows * CardsGrid.Columns) {
				UpdateItems();
			}
		}

		private void UpdateItems() {
			CardsGrid.Children.Clear();
			var data = (ViewModel.Collection) DataContext;
			data.PageSize = CardsGrid.Rows * CardsGrid.Columns;
			var index = data.StartIndex;
			for (var row = 0; row < CardsGrid.Rows; row++) {
				for (var column = 0; column < CardsGrid.Columns; column++) {
					CardsGrid.Children.Add(new Card {
						Margin = new Thickness(5),
						DataContext = data.Cards[index++]
					});
				}
			}
		}

		private void Collection_OnLoaded(object sender, RoutedEventArgs e) {
			var data = (ViewModel.Collection) DataContext;
			data.PropertyChanged += (obj, args) => {
				if (args.PropertyName == nameof(data.StartIndex)) {
					UpdateItems();
				}
			};
		}
	}
}
