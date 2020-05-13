using System.ComponentModel;
using FabricComponents;
using UIKit;
using Visual.Fabric.Forms;
using Visual.Fabric.iOS.Renderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Label), typeof(FabicLabelRenderer), new[] { typeof(FabricVisual) })]

namespace Visual.Fabric.iOS.Renderers
{
    public class FabicLabelRenderer : LabelRenderer
    {
        protected override UILabel CreateNativeControl()
        {
            return new MSLabel(MSTextStyle.Body, MSTextColorStyle.Regular);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                UpdateLabelColorStyle();
                UpdateLabelTextStyle();
                UpdateLabelWeightStyle();
            }
        }

        // Todo: Implement this
        private void UpdateLabelWeightStyle()
        {
            if (Control != null)
            {
                var style = FabricLabel.GetLabelWeightStyle(Element);
                switch (style)
                {
                    case FabricLabelWeightStyle.Bold:
                        break;
                    case FabricLabelWeightStyle.Semibold:
                        break;
                    case FabricLabelWeightStyle.Medium:
                        break;
                    case FabricLabelWeightStyle.Regular:
                        break;
                }
            }
        }

        private void UpdateLabelTextStyle()
        {
            if (Control != null)
            {
                var style = FabricLabel.GetLabelTextStyle(Element);
                var newStyle = MSTextStyle.Body;
                switch (style)
                {
                    case FabricLabelTextStyle.LargeTitle:
                        newStyle = MSTextStyle.LargeTitle;
                        break;
                    case FabricLabelTextStyle.Title1:
                        newStyle = MSTextStyle.Title1;
                        break;
                    case FabricLabelTextStyle.Title2:
                        newStyle = MSTextStyle.Title2;
                        break;
                    case FabricLabelTextStyle.Headline:
                        newStyle = MSTextStyle.Headline;
                        break;
                    case FabricLabelTextStyle.HeadlineUnscaled:
                        newStyle = MSTextStyle.HeadlineUnscaled;
                        break;
                    case FabricLabelTextStyle.Body:
                        newStyle = MSTextStyle.Body;
                        break;
                    case FabricLabelTextStyle.BodyUnscaled:
                        newStyle = MSTextStyle.BodyUnscaled;
                        break;
                    case FabricLabelTextStyle.Subhead:
                        newStyle = MSTextStyle.Subhead;
                        break;
                    case FabricLabelTextStyle.Footnote:
                        newStyle = MSTextStyle.Footnote;
                        break;
                    case FabricLabelTextStyle.FootnodeUnscaled:
                        newStyle = MSTextStyle.FootnoteUnscaled;
                        break;
                    case FabricLabelTextStyle.Button1:
                        newStyle = MSTextStyle.Button1;
                        break;
                    case FabricLabelTextStyle.Button2:
                        newStyle = MSTextStyle.Button2;
                        break;
                    case FabricLabelTextStyle.Button3:
                        newStyle = MSTextStyle.Button3;
                        break;
                    case FabricLabelTextStyle.Caption1:
                        newStyle = MSTextStyle.Caption1;
                        break;
                    case FabricLabelTextStyle.Caption2:
                        newStyle = MSTextStyle.Caption2;
                        break;
                }
                ((MSLabel)Control).Style = newStyle;
            }
        }

        private void UpdateLabelColorStyle()
        {
            if (Control != null)
            {
                var style = FabricLabel.GetLabelColorStyle(Element);
                var newStyle = MSTextColorStyle.Regular;
                switch (style)
                {
                    case FabricLabelColorStyle.Regular:
                        newStyle = MSTextColorStyle.Regular;
                        break;
                    case FabricLabelColorStyle.Secondary:
                        newStyle = MSTextColorStyle.Secondary;
                        break;
                    case FabricLabelColorStyle.White:
                        newStyle = MSTextColorStyle.White;
                        break;
                    case FabricLabelColorStyle.Primary:
                        newStyle = MSTextColorStyle.Primary;
                        break;
                    case FabricLabelColorStyle.Error:
                        newStyle = MSTextColorStyle.Error;
                        break;
                    case FabricLabelColorStyle.Warning:
                        newStyle = MSTextColorStyle.Warning;
                        break;
                    case FabricLabelColorStyle.Disabled:
                        newStyle = MSTextColorStyle.Disabled;
                        break;
                }
                ((MSLabel)Control).ColorStyle = newStyle;
            }
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);

            if (e.PropertyName == FabricLabel.LabelColorStyleProperty.PropertyName)
                UpdateLabelColorStyle();
            else if (e.PropertyName == FabricLabel.LabelWeightStyleProperty.PropertyName)
                UpdateLabelWeightStyle();
            else if (e.PropertyName == FabricLabel.LabelTextStyleProperty.PropertyName)
                UpdateLabelTextStyle();
        }
    }
}
