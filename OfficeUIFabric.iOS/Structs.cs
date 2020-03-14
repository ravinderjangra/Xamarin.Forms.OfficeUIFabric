using System;
using System.Runtime.InteropServices;
using CoreGraphics;
using ObjCRuntime;

namespace FabricComponents
{
    [Native]
    public enum MSActionsCellActionType : long
    {
        Regular = 0,
        Destructive = 1,
        Communication = 2
    }

    [Native]
    public enum MSActivityIndicatorViewSize : long
    {
        XSmall = 0,
        Small = 1,
        Medium = 2,
        Large = 3,
        XLarge = 4
    }

    [Native]
    public enum MSAvatarSize : long
    {
        ExtraSmall = 0,
        Small = 1,
        Medium = 2,
        Large = 3,
        ExtraLarge = 4,
        ExtraExtraLarge = 5
    }

    [Native]
    public enum MSAvatarStyle : long
    {
        Circle = 0,
        Square = 1
    }

    [Native]
    public enum MSBadgeViewStyle : long
    {
        Default = 0,
        Warning = 1,
        Error = 2
    }

    [Native]
    public enum MSBadgeViewSize : long
    {
        Small = 0,
        Medium = 1
    }

    [Native]
    public enum MSTableViewCellCustomViewSize : long
    {
        Default = 0,
        Zero = 1,
        Small = 2,
        Medium = 3
    }

    [Native]
    public enum MSTableViewCellSeparatorType : long
    {
        None = 0,
        Inset = 1,
        Full = 2
    }

    [Native]
    public enum MSButtonStyle : long
    {
        PrimaryFilled = 0,
        PrimaryOutline = 1,
        SecondaryOutline = 2,
        Borderless = 3
    }

    [Native]
    public enum MSDateStringCompactness : long
    {
        LongDaynameDayMonth = 1,
        LongDaynameDayMonthYear = 2,
        ShortDayname = 3,
        ShortDaynameShortMonthnameDay = 4,
        ShortDaynameShortMonthnameDayFullYear = 5,
        PartialDaynameShortDayMonth = 6,
        LongDaynameDayMonthHoursColumnsMinutes = 7,
        ShortDaynameShortMonthnameHoursColumnsMinutes = 8,
        PartialDaynameShortDayMonthHoursColumsMinutes = 9,
        PartialMonthnameDaynameFullYear = 10,
        PartialMonthnameDaynameHoursColumnsMinutes = 11,
        PartialMonthnameDayname = 12,
        LongMonthNameFullYear = 13,
        ShortDaynameHoursColumnMinutes = 14,
        ShortDayMonth = 15,
        LongDayMonthYearTime = 16,
        ShortDaynameDayShortMonthYear = 17
    }

    [Native]
    public enum MSDateTimePickerDatePickerType : long
    {
        alendar = 0,
        omponents = 1
    }

    [Native]
    public enum MSDateTimePickerDateRangePresentation : long
    {
        Paged = 0,
        Tabbed = 1
    }

    [Native]
    public enum MSDateTimePickerMode : long
    {
        MSDateTimePickerModeDate = 0,
        Time = 1,
        Range = 2,
        TimeRange = 3
    }

    [Native]
    public enum MSDimmingViewType : long
    {
        White = 1,
        Black = 2,
        None = 3
    }

    [Native]
    public enum MSDrawerPresentationBackground : long
    {
        None = 0,
        Black = 1
    }

    [Native]
    public enum MSDrawerPresentationDirection : long
    {
        Down = 0,
        Up = 1,
        FromLeading = 2,
        FromTrailing = 3
    }

    [Native]
    public enum MSDrawerPresentationStyle : long
    {
        Automatic = -1,
        Slideover = 0,
        Popover = 1
    }

    [Native]
    public enum MSDrawerResizingBehavior : long
    {
        None = 0,
        Dismiss = 1,
        DismissOrExpand = 2
    }

    [Native]
    public enum MSNavigationBarStyle : long
    {
        Default = 0,
        Primary = 1,
        System = 2,
        Custom = 3
    }

    [Native]
    public enum MSNavigationBarElementSize : long
    {
        Automatic = 0,
        Contracted = 1,
        Expanded = 2
    }

    [Native]
    public enum MSNavigationBarShadow : long
    {
        utomatic = 0,
        lwaysHidden = 1
    }

    [Native]
    public enum MSNotificationViewStyle : long
    {
        PrimaryToast = 0,
        NeutralToast = 1,
        PrimaryBar = 2,
        PrimaryOutlineBar = 3,
        NeutralBar = 4
    }

    [Native]
    public enum MSPersonaListViewSelectionDirection : long
    {
        Next = 1,
        Prev = -1
    }

    [Native]
    public enum MSPopupMenuItemExecutionMode : long
    {
        OnSelection = 0,
        AfterPopupMenuDismissal = 1,
        AfterPopupMenuDismissalCompleted = 2
    }

    [Native]
    public enum MSSearchBarStyle : long
    {
        LightContent = 0,
        DarkContent = 1
    }

    [Native]
    public enum MSSeparatorOrientation : long
    {
        Horizontal = 0,
        Vertical = 1
    }

    [Native]
    public enum MSSeparatorStyle : long
    {
        Default = 0,
        Shadow = 1
    }

    [Native]
    public enum MSTableViewCellAccessoryType : long
    {
        None = 0,
        DisclosureIndicator = 1,
        DetailButton = 2,
        Checkmark = 3
    }

    [Native]
    public enum MSTableViewHeaderFooterViewAccessoryButtonStyle : long
    {
        Regular = 0,
        Primary = 1
    }

    [Native]
    public enum MSTableViewHeaderFooterViewStyle : long
    {
        Header = 0,
        Divider = 1,
        DividerHighlighted = 2,
        Footer = 3
    }

    [Native]
    public enum MSTextColorStyle : long
    {
        Regular = 0,
        Secondary = 1,
        White = 2,
        Primary = 3,
        Error = 4,
        Warning = 5,
        Disabled = 6
    }

    [Native]
    public enum MSTextStyle : long
    {
        LargeTitle = 0,
        Title1 = 1,
        Title2 = 2,
        Headline = 3,
        HeadlineUnscaled = 4,
        Body = 5,
        BodyUnscaled = 6,
        Subhead = 7,
        Footnote = 8,
        FootnoteUnscaled = 9,
        Button1 = 10,
        Button2 = 11,
        Button3 = 12,
        Caption1 = 13,
        Caption2 = 14
    }

    [Native]
    public enum MSTimeStringCompactness : long
    {
        ColumnsMinutes = 1,
        MSTimeStringCompactnessHours = 2
    }

    [Native]
    public enum MSTooltipArrowDirection : long
    {
        Up = 0,
        Down = 1,
        Left = 2,
        Right = 3
    }

    [Native]
    public enum MSTooltipDismissMode : long
    {
        Anywhere = 0,
        OnTooltip = 1,
        OnTooltipOrAnchor = 2
    }

    [Native]
    public enum MSTwoLineTitleViewStyle : long
    {
        Light = 0,
        Dark = 1
    }

    [Native]
    public enum MSTwoLineTitleViewInteractivePart : long
    {
        None = 0,
        Title = 1,
        Subtitle = 2
    }

    [Native]
    public enum MSTwoLineTitleViewAccessoryType : long
    {
        None = 0,
        Disclosure = 1,
        DownArrow = 2
    }

    [Native]
    public enum ObscureStyle : long
    {
        Blur = 0,
        Dim = 1
    }
}