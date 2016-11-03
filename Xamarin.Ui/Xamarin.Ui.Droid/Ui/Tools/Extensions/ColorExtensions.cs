using System.Diagnostics.CodeAnalysis;
using Android.Content.Res;
using Android.Support.V4.Content;
using Android.Graphics;

namespace Xamarin.Ui.Droid.Ui.Tools.Extensions
{
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public static class ColorExtensions
    {
        public static readonly int[][] States =
        {
            new[] {16842910},
            new[] {-16842910}
        };

        public static Color ToAndroid(this Forms.Color self)
        {
            return new Color((byte) (byte.MaxValue*self.R), (byte) (byte.MaxValue*self.G), (byte) (byte.MaxValue*self.B), (byte) (byte.MaxValue*self.A));
        }

        public static Color ToAndroid(this Forms.Color self, int defaultColorResourceId)
        {
            return self == Forms.Color.Default ? new Color(ContextCompat.GetColor(Forms.Forms.Context, defaultColorResourceId)) : self.ToAndroid();
        }

        public static Color ToAndroid(this Forms.Color self, Forms.Color defaultColor)
        {
            if (self == Forms.Color.Default)
                return defaultColor.ToAndroid();
            return self.ToAndroid();
        }

        public static ColorStateList ToAndroidPreserveDisabled(this Forms.Color color, ColorStateList defaults)
        {
            int colorForState = defaults.GetColorForState(Forms.Platform.Android.ColorExtensions.States[1], color.ToAndroid());
            return new ColorStateList(Forms.Platform.Android.ColorExtensions.States, new[]
            {
                color.ToAndroid().ToArgb(),
                colorForState
            });
        }
    }
}