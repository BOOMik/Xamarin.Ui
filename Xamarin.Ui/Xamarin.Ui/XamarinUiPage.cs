using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Ui.Ui;

namespace Xamarin.Ui
{
	public class XamarinUiPage : ContentPage
	{
	    protected override void OnAppearing()
	    {
	        base.OnAppearing();
	        var appearingTime = DateTime.Now - App._tapTime;
			var text = $"Appearing Time for Ui: {appearingTime.TotalMilliseconds}";
            App.Logger(text);
			_time.Text = text;
			Device.StartTimer(TimeSpan.FromMilliseconds(500), () =>
			{
				if (appearingTime.TotalMilliseconds < 50)
				{
					_time.BackgroundColor = Color.Lime;
				} else if (appearingTime.TotalMilliseconds < 100)
				{
					_time.BackgroundColor = Color.Yellow;
				}
				else 
				{
					_time.BackgroundColor = Color.Red;
				}
				return false;
			});
        }


		UiLabel _time;
	    public XamarinUiPage()
	    {
	        Title = "Xamarin.Ui";
            ToolbarItems.Add(new ToolbarItem() { Text = "Views", Command = new Command(App.SeeViews) });
            var content = new UiViewForms()
	        {
	            View = new UiStackLayout()
	            {
	                Orientation = UiStackOrientation.Vertical,
					Spacing = 10,
                    Padding = new Thickness(10),
	                Childrens = new List<UiView>
	                {
	                    new UiLabel()
	                    {
	                        Text = "Hello world!",
	                        TextSize = 30,
	                        TextColor = Color.Black
	                    },
						new UiLabel()
						{
							Text = "New Ui for Xamarin is work!",
							TextSize = 14,
							TextColor = Color.Lime
						},
						new UiLabel()
                        {
                            Padding = new Thickness(10),
                            Text = "time...",
							TextSize = 20,
						}.ToVariable(out _time),
	                    new UiStackLayout()
	                    {
	                        Orientation = UiStackOrientation.Horizontal,
							Spacing = 50,
	                        Childrens = new List<UiView>
	                        {
	                            new UiLabel()
	                            {
	                                Text = "And horizontal",
	                                TextSize = 14,
	                                TextColor = Color.Gray
	                            },
	                            new UiLabel()
	                            {
	                                Text = " too!",
	                                TextSize = 10,
	                                TextColor = Color.Green
	                            }
	                        }
	                    },
	                    new UiStackLayout()
	                    {
	                        Orientation = UiStackOrientation.Horizontal,
	                        
	                        Childrens = new List<UiView>
	                        {
	                            new UiLabel()
	                            {
	                                Text = "And horizontal",
	                                TextSize = 14,
	                                TextColor = Color.Gray
	                            },
	                            new UiLabel()
	                            {
	                                Text = " too!",
	                                TextSize = 10,
	                                TextColor = Color.Green
	                            }
	                        }
	                    },
	                    new UiStackLayout()
	                    {
	                        Orientation = UiStackOrientation.Horizontal,
	                        
	                        Childrens = new List<UiView>
	                        {
	                            new UiLabel()
	                            {
	                                Text = "And horizontal",
                                    TextSize = 14,
	                                TextColor = Color.Gray
	                            },
	                            new UiLabel()
	                            {
	                                Text = " too!",
	                                TextSize = 10,
	                                TextColor = Color.Green
	                            }
	                        }
	                    },
	                    new UiStackLayout()
	                    {
	                        Orientation = UiStackOrientation.Horizontal,
	                        
	                        Childrens = new List<UiView>
	                        {
	                            new UiLabel()
	                            {
	                                Text = "And horizontal",
	                                TextSize = 14,
	                                TextColor = Color.Gray
	                            },
	                            new UiLabel()
	                            {
	                                Text = " too!",
	                                TextSize = 10,
	                                TextColor = Color.Green
	                            }
	                        }
	                    },
	                    new UiStackLayout()
	                    {
	                        Orientation = UiStackOrientation.Horizontal,
	                        
	                        Childrens = new List<UiView>
	                        {
	                            new UiLabel()
	                            {
	                                Text = "And horizontal",
	                                TextSize = 14,
	                                TextColor = Color.Gray
	                            },
	                            new UiLabel()
	                            {
	                                Text = " too!",
	                                TextSize = 10,
	                                TextColor = Color.Green
	                            }
	                        }
	                    },
	                    new UiStackLayout()
	                    {
	                        Orientation = UiStackOrientation.Horizontal,
	                        
	                        Childrens = new List<UiView>
	                        {
	                            new UiLabel()
	                            {
	                                Text = "And horizontal",
	                                TextSize = 14,
	                                TextColor = Color.Gray
	                            },
	                            new UiLabel()
	                            {
	                                Text = " too!",
	                                TextSize = 10,
	                                TextColor = Color.Green
	                            }
	                        }
	                    },
	                    new UiStackLayout()
	                    {
	                        Orientation = UiStackOrientation.Horizontal,
	                        
	                        Childrens = new List<UiView>
	                        {
	                            new UiLabel()
	                            {
	                                Text = "And horizontal",
	                                TextSize = 14,
	                                TextColor = Color.Gray
	                            },
	                            new UiLabel()
	                            {
	                                Text = " too!",
	                                TextSize = 10,
	                                TextColor = Color.Green
	                            }
	                        }
	                    },
	                    new UiStackLayout()
	                    {
	                        Orientation = UiStackOrientation.Horizontal,
	                        
	                        Childrens = new List<UiView>
	                        {
	                            new UiLabel()
	                            {
	                                Text = "And horizontal",
	                                TextSize = 14,
	                                TextColor = Color.Gray
	                            },
	                            new UiLabel()
	                            {
	                                Text = " too!",
	                                TextSize = 10,
	                                TextColor = Color.Green
	                            }
	                        }
	                    },
	                    new UiStackLayout()
	                    {
	                        Orientation = UiStackOrientation.Horizontal,
	                        
	                        Childrens = new List<UiView>
	                        {
	                            new UiLabel()
	                            {
	                                Text = "And horizontal",
	                                TextSize = 14,
	                                TextColor = Color.Gray
	                            },
	                            new UiLabel()
	                            {
	                                Text = " too!",
	                                TextSize = 10,
	                                TextColor = Color.Green
	                            }
	                        }
	                    },
	                    new UiStackLayout()
	                    {
	                        Orientation = UiStackOrientation.Horizontal,
	                        
	                        Childrens = new List<UiView>
	                        {
	                            new UiLabel()
	                            {
	                                Text = "And horizontal",
	                                TextSize = 14,
	                                TextColor = Color.Gray
	                            },
	                            new UiLabel()
	                            {
	                                Text = " too!",
	                                TextSize = 10,
	                                TextColor = Color.Green
	                            }
	                        }
	                    },
	                    new UiStackLayout()
	                    {
	                        Orientation = UiStackOrientation.Horizontal,
	                        
	                        Childrens = new List<UiView>
	                        {
	                            new UiLabel()
	                            {
	                                Text = "And horizontal",
	                                TextSize = 14,
	                                TextColor = Color.Gray
	                            },
	                            new UiLabel()
	                            {
	                                Text = " too!",
	                                TextSize = 10,
	                                TextColor = Color.Green
	                            }
	                        }
	                    }
	                }
	            }
	        };

	        Content = content;
	    }
	}
}

