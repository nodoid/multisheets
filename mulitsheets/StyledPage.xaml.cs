using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.StyleSheets;

namespace mulitsheets
{
    public partial class StyledPage : ContentPage
    {
        public StyledPage(string id)
        {
            InitializeComponent();

            var filename = "multisheets.Assets.sheet";
            filename += id == "0" ? "1" : id == "1" ? "2" : "3";
            filename += ".css";

            Resources.Add(StyleSheet.FromAssemblyResource(IntrospectionExtensions.GetTypeInfo(typeof(StyledPage)).Assembly, filename));
        }
    }
}
