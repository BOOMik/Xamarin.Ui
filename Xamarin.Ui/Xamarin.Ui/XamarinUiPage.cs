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
            App.Logger($"Appearing Time for Ui: {appearingTime.TotalMilliseconds}");
        }

	    public XamarinUiPage()
	    {
	        Title = "Xamarin.Ui";
            ToolbarItems.Add(new ToolbarItem() { Text = "Views", Command = new Command(App.SeeViews) });
            var content = new UiViewForms()
	        {
	            View = new UiStackLayout()
	            {
	                Orientation = UiStackOrientation.Vertical,
	                
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

