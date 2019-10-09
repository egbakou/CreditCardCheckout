using ShopTimeline.Models;
using System.Collections.Generic;
using Xamarin.Forms;

namespace ShopTimeline.Services
{
    public class FakeService
    {
        public static List<Card> GetAllCards()
        {
            return new List<Card>
            {
                new Card
                {
                    Bank ="AXIS BANK",
                    FirstSignColor = Color.FromHex("#D32F2F"),
                    LastSignColor = Color.FromHex("#FFA000"),
                    CardNumber = "5789 XXXX XXXX 6789",
                    ExpirationDate = "15/20",
                    Owner = "CARDINE DOE",
                    BackgroundGradientStartColor = Color.FromHex("#4C273C"),
                    BackgroundGradientEndColor = Color.FromHex("#A62C60"),
                },
                new Card
                {
                    Bank ="CORIS BANK",
                    FirstSignColor = Color.FromHex("#98DE5B"),
                    LastSignColor = Color.FromHex("#EF6DA0"),
                    CardNumber = "4567 XXXX XXXX 1119",
                    ExpirationDate = "09/20",
                    Owner = "CARDINE DOE",
                    BackgroundGradientStartColor = Color.FromHex("#CB218E"),
                    BackgroundGradientEndColor = Color.FromHex("#6617CB"),
                },
                new Card
                {
                    Bank ="ECOBANK TOGO",
                    FirstSignColor = Color.FromHex("#874da2"),
                    LastSignColor = Color.FromHex("#c43a30"),
                    CardNumber = "3456 XXXX XXXX 8790",
                    ExpirationDate = "12/21",
                    Owner = "CARDINE DOE",
                    BackgroundGradientStartColor = Color.FromHex("#d558c8"),
                    BackgroundGradientEndColor = Color.FromHex("#24d292"),
                },
                new Card
                {
                    Bank ="ORABANK",
                    FirstSignColor = Color.FromHex("#df89b5"),
                    LastSignColor = Color.FromHex("#c1c161"),
                    CardNumber = "5673 XXXX XXXX 2345",
                    ExpirationDate = "12/21",
                    Owner = "CARDINE DOE",
                    BackgroundGradientStartColor = Color.FromHex("#616161"),
                    BackgroundGradientEndColor = Color.FromHex("#9bc5c3"),
                }

            };
        }
    }
}
