using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Application = Android.App.Application;
using View = Android.Views.View;

namespace Xamarin.Ui.Droid.Ui
{
    public static class UiTools
    {
        private static float _density;

        public static float Density => _density > 0 ? _density : _density = Application.Context.Resources.DisplayMetrics.Density;

        public static int ToPixels(this double value)
        {
            return (int) (value*Density);
        }
        [SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
        public static bool IsZero (this Thickness thickness)
        {
            return thickness.Left == 0.0 && thickness.Top == 0.0 && thickness.Right == 0.0 && thickness.Bottom == 0.0;
        }

        public static void SetMargins(this View view, Thickness margin)
        {
            if (view == null || margin.IsZero()) return;
            var lp = view.LayoutParameters as ViewGroup.MarginLayoutParams ?? new ViewGroup.MarginLayoutParams(ViewGroup.LayoutParams.WrapContent, ViewGroup.LayoutParams.WrapContent);
            lp.SetMargins(margin.Left.ToPixels(), margin.Top.ToPixels(), margin.Right.ToPixels(), margin.Bottom.ToPixels());
            view.LayoutParameters = lp;
        }

        [SuppressMessage("ReSharper", "CompareOfFloatsByEqualityOperator")]
        public static void SetSize(this View view, double width, double height)
        {
            if (view == null) return;
            var newWidth = width == 0 ? ViewGroup.LayoutParams.WrapContent : width.ToPixels();
            var newHeight = height == 0 ? ViewGroup.LayoutParams.WrapContent : height.ToPixels();
            var lp = view.LayoutParameters;
            if (lp != null)
            {
                lp.Width = newWidth;
                lp.Height = newHeight;
            }
            else
            {
                lp = new ViewGroup.MarginLayoutParams(newWidth, newHeight);

            }
            view.LayoutParameters = lp;
        }

        public static void SetPadding(this View view, Thickness padding)
        {
            view?.SetPadding(padding.Left.ToPixels(), padding.Top.ToPixels(), padding.Right.ToPixels(), padding.Bottom.ToPixels());
        }
    }
}