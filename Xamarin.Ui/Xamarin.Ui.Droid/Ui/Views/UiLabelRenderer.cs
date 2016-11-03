using System;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Ui.Ui;
using AApp = Android.App.Application;

namespace Xamarin.Ui.Droid.Ui.Views
{
	public class UiLabelRenderer : TextView, INativeUiView
	{
	    private UiLabel _view;
		public UiLabelRenderer() : base(AApp.Context) {}
        public void Init()
        {
            _view = ViewHelper.GetSharedView<UiLabel>();
            if (_view == null) return;
            Text = _view.Text;
            SetTextColor(_view.TextColor.ToAndroid());
            TextSize = (float)_view.TextSize;
        }

	    public void UpdateProperty(string property, object value)
	    {
	        if (property == "Text")
	        {
	            Text = value as string;
	        }
	        if (property == "TextColor")
	        {
	            SetTextColor(((Color) value).ToAndroid());
	        }
	        if (property == "TextSize")
	        {
	            TextSize = (float) value;
	        }
	    }


	    Size INativeUiView.GetSize(double width, double height)
		{
			return new Size(500, 100);
		}

		Size INativeUiView.OnMeasure(double width, double height)
		{
			return new Size(MeasuredWidth, MeasuredHeight);
		}

	    public IViewHelper ViewHelper { get; set; }

	}
}
