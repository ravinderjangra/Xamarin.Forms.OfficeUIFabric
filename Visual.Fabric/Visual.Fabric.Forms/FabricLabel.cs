using Xamarin.Forms;

namespace Visual.Fabric.Forms
{
    public static class FabricLabel
    {
        public static readonly BindableProperty LabelTextStyleProperty =
            BindableProperty.CreateAttached(
                "LabelTextStyle",
                typeof(FabricLabelTextStyle),
                typeof(Label),
                FabricLabelTextStyle.Body);

        public static readonly BindableProperty LabelColorStyleProperty =
            BindableProperty.CreateAttached(
                "LabelColorStyle",
                typeof(FabricLabelColorStyle),
                typeof(Label),
                FabricLabelColorStyle.Regular);

        public static readonly BindableProperty LabelWeightStyleProperty =
            BindableProperty.CreateAttached(
                "LabelWeightStyle",
                typeof(FabricLabelWeightStyle),
                typeof(Label),
                FabricLabelWeightStyle.Regular);

        public static FabricLabelTextStyle GetLabelTextStyle(BindableObject view)
        {
            return (FabricLabelTextStyle)view.GetValue(LabelTextStyleProperty);
        }

        public static void SetLabelTextStyle(BindableObject view, FabricLabelTextStyle value)
        {
            view.SetValue(LabelTextStyleProperty, value);
        }

        public static FabricLabelColorStyle GetLabelColorStyle(BindableObject view)
        {
            return (FabricLabelColorStyle)view.GetValue(LabelColorStyleProperty);
        }

        public static void SetLabelColorStyle(BindableObject view, FabricLabelColorStyle value)
        {
            view.SetValue(LabelColorStyleProperty, value);
        }

        public static FabricLabelWeightStyle GetLabelWeightStyle(BindableObject view)
        {
            return (FabricLabelWeightStyle)view.GetValue(LabelWeightStyleProperty);
        }

        public static void SetLabelWeightStyle(BindableObject view, FabricLabelWeightStyle value)
        {
            view.SetValue(LabelWeightStyleProperty, value);
        }
    }
}
