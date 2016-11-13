using System;
using CircleImage;
using CircleImage.UWP;
using Xamarin.Forms.Platform.UWP;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Xaml.Media.Imaging;

[assembly: ExportRenderer(typeof(CircleImage), typeof(CircleImageRenderer))]
namespace CircleImage.UWP
{
    class CircleImageRenderer : ViewRenderer<CircleImage, Ellipse>
    {

        public CircleImageRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<CircleImage> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement != null || this.Element == null)
                return;

            if (Control == null && Element != null)
            {
                System.Diagnostics.Debug.WriteLine(Element.ImageSource);
                Ellipse ellipse = new Ellipse() { Fill = new ImageBrush() { ImageSource = GetImageSource() } };
                SetNativeControl(ellipse);
            }

        }

        private Windows.UI.Xaml.Media.ImageSource GetImageSource()
        {
            try
            {
                Windows.UI.Xaml.Media.ImageSource source = new BitmapImage(new Uri("ms-appx:///" + Element.ImageSource));
                return source;
            }
            catch (Exception e)
            {
                return new BitmapImage(new Uri("ms-appx:///AvatarPlaceholder.png"));
            }
        }
    }
}
