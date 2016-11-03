using Android.Widget;
using Xamarin.Forms;
using Xamarin.Ui.Droid.Ui.Tools;
using Xamarin.Ui.Ui;
using AApp = Android.App.Application;

namespace Xamarin.Ui.Droid.Ui
{
	public class UiStackLayoutRenderer : LinearLayout, INativeUiView
	{
		public UiView _view;

		public UiStackLayoutRenderer() : base(AApp.Context)
		{
			
		}

		UiView INativeUiView.View
		{
			get
			{
				return _view;
			}

			set
			{
				_view = value;
				OnElementChanged(value);
			}
		}

		void OnElementChanged(UiView uiView)
		{
			var container = uiView as UiStackLayout;
			if (container == null) return;
		    DividerPadding = container.Spacing.ToPixels();
			Orientation = container.Orientation == UiStackOrientation.Vertical ? Orientation.Vertical : Orientation.Horizontal;

			var childs = container.Childrens;
			if (childs == null) return;
			foreach (var child in childs)
			{
				var childView = UiRendererFactory.GetView(child);
				AddView(childView);
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
	    public void Init()
	    {
	        throw new System.NotImplementedException();
	    }

	    public void UpdateProperty(Type type, string property, object value)
	    {
	        throw new System.NotImplementedException();
	    }
	}
}
