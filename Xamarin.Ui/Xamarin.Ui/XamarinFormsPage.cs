using System;
using Xamarin.Forms;

namespace Xamarin.Ui
{
    public static class AddChildrenHelper
    {
        public static Layout<View> Add(this Layout<View> self, params View[] views)
        {
            foreach (var view in views)
            {
                self.Children.Add(view);
            }
            return self;
        }
    }

    public class XamarinFormsPage : ContentPage
	{

        protected override void OnAppearing()
        {
            base.OnAppearing();
            var appearingTime = DateTime.Now - App._tapTime;
            App.Logger($"Appearing Time for Forms: {appearingTime.TotalMilliseconds}");
        }
        public XamarinFormsPage()
        {
            Title = "Xamarin.Forms";
            ToolbarItems.Add(new ToolbarItem() {Text = "Views", Command = new Command(App.SeeViews)});
            var content = new StackLayout()
            {
                Orientation = StackOrientation.Vertical,
                Spacing = 0,
                Padding = 0,
            }.Add(new Label()
            {
                Text = "Hello world!",
                FontSize = 30,
                TextColor = Color.Black
            },
                new Label()
                {
                    Text = "Xamarin Forms is work!",
                    FontSize = 14,
                    TextColor = Color.Lime
                },
                new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 0,
                    Padding = 0
                }.Add(
                    new Label()
                    {
                        Text = "And horizontal",
                        FontSize = 14,
                        TextColor = Color.Gray
                    },
                    new Label()
                    {
                        Text = " too!",
                        FontSize = 10,
                        TextColor = Color.Green
                    }),
                new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 0,
                    Padding = 0,
                    
                }.Add(
                    new Label()
                    {
                        Text = "And horizontal",
                        FontSize = 14,
                        TextColor = Color.Gray
                    },
                    new Label()
                    {
                        Text = " too!",
                        FontSize = 10,
                        TextColor = Color.Green
                    }),
                new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 0,
                    Padding = 0,
                    
                }.Add(
                    new Label()
                    {
                        Text = "And horizontal",
                        FontSize = 14,
                        TextColor = Color.Gray
                    },
                    new Label()
                    {
                        Text = " too!",
                        FontSize = 10,
                        TextColor = Color.Green
                    }),
                new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 0,
                    Padding = 0,
                    
                }.Add(
                    new Label()
                    {
                        Text = "And horizontal",
                        FontSize = 14,
                        TextColor = Color.Gray
                    },
                    new Label()
                    {
                        Text = " too!",
                        FontSize = 10,
                        TextColor = Color.Green
                    }),
                new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 0,
                    Padding = 0,
                    
                }.Add(
                    new Label()
                    {
                        Text = "And horizontal",
                        FontSize = 14,
                        TextColor = Color.Gray
                    },
                    new Label()
                    {
                        Text = " too!",
                        FontSize = 10,
                        TextColor = Color.Green
                    }),
                new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 0,
                    Padding = 0,
                    
                }.Add(
                    new Label()
                    {
                        Text = "And horizontal",
                        FontSize = 14,
                        TextColor = Color.Gray
                    },
                    new Label()
                    {
                        Text = " too!",
                        FontSize = 10,
                        TextColor = Color.Green
                    }),
                new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 0,
                    Padding = 0,
                    
                }.Add(
                    new Label()
                    {
                        Text = "And horizontal",
                        FontSize = 14,
                        TextColor = Color.Gray
                    },
                    new Label()
                    {
                        Text = " too!",
                        FontSize = 10,
                        TextColor = Color.Green
                    }),
                new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 0,
                    Padding = 0,
                    
                }.Add(
                    new Label()
                    {
                        Text = "And horizontal",
                        FontSize = 14,
                        TextColor = Color.Gray
                    },
                    new Label()
                    {
                        Text = " too!",
                        FontSize = 10,
                        TextColor = Color.Green
                    }),
                new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 0,
                    Padding = 0,
                    
                }.Add(
                    new Label()
                    {
                        Text = "And horizontal",
                        FontSize = 14,
                        TextColor = Color.Gray
                    },
                    new Label()
                    {
                        Text = " too!",
                        FontSize = 10,
                        TextColor = Color.Green
                    }),
                new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 0,
                    Padding = 0,
                    
                }.Add(
                    new Label()
                    {
                        Text = "And horizontal",
                        FontSize = 14,
                        TextColor = Color.Gray
                    },
                    new Label()
                    {
                        Text = " too!",
                        FontSize = 10,
                        TextColor = Color.Green
                    }),
                new StackLayout()
                {
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 0,
                    Padding = 0,
                    
                }.Add(
                    new Label()
                    {
                        Text = "And horizontal",
                        FontSize = 14,
                        TextColor = Color.Gray
                    },
                    new Label()
                    {
                        Text = " too!",
                        FontSize = 10,
                        TextColor = Color.Green
                    }));


            Content = content;

        }
	}


}

