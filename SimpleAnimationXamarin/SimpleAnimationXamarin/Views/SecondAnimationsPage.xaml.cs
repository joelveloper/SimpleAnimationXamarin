using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleAnimationXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondAnimationsPage : ContentPage
    {
        public SecondAnimationsPage()
        {
            InitializeComponent();
        }

        private async void BtnStart_Clicked(object sender, System.EventArgs e)
        {
            _ = await FrameStart.FadeTo(0, 500);
            _ = MainThread.InvokeOnMainThreadAsync(async () => await LoadAnimation());
        }

        private async Task LoadAnimation()
        {
            _ = await FrameImage.FadeTo(1, 500);
            _ = await ImageRotate.RotateTo(180, 400);
            _ = await ImageRotate.RotateTo(180, 200);
            _ = await ImageRotate.RotateTo(0, 400);
            _ = await ImageRotate.RotateTo(0, 200);
            _ = await ImageRotate.RotateTo(180, 400);
            _ = await ImageRotate.RotateTo(180, 200);
            _ = await ImageRotate.RotateTo(0, 400);
            _ = await ImageRotate.RotateTo(0, 200);
            _ = await FrameImage.FadeTo(0, 400);
            _ = await RectangleZoom.FadeTo(1, 200);
            _ = await RectangleZoom.ScaleTo(15, 400);
            _ = await RectangleZoom.ScaleTo(15, 200);
            _ = await RectangleZoom.ScaleTo(1, 400);
            _ = await RectangleZoom.ScaleTo(1, 200);
            _ = await RectangleZoom.ScaleTo(15, 400);
            _ = await RectangleZoom.ScaleTo(15, 200);
            _ = await RectangleZoom.ScaleTo(1, 400);
            _ = await RectangleZoom.ScaleTo(1, 200);
            _ = await RectangleZoom.FadeTo(0, 400);
            _ = await ImageScale.ScaleTo(3, 400);
            _ = await ImageScale.ScaleTo(3, 200);
            _ = await ImageScale.ScaleTo(1, 400);
            _ = await ImageScale.ScaleTo(1, 200);
            _ = await ImageScale.ScaleTo(3, 400);
            _ = await ImageScale.ScaleTo(3, 200);
            _ = await ImageScale.ScaleTo(1, 400);
            _ = await ImageScale.ScaleTo(1, 200);
            _ = await FrameStart.FadeTo(1, 300);
            _ = await RectangleZoom.FadeTo(1);
            _ = await FrameImage.FadeTo(1);
        }
    }
}