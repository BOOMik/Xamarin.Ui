using System;
using Android.Views;
using Javax.Microedition.Khronos.Opengles;
using Xamarin.Ui.Droid.Ui.Tools.Extensions;
using Xamarin.Ui.Ui;

namespace Xamarin.Ui.Droid.Ui.Tools
{
    internal sealed class UiRendererHelper : IViewHelper
    {
        private readonly INativeUiView _nativeUiView;
        private readonly View _nativeView;
        private readonly UiView _sharedView;

        public UiRendererHelper(INativeUiView nativeUiView, View view, UiView sharedView)
        {
            _nativeUiView = nativeUiView;
            _nativeView = view;
            _sharedView = sharedView;
            ApplyInitialSettings();
        }

        private void ApplyInitialSettings()
        {
            _nativeView.SetPadding(_sharedView.Padding);
            _nativeView.SetMargins(_sharedView.Margin);
            _nativeView.SetBackgroundColor(_sharedView.BackgroundColor.ToAndroid());
            _nativeView.SetSize(_sharedView.Width, _sharedView.Height);
            _nativeView.Visibility = _sharedView.IsVisible ? ViewStates.Visible : ViewStates.Gone;
        }

        public void UpdateProperty(Type type, string property, object value)
        {

        }

        public T GetSharedView<T>() where T : UiView
        {
            return _sharedView as T;
        }
    }
}