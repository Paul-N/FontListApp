using Xamarin.Forms;

namespace FontListApp.Views
{
    class LabelFontWeightEffect : RoutingEffect
    {
        public LabelFontWeightEffect() : base($"{Consts.CompanyName}.{nameof(LabelFontWeightEffect)}")
        {
        }
    }
}
