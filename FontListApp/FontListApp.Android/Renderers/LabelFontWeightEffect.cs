using Android.Widget;
using FontListApp.Droid.Renderers;
using FontListApp.Views;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportEffect(typeof(LabelFontWeightEffect), nameof(LabelFontWeightEffect))]
namespace FontListApp.Droid.Renderers
{
    public class LabelFontWeightEffect : PlatformEffect
    {
        protected override void OnAttached() => SetFontWeight();

        protected override void OnDetached() { }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            SetFontWeight(); //for some reasons calling this in OnAttached() gives no effect..
        }

        private void SetFontWeight()
        {
            if (Control is TextView textView && Element is Label label)
            {
                int weight = FontWeightEffect.GetFontWeight(label).ToNative();

                textView.SetWeight(weight);
            }
        }
    }
}