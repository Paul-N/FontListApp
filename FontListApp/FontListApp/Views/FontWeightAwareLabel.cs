using Xamarin.Forms;

namespace FontListApp.Views
{
    public class FontWeightAwareLabel : Label
    {
        /// <summary>
        /// Font weight property
        /// </summary>
        public FontWeight FontWeight
        {
            get => (FontWeight)GetValue(FontWeightProperty);
            set => SetValue(FontWeightProperty, value);
        }

        public static readonly BindableProperty FontWeightProperty = BindableProperty.Create(nameof(FontWeight), typeof(FontWeight), typeof(FontWeightAwareLabel));
    }
}
