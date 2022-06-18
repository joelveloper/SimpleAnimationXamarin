using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleAnimationXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimationsPage : ContentPage
    {
        public AnimationsPage()
        {
            InitializeComponent();
        }

        private async void BtnRotate_Clicked(object sender, EventArgs e)
        {
            _ = await Frame.RotateTo(360, 1000, Easing.CubicIn);
            _ = await Frame.RotateTo(0, 1000, Easing.CubicIn);
        }

        private async void BtnTranslate_Clicked(object sender, EventArgs e)
        {
            _ = await Frame.TranslateTo(100, 0, 500);
            _ = await Frame.TranslateTo(100, -100, 500);
            _ = await Frame.TranslateTo(0, 0, 500);
        }

        private async void BtnScale_Clicked(object sender, EventArgs e)
        {
            _ = await Frame.ScaleTo(2, 1000);
            _ = await Frame.ScaleTo(0.5, 1000);
            _ = await Frame.ScaleTo(1, 1000);
        }

        private async void BtnFade_Clicked(object sender, EventArgs e)
        {
            _ = await Frame.FadeTo(0, 1000);
            _ = await Frame.FadeTo(1, 1000);
        }

        private async void BtnRotateX_Clicked(object sender, EventArgs e)
        {
            _ = await Frame.RotateXTo(180, 1000);
            _ = await Frame.RotateXTo(0, 1000);
        }

        private async void BtnRotateY_Clicked(object sender, EventArgs e)
        {
            _ = await Frame.RotateYTo(180, 1000);
            _ = await Frame.RotateYTo(0, 1000);
        }
    }
}