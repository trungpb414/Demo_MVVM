using System;
using System.ComponentModel;
using Android.Graphics.Drawables;
using Android.Util;
using Demo_MVVM.Customize;
using Demo_MVVM.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomRoundButton))]
namespace Demo_MVVM.Droid
{
    [Obsolete]
    public class CustomRoundButton : ButtonRenderer
    {
        private GradientDrawable _gradientBackground;
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
            if (e.PropertyName == CustomButton.CustomBorderColorProperty.PropertyName ||
                 e.PropertyName == CustomButton.CustomBorderRadiusProperty.PropertyName ||
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
            _gradientBackground = new GradientDrawable();
            _gradientBackground.SetShape(ShapeType.Rectangle);
            _gradientBackground.SetColor(view.CustomBackgroundColor.ToAndroid());
            _gradientBackground.SetStroke((int)view.CustomBorderWidth, view.CustomBorderColor.ToAndroid());
            _gradientBackground.SetCornerRadius(
                DpToPixels(Context, Convert.ToSingle(view.CustomBorderRadius)));
            Control.SetBackground(_gradientBackground);
        }

        private float DpToPixels(Android.Content.Context context, float v)
        {
            DisplayMetrics metrics = context.Resources.DisplayMetrics;
            return TypedValue.ApplyDimension(ComplexUnitType.Dip, v, metrics);
        }
    }
}

