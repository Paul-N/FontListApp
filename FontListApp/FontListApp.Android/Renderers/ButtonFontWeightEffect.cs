using FontListApp.Droid.Renderers;
using FontListApp.Views;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using AndroidButton = Android.Widget.Button;
using XamarinButton = Xamarin.Forms.Button;

[assembly: ExportEffect(typeof(ButtonFontWeightEffect), nameof(ButtonFontWeightEffect))]
namespace FontListApp.Droid.Renderers
{
    public class ButtonFontWeightEffect : PlatformEffect
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
            if (Control is AndroidButton nativeBtn && Element is XamarinButton btn)
            {
                int weight = FontWeightEffect.GetFontWeight(btn).ToNative();

                nativeBtn.SetWeight(weight);
            }
        }
    }
}