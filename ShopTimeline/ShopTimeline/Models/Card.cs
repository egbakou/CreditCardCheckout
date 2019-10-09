using Xamarin.Forms;

namespace ShopTimeline.Models
{
    public class Card
    {
        public string Bank { get; set; }
        public Color FirstSignColor { get; set; }
        public Color LastSignColor { get; set; }
        public string CardNumber { get; set; }
        public string ExpirationDate { get; set; }
        public string Owner { get; set; }
        public Color BackgroundGradientStartColor { get; set; }
        public Color BackgroundGradientEndColor { get; set; }
    }
}
