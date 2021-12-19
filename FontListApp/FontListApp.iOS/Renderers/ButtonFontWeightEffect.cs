using FontListApp.iOS.Renderers;
using FontListApp.Views;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportEffect(typeof(ButtonFontWeightEffect), nameof(ButtonFontWeightEffect))]
namespace FontListApp.iOS.Renderers
{
    public class ButtonFontWeightEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control is UIButton nativeButton && nativeButton?.Font != null && Element is Button btn)
            {
                var font = UIFont.SystemFontOfSize(nativeButton.Font.PointSize, FontWeightEffect.GetFontWeight(btn).ToNative());

                nativeButton.Font = font;
            }
        }

        protected override void OnDetached() { }
    }
}