using FontListApp.iOS.Renderers;
using FontListApp.Views;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(FontWeightAwareLabel), typeof(FontWeightAwareLabelRenderer))]
namespace FontListApp.iOS.Renderers
{
    public class FontWeightAwareLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control?.Font != null && Element is FontWeightAwareLabel label)
            {
                var font = UIFont.SystemFontOfSize(Control.Font.PointSize, label.FontWeight.ToNative());

                Control.Font = font;
            }
        }
    }
}