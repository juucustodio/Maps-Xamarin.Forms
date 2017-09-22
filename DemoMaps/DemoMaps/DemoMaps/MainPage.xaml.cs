using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace DemoMaps
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Mapa.MoveToRegion(MapSpan.FromCenterAndRadius(
                new Position(-23.4859591, -47.4420192),
                Distance.FromMiles(0.5)));


            var pin = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-23.4859591, -47.4420192),
                Label = "Demo Maps",
                Address = "www.julianocustodio.com",
            };

            Mapa.Pins.Add(pin);
        }
    }
}
