using FontListApp.Views;
using UIKit;

namespace FontListApp.iOS.Renderers
{
    internal static class FontWeightExtensions
    {
        public static UIFontWeight ToNative(this FontWeight weight)
        {
            if (weight >= 0 && (int)weight <= 8)
                return (UIFontWeight)weight;
            else return UIFontWeight.Regular;
        }
    }
}