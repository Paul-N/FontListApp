using Android.Content;
using Android.Graphics;
using FontListApp.Droid.Renderers;
using FontListApp.Views;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using LabelRenderer = Xamarin.Forms.Platform.Android.FastRenderers.LabelRenderer;

[assembly: ExportRenderer(typeof(FontWeightAwareLabel), typeof(FontWeightAwareLabelRenderer))]
namespace FontListApp.Droid.Renderers
{
    public class FontWeightAwareLabelRenderer : LabelRenderer
    {
        public FontWeightAwareLabelRenderer(Context context) : base(context) { }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Element is FontWeightAwareLabel label)
            {
                int weight = label.FontWeight.ToNative();

                var typeface = Control.Typeface;
                Control.Typeface = Typeface.Create(typeface, weight, typeface.IsItalic);
            }
        }
    }
}