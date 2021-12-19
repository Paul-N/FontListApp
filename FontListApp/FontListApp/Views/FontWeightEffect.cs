using System.Linq;
using Xamarin.Forms;

namespace FontListApp.Views
{
    public static class FontWeightEffect
    {
        public static readonly BindableProperty FontWeightProperty = BindableProperty.CreateAttached("FontWeight", typeof(FontWeight), typeof(FontWeightEffect), FontWeight.Regular, propertyChanged: OnFontWeightChanged);

        private static void OnFontWeightChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var view = bindable as View;
            if (view == null)
                return;

            var fontWeight = (FontWeight)newValue;
            if (fontWeight != FontWeight.Regular)
            {
                if(view is Label)
                    view.Effects.Add(new LabelFontWeightEffect());
                else if(view is Button)
                    view.Effects.Add(new ButtonFontWeightEffect());
            }
            else
            {
                if (view is Label)
                {
                    var toRemove = view.Effects.FirstOrDefault(e => e is LabelFontWeightEffect);
                    if (toRemove != null)
                    {
                        view.Effects.Remove(toRemove);
                    }
                }
                else if (view is Button)
                {
                    var toRemove = view.Effects.FirstOrDefault(e => e is ButtonFontWeightEffect);
                    if (toRemove != null)
                    {
                        view.Effects.Remove(toRemove);
                    }
                }
            }
        }

        public static FontWeight GetFontWeight(BindableObject view) => (FontWeight)view.GetValue(FontWeightProperty);

        public static void SetFontWeight(BindableObject view, FontWeight value) => view.SetValue(FontWeightProperty, value);
    }
}
