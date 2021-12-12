using Android.Graphics.Fonts;
using FontListApp.Views;

namespace FontListApp.Droid.Renderers
{
    internal static class FontWeightExtensions
    {
        public static int ToNative(this FontWeight weight)
        {
            return weight switch
            {
                FontWeight.UltraLight => FontStyle.FontWeightExtraLight,
                FontWeight.Thin => FontStyle.FontWeightThin,
                FontWeight.Light => FontStyle.FontWeightLight,
                FontWeight.Regular => FontStyle.FontWeightNormal,
                FontWeight.Medium => FontStyle.FontWeightMedium,
                FontWeight.Semibold => FontStyle.FontWeightSemiBold,
                FontWeight.Bold => FontStyle.FontWeightBold,
                FontWeight.Heavy => FontStyle.FontWeightExtraBold,
                FontWeight.Black => FontStyle.FontWeightBlack,
                _ => FontStyle.FontWeightNormal,
            };
        }
    }
}