﻿using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.StyleSheets;

namespace mulitsheets
{
    public partial class StyledPage : ContentPage
    {
        public StyledPage()
        {
            InitializeComponent();
        }

        public StyledPage(string id)
        {
            InitializeComponent();

            var filename = $"mulitsheets.Assets.sheet{id}.css";
            var img = id == "1" ? "zx81" : id == "2" ? "spectrum" : "ql";

            Resources.Add(StyleSheet.FromAssemblyResource(IntrospectionExtensions.GetTypeInfo(typeof(StyledPage)).Assembly, filename));
            imgPic.Source = img;
        }
    }
}
