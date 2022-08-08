using System;
using System.ComponentModel;
using Demo_MVVM.Customize;
using Demo_MVVM.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomRoundButton))]
namespace Demo_MVVM.iOS
{
    public class CustomRoundButton : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);
            var view = (CustomButton)Element;
            if (view == null) return;
            Paint(view);
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            if (e.PropertyName == CustomButton.CustomBorderRadiusProperty.PropertyName ||
               e.PropertyName == CustomButton.CustomBorderColorProperty.PropertyName ||
               e.PropertyName == CustomButton.CustomBorderWidthProperty.PropertyName)
            {
                if (Element != null)
                {
                    Paint((CustomButton)Element);
                }
            }
        }
        private void Paint(CustomButton view)
        {
            this.Layer.CornerRadius = (float)view.CustomBorderRadius;
            this.Layer.BorderColor = view.CustomBorderColor.ToCGColor();
            this.Layer.BackgroundColor = view.CustomBackgroundColor.ToCGColor();
            this.Layer.BorderWidth = (int)view.CustomBorderWidth;
        }
    }
}

