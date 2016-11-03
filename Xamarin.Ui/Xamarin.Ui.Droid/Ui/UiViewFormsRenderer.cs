using System;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Ui.Droid.Ui;
using Xamarin.Ui.Droid.Ui.Tools;
using Xamarin.Ui.Ui;
using AApp = Android.App.Application;

[assembly: ExportRenderer(typeof(UiViewForms), typeof(UiViewFormsRenderer))]

namespace Xamarin.Ui.Droid.Ui
{
    public class UiViewFormsRenderer : ViewRenderer
    {
        INativeUiView _view { get; set; }

        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.View> e)
        {
            base.OnElementChanged(e);
            var element = e.NewElement as UiViewForms;
			if (element == null) return;
            _view = element.View.NativeView;
			
			var rootFrame = new FrameLayout(AApp.Context);
			var nativeView = UiRendererFactory.GetView(element.View);
			if (nativeView == null) return;
			rootFrame.AddView(nativeView);
            SetNativeControl(rootFrame);
        }


        public override SizeRequest GetDesiredSize(int widthConstraint, int heightConstraint)
        {
            return new SizeRequest(_view?.GetSize(widthConstraint, heightConstraint) ?? new Size(200, 200));
        }
    }
}