using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PanCardView;
using PanCardView.EventArgs;
using Xamarin.Forms;

namespace MarvelCards
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCoverFlowViewSizeChanged(object sender, EventArgs e)
        {
            var view = (View)sender;
            view.HeightRequest = view.Width * 1.5;
        }

        private async void OnCoverFlowViewItemAppeared(CardsView view, ItemAppearedEventArgs args)
        {
            await AvengersLabel.ScaleTo(1.2, 250, Easing.CubicInOut);
            await AvengersLabel.ScaleTo(1, 500, Easing.BounceOut);
        }
    }
}
