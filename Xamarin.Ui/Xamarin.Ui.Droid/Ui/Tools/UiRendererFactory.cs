using System;
using System.Collections.Generic;
using Android.Views;
using Xamarin.Forms.Platform.Android;
using Xamarin.Ui.Droid.Ui.Containers;
using Xamarin.Ui.Droid.Ui.Views;
using Xamarin.Ui.Ui;

namespace Xamarin.Ui.Droid.Ui.Tools
{
	internal sealed class UiRendererFactory
	{
		private static UiRendererFactory Instance { get; } = new UiRendererFactory();
		public UiRendererFactory()
		{
			_renderers.Add(typeof(UiStackLayout), typeof(UiStackLayoutRenderer));
			_renderers.Add(typeof(UiLabel), typeof(UiLabelRenderer));
		}
		private readonly Dictionary<Type, Type> _renderers = new Dictionary<Type, Type>();

		public static View GetView(UiView sharedView)
		{
		    return sharedView == null ? null : Instance.GetViewInternal(sharedView);
		}

	    private View GetViewInternal(UiView sharedView)
		{
			var sharedViewType = sharedView.GetType();
		    if (!_renderers.ContainsKey(sharedViewType)) return null;
		    var nativeView =  Activator.CreateInstance(_renderers[sharedViewType]);
            var view = nativeView as View;
            if (view == null) return null;
            var nativeUiView = nativeView as INativeUiView;
			sharedView.NativeView = nativeUiView;
	        if (nativeUiView == null) return null;
	        nativeUiView.ViewHelper = new UiRendererHelper(nativeUiView, view, sharedView);
			nativeUiView.Init();
            sharedView.SetInit();
            return view;

		}
	}
}
