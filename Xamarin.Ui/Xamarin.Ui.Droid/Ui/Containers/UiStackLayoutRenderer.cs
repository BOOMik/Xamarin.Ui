using System.Collections.Generic;
using Android.Graphics.Drawables;
using Android.Graphics.Drawables.Shapes;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Ui.Droid.Ui.Tools;
using Xamarin.Ui.Droid.Ui.Tools.Extensions;
using Xamarin.Ui.Ui;
using AApp = Android.App.Application;

namespace Xamarin.Ui.Droid.Ui.Containers
{
	public class UiStackLayoutRenderer : LinearLayout, INativeUiView
	{
	    private UiStackLayout _view;

		public UiStackLayoutRenderer() : base(AApp.Context){}

		public void Init()
        {
            _view = ViewHelper.GetSharedView<UiStackLayout>();
            if (_view == null) return;
            Orientation = _view.Orientation == UiStackOrientation.Vertical ? Orientation.Vertical : Orientation.Horizontal;
            SetSpacing();
            var childs = _view.Childrens;
			if (childs == null) return;
			foreach (var child in childs)
			{
				var childView = UiRendererFactory.GetView(child);
				AddView(childView);
			}
        }

	    private void SetSpacing()
	    {
	        if (_view.Spacing > 0)
	        {
	            var spacing = _view.Spacing.ToPixels();
	            ShapeDrawable sd1 = new ShapeDrawable(new RectShape());
	            sd1.Paint.Color = Color.Transparent.ToAndroid();
	            if (Orientation == Orientation.Horizontal) sd1.SetIntrinsicWidth(spacing);
	            else sd1.SetIntrinsicHeight(spacing);
	            SetDividerDrawable(sd1);
	            ShowDividers = ShowDividers.Middle;
	        }
	        else
	        {
	            ShowDividers = ShowDividers.None;
	        }
	    }

	    public void UpdateProperty(string property, object value)
        {
            if (property == nameof(UiStackLayout.Orientation))
            {
                Orientation = (UiStackOrientation) value == UiStackOrientation.Vertical ? Orientation.Vertical : Orientation.Horizontal;
                SetSpacing();
            }
            if (property == nameof(UiStackLayout.Spacing))
            {
                SetSpacing();
            }
            if (property == nameof(UiStackLayout.Childrens))
            {
                RemoveAllViews();
                var childs = (List<UiView>)value;
                foreach (var child in childs)
                {
                    var childView = UiRendererFactory.GetView(child);
                    AddView(childView);
                }
            }
        }

        Size INativeUiView.GetSize(double width, double height)
		{
			return new Size(500, 500);
		}

		Size INativeUiView.OnMeasure(double width, double height)
		{
			return new Size(MeasuredWidth, MeasuredHeight);
		}

	    public IViewHelper ViewHelper { get; set; }
	}
}
