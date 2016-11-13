using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CircleImage
{
    class CircleImage : Image
    {
        public static readonly BindableProperty OutlineColorProperty = BindableProperty.Create("OutlineColor", typeof(Color), typeof(CircleImage), Color.Transparent);
        public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create("ImageSource", typeof(string), typeof(CircleImage), "Add.png");

        public Color OutlineColor
        {
            get
            {
                return (Color)GetValue(OutlineColorProperty);
            }
            set
            {
                SetValue(OutlineColorProperty, value);
            }
        }
        public string ImageSource
        {
            get
            {
                FileImageSource source = (FileImageSource)GetValue(SourceProperty);
                return source.File;
            }
            set
            {
                SetValue(ImageSourceProperty, value);
            }
        }
    }
}
