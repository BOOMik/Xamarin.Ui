using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Ui.Droid;

[assembly: ExportRenderer(typeof(ContentPage), typeof(LogPageRenderer))]
namespace Xamarin.Ui.Droid
{
    public class LogPageRenderer : PageRenderer
    {
        private static StringBuilder _sb;

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                App.SeeViews += SeeViews;
            }
			if (e.OldElement != null)
			{
				App.SeeViews -= SeeViews;
			}

			Device.StartTimer(TimeSpan.FromSeconds(5), () =>
			{
				SeeViews();
				return false;
			});
        }



        private void SeeViews()
        {
			if (Element == null) return;
            _sb = new StringBuilder();
			_sb.Append(Element?.Title).Append("\n");
			Log.Error("SeeViews", Element?.Title);
			try
			{
				SeeViews(ViewGroup);
			}
			catch { }
			finally
			{
				Toast.MakeText(ViewGroup.Context, _sb.ToString(), ToastLength.Short).Show();
			}
            
			
        }

        public static void SeeViews(ViewGroup viewGroup, int level=0)
        {
            if (viewGroup == null) return;
            var msg = $"{"-".Repeat(level)} [] {viewGroup.GetType().Name}";
            _sb.Append(msg).Append("\n");
            Log.Error("SeeViews", msg);
            level++;
            for (int i = 0; i < viewGroup.ChildCount; i++)
            {
                var view = viewGroup.GetChildAt(i);
                var group = view as ViewGroup;
                //Debug.WriteLine($"FindEditText {view.GetType().FullName}. Is group: {group != null} {group?.GetType().FullName ?? string.Empty}");
                if (group != null)
                {
                    SeeViews(group, level);
                }
                else
                {
                    var msg2 = $"{"-".Repeat(level)} {viewGroup.GetType().Name}";
                    _sb.Append(msg2).Append("\n");
                    Log.Error("SeeViews", msg2);
                }
            }
        }

    }

    public static class StringExtensions
    {
        public static string Repeat(this string input, int howTimes = 1)
        {
            if (string.IsNullOrEmpty(input)) return input;
            if (howTimes == 0) return string.Empty;
            if (howTimes == 1) return input;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < howTimes; i++)
            {
                sb.Append(input);
            }
            return sb.ToString();
        }
    }
}