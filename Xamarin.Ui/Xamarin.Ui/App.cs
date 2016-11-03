using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using Xamarin.Ui.Ui;

namespace Xamarin.Ui
{
    public class App : Application
    {
        public static DateTime _tapTime;
        public static Action<string> Logger;
        public static Action SeeViews;
		NavigationPage _nav;
		public App()
		{
			// The root page of your application
			var stack = new StackLayout
			{
				Padding = 16,
				Spacing = 16,
			};

			stack.Children.Add(new Button
			{
				Text = "Xamarin.Ui",
				Command = new Command(() =>
				{
                    _tapTime= DateTime.Now;
				    _nav.PushAsync(new XamarinUiPage());
				})
			});
			stack.Children.Add(new Button
			{
				Text = "Xamarin.Forms",
				Command = new Command(() =>
				{
                    _tapTime = DateTime.Now;
				    _nav.PushAsync(new XamarinFormsPage());
				})
			});
			stack.Children.Add(new Button
			{
				Text = "Xamarin.Forms Xaml",
				Command = new Command(() =>
				{
                    _tapTime = DateTime.Now;
				    _nav.PushAsync(new XamarinFormsXamlPage());
				})
			});
		    var cp = new ContentPage
		    {
		        Title = "Pages",
		        Content = stack,
		    };
            _nav = new NavigationPage(cp);

			cp.ToolbarItems.Add(new ToolbarItem() { Text = "Views", Command = new Command((obj) => App.SeeViews?.Invoke()) });
            MainPage = _nav;
		}

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
