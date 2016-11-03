using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Xamarin.Ui
{
    public partial class XamarinFormsXamlPage : ContentPage
    {

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var appearingTime = DateTime.Now - App._tapTime;
            App.Logger($"Appearing Time for Xaml: {appearingTime.TotalMilliseconds}");
        }


        public XamarinFormsXamlPage()
        {
            InitializeComponent();
            ToolbarItems.Add(new ToolbarItem() { Text = "Views", Command = new Command(App.SeeViews) });
        }
    }
}
