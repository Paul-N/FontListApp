using FontListApp;
using FontListApp.iOS.Renderers;
using FontListApp.Views;
using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName(Consts.CompanyName)]
[assembly: ExportEffect(typeof(LabelFontWeightEffect), nameof(LabelFontWeightEffect))]
namespace FontListApp.iOS.Renderers
{
    public class LabelFontWeightEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            if (Control is UILabel nativeLabel && nativeLabel?.Font != null && Element is Label label)
            {
                var font = UIFont.SystemFontOfSize(nativeLabel.Font.PointSize, FontWeightEffect.GetFontWeight(label).ToNative());

                nativeLabel.Font = font;
            }
        }

        protected override void OnDetached() { }
    }
}