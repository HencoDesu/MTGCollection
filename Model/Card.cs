using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HencoDesu.MtgCollection.Model {
	public class Card {
		[Key]
		[Column(Order = 1)]
		public string SetCode { get; set; }
		
		[Key]
		[Column(Order = 2)]
		public string CardCode { get; set; }
		
		public int Amount { get; set; }
	}
}