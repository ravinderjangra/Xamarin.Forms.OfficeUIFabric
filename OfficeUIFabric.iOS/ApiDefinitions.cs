using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using NSTextAlignment = UIKit.UITextAlignment;
using NSLineBreakMode = UIKit.UILineBreakMode;

namespace FabricComponents
{
    [Static]
    partial interface Constants
    {
        // extern double OfficeUIFabricVersionNumber;
        [Field("OfficeUIFabricVersionNumber", "__Internal")]
        double OfficeUIFabricVersionNumber { get; }

        // extern const unsigned char [] OfficeUIFabricVersionString;
        [Field("OfficeUIFabricVersionString", "__Internal")]
        NSString OfficeUIFabricVersionString { get; }
    }

    // @protocol AccessibleViewDelegate
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AccessibleViewDelegate
    {
        // @optional -(NSString * _Nullable)accessibilityValueForAccessibleView:(UIView * _Nonnull)accessibleView __attribute__((warn_unused_result));
        [Export("accessibilityValueForAccessibleView:")]
        [
            return: NullAllowed
        ]
        string AccessibilityValueForAccessibleView(UIView accessibleView);

        // @optional -(NSString * _Nullable)accessibilityLabelForAccessibleView:(UIView * _Nonnull)accessibleView __attribute__((warn_unused_result));
        [Export("accessibilityLabelForAccessibleView:")]
        [
            return: NullAllowed
        ]
        string AccessibilityLabelForAccessibleView(UIView accessibleView);

        // @optional -(BOOL)accessibilityActivateForAccessibleView:(UIView * _Nonnull)accessibleView __attribute__((warn_unused_result));
        [Export("accessibilityActivateForAccessibleView:")]
        bool AccessibilityActivateForAccessibleView(UIView accessibleView);

        // @optional -(void)accessibilityIncrementForAccessibleView:(UIView * _Nonnull)accessibleView;
        [Export("accessibilityIncrementForAccessibleView:")]
        void AccessibilityIncrementForAccessibleView(UIView accessibleView);

        // @optional -(void)accessibilityDecrementForAccessibleView:(UIView * _Nonnull)accessibleView;
        [Export("accessibilityDecrementForAccessibleView:")]
        void AccessibilityDecrementForAccessibleView(UIView accessibleView);

        // @optional -(BOOL)accessibilityPerformMagicTapForAccessibleView:(UIView * _Nonnull)accessibleView __attribute__((warn_unused_result));
        [Export("accessibilityPerformMagicTapForAccessibleView:")]
        bool AccessibilityPerformMagicTapForAccessibleView(UIView accessibleView);

        // @optional -(NSArray * _Nullable)accessibilityElementsForAccessibleView:(UIView * _Nonnull)accessibleView __attribute__((warn_unused_result));
        [Export("accessibilityElementsForAccessibleView:")]
        NSObject[] AccessibilityElementsForAccessibleView(UIView accessibleView);
    }

    interface IAccessibleViewDelegate { }

    // @protocol AccessibleTableViewDelegate <AccessibleViewDelegate>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface AccessibleTableViewDelegate
    {
        // @optional -(NSString * _Nullable)accessibilityValueForRowAtIndexPath:(NSIndexPath * _Nonnull)indexPath forTableView:(UITableView * _Nonnull)forTableView __attribute__((warn_unused_result));
        [Export("accessibilityValueForRowAtIndexPath:forTableView:")]
        [
            return: NullAllowed
        ]
        string ForTableView(NSIndexPath indexPath, UITableView forTableView);
    }

    // @interface MSActionsCell : UITableViewCell
    [BaseType(typeof(UITableViewCell))]
    [Protocol]
    interface MSActionsCell
    {
        // +(CGFloat)heightWithAction1Title:(NSString * _Nonnull)action1Title action2Title:(NSString * _Nonnull)action2Title containerWidth:(CGFloat)containerWidth __attribute__((warn_unused_result));
        [Static]
        [Export("heightWithAction1Title:action2Title:containerWidth:")]
        nfloat HeightWithAction1Title(string action1Title, string action2Title, nfloat containerWidth);

        // +(CGFloat)preferredWidthWithAction1Title:(NSString * _Nonnull)action1Title action2Title:(NSString * _Nonnull)action2Title __attribute__((warn_unused_result));
        [Static]
        [Export("preferredWidthWithAction1Title:action2Title:")]
        nfloat PreferredWidthWithAction1Title(string action1Title, string action2Title);

        // @property (nonatomic) enum MSTableViewCellSeparatorType topSeparatorType;
        [Export("topSeparatorType", ArgumentSemantic.Assign)]
        MSTableViewCellSeparatorType TopSeparatorType { get; set; }

        // @property (nonatomic) enum MSTableViewCellSeparatorType bottomSeparatorType;
        [Export("bottomSeparatorType", ArgumentSemantic.Assign)]
        MSTableViewCellSeparatorType BottomSeparatorType { get; set; }

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }

        // @property (readonly, nonatomic, strong) UIButton * _Nonnull action1Button;
        [Export("action1Button", ArgumentSemantic.Strong)]
        UIButton Action1Button { get; }

        // @property (readonly, nonatomic, strong) UIButton * _Nonnull action2Button;
        [Export("action2Button", ArgumentSemantic.Strong)]
        UIButton Action2Button { get; }

        // -(instancetype _Nonnull)initWithStyle:(UITableViewCellStyle)style reuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
        [Export("initWithStyle:reuseIdentifier:")]
        [DesignatedInitializer]
        IntPtr Constructor(UITableViewCellStyle style, [NullAllowed] string reuseIdentifier);

        // -(void)setupWithAction1Title:(NSString * _Nonnull)action1Title action2Title:(NSString * _Nonnull)action2Title action1Type:(enum MSActionsCellActionType)action1Type action2Type:(enum MSActionsCellActionType)action2Type;
        [Export("setupWithAction1Title:action2Title:action1Type:action2Type:")]
        void SetupWithAction1Title(string action1Title, string action2Title, MSActionsCellActionType action1Type, MSActionsCellActionType action2Type);

        // -(void)setupWithAction1Title:(NSString * _Nonnull)action1Title action1Type:(enum MSActionsCellActionType)action1Type;
        [Export("setupWithAction1Title:action1Type:")]
        void SetupWithAction1Title(string action1Title, MSActionsCellActionType action1Type);

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
        [Export("sizeThatFits:")]
        CGSize SizeThatFits(CGSize size);

        // -(void)prepareForReuse __attribute__((objc_requires_super));
        [Export("prepareForReuse")]
        [RequiresSuper]
        void PrepareForReuse();

        // -(void)setHighlighted:(BOOL)highlighted animated:(BOOL)animated;
        [Export("setHighlighted:animated:")]
        void SetHighlighted(bool highlighted, bool animated);

        // -(void)setSelected:(BOOL)selected animated:(BOOL)animated;
        [Export("setSelected:animated:")]
        void SetSelected(bool selected, bool animated);
    }

    // @interface MSActivityIndicatorCell : UITableViewCell
    [BaseType(typeof(UITableViewCell))]
    [Protocol]
    interface MSActivityIndicatorCell
    {
        // -(instancetype _Nonnull)initWithStyle:(UITableViewCellStyle)style reuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
        [Export("initWithStyle:reuseIdentifier:")]
        [DesignatedInitializer]
        IntPtr Constructor(UITableViewCellStyle style, [NullAllowed] string reuseIdentifier);

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(void)prepareForReuse __attribute__((objc_requires_super));
        [Export("prepareForReuse")]
        [RequiresSuper]
        void PrepareForReuse();

        // -(void)setHighlighted:(BOOL)highlighted animated:(BOOL)animated;
        [Export("setHighlighted:animated:")]
        void SetHighlighted(bool highlighted, bool animated);

        // -(void)setSelected:(BOOL)selected animated:(BOOL)animated;
        [Export("setSelected:animated:")]
        void SetSelected(bool selected, bool animated);
    }

    // @interface MSActivityIndicatorView : UIView
    [BaseType(typeof(UIView))]
    [Protocol]
    interface MSActivityIndicatorView
    {
        // +(CGSize)sizeThatFitsWithSize:(enum MSActivityIndicatorViewSize)size __attribute__((warn_unused_result));
        [Static]
        [Export("sizeThatFitsWithSize:")]
        CGSize SizeThatFitsWithSize(MSActivityIndicatorViewSize size);

        // @property (nonatomic) enum MSActivityIndicatorViewSize size;
        [Export("size", ArgumentSemantic.Assign)]
        MSActivityIndicatorViewSize Size { get; set; }

        // @property (nonatomic) BOOL hidesWhenStopped;
        [Export("hidesWhenStopped")]
        bool HidesWhenStopped { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull color;
        [Export("color", ArgumentSemantic.Strong)]
        UIColor Color { get; set; }

        // @property (readonly, nonatomic) BOOL isAnimating;
        [Export("isAnimating")]
        bool IsAnimating { get; }

        // -(instancetype _Nonnull)initWithSize:(enum MSActivityIndicatorViewSize)size;
        [Export("initWithSize:")]
        IntPtr Constructor(MSActivityIndicatorViewSize size);

        // -(instancetype _Nonnull)initWithSideSize:(CGFloat)sideSize strokeThickness:(CGFloat)strokeThickness __attribute__((objc_designated_initializer));
        [Export("initWithSideSize:strokeThickness:")]
        [DesignatedInitializer]
        IntPtr Constructor(nfloat sideSize, nfloat strokeThickness);

        // -(void)startAnimating;
        [Export("startAnimating")]
        void StartAnimating();

        // -(void)stopAnimating;
        [Export("stopAnimating")]
        void StopAnimating();

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }

        // -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
        [Export("sizeThatFits:")]
        CGSize SizeThatFits(CGSize size);

        // -(void)sizeToFit;
        [Export("sizeToFit")]
        void SizeToFit();
    }

    // @interface MSAnimationSynchronizer : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    [DisableDefaultCtor]
    interface MSAnimationSynchronizer
    {
        // -(instancetype _Nonnull)initWithReferenceLayer:(CALayer * _Nullable)referenceLayer __attribute__((objc_designated_initializer));
        [Export("initWithReferenceLayer:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] CALayer referenceLayer);

        // @property (nonatomic, weak) CALayer * _Nullable referenceLayer;
        [NullAllowed, Export("referenceLayer", ArgumentSemantic.Weak)]
        CALayer ReferenceLayer { get; set; }

        // -(CFTimeInterval)timeOffsetFor:(CALayer * _Nonnull)layer __attribute__((warn_unused_result));
        [Export("timeOffsetFor:")]
        double TimeOffsetFor(CALayer layer);
    }

    // @protocol MSAvatar
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MSAvatar
    {
        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull primaryText;
        [Abstract]
        [Export("primaryText")]
        string PrimaryText { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull secondaryText;
        [Abstract]
        [Export("secondaryText")]
        string SecondaryText { get; }

        // @required @property (readonly, nonatomic, strong) UIImage * _Nullable image;
        [Abstract]
        [NullAllowed, Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; }
    }

    // @interface MSAvatarData : NSObject <MSAvatar>
    [BaseType(typeof(NSObject))]
    [Protocol]
    [DisableDefaultCtor]
    interface MSAvatarData : MSAvatar
    {
        // @property (copy, nonatomic) NSString * _Nonnull primaryText;
        [Export("primaryText")]
        string PrimaryText { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull secondaryText;
        [Export("secondaryText")]
        string SecondaryText { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable image;
        [NullAllowed, Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }

        // -(instancetype _Nonnull)initWithPrimaryText:(NSString * _Nonnull)primaryText secondaryText:(NSString * _Nonnull)secondaryText image:(UIImage * _Nullable)image __attribute__((objc_designated_initializer));
        [Export("initWithPrimaryText:secondaryText:image:")]
        [DesignatedInitializer]
        IntPtr Constructor(string primaryText, string secondaryText, [NullAllowed] UIImage image);
    }

    // @interface MSAvatarView : UIView
    [BaseType(typeof(UIView))]
    [Protocol]
    interface MSAvatarView
    {
        // @property (nonatomic) enum MSAvatarSize avatarSize;
        [Export("avatarSize", ArgumentSemantic.Assign)]
        MSAvatarSize AvatarSize { get; set; }

        // @property (nonatomic, strong) UIColor * _Nonnull avatarBackgroundColor;
        [Export("avatarBackgroundColor", ArgumentSemantic.Strong)]
        UIColor AvatarBackgroundColor { get; set; }

        // @property (nonatomic) enum MSAvatarStyle style;
        [Export("style", ArgumentSemantic.Assign)]
        MSAvatarStyle Style { get; set; }

        // -(instancetype _Nonnull)initWithAvatarSize:(enum MSAvatarSize)avatarSize withBorder:(BOOL)hasBorder style:(enum MSAvatarStyle)style __attribute__((objc_designated_initializer));
        [Export("initWithAvatarSize:withBorder:style:")]
        [DesignatedInitializer]
        IntPtr Constructor(MSAvatarSize avatarSize, bool hasBorder, MSAvatarStyle style);

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }

        // -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
        [Export("sizeThatFits:")]
        CGSize SizeThatFits(CGSize size);

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(void)setupWithPrimaryText:(NSString * _Nullable)primaryText secondaryText:(NSString * _Nullable)secondaryText image:(UIImage * _Nullable)image;
        [Export("setupWithPrimaryText:secondaryText:image:")]
        void SetupWithPrimaryText([NullAllowed] string primaryText, [NullAllowed] string secondaryText, [NullAllowed] UIImage image);

        // -(void)setupWithImage:(UIImage * _Nonnull)image;
        [Export("setupWithImage:")]
        void SetupWithImage(UIImage image);

        // -(void)setupWithAvatar:(id<MSAvatar> _Nullable)avatar;
        [Export("setupWithAvatar:")]
        void SetupWithAvatar([NullAllowed] MSAvatar avatar);

        // @property (nonatomic) BOOL isAccessibilityElement;
        [Export("isAccessibilityElement")]
        bool IsAccessibilityElement { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityLabel;
        [NullAllowed, Export("accessibilityLabel")]
        string AccessibilityLabel { get; set; }

        // @property (nonatomic) UIAccessibilityTraits accessibilityTraits;
        [Export("accessibilityTraits")]
        ulong AccessibilityTraits { get; set; }
    }

    // @interface MSBadgeField : UIView
    [BaseType(typeof(UIView))]
    [Protocol]
    interface MSBadgeField
    {
        // @property (copy, nonatomic) NSString * _Nonnull label;
        [Export("label")]
        string Label { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull placeholder;
        [Export("placeholder")]
        string Placeholder { get; set; }

        // @property (nonatomic) NSInteger numberOfLines;
        [Export("numberOfLines")]
        nint NumberOfLines { get; set; }

        // @property (nonatomic) BOOL isEditable;
        [Export("isEditable")]
        bool IsEditable { get; set; }

        // @property (nonatomic) BOOL isActive;
        [Export("isActive")]
        bool IsActive { get; set; }

        // @property (nonatomic) BOOL allowsDragAndDrop;
        [Export("allowsDragAndDrop")]
        bool AllowsDragAndDrop { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull softBadgingCharacters;
        [Export("softBadgingCharacters")]
        string SoftBadgingCharacters { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull hardBadgingCharacters;
        [Export("hardBadgingCharacters")]
        string HardBadgingCharacters { get; set; }

        // @property (readonly, copy, nonatomic) NSArray<MSBadgeView *> * _Nonnull badges;
        [Export("badges", ArgumentSemantic.Copy)]
        MSBadgeView[] Badges { get; }

        // @property (readonly, copy, nonatomic) NSArray<MSBadgeViewDataSource *> * _Nonnull badgeDataSources;
        [Export("badgeDataSources", ArgumentSemantic.Copy)]
        MSBadgeViewDataSource[] BadgeDataSources { get; }

        [Wrap("WeakBadgeFieldDelegate")]
        [NullAllowed]
        MSBadgeFieldDelegate BadgeFieldDelegate { get; set; }

        // @property (nonatomic, weak) id<MSBadgeFieldDelegate> _Nullable badgeFieldDelegate;
        [NullAllowed, Export("badgeFieldDelegate", ArgumentSemantic.Weak)]
        NSObject WeakBadgeFieldDelegate { get; set; }

        // -(void)setupWithDataSources:(NSArray<MSBadgeViewDataSource *> * _Nonnull)dataSources;
        [Export("setupWithDataSources:")]
        void SetupWithDataSources(MSBadgeViewDataSource[] dataSources);

        // -(void)reload;
        [Export("reload")]
        void Reload();

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
        [Export("sizeThatFits:")]
        CGSize SizeThatFits(CGSize size);

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }

        // -(CGFloat)heightThatFitsWithNumberOfLines:(NSInteger)numberOfLines __attribute__((warn_unused_result));
        [Export("heightThatFitsWithNumberOfLines:")]
        nfloat HeightThatFitsWithNumberOfLines(nint numberOfLines);

        // -(void)badgeText;
        [Export("badgeText")]
        void BadgeText();

        // -(void)addBadgesWithDataSources:(NSArray<MSBadgeViewDataSource *> * _Nonnull)dataSources;
        [Export("addBadgesWithDataSources:")]
        void AddBadgesWithDataSources(MSBadgeViewDataSource[] dataSources);

        // -(void)addBadgeWithDataSource:(MSBadgeViewDataSource * _Nonnull)dataSource fromUserAction:(BOOL)fromUserAction updateConstrainedBadges:(BOOL)updateConstrainedBadges;
        [Export("addBadgeWithDataSource:fromUserAction:updateConstrainedBadges:")]
        void AddBadgeWithDataSource(MSBadgeViewDataSource dataSource, bool fromUserAction, bool updateConstrainedBadges);

        // -(void)deleteBadgesWithDataSource:(MSBadgeViewDataSource * _Nonnull)dataSource;
        [Export("deleteBadgesWithDataSource:")]
        void DeleteBadgesWithDataSource(MSBadgeViewDataSource dataSource);

        // -(void)deleteAllBadges;
        [Export("deleteAllBadges")]
        void DeleteAllBadges();

        // -(void)selectBadge:(MSBadgeView * _Nonnull)badge;
        [Export("selectBadge:")]
        void SelectBadge(MSBadgeView badge);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull textFieldContent;
        [Export("textFieldContent")]
        string TextFieldContent { get; }

        // -(void)resetTextFieldContent;
        [Export("resetTextFieldContent")]
        void ResetTextFieldContent();

        // -(BOOL)becomeFirstResponder;
        [Export("becomeFirstResponder")]
        bool BecomeFirstResponder { get; }

        // @property (readonly, nonatomic) BOOL isFirstResponder;
        [Export("isFirstResponder")]
        bool IsFirstResponder { get; }

        // -(BOOL)resignFirstResponder;
        [Export("resignFirstResponder")]
        bool ResignFirstResponder { get; }

        // Todo
        // -(void)observeValueForKeyPath:(NSString * _Nullable)keyPath ofObject:(id _Nullable)object change:(NSDictionary<NSKeyValueChangeKey,id> * _Nullable)change context:(void * _Nullable)context;
        //[Export("observeValueForKeyPath:ofObject:change:context:")]
        //unsafe void ObserveValueForKeyPath([NullAllowed] string keyPath, [NullAllowed] NSObject @object, [NullAllowed] NSDictionary<NSString, NSObject> change, [NullAllowed] void* context);

        // -(NSInteger)accessibilityElementCount __attribute__((warn_unused_result));
        [Export("accessibilityElementCount")]
        nint AccessibilityElementCount { get; }

        // -(id _Nullable)accessibilityElementAtIndex:(NSInteger)index __attribute__((warn_unused_result));
        [Export("accessibilityElementAtIndex:")]
        [
            return: NullAllowed
        ]
        NSObject AccessibilityElementAtIndex(nint index);

        // -(NSInteger)indexOfAccessibilityElement:(id _Nonnull)element __attribute__((warn_unused_result));
        [Export("indexOfAccessibilityElement:")]
        nint IndexOfAccessibilityElement(NSObject element);

        // -(void)voiceOverFocusOnTextFieldAndAnnounce:(NSString * _Nullable)announcement;
        [Export("voiceOverFocusOnTextFieldAndAnnounce:")]
        void VoiceOverFocusOnTextFieldAndAnnounce([NullAllowed] string announcement);
    }

    // @protocol MSBadgeViewDelegate
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MSBadgeViewDelegate
    {
        // @required -(void)didSelectBadge:(MSBadgeView * _Nonnull)badge;
        [Abstract]
        [Export("didSelectBadge:")]
        void DidSelectBadge(MSBadgeView badge);

        // @required -(void)didTapSelectedBadge:(MSBadgeView * _Nonnull)badge;
        [Abstract]
        [Export("didTapSelectedBadge:")]
        void DidTapSelectedBadge(MSBadgeView badge);
    }

    interface IMSBadgeViewDelegate { }

    // @protocol MSBadgeFieldDelegate
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MSBadgeFieldDelegate
    {
        // @optional -(MSBadgeViewDataSource * _Nonnull)badgeField:(MSBadgeField * _Nonnull)badgeField badgeDataSourceForText:(NSString * _Nonnull)text __attribute__((warn_unused_result));
        [Export("badgeField:badgeDataSourceForText:")]
        MSBadgeViewDataSource BadgeField(MSBadgeField badgeField, string text);

        // @optional -(void)badgeField:(MSBadgeField * _Nonnull)badgeField willChangeTextFieldContentWithText:(NSString * _Nonnull)newText;
        [Export("badgeField:willChangeTextFieldContentWithText:")]
        void WillChangeTextFieldContentWithText(MSBadgeField badgeField, string newText);

        // @optional -(void)badgeFieldDidChangeTextFieldContent:(MSBadgeField * _Nonnull)badgeField isPaste:(BOOL)isPaste;
        [Export("badgeFieldDidChangeTextFieldContent:isPaste:")]
        void BadgeFieldDidChangeTextFieldContent(MSBadgeField badgeField, bool isPaste);

        // @optional -(BOOL)badgeField:(MSBadgeField * _Nonnull)badgeField shouldBadgeText:(NSString * _Nonnull)text forSoftBadgingString:(NSString * _Nonnull)badgingString __attribute__((warn_unused_result));
        [Export("badgeField:shouldBadgeText:forSoftBadgingString:")]
        bool BadgeField(MSBadgeField badgeField, string text, string badgingString);

        // @optional -(void)badgeField:(MSBadgeField * _Nonnull)badgeField didAddBadge:(MSBadgeView * _Nonnull)badge;
        [Export("badgeField:didAddBadge:")]
        void BadgeField(MSBadgeField badgeField, MSBadgeView badge);

        // @optional -(void)badgeField:(MSBadgeField * _Nonnull)badgeField didDeleteBadge:(MSBadgeView * _Nonnull)badge;
        [Export("badgeField:didDeleteBadge:")]
        void DidDeleteBadge(MSBadgeField badgeField, MSBadgeView badge);

        // @optional -(BOOL)badgeField:(MSBadgeField * _Nonnull)badgeField shouldAddBadgeForBadgeDataSource:(MSBadgeViewDataSource * _Nonnull)badgeDataSource __attribute__((warn_unused_result));
        [Export("badgeField:shouldAddBadgeForBadgeDataSource:")]
        bool BadgeField(MSBadgeField badgeField, MSBadgeViewDataSource badgeDataSource);

        // @optional -(MSBadgeView * _Nonnull)badgeField:(MSBadgeField * _Nonnull)badgeField newBadgeForBadgeDataSource:(MSBadgeViewDataSource * _Nonnull)badgeDataSource __attribute__((warn_unused_result));
        [Export("badgeField:newBadgeForBadgeDataSource:")]
        MSBadgeView NewBadgeForBadgeDataSource(MSBadgeField badgeField, MSBadgeViewDataSource badgeDataSource);

        // @optional -(MSBadgeView * _Nonnull)badgeField:(MSBadgeField * _Nonnull)badgeField newMoreBadgeForBadgeDataSources:(NSArray<MSBadgeViewDataSource *> * _Nonnull)badgeDataSources __attribute__((warn_unused_result));
        [Export("badgeField:newMoreBadgeForBadgeDataSources:")]
        MSBadgeView BadgeField(MSBadgeField badgeField, MSBadgeViewDataSource[] badgeDataSources);

        // @optional -(void)badgeFieldContentHeightDidChange:(MSBadgeField * _Nonnull)badgeField;
        [Export("badgeFieldContentHeightDidChange:")]
        void BadgeFieldContentHeightDidChange(MSBadgeField badgeField);

        // @optional -(void)badgeField:(MSBadgeField * _Nonnull)badgeField didTapSelectedBadge:(MSBadgeView * _Nonnull)badge;
        [Export("badgeField:didTapSelectedBadge:")]
        void DidTapSelectedBadge(MSBadgeField badgeField, MSBadgeView badge);

        // @optional -(BOOL)badgeField:(MSBadgeField * _Nonnull)badgeField shouldDragBadge:(MSBadgeView * _Nonnull)badge __attribute__((warn_unused_result));
        [Export("badgeField:shouldDragBadge:")]
        bool ShouldDragBadge(MSBadgeField badgeField, MSBadgeView badge);

        // @optional -(void)badgeField:(MSBadgeField * _Nonnull)originbadgeField didEndDraggingOriginBadge:(MSBadgeView * _Nonnull)originBadge toBadgeField:(MSBadgeField * _Nullable)destinationBadgeField withNewBadge:(MSBadgeView * _Nullable)newBadge;
        [Export("badgeField:didEndDraggingOriginBadge:toBadgeField:withNewBadge:")]
        void BadgeField(MSBadgeField originbadgeField, MSBadgeView originBadge, [NullAllowed] MSBadgeField destinationBadgeField, [NullAllowed] MSBadgeView newBadge);

        // @optional -(BOOL)badgeFieldShouldBeginEditing:(MSBadgeField * _Nonnull)badgeField __attribute__((warn_unused_result));
        [Export("badgeFieldShouldBeginEditing:")]
        bool BadgeFieldShouldBeginEditing(MSBadgeField badgeField);

        // @optional -(void)badgeFieldDidBeginEditing:(MSBadgeField * _Nonnull)badgeField;
        [Export("badgeFieldDidBeginEditing:")]
        void BadgeFieldDidBeginEditing(MSBadgeField badgeField);

        // @optional -(void)badgeFieldDidEndEditing:(MSBadgeField * _Nonnull)badgeField;
        [Export("badgeFieldDidEndEditing:")]
        void BadgeFieldDidEndEditing(MSBadgeField badgeField);

        // @optional -(BOOL)badgeFieldShouldReturn:(MSBadgeField * _Nonnull)badgeField __attribute__((warn_unused_result));
        [Export("badgeFieldShouldReturn:")]
        bool BadgeFieldShouldReturn(MSBadgeField badgeField);
    }

    // @interface MSBadgeView : UIView
    [BaseType(typeof(UIView))]
    [Protocol]
    interface MSBadgeView
    {
        // @property (nonatomic, strong) MSBadgeViewDataSource * _Nullable dataSource;
        [NullAllowed, Export("dataSource", ArgumentSemantic.Strong)]
        MSBadgeViewDataSource DataSource { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MSBadgeViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MSBadgeViewDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (nonatomic) BOOL isActive;
        [Export("isActive")]
        bool IsActive { get; set; }

        // @property (nonatomic) BOOL isSelected;
        [Export("isSelected")]
        bool IsSelected { get; set; }

        // @property (nonatomic) CGFloat minWidth;
        [Export("minWidth")]
        nfloat MinWidth { get; set; }

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
        [Export("sizeThatFits:")]
        CGSize SizeThatFits(CGSize size);

        // @property (copy, nonatomic) NSString * _Nullable accessibilityLabel;
        [NullAllowed, Export("accessibilityLabel")]
        string AccessibilityLabel { get; set; }
    }

    // @interface MSBadgeViewDataSource : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    [DisableDefaultCtor]
    interface MSBadgeViewDataSource
    {
        // @property (copy, nonatomic) NSString * _Nonnull text;
        [Export("text")]
        string Text { get; set; }

        // @property (nonatomic) enum MSBadgeViewStyle style;
        [Export("style", ArgumentSemantic.Assign)]
        MSBadgeViewStyle Style { get; set; }

        // @property (nonatomic) enum MSBadgeViewSize size;
        [Export("size", ArgumentSemantic.Assign)]
        MSBadgeViewSize Size { get; set; }

        // -(instancetype _Nonnull)initWithText:(NSString * _Nonnull)text style:(enum MSBadgeViewStyle)style size:(enum MSBadgeViewSize)size __attribute__((objc_designated_initializer));
        [Export("initWithText:style:size:")]
        [DesignatedInitializer]
        IntPtr Constructor(string text, MSBadgeViewStyle style, MSBadgeViewSize size);
    }

    // @interface MSBarButtonItems : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    [DisableDefaultCtor]
    interface MSBarButtonItems
    {
        // +(UIBarButtonItem * _Nonnull)confirmWithTarget:(id _Nullable)target action:(SEL _Nullable)action __attribute__((warn_unused_result));
        [Static]
        [Export("confirmWithTarget:action:")]
        UIBarButtonItem ConfirmWithTarget([NullAllowed] NSObject target, [NullAllowed] Selector action);
    }

    // @interface MSBlurringView : UIView
    [BaseType(typeof(UIView))]
    [Protocol]
    interface MSBlurringView
    {
        // -(instancetype _Nonnull)initWithStyle:(UIBlurEffectStyle)style backgroundColor:(UIColor * _Nullable)backgroundColor __attribute__((objc_designated_initializer));
        [Export("initWithStyle:backgroundColor:")]
        [DesignatedInitializer]
        IntPtr Constructor(UIBlurEffectStyle style, [NullAllowed] UIColor backgroundColor);

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(void)updateBackgroundWithBackgroundColor:(UIColor * _Nullable)backgroundColor;
        [Export("updateBackgroundWithBackgroundColor:")]
        void UpdateBackgroundWithBackgroundColor([NullAllowed] UIColor backgroundColor);
    }

    // @interface MSTableViewCell : UITableViewCell
    [BaseType(typeof(UITableViewCell))]
    [Protocol]
    interface MSTableViewCell
    {
        // @property (readonly, nonatomic, class) CGFloat smallHeight;
        [Static]
        [Export("smallHeight")]
        nfloat SmallHeight { get; }

        // @property (readonly, nonatomic, class) CGFloat mediumHeight;
        [Static]
        [Export("mediumHeight")]
        nfloat MediumHeight { get; }

        // @property (readonly, nonatomic, class) CGFloat largeHeight;
        [Static]
        [Export("largeHeight")]
        nfloat LargeHeight { get; }

        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull identifier;
        [Static]
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, nonatomic, class) NSInteger defaultNumberOfLinesForLargerDynamicType;
        [Static]
        [Export("defaultNumberOfLinesForLargerDynamicType")]
        nint DefaultNumberOfLinesForLargerDynamicType { get; }

        // +(CGFloat)heightWithTitle:(NSString * _Nonnull)title subtitle:(NSString * _Nonnull)subtitle footer:(NSString * _Nonnull)footer titleLeadingAccessoryView:(UIView * _Nullable)titleLeadingAccessoryView titleTrailingAccessoryView:(UIView * _Nullable)titleTrailingAccessoryView subtitleLeadingAccessoryView:(UIView * _Nullable)subtitleLeadingAccessoryView subtitleTrailingAccessoryView:(UIView * _Nullable)subtitleTrailingAccessoryView footerLeadingAccessoryView:(UIView * _Nullable)footerLeadingAccessoryView footerTrailingAccessoryView:(UIView * _Nullable)footerTrailingAccessoryView customViewSize:(enum MSTableViewCellCustomViewSize)customViewSize customAccessoryView:(UIView * _Nullable)customAccessoryView accessoryType:(enum MSTableViewCellAccessoryType)accessoryType titleNumberOfLines:(NSInteger)titleNumberOfLines subtitleNumberOfLines:(NSInteger)subtitleNumberOfLines footerNumberOfLines:(NSInteger)footerNumberOfLines customAccessoryViewExtendsToEdge:(BOOL)customAccessoryViewExtendsToEdge containerWidth:(CGFloat)containerWidth isInSelectionMode:(BOOL)isInSelectionMode __attribute__((warn_unused_result));
        [Static]
        [Export("heightWithTitle:subtitle:footer:titleLeadingAccessoryView:titleTrailingAccessoryView:subtitleLeadingAccessoryView:subtitleTrailingAccessoryView:footerLeadingAccessoryView:footerTrailingAccessoryView:customViewSize:customAccessoryView:accessoryType:titleNumberOfLines:subtitleNumberOfLines:footerNumberOfLines:customAccessoryViewExtendsToEdge:containerWidth:isInSelectionMode:")]
        nfloat HeightWithTitle(string title, string subtitle, string footer, [NullAllowed] UIView titleLeadingAccessoryView, [NullAllowed] UIView titleTrailingAccessoryView, [NullAllowed] UIView subtitleLeadingAccessoryView, [NullAllowed] UIView subtitleTrailingAccessoryView, [NullAllowed] UIView footerLeadingAccessoryView, [NullAllowed] UIView footerTrailingAccessoryView, MSTableViewCellCustomViewSize customViewSize, [NullAllowed] UIView customAccessoryView, MSTableViewCellAccessoryType accessoryType, nint titleNumberOfLines, nint subtitleNumberOfLines, nint footerNumberOfLines, bool customAccessoryViewExtendsToEdge, nfloat containerWidth, bool isInSelectionMode);

        // +(CGFloat)preferredWidthWithTitle:(NSString * _Nonnull)title subtitle:(NSString * _Nonnull)subtitle footer:(NSString * _Nonnull)footer titleLeadingAccessoryView:(UIView * _Nullable)titleLeadingAccessoryView titleTrailingAccessoryView:(UIView * _Nullable)titleTrailingAccessoryView subtitleLeadingAccessoryView:(UIView * _Nullable)subtitleLeadingAccessoryView subtitleTrailingAccessoryView:(UIView * _Nullable)subtitleTrailingAccessoryView footerLeadingAccessoryView:(UIView * _Nullable)footerLeadingAccessoryView footerTrailingAccessoryView:(UIView * _Nullable)footerTrailingAccessoryView customViewSize:(enum MSTableViewCellCustomViewSize)customViewSize customAccessoryView:(UIView * _Nullable)customAccessoryView accessoryType:(enum MSTableViewCellAccessoryType)accessoryType customAccessoryViewExtendsToEdge:(BOOL)customAccessoryViewExtendsToEdge isInSelectionMode:(BOOL)isInSelectionMode __attribute__((warn_unused_result));
        [Static]
        [Export("preferredWidthWithTitle:subtitle:footer:titleLeadingAccessoryView:titleTrailingAccessoryView:subtitleLeadingAccessoryView:subtitleTrailingAccessoryView:footerLeadingAccessoryView:footerTrailingAccessoryView:customViewSize:customAccessoryView:accessoryType:customAccessoryViewExtendsToEdge:isInSelectionMode:")]
        nfloat PreferredWidthWithTitle(string title, string subtitle, string footer, [NullAllowed] UIView titleLeadingAccessoryView, [NullAllowed] UIView titleTrailingAccessoryView, [NullAllowed] UIView subtitleLeadingAccessoryView, [NullAllowed] UIView subtitleTrailingAccessoryView, [NullAllowed] UIView footerLeadingAccessoryView, [NullAllowed] UIView footerTrailingAccessoryView, MSTableViewCellCustomViewSize customViewSize, [NullAllowed] UIView customAccessoryView, MSTableViewCellAccessoryType accessoryType, bool customAccessoryViewExtendsToEdge, bool isInSelectionMode);

        // @property (readonly, copy, nonatomic) NSString * _Nonnull title;
        [Export("title")]
        string Title { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull subtitle;
        [Export("subtitle")]
        string Subtitle { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull footer;
        [Export("footer")]
        string Footer { get; }

        // @property (nonatomic) NSInteger titleNumberOfLines;
        [Export("titleNumberOfLines")]
        nint TitleNumberOfLines { get; set; }

        // @property (nonatomic) NSInteger subtitleNumberOfLines;
        [Export("subtitleNumberOfLines")]
        nint SubtitleNumberOfLines { get; set; }

        // @property (nonatomic) NSInteger footerNumberOfLines;
        [Export("footerNumberOfLines")]
        nint FooterNumberOfLines { get; set; }

        // @property (nonatomic) NSInteger titleNumberOfLinesForLargerDynamicType;
        [Export("titleNumberOfLinesForLargerDynamicType")]
        nint TitleNumberOfLinesForLargerDynamicType { get; set; }

        // @property (nonatomic) NSInteger subtitleNumberOfLinesForLargerDynamicType;
        [Export("subtitleNumberOfLinesForLargerDynamicType")]
        nint SubtitleNumberOfLinesForLargerDynamicType { get; set; }

        // @property (nonatomic) NSInteger footerNumberOfLinesForLargerDynamicType;
        [Export("footerNumberOfLinesForLargerDynamicType")]
        nint FooterNumberOfLinesForLargerDynamicType { get; set; }

        // @property (nonatomic) NSLineBreakMode titleLineBreakMode;
        [Export("titleLineBreakMode", ArgumentSemantic.Assign)]
        NSLineBreakMode TitleLineBreakMode { get; set; }

        // @property (nonatomic) NSLineBreakMode subtitleLineBreakMode;
        [Export("subtitleLineBreakMode", ArgumentSemantic.Assign)]
        NSLineBreakMode SubtitleLineBreakMode { get; set; }

        // @property (nonatomic) NSLineBreakMode footerLineBreakMode;
        [Export("footerLineBreakMode", ArgumentSemantic.Assign)]
        NSLineBreakMode FooterLineBreakMode { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable titleLeadingAccessoryView;
        [NullAllowed, Export("titleLeadingAccessoryView", ArgumentSemantic.Strong)]
        UIView TitleLeadingAccessoryView { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable titleTrailingAccessoryView;
        [NullAllowed, Export("titleTrailingAccessoryView", ArgumentSemantic.Strong)]
        UIView TitleTrailingAccessoryView { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable subtitleLeadingAccessoryView;
        [NullAllowed, Export("subtitleLeadingAccessoryView", ArgumentSemantic.Strong)]
        UIView SubtitleLeadingAccessoryView { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable subtitleTrailingAccessoryView;
        [NullAllowed, Export("subtitleTrailingAccessoryView", ArgumentSemantic.Strong)]
        UIView SubtitleTrailingAccessoryView { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable footerLeadingAccessoryView;
        [NullAllowed, Export("footerLeadingAccessoryView", ArgumentSemantic.Strong)]
        UIView FooterLeadingAccessoryView { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable footerTrailingAccessoryView;
        [NullAllowed, Export("footerTrailingAccessoryView", ArgumentSemantic.Strong)]
        UIView FooterTrailingAccessoryView { get; set; }

        // @property (nonatomic) enum MSTableViewCellCustomViewSize customViewSize;
        [Export("customViewSize", ArgumentSemantic.Assign)]
        MSTableViewCellCustomViewSize CustomViewSize { get; set; }

        // @property (readonly, nonatomic, strong) UIView * _Nullable customAccessoryView;
        [NullAllowed, Export("customAccessoryView", ArgumentSemantic.Strong)]
        UIView CustomAccessoryView { get; }

        // @property (nonatomic) BOOL customAccessoryViewExtendsToEdge;
        [Export("customAccessoryViewExtendsToEdge")]
        bool CustomAccessoryViewExtendsToEdge { get; set; }

        // @property (nonatomic) enum MSTableViewCellSeparatorType topSeparatorType;
        [Export("topSeparatorType", ArgumentSemantic.Assign)]
        MSTableViewCellSeparatorType TopSeparatorType { get; set; }

        // @property (nonatomic) enum MSTableViewCellSeparatorType bottomSeparatorType;
        [Export("bottomSeparatorType", ArgumentSemantic.Assign)]
        MSTableViewCellSeparatorType BottomSeparatorType { get; set; }

        // @property (nonatomic) BOOL isEnabled;
        [Export("isEnabled")]
        bool IsEnabled { get; set; }

        // @property (nonatomic) BOOL isInSelectionMode;
        [Export("isInSelectionMode")]
        bool IsInSelectionMode { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) onAccessoryTapped;
        [NullAllowed, Export("onAccessoryTapped", ArgumentSemantic.Copy)]
        Action OnAccessoryTapped { get; set; }

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }

        // @property (nonatomic) CGRect bounds;
        [Export("bounds", ArgumentSemantic.Assign)]
        CGRect Bounds { get; set; }

        // @property (nonatomic) CGRect frame;
        [Export("frame", ArgumentSemantic.Assign)]
        CGRect Frame { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityHint;
        [NullAllowed, Export("accessibilityHint")]
        string AccessibilityHint { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable accessibilityValue;
        [NullAllowed, Export("accessibilityValue")]
        string AccessibilityValue { get; set; }

        // @property (nonatomic) CGPoint accessibilityActivationPoint;
        [Export("accessibilityActivationPoint", ArgumentSemantic.Assign)]
        CGPoint AccessibilityActivationPoint { get; set; }

        // -(instancetype _Nonnull)initWithStyle:(UITableViewCellStyle)style reuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
        [Export("initWithStyle:reuseIdentifier:")]
        [DesignatedInitializer]
        IntPtr Constructor(UITableViewCellStyle style, [NullAllowed] string reuseIdentifier);

        // -(void)setupWithTitle:(NSString * _Nonnull)title subtitle:(NSString * _Nonnull)subtitle footer:(NSString * _Nonnull)footer customView:(UIView * _Nullable)customView customAccessoryView:(UIView * _Nullable)customAccessoryView accessoryType:(enum MSTableViewCellAccessoryType)accessoryType;
        [Export("setupWithTitle:subtitle:footer:customView:customAccessoryView:accessoryType:")]
        void SetupWithTitle(string title, string subtitle, string footer, [NullAllowed] UIView customView, [NullAllowed] UIView customAccessoryView, MSTableViewCellAccessoryType accessoryType);

        // -(void)changeAccessoryTypeTo:(enum MSTableViewCellAccessoryType)accessoryType;
        [Export("changeAccessoryTypeTo:")]
        void ChangeAccessoryTypeTo(MSTableViewCellAccessoryType accessoryType);

        // -(void)setIsInSelectionMode:(BOOL)isInSelectionMode animated:(BOOL)animated;
        [Export("setIsInSelectionMode:animated:")]
        void SetIsInSelectionMode(bool isInSelectionMode, bool animated);

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(void)prepareForReuse __attribute__((objc_requires_super));
        [Export("prepareForReuse")]
        [RequiresSuper]
        void PrepareForReuse();

        // -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
        [Export("sizeThatFits:")]
        CGSize SizeThatFits(CGSize size);

        // -(void)touchesBegan:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
        [Export("touchesBegan:withEvent:")]
        void TouchesBegan(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(void)touchesCancelled:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
        [Export("touchesCancelled:withEvent:")]
        void TouchesCancelled(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(void)touchesEnded:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nullable)event;
        [Export("touchesEnded:withEvent:")]
        void TouchesEnded(NSSet<UITouch> touches, [NullAllowed] UIEvent @event);

        // -(void)setSelected:(BOOL)selected animated:(BOOL)animated;
        [Export("setSelected:animated:")]
        void SetSelected(bool selected, bool animated);
    }

    // @interface MSBooleanCell : MSTableViewCell
    [BaseType(typeof(MSTableViewCell))]
    [Protocol]
    interface MSBooleanCell
    {
        // @property (nonatomic) BOOL isOn;
        [Export("isOn")]
        bool IsOn { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) onValueChanged;
        [NullAllowed, Export("onValueChanged", ArgumentSemantic.Copy)]
        Action OnValueChanged { get; set; }

        // -(void)setupWithTitle:(NSString * _Nonnull)title customView:(UIView * _Nullable)customView isOn:(BOOL)isOn;
        [Export("setupWithTitle:customView:isOn:")]
        void SetupWithTitle(string title, [NullAllowed] UIView customView, bool isOn);

        // -(instancetype _Nonnull)initWithStyle:(UITableViewCellStyle)style reuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
        [Export("initWithStyle:reuseIdentifier:")]
        [DesignatedInitializer]
        IntPtr Constructor(UITableViewCellStyle style, [NullAllowed] string reuseIdentifier);
    }

    // @interface MSButton : UIButton
    [BaseType(typeof(UIButton), Name = "_TtC14OfficeUIFabric8MSButton")]
    [Protocol]
    interface MSButton
    {
        // @property (nonatomic) enum MSButtonStyle style;
        [Export("style", ArgumentSemantic.Assign)]
        MSButtonStyle Style { get; set; }

        // @property (getter = isHighlighted, nonatomic) BOOL highlighted;
        [Export("highlighted")]
        bool Highlighted
        {
            [Bind("isHighlighted")]
            get; set;
        }

        // @property (getter = isEnabled, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled
        {
            [Bind("isEnabled")]
            get; set;
        }

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }

        // -(instancetype _Nonnull)initWithStyle:(enum MSButtonStyle)style __attribute__((objc_designated_initializer));
        [Export("initWithStyle:")]
        [DesignatedInitializer]
        IntPtr Constructor(MSButtonStyle style);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();
    }

    // @interface MSCalendarConfiguration : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    [DisableDefaultCtor]
    interface MSCalendarConfiguration
    {
        // @property (readonly, getter = default, nonatomic, strong, class) MSCalendarConfiguration * _Nonnull default_;
        [Static]
        [Export("default_", ArgumentSemantic.Strong)]
        MSCalendarConfiguration Default_
        {
            [Bind("default")]
            get;
        }

        // @property (nonatomic) NSInteger firstWeekday;
        [Export("firstWeekday")]
        nint FirstWeekday { get; set; }
    }

    // @interface MSCenteredLabelCell : UITableViewCell
    [BaseType(typeof(UITableViewCell))]
    [Protocol]
    interface MSCenteredLabelCell
    {
        // -(instancetype _Nonnull)initWithStyle:(UITableViewCellStyle)style reuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
        [Export("initWithStyle:reuseIdentifier:")]
        [DesignatedInitializer]
        IntPtr Constructor(UITableViewCellStyle style, [NullAllowed] string reuseIdentifier);

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(void)setHighlighted:(BOOL)highlighted animated:(BOOL)animated;
        [Export("setHighlighted:animated:")]
        void SetHighlighted(bool highlighted, bool animated);

        // -(void)setSelected:(BOOL)selected animated:(BOOL)animated;
        [Export("setSelected:animated:")]
        void SetSelected(bool selected, bool animated);
    }

    // @interface MSCollectionViewCell : UICollectionViewCell
    [BaseType(typeof(UICollectionViewCell))]
    [Protocol]
    interface MSCollectionViewCell
    {
        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull identifier;
        [Static]
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, nonatomic, strong) MSTableViewCell * _Nonnull cellView;
        [Export("cellView", ArgumentSemantic.Strong)]
        MSTableViewCell CellView { get; }

        // @property (getter = isSelected, nonatomic) BOOL selected;
        [Export("selected")]
        bool Selected
        {
            [Bind("isSelected")]
            get; set;
        }

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
        [Export("sizeThatFits:")]
        CGSize SizeThatFits(CGSize size);

        // -(UICollectionViewLayoutAttributes * _Nonnull)preferredLayoutAttributesFittingAttributes:(UICollectionViewLayoutAttributes * _Nonnull)layoutAttributes __attribute__((warn_unused_result));
        [Export("preferredLayoutAttributesFittingAttributes:")]
        UICollectionViewLayoutAttributes PreferredLayoutAttributesFittingAttributes(UICollectionViewLayoutAttributes layoutAttributes);
    }

    // @interface MSCollectionViewHeaderFooterView : UICollectionReusableView
    [BaseType(typeof(UICollectionReusableView))]
    [Protocol]
    interface MSCollectionViewHeaderFooterView
    {
        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull identifier;
        [Static]
        [Export("identifier")]
        string Identifier { get; }

        // @property (readonly, nonatomic, strong) MSTableViewHeaderFooterView * _Nonnull headerFooterView;
        [Export("headerFooterView", ArgumentSemantic.Strong)]
        MSTableViewHeaderFooterView HeaderFooterView { get; }

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }

        // @property (readonly, nonatomic, strong) CALayer * _Nonnull layer;
        [Export("layer", ArgumentSemantic.Strong)]
        CALayer Layer { get; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
        [Export("sizeThatFits:")]
        CGSize SizeThatFits(CGSize size);
    }

    // @interface MSColors : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    [DisableDefaultCtor]
    interface MSColors
    {
        // @property (nonatomic, strong, class) UIColor * _Nonnull primary;
        [Static]
        [Export("primary", ArgumentSemantic.Strong)]
        UIColor Primary { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull primaryLight;
        [Static]
        [Export("primaryLight", ArgumentSemantic.Strong)]
        UIColor PrimaryLight { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull primaryDark;
        [Static]
        [Export("primaryDark", ArgumentSemantic.Strong)]
        UIColor PrimaryDark { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull primaryHighContrast;
        [Static]
        [Export("primaryHighContrast", ArgumentSemantic.Strong)]
        UIColor PrimaryHighContrast { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull foregroundOnPrimary;
        [Static]
        [Export("foregroundOnPrimary", ArgumentSemantic.Strong)]
        UIColor ForegroundOnPrimary { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull lightPrimary;
        [Static]
        [Export("lightPrimary", ArgumentSemantic.Strong)]
        UIColor LightPrimary { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull extraLightPrimary;
        [Static]
        [Export("extraLightPrimary", ArgumentSemantic.Strong)]
        UIColor ExtraLightPrimary { get; set; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull black;
        [Static]
        [Export("black", ArgumentSemantic.Strong)]
        UIColor Black { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray1;
        [Static]
        [Export("gray1", ArgumentSemantic.Strong)]
        UIColor Gray1 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray2;
        [Static]
        [Export("gray2", ArgumentSemantic.Strong)]
        UIColor Gray2 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray3;
        [Static]
        [Export("gray3", ArgumentSemantic.Strong)]
        UIColor Gray3 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray4;
        [Static]
        [Export("gray4", ArgumentSemantic.Strong)]
        UIColor Gray4 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray5;
        [Static]
        [Export("gray5", ArgumentSemantic.Strong)]
        UIColor Gray5 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray6;
        [Static]
        [Export("gray6", ArgumentSemantic.Strong)]
        UIColor Gray6 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray7;
        [Static]
        [Export("gray7", ArgumentSemantic.Strong)]
        UIColor Gray7 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray8;
        [Static]
        [Export("gray8", ArgumentSemantic.Strong)]
        UIColor Gray8 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray9;
        [Static]
        [Export("gray9", ArgumentSemantic.Strong)]
        UIColor Gray9 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray10;
        [Static]
        [Export("gray10", ArgumentSemantic.Strong)]
        UIColor Gray10 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray11;
        [Static]
        [Export("gray11", ArgumentSemantic.Strong)]
        UIColor Gray11 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray12;
        [Static]
        [Export("gray12", ArgumentSemantic.Strong)]
        UIColor Gray12 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull white;
        [Static]
        [Export("white", ArgumentSemantic.Strong)]
        UIColor White { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray950;
        [Static]
        [Export("gray950", ArgumentSemantic.Strong)]
        UIColor Gray950 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray900;
        [Static]
        [Export("gray900", ArgumentSemantic.Strong)]
        UIColor Gray900 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray800;
        [Static]
        [Export("gray800", ArgumentSemantic.Strong)]
        UIColor Gray800 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray700;
        [Static]
        [Export("gray700", ArgumentSemantic.Strong)]
        UIColor Gray700 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray600;
        [Static]
        [Export("gray600", ArgumentSemantic.Strong)]
        UIColor Gray600 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray500;
        [Static]
        [Export("gray500", ArgumentSemantic.Strong)]
        UIColor Gray500 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray400;
        [Static]
        [Export("gray400", ArgumentSemantic.Strong)]
        UIColor Gray400 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray300;
        [Static]
        [Export("gray300", ArgumentSemantic.Strong)]
        UIColor Gray300 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray200;
        [Static]
        [Export("gray200", ArgumentSemantic.Strong)]
        UIColor Gray200 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray100;
        [Static]
        [Export("gray100", ArgumentSemantic.Strong)]
        UIColor Gray100 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray50;
        [Static]
        [Export("gray50", ArgumentSemantic.Strong)]
        UIColor Gray50 { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull gray25;
        [Static]
        [Export("gray25", ArgumentSemantic.Strong)]
        UIColor Gray25 { get; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull error;
        [Static]
        [Export("error", ArgumentSemantic.Strong)]
        UIColor Error { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull errorLight;
        [Static]
        [Export("errorLight", ArgumentSemantic.Strong)]
        UIColor ErrorLight { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull errorDark;
        [Static]
        [Export("errorDark", ArgumentSemantic.Strong)]
        UIColor ErrorDark { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull lightError;
        [Static]
        [Export("lightError", ArgumentSemantic.Strong)]
        UIColor LightError { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull warning;
        [Static]
        [Export("warning", ArgumentSemantic.Strong)]
        UIColor Warning { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull lightWarning;
        [Static]
        [Export("lightWarning", ArgumentSemantic.Strong)]
        UIColor LightWarning { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull yellow;
        [Static]
        [Export("yellow", ArgumentSemantic.Strong)]
        UIColor Yellow { get; set; }

        // @property (copy, nonatomic, class) NSArray<UIColor *> * _Nonnull avatarBackgroundColors;
        [Static]
        [Export("avatarBackgroundColors", ArgumentSemantic.Copy)]
        UIColor[] AvatarBackgroundColors { get; set; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull communicationBlue;
        [Static]
        [Export("communicationBlue", ArgumentSemantic.Strong)]
        UIColor CommunicationBlue { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull communicationBlueHighContrast;
        [Static]
        [Export("communicationBlueHighContrast", ArgumentSemantic.Strong)]
        UIColor CommunicationBlueHighContrast { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull communicationBlueLight;
        [Static]
        [Export("communicationBlueLight", ArgumentSemantic.Strong)]
        UIColor CommunicationBlueLight { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull communicationBlueDark;
        [Static]
        [Export("communicationBlueDark", ArgumentSemantic.Strong)]
        UIColor CommunicationBlueDark { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull communicationBlueHighContrastLight;
        [Static]
        [Export("communicationBlueHighContrastLight", ArgumentSemantic.Strong)]
        UIColor CommunicationBlueHighContrastLight { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull communicationBlueHighContrastDark;
        [Static]
        [Export("communicationBlueHighContrastDark", ArgumentSemantic.Strong)]
        UIColor CommunicationBlueHighContrastDark { get; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull background1;
        [Static]
        [Export("background1", ArgumentSemantic.Strong)]
        UIColor Background1 { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull background1b;
        [Static]
        [Export("background1b", ArgumentSemantic.Strong)]
        UIColor Background1b { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull background1c;
        [Static]
        [Export("background1c", ArgumentSemantic.Strong)]
        UIColor Background1c { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull background2;
        [Static]
        [Export("background2", ArgumentSemantic.Strong)]
        UIColor Background2 { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull background2b;
        [Static]
        [Export("background2b", ArgumentSemantic.Strong)]
        UIColor Background2b { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull background3;
        [Static]
        [Export("background3", ArgumentSemantic.Strong)]
        UIColor Background3 { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull background3b;
        [Static]
        [Export("background3b", ArgumentSemantic.Strong)]
        UIColor Background3b { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull background4;
        [Static]
        [Export("background4", ArgumentSemantic.Strong)]
        UIColor Background4 { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull background5;
        [Static]
        [Export("background5", ArgumentSemantic.Strong)]
        UIColor Background5 { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull disabled;
        [Static]
        [Export("disabled", ArgumentSemantic.Strong)]
        UIColor Disabled { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull foreground1;
        [Static]
        [Export("foreground1", ArgumentSemantic.Strong)]
        UIColor Foreground1 { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull foreground1b;
        [Static]
        [Export("foreground1b", ArgumentSemantic.Strong)]
        UIColor Foreground1b { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull foreground2;
        [Static]
        [Export("foreground2", ArgumentSemantic.Strong)]
        UIColor Foreground2 { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull foreground2b;
        [Static]
        [Export("foreground2b", ArgumentSemantic.Strong)]
        UIColor Foreground2b { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull foreground2c;
        [Static]
        [Export("foreground2c", ArgumentSemantic.Strong)]
        UIColor Foreground2c { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull foreground2d;
        [Static]
        [Export("foreground2d", ArgumentSemantic.Strong)]
        UIColor Foreground2d { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull foreground3;
        [Static]
        [Export("foreground3", ArgumentSemantic.Strong)]
        UIColor Foreground3 { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull foreground3b;
        [Static]
        [Export("foreground3b", ArgumentSemantic.Strong)]
        UIColor Foreground3b { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull foreground3c;
        [Static]
        [Export("foreground3c", ArgumentSemantic.Strong)]
        UIColor Foreground3c { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull foreground4;
        [Static]
        [Export("foreground4", ArgumentSemantic.Strong)]
        UIColor Foreground4 { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull foreground4b;
        [Static]
        [Export("foreground4b", ArgumentSemantic.Strong)]
        UIColor Foreground4b { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull foreground5;
        [Static]
        [Export("foreground5", ArgumentSemantic.Strong)]
        UIColor Foreground5 { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull foreground6;
        [Static]
        [Export("foreground6", ArgumentSemantic.Strong)]
        UIColor Foreground6 { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull foreground6b;
        [Static]
        [Export("foreground6b", ArgumentSemantic.Strong)]
        UIColor Foreground6b { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull foreground6c;
        [Static]
        [Export("foreground6c", ArgumentSemantic.Strong)]
        UIColor Foreground6c { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull foreground7;
        [Static]
        [Export("foreground7", ArgumentSemantic.Strong)]
        UIColor Foreground7 { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull foreground7b;
        [Static]
        [Export("foreground7b", ArgumentSemantic.Strong)]
        UIColor Foreground7b { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull foreground8;
        [Static]
        [Export("foreground8", ArgumentSemantic.Strong)]
        UIColor Foreground8 { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull selected;
        [Static]
        [Export("selected", ArgumentSemantic.Strong)]
        UIColor Selected { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull selected2;
        [Static]
        [Export("selected2", ArgumentSemantic.Strong)]
        UIColor Selected2 { get; set; }

        // @property (nonatomic, strong, class) UIColor * _Nonnull foregroundOnSelected;
        [Static]
        [Export("foregroundOnSelected", ArgumentSemantic.Strong)]
        UIColor ForegroundOnSelected { get; set; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull separatorDefault;
        [Static]
        [Export("separatorDefault", ArgumentSemantic.Strong)]
        UIColor SeparatorDefault { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull tableBackground;
        [Static]
        [Export("tableBackground", ArgumentSemantic.Strong)]
        UIColor TableBackground { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull tableBackgroundGrouped;
        [Static]
        [Export("tableBackgroundGrouped", ArgumentSemantic.Strong)]
        UIColor TableBackgroundGrouped { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull tableCellBackground;
        [Static]
        [Export("tableCellBackground", ArgumentSemantic.Strong)]
        UIColor TableCellBackground { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull tableCellBackgroundGrouped;
        [Static]
        [Export("tableCellBackgroundGrouped", ArgumentSemantic.Strong)]
        UIColor TableCellBackgroundGrouped { get; }

        // @property (readonly, nonatomic, strong, class) UIColor * _Nonnull tableCellImage;
        [Static]
        [Export("tableCellImage", ArgumentSemantic.Strong)]
        UIColor TableCellImage { get; }
    }

    // @interface MSDateTimePicker : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface MSDateTimePicker
    {
        [Wrap("WeakDelegate")]
        [NullAllowed]
        MSDateTimePickerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MSDateTimePickerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(void)presentFrom:(UIViewController * _Nonnull)presentingController with:(enum MSDateTimePickerMode)mode startDate:(NSDate * _Nonnull)startDate endDate:(NSDate * _Nullable)endDate datePickerType:(enum MSDateTimePickerDatePickerType)datePickerType dateRangePresentation:(enum MSDateTimePickerDateRangePresentation)dateRangePresentation titles:(MSDateTimePickerTitles * _Nullable)titles;
        [Export("presentFrom:with:startDate:endDate:datePickerType:dateRangePresentation:titles:")]
        void PresentFrom(UIViewController presentingController, MSDateTimePickerMode mode, NSDate startDate, [NullAllowed] NSDate endDate, MSDateTimePickerDatePickerType datePickerType, MSDateTimePickerDateRangePresentation dateRangePresentation, [NullAllowed] MSDateTimePickerTitles titles);

        // -(void)dismiss;
        [Export("dismiss")]
        void Dismiss();
    }

    // @interface MSDateTimePickerTitles : NSObject
    [BaseType(typeof(NSObject))]
    interface MSDateTimePickerTitles { }

    // @protocol MSDateTimePickerDelegate
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MSDateTimePickerDelegate
    {
        // @required -(void)dateTimePicker:(MSDateTimePicker * _Nonnull)dateTimePicker didPickStartDate:(NSDate * _Nonnull)startDate endDate:(NSDate * _Nonnull)endDate;
        [Abstract]
        [Export("dateTimePicker:didPickStartDate:endDate:")]
        void DidPickStartDate(MSDateTimePicker dateTimePicker, NSDate startDate, NSDate endDate);

        // @optional -(BOOL)dateTimePicker:(MSDateTimePicker * _Nonnull)dateTimePicker shouldEndPickingStartDate:(NSDate * _Nonnull)startDate endDate:(NSDate * _Nonnull)endDate __attribute__((warn_unused_result));
        [Export("dateTimePicker:shouldEndPickingStartDate:endDate:")]
        bool ShouldEndPickingStartDate(MSDateTimePicker dateTimePicker, NSDate startDate, NSDate endDate);
    }

    // @interface MSDimmingView : UIView
    [BaseType(typeof(UIView))]
    [Protocol]
    interface MSDimmingView
    {
        // -(instancetype _Nonnull)initWithType:(enum MSDimmingViewType)type __attribute__((objc_designated_initializer));
        [Export("initWithType:")]
        [DesignatedInitializer]
        IntPtr Constructor(MSDimmingViewType type);
    }

    // @interface MSDotView : UIView
    [BaseType(typeof(UIView))]
    [Protocol]
    interface MSDotView
    {
        // @property (nonatomic, strong) UIColor * _Nullable color;
        [NullAllowed, Export("color", ArgumentSemantic.Strong)]
        UIColor Color { get; set; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // -(void)drawRect:(CGRect)rect;
        [Export("drawRect:")]
        void DrawRect(CGRect rect);
    }

    // @interface MSDrawerController : UIViewController
    [BaseType(typeof(UIViewController))]
    [Protocol]
    interface MSDrawerController
    {
        // @property (nonatomic, strong) UIViewController * _Nullable contentController;
        [NullAllowed, Export("contentController", ArgumentSemantic.Strong)]
        UIViewController ContentController { get; set; }

        // @property (nonatomic, strong) UIView * _Nullable contentView;
        [NullAllowed, Export("contentView", ArgumentSemantic.Strong)]
        UIView ContentView { get; set; }

        // @property (nonatomic, strong) UIScrollView * _Nullable contentScrollView;
        [NullAllowed, Export("contentScrollView", ArgumentSemantic.Strong)]
        UIScrollView ContentScrollView { get; set; }

        // @property (nonatomic) enum MSDrawerPresentationStyle presentationStyle;
        [Export("presentationStyle", ArgumentSemantic.Assign)]
        MSDrawerPresentationStyle PresentationStyle { get; set; }

        // @property (nonatomic) CGFloat presentationOffset;
        [Export("presentationOffset")]
        nfloat PresentationOffset { get; set; }

        // @property (nonatomic) enum MSDrawerPresentationBackground presentationBackground;
        [Export("presentationBackground", ArgumentSemantic.Assign)]
        MSDrawerPresentationBackground PresentationBackground { get; set; }

        // @property (nonatomic, strong) UIPanGestureRecognizer * _Nullable presentingGesture;
        [NullAllowed, Export("presentingGesture", ArgumentSemantic.Strong)]
        UIPanGestureRecognizer PresentingGesture { get; set; }

        // @property (nonatomic) enum MSDrawerResizingBehavior resizingBehavior;
        [Export("resizingBehavior", ArgumentSemantic.Assign)]
        MSDrawerResizingBehavior ResizingBehavior { get; set; }

        // @property (nonatomic) BOOL isExpanded;
        [Export("isExpanded")]
        bool IsExpanded { get; set; }

        // @property (nonatomic) BOOL adjustsHeightForKeyboard;
        [Export("adjustsHeightForKeyboard")]
        bool AdjustsHeightForKeyboard { get; set; }

        // @property (nonatomic) UIPopoverArrowDirection permittedArrowDirections;
        [Export("permittedArrowDirections", ArgumentSemantic.Assign)]
        UIPopoverArrowDirection PermittedArrowDirections { get; set; }

        // @property (nonatomic) CGSize preferredContentSize;
        [Export("preferredContentSize", ArgumentSemantic.Assign)]
        CGSize PreferredContentSize { get; set; }

        // @property (readonly, nonatomic) BOOL shouldAutorotate;
        [Export("shouldAutorotate")]
        bool ShouldAutorotate { get; }

        // @property (readonly, nonatomic) UIInterfaceOrientationMask supportedInterfaceOrientations;
        [Export("supportedInterfaceOrientations")]
        UIInterfaceOrientationMask SupportedInterfaceOrientations { get; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) onDismiss;
        [NullAllowed, Export("onDismiss", ArgumentSemantic.Copy)]
        Action OnDismiss { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) onDismissCompleted;
        [NullAllowed, Export("onDismissCompleted", ArgumentSemantic.Copy)]
        Action OnDismissCompleted { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MSDrawerControllerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MSDrawerControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(instancetype _Nonnull)initWithSourceView:(UIView * _Nonnull)sourceView sourceRect:(CGRect)sourceRect presentationOrigin:(CGFloat)presentationOrigin presentationDirection:(enum MSDrawerPresentationDirection)presentationDirection __attribute__((objc_designated_initializer));
        [Export("initWithSourceView:sourceRect:presentationOrigin:presentationDirection:")]
        [DesignatedInitializer]
        IntPtr Constructor(UIView sourceView, CGRect sourceRect, nfloat presentationOrigin, MSDrawerPresentationDirection presentationDirection);

        // -(instancetype _Nonnull)initWithBarButtonItem:(UIBarButtonItem * _Nonnull)barButtonItem presentationOrigin:(CGFloat)presentationOrigin presentationDirection:(enum MSDrawerPresentationDirection)presentationDirection __attribute__((objc_designated_initializer));
        [Export("initWithBarButtonItem:presentationOrigin:presentationDirection:")]
        [DesignatedInitializer]
        IntPtr Constructor(UIBarButtonItem barButtonItem, nfloat presentationOrigin, MSDrawerPresentationDirection presentationDirection);

        // -(void)viewDidLoad;
        [Export("viewDidLoad")]
        void ViewDidLoad();

        // -(void)viewWillAppear:(BOOL)animated;
        [Export("viewWillAppear:")]
        void ViewWillAppear(bool animated);

        // -(void)viewDidAppear:(BOOL)animated;
        [Export("viewDidAppear:")]
        void ViewDidAppear(bool animated);

        // -(void)viewWillDisappear:(BOOL)animated;
        [Export("viewWillDisappear:")]
        void ViewWillDisappear(bool animated);

        // -(void)viewDidDisappear:(BOOL)animated;
        [Export("viewDidDisappear:")]
        void ViewDidDisappear(bool animated);

        // -(void)viewWillTransitionToSize:(CGSize)size withTransitionCoordinator:(id<UIViewControllerTransitionCoordinator> _Nonnull)coordinator;
        [Export("viewWillTransitionToSize:withTransitionCoordinator:")]
        void ViewWillTransitionToSize(CGSize size, IUIViewControllerTransitionCoordinator coordinator);

        // -(void)preferredContentSizeDidChangeForChildContentContainer:(id<UIContentContainer> _Nonnull)container;
        [Export("preferredContentSizeDidChangeForChildContentContainer:")]
        void PreferredContentSizeDidChangeForChildContentContainer(UIContentContainer container);

        // -(BOOL)accessibilityPerformEscape __attribute__((warn_unused_result));
        [Export("accessibilityPerformEscape")]
        bool AccessibilityPerformEscape { get; }
    }

    // @protocol MSDrawerControllerDelegate
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MSDrawerControllerDelegate
    {
        // @optional -(void)drawerControllerDidChangeExpandedState:(MSDrawerController * _Nonnull)controller;
        [Export("drawerControllerDidChangeExpandedState:")]
        void DrawerControllerDidChangeExpandedState(MSDrawerController controller);

        // @optional -(void)drawerControllerWillDismiss:(MSDrawerController * _Nonnull)controller;
        [Export("drawerControllerWillDismiss:")]
        void DrawerControllerWillDismiss(MSDrawerController controller);

        // @optional -(void)drawerControllerDidDismiss:(MSDrawerController * _Nonnull)controller;
        [Export("drawerControllerDidDismiss:")]
        void DrawerControllerDidDismiss(MSDrawerController controller);
    }

    // @interface MSEasyTapButton : UIButton
    [BaseType(typeof(UIButton))]
    [Protocol]
    interface MSEasyTapButton
    {
        // -(BOOL)pointInside:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result));
        [Export("pointInside:withEvent:")]
        bool PointInside(CGPoint point, [NullAllowed] UIEvent @event);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MSFonts : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    [DisableDefaultCtor]
    interface MSFonts
    {
        // @property (readonly, nonatomic, strong, class) UIFont * _Nonnull largeTitle;
        [Static]
        [Export("largeTitle", ArgumentSemantic.Strong)]
        UIFont LargeTitle { get; }

        // @property (readonly, nonatomic, strong, class) UIFont * _Nonnull title1;
        [Static]
        [Export("title1", ArgumentSemantic.Strong)]
        UIFont Title1 { get; }

        // @property (readonly, nonatomic, strong, class) UIFont * _Nonnull title2;
        [Static]
        [Export("title2", ArgumentSemantic.Strong)]
        UIFont Title2 { get; }

        // @property (readonly, nonatomic, strong, class) UIFont * _Nonnull headline;
        [Static]
        [Export("headline", ArgumentSemantic.Strong)]
        UIFont Headline { get; }

        // @property (readonly, nonatomic, strong, class) UIFont * _Nonnull headlineUnscaled;
        [Static]
        [Export("headlineUnscaled", ArgumentSemantic.Strong)]
        UIFont HeadlineUnscaled { get; }

        // @property (readonly, nonatomic, strong, class) UIFont * _Nonnull body;
        [Static]
        [Export("body", ArgumentSemantic.Strong)]
        UIFont Body { get; }

        // @property (readonly, nonatomic, strong, class) UIFont * _Nonnull bodyUnscaled;
        [Static]
        [Export("bodyUnscaled", ArgumentSemantic.Strong)]
        UIFont BodyUnscaled { get; }

        // @property (readonly, nonatomic, strong, class) UIFont * _Nonnull subhead;
        [Static]
        [Export("subhead", ArgumentSemantic.Strong)]
        UIFont Subhead { get; }

        // @property (readonly, nonatomic, strong, class) UIFont * _Nonnull footnote;
        [Static]
        [Export("footnote", ArgumentSemantic.Strong)]
        UIFont Footnote { get; }

        // @property (readonly, nonatomic, strong, class) UIFont * _Nonnull footnoteUnscaled;
        [Static]
        [Export("footnoteUnscaled", ArgumentSemantic.Strong)]
        UIFont FootnoteUnscaled { get; }

        // @property (readonly, nonatomic, strong, class) UIFont * _Nonnull button1;
        [Static]
        [Export("button1", ArgumentSemantic.Strong)]
        UIFont Button1 { get; }

        // @property (readonly, nonatomic, strong, class) UIFont * _Nonnull button2;
        [Static]
        [Export("button2", ArgumentSemantic.Strong)]
        UIFont Button2 { get; }

        // @property (readonly, nonatomic, strong, class) UIFont * _Nonnull button3;
        [Static]
        [Export("button3", ArgumentSemantic.Strong)]
        UIFont Button3 { get; }

        // @property (readonly, nonatomic, strong, class) UIFont * _Nonnull caption1;
        [Static]
        [Export("caption1", ArgumentSemantic.Strong)]
        UIFont Caption1 { get; }

        // @property (readonly, nonatomic, strong, class) UIFont * _Nonnull caption2;
        [Static]
        [Export("caption2", ArgumentSemantic.Strong)]
        UIFont Caption2 { get; }
    }

    // @interface MSHUD : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    [DisableDefaultCtor]
    interface MSHUD
    {
        // @property (readonly, nonatomic, strong, class) MSHUD * _Nonnull shared;
        [Static]
        [Export("shared", ArgumentSemantic.Strong)]
        MSHUD Shared { get; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MSHUDDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MSHUDDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(void)showIn:(UIView * _Nonnull)view;
        [Export("showIn:")]
        void ShowIn(UIView view);

        // -(void)showIn:(UIView * _Nonnull)view with:(MSHUDParams * _Nonnull)params;
        [Export("showIn:with:")]
        void ShowIn(UIView view, MSHUDParams @params);

        // -(void)showIn:(UIView * _Nonnull)view with:(MSHUDParams * _Nonnull)params onTap:(void (^ _Nullable)(void))onTap;
        [Export("showIn:with:onTap:")]
        void ShowIn(UIView view, MSHUDParams @params, [NullAllowed] Action onTap);

        // -(void)showFrom:(UIViewController * _Nonnull)controller;
        [Export("showFrom:")]
        void ShowFrom(UIViewController controller);

        // -(void)showFrom:(UIViewController * _Nonnull)controller with:(MSHUDParams * _Nonnull)params;
        [Export("showFrom:with:")]
        void ShowFrom(UIViewController controller, MSHUDParams @params);

        // -(void)showSuccessIn:(UIView * _Nonnull)view with:(NSString * _Nonnull)caption;
        [Export("showSuccessIn:with:")]
        void ShowSuccessIn(UIView view, string caption);

        // -(void)showSuccessFrom:(UIViewController * _Nonnull)controller with:(NSString * _Nonnull)caption;
        [Export("showSuccessFrom:with:")]
        void ShowSuccessFrom(UIViewController controller, string caption);

        // -(void)showFailureIn:(UIView * _Nonnull)view with:(NSString * _Nonnull)caption;
        [Export("showFailureIn:with:")]
        void ShowFailureIn(UIView view, string caption);

        // -(void)showFailureFrom:(UIViewController * _Nonnull)controller with:(NSString * _Nonnull)caption;
        [Export("showFailureFrom:with:")]
        void ShowFailureFrom(UIViewController controller, string caption);

        // -(void)hideAnimated:(BOOL)animated;
        [Export("hideAnimated:")]
        void HideAnimated(bool animated);

        // -(void)updateWith:(NSString * _Nonnull)caption;
        [Export("updateWith:")]
        void UpdateWith(string caption);
    }

    // @protocol MSHUDDelegate
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MSHUDDelegate
    {
        // @required -(UIWindow * _Nullable)defaultWindowForHUD:(MSHUD * _Nonnull)hud __attribute__((warn_unused_result));
        [Abstract]
        [Export("defaultWindowForHUD:")]
        [
            return: NullAllowed
        ]
        UIWindow DefaultWindowForHUD(MSHUD hud);
    }

    // @interface MSHUDParams : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface MSHUDParams
    {
        // @property (copy, nonatomic) NSString * _Nonnull caption;
        [Export("caption")]
        string Caption { get; set; }

        // @property (nonatomic, strong) UIImage * _Nullable image;
        [NullAllowed, Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; set; }

        // @property (nonatomic) BOOL isBlocking;
        [Export("isBlocking")]
        bool IsBlocking { get; set; }

        // @property (nonatomic) BOOL isPersistent;
        [Export("isPersistent")]
        bool IsPersistent { get; set; }

        // -(instancetype _Nonnull)initWithCaption:(NSString * _Nonnull)caption image:(UIImage * _Nullable)image isPersistent:(BOOL)isPersistent isBlocking:(BOOL)isBlocking;
        [Export("initWithCaption:image:isPersistent:isBlocking:")]
        IntPtr Constructor(string caption, [NullAllowed] UIImage image, bool isPersistent, bool isBlocking);
    }

    // @interface MSLabel : UILabel
    [BaseType(typeof(UILabel))]
    [Protocol]
    interface MSLabel
    {
        // @property (nonatomic) enum MSTextColorStyle colorStyle;
        [Export("colorStyle", ArgumentSemantic.Assign)]
        MSTextColorStyle ColorStyle { get; set; }

        // @property (nonatomic) enum MSTextStyle style;
        [Export("style", ArgumentSemantic.Assign)]
        MSTextStyle Style { get; set; }

        // @property (nonatomic) CGFloat maxFontSize;
        [Export("maxFontSize")]
        nfloat MaxFontSize { get; set; }

        // @property (nonatomic, strong) UIColor * _Null_unspecified textColor;
        [Export("textColor", ArgumentSemantic.Strong)]
        UIColor TextColor { get; set; }

        // -(instancetype _Nonnull)initWithStyle:(enum MSTextStyle)style colorStyle:(enum MSTextColorStyle)colorStyle __attribute__((objc_designated_initializer));
        [Export("initWithStyle:colorStyle:")]
        [DesignatedInitializer]
        IntPtr Constructor(MSTextStyle style, MSTextColorStyle colorStyle);
    }

    // @interface MSNavigationBar : UINavigationBar
    [BaseType(typeof(UINavigationBar))]
    [Protocol]
    interface MSNavigationBar
    {
        // @property (nonatomic, strong) id<MSAvatar> _Nullable avatar;
        [NullAllowed, Export("avatar", ArgumentSemantic.Strong)]
        MSAvatar Avatar { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable avatarCustomAccessibilityLabel;
        [NullAllowed, Export("avatarCustomAccessibilityLabel")]
        string AvatarCustomAccessibilityLabel { get; set; }

        // @property (nonatomic) enum MSNavigationBarElementSize avatarSize;
        [Export("avatarSize", ArgumentSemantic.Assign)]
        MSNavigationBarElementSize AvatarSize { get; set; }

        // @property (readonly, nonatomic) enum MSNavigationBarElementSize barHeight;
        [Export("barHeight")]
        MSNavigationBarElementSize BarHeight { get; }

        // @property (nonatomic) enum MSNavigationBarElementSize titleSize;
        [Export("titleSize", ArgumentSemantic.Assign)]
        MSNavigationBarElementSize TitleSize { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) onAvatarTapped;
        [NullAllowed, Export("onAvatarTapped", ArgumentSemantic.Copy)]
        Action OnAvatarTapped { get; set; }

        // @property (nonatomic) CGPoint center;
        [Export("center", ArgumentSemantic.Assign)]
        CGPoint Center { get; set; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(BOOL)pointInside:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result));
        [Export("pointInside:withEvent:")]
        bool PointInside(CGPoint point, [NullAllowed] UIEvent @event);

        // -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
        [Export("traitCollectionDidChange:")]
        void TraitCollectionDidChange([NullAllowed] UITraitCollection previousTraitCollection);
    }

    // @interface MSNavigationController : UINavigationController
    [BaseType(typeof(UINavigationController))]
    [Protocol]
    interface MSNavigationController
    {
        // @property (readonly, nonatomic, strong) MSNavigationBar * _Nonnull msNavigationBar;
        [Export("msNavigationBar", ArgumentSemantic.Strong)]
        MSNavigationBar MsNavigationBar { get; }

        // @property (readonly, nonatomic, strong) UIViewController * _Nullable topContentViewController;
        [NullAllowed, Export("topContentViewController", ArgumentSemantic.Strong)]
        UIViewController TopContentViewController { get; }

        // @property (readonly, nonatomic, strong) UIViewController * _Nullable childViewControllerForStatusBarStyle;
        [NullAllowed, Export("childViewControllerForStatusBarStyle", ArgumentSemantic.Strong)]
        UIViewController ChildViewControllerForStatusBarStyle { get; }

        // @property (readonly, nonatomic) UIStatusBarStyle preferredStatusBarStyle;
        [Export("preferredStatusBarStyle")]
        UIStatusBarStyle PreferredStatusBarStyle { get; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        UINavigationControllerDelegate Delegate { get; set; }

        // @property (nonatomic, strong) id<UINavigationControllerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Strong)]
        NSObject WeakDelegate { get; set; }

        // -(instancetype _Nonnull)initWithNavigationBarClass:(Class _Nullable)navigationBarClass toolbarClass:(Class _Nullable)toolbarClass __attribute__((objc_designated_initializer));
        [Export("initWithNavigationBarClass:toolbarClass:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] Class navigationBarClass, [NullAllowed] Class toolbarClass);

        // -(instancetype _Nonnull)initWithRootViewController:(UIViewController * _Nonnull)rootViewController;
        [Export("initWithRootViewController:")]
        IntPtr Constructor(UIViewController rootViewController);

        // -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
        [Export("initWithNibName:bundle:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

        // -(void)viewDidLoad;
        [Export("viewDidLoad")]
        void ViewDidLoad();

        // -(void)viewWillLayoutSubviews;
        [Export("viewWillLayoutSubviews")]
        void ViewWillLayoutSubviews();

        // -(void)pushViewController:(UIViewController * _Nonnull)viewController animated:(BOOL)animated;
        [Export("pushViewController:animated:")]
        void PushViewController(UIViewController viewController, bool animated);

        // -(void)setViewControllers:(NSArray<UIViewController *> * _Nonnull)viewControllers animated:(BOOL)animated;
        [Export("setViewControllers:animated:")]
        void SetViewControllers(UIViewController[] viewControllers, bool animated);

        // -(void)expandNavigationBarWithAnimated:(BOOL)animated;
        [Export("expandNavigationBarWithAnimated:")]
        void ExpandNavigationBarWithAnimated(bool animated);

        // -(void)contractNavigationBarWithAnimated:(BOOL)animated;
        [Export("contractNavigationBarWithAnimated:")]
        void ContractNavigationBarWithAnimated(bool animated);

        // -(UIViewController * _Nonnull)contentViewControllerFor:(UIViewController * _Nonnull)controller __attribute__((warn_unused_result));
        [Export("contentViewControllerFor:")]
        UIViewController ContentViewControllerFor(UIViewController controller);

        // -(void)setNavigationBarHidden:(BOOL)hidden animated:(BOOL)animated;
        [Export("setNavigationBarHidden:animated:")]
        void SetNavigationBarHidden(bool hidden, bool animated);
    }

    // @interface MSNotificationView : UIView
    [BaseType(typeof(UIView))]
    [Protocol]
    interface MSNotificationView
    {
        // @property (nonatomic, class) BOOL allowsMultipleToasts;
        [Static]
        [Export("allowsMultipleToasts")]
        bool AllowsMultipleToasts { get; set; }

        // @property (readonly, nonatomic) BOOL isShown;
        [Export("isShown")]
        bool IsShown { get; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // -(void)initialize;
        [Export("initialize")]
        void Initialize();

        // -(instancetype _Nonnull)setupWithStyle:(enum MSNotificationViewStyle)style title:(NSString * _Nonnull)title message:(NSString * _Nonnull)message image:(UIImage * _Nullable)image actionTitle:(NSString * _Nonnull)actionTitle action:(void (^ _Nullable)(void))action messageAction:(void (^ _Nullable)(void))messageAction;
        [Export("setupWithStyle:title:message:image:actionTitle:action:messageAction:")]
        MSNotificationView SetupWithStyle(MSNotificationViewStyle style, string title, string message, [NullAllowed] UIImage image, string actionTitle, [NullAllowed] Action action, [NullAllowed] Action messageAction);

        // -(void)showIn:(UIView * _Nonnull)view from:(UIView * _Nullable)anchorView animated:(BOOL)animated completion:(void (^ _Nullable)(MSNotificationView * _Nonnull))completion;
        [Export("showIn:from:animated:completion:")]
        void ShowIn(UIView view, [NullAllowed] UIView anchorView, bool animated, [NullAllowed] Action<MSNotificationView> completion);

        // -(void)showFrom:(UIViewController * _Nonnull)controller animated:(BOOL)animated completion:(void (^ _Nullable)(MSNotificationView * _Nonnull))completion;
        [Export("showFrom:animated:completion:")]
        void ShowFrom(UIViewController controller, bool animated, [NullAllowed] Action<MSNotificationView> completion);

        // -(void)hideAfter:(NSTimeInterval)delay animated:(BOOL)animated completion:(void (^ _Nullable)(void))completion;
        [Export("hideAfter:animated:completion:")]
        void HideAfter(double delay, bool animated, [NullAllowed] Action completion);

        // -(void)safeAreaInsetsDidChange;
        [Export("safeAreaInsetsDidChange")]
        void SafeAreaInsetsDidChange();
    }

    // @interface MSPageCardPresenterController : UIViewController
    [BaseType(typeof(UIViewController))]
    [Protocol]
    interface MSPageCardPresenterController
    {
        // @property (nonatomic) UIModalPresentationStyle modalPresentationStyle;
        [Export("modalPresentationStyle", ArgumentSemantic.Assign)]
        UIModalPresentationStyle ModalPresentationStyle { get; set; }

        [Wrap("WeakTransitioningDelegate")]
        [NullAllowed]
        UIViewControllerTransitioningDelegate TransitioningDelegate { get; set; }

        // @property (nonatomic, strong) id<UIViewControllerTransitioningDelegate> _Nullable transitioningDelegate;
        [NullAllowed, Export("transitioningDelegate", ArgumentSemantic.Strong)]
        NSObject WeakTransitioningDelegate { get; set; }

        // -(void)viewDidLoad;
        [Export("viewDidLoad")]
        void ViewDidLoad();

        // -(void)viewWillAppear:(BOOL)animated;
        [Export("viewWillAppear:")]
        void ViewWillAppear(bool animated);

        // -(void)viewWillLayoutSubviews;
        [Export("viewWillLayoutSubviews")]
        void ViewWillLayoutSubviews();
    }

    // @interface MSPeoplePicker : MSBadgeField
    [BaseType(typeof(MSBadgeField))]
    [Protocol]
    interface MSPeoplePicker
    {
        // @property (copy, nonatomic) NSArray<id<MSPersona>> * _Nonnull availablePersonas;
        [Export("availablePersonas", ArgumentSemantic.Copy)]
        MSPersona[] AvailablePersonas { get; set; }

        // @property (copy, nonatomic) NSArray<id<MSPersona>> * _Nonnull pickedPersonas;
        [Export("pickedPersonas", ArgumentSemantic.Copy)]
        MSPersona[] PickedPersonas { get; set; }

        // @property (nonatomic) BOOL showsSearchDirectoryButton;
        [Export("showsSearchDirectoryButton")]
        bool ShowsSearchDirectoryButton { get; set; }

        // @property (nonatomic) BOOL allowsPickedPersonasToAppearAsSuggested;
        [Export("allowsPickedPersonasToAppearAsSuggested")]
        bool AllowsPickedPersonasToAppearAsSuggested { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MSPeoplePickerDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MSPeoplePickerDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(void)initialize;
        [Export("initialize")]
        void Initialize();

        // -(MSBadgeView * _Nullable)badgeFor:(id<MSPersona> _Nonnull)persona __attribute__((warn_unused_result));
        [Export("badgeFor:")]
        [
            return: NullAllowed
        ]
        MSBadgeView BadgeFor(MSPersona persona);

        // -(void)willMoveToWindow:(UIWindow * _Nullable)newWindow;
        [Export("willMoveToWindow:")]
        void WillMoveToWindow([NullAllowed] UIWindow newWindow);

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(void)badgeText;
        [Export("badgeText")]
        void BadgeText();

        // -(void)addBadgeWithDataSource:(MSBadgeViewDataSource * _Nonnull)dataSource fromUserAction:(BOOL)fromUserAction updateConstrainedBadges:(BOOL)updateConstrainedBadges;
        [Export("addBadgeWithDataSource:fromUserAction:updateConstrainedBadges:")]
        void AddBadgeWithDataSource(MSBadgeViewDataSource dataSource, bool fromUserAction, bool updateConstrainedBadges);

        // -(void)resetTextFieldContent;
        [Export("resetTextFieldContent")]
        void ResetTextFieldContent();

        // -(void)textFieldDidEndEditing:(UITextField * _Nonnull)textField;
        [Export("textFieldDidEndEditing:")]
        void TextFieldDidEndEditing(UITextField textField);

        // -(void)didSelectBadge:(MSBadgeView * _Nonnull)badge;
        [Export("didSelectBadge:")]
        void DidSelectBadge(MSBadgeView badge);

        // -(void)didTapSelectedBadge:(MSBadgeView * _Nonnull)badge;
        [Export("didTapSelectedBadge:")]
        void DidTapSelectedBadge(MSBadgeView badge);
    }

    // @protocol MSPersonaListViewSearchDirectoryDelegate
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MSPersonaListViewSearchDirectoryDelegate
    {
        // @required -(void)personaListSearchDirectory:(MSPersonaListView * _Nonnull)personaListView completion:(void (^ _Nonnull)(BOOL))completion;
        [Abstract]
        [Export("personaListSearchDirectory:completion:")]
        void Completion(MSPersonaListView personaListView, Action<bool> completion);
    }

    interface IMSPersonaListViewSearchDirectoryDelegate { }

    interface IMSBadgeFieldDelegate { }

    // @protocol MSPeoplePickerDelegate <MSBadgeFieldDelegate>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MSPeoplePickerDelegate
    {
        // todo
        // @optional -(void)peoplePicker:(MSPeoplePicker * _Nonnull)peoplePicker getSuggestedPersonasForText:(NSString * _Nonnull)text completion:(void (^ _Nonnull)(NSArray<id<MSPersona>> * _Nonnull))completion;
        //[Export("peoplePicker:getSuggestedPersonasForText:completion:")]
        //void PeoplePicker(MSPeoplePicker peoplePicker, string text, Action<NSArray<MSPersona>> completion);

        // @optional -(BOOL)peoplePicker:(MSPeoplePicker * _Nonnull)peoplePicker shouldPickPersona:(id<MSPersona> _Nonnull)persona __attribute__((warn_unused_result));
        [Export("peoplePicker:shouldPickPersona:")]
        bool PeoplePicker(MSPeoplePicker peoplePicker, MSPersona persona);

        // @optional -(void)peoplePicker:(MSPeoplePicker * _Nonnull)peoplePicker didPickPersona:(id<MSPersona> _Nonnull)persona;
        [Export("peoplePicker:didPickPersona:")]
        void DidPickPersona(MSPeoplePicker peoplePicker, MSPersona persona);

        // @optional -(id<MSPersona> _Nonnull)peoplePicker:(MSPeoplePicker * _Nonnull)peoplePicker personaFromText:(NSString * _Nonnull)text __attribute__((warn_unused_result));
        [Export("peoplePicker:personaFromText:")]
        MSPersona PeoplePicker(MSPeoplePicker peoplePicker, string text);

        // @optional -(BOOL)peoplePicker:(MSPeoplePicker * _Nonnull)peoplePicker personaIsValid:(id<MSPersona> _Nonnull)persona __attribute__((warn_unused_result));
        [Export("peoplePicker:personaIsValid:")]
        bool PersonaIsValid(MSPeoplePicker peoplePicker, MSPersona persona);

        // @optional -(void)peoplePicker:(MSPeoplePicker * _Nonnull)peoplePicker didSelectPersona:(id<MSPersona> _Nonnull)persona;
        [Export("peoplePicker:didSelectPersona:")]
        void DidSelectPersona(MSPeoplePicker peoplePicker, MSPersona persona);

        // @optional -(void)peoplePicker:(MSPeoplePicker * _Nonnull)peoplePicker didTapSelectedPersona:(id<MSPersona> _Nonnull)persona;
        [Export("peoplePicker:didTapSelectedPersona:")]
        void DidTapSelectedPersona(MSPeoplePicker peoplePicker, MSPersona persona);

        // @optional -(void)peoplePicker:(MSPeoplePicker * _Nonnull)peoplePicker didRemovePersona:(id<MSPersona> _Nonnull)persona;
        [Export("peoplePicker:didRemovePersona:")]
        void DidRemovePersona(MSPeoplePicker peoplePicker, MSPersona persona);

        // Todo
        // @optional -(void)peoplePicker:(MSPeoplePicker * _Nonnull)peoplePicker searchDirectoryWithCompletion:(void (^ _Nonnull)(NSArray<id<MSPersona>> * _Nonnull, BOOL))completion;
        //[Export("peoplePicker:searchDirectoryWithCompletion:")]
        //void PeoplePicker(MSPeoplePicker peoplePicker, Action<NSArray<MSPersona>, bool> completion);
    }

    public interface IMSAvatar { }

    // @protocol MSPersona <MSAvatar>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MSPersona
    {
        // @required @property (readonly, nonatomic, strong) UIImage * _Nullable avatarImage;
        [Abstract]
        [NullAllowed, Export("avatarImage", ArgumentSemantic.Strong)]
        UIImage AvatarImage { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull email;
        [Abstract]
        [Export("email")]
        string Email { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull name;
        [Abstract]
        [Export("name")]
        string Name { get; }

        // @required @property (readonly, copy, nonatomic) NSString * _Nonnull subtitle;
        [Abstract]
        [Export("subtitle")]
        string Subtitle { get; }
    }

    // @interface MSPersonaBadgeViewDataSource : MSBadgeViewDataSource
    [BaseType(typeof(MSBadgeViewDataSource))]
    [Protocol]
    interface MSPersonaBadgeViewDataSource
    {
        // @property (nonatomic, strong) id<MSPersona> _Nonnull persona;
        [Export("persona", ArgumentSemantic.Strong)]
        MSPersona Persona { get; set; }

        // -(instancetype _Nonnull)initWithPersona:(id<MSPersona> _Nonnull)persona style:(enum MSBadgeViewStyle)style size:(enum MSBadgeViewSize)size __attribute__((objc_designated_initializer));
        [Export("initWithPersona:style:size:")]
        [DesignatedInitializer]
        IntPtr Constructor(MSPersona persona, MSBadgeViewStyle style, MSBadgeViewSize size);
    }

    // @interface MSPersonaCell : MSTableViewCell
    [BaseType(typeof(MSTableViewCell))]
    [Protocol]
    interface MSPersonaCell
    {
        // @property (nonatomic) enum MSTableViewCellCustomViewSize customViewSize;
        [Export("customViewSize", ArgumentSemantic.Assign)]
        MSTableViewCellCustomViewSize CustomViewSize { get; set; }

        // -(void)setupWithPersona:(id<MSPersona> _Nonnull)persona accessoryType:(enum MSTableViewCellAccessoryType)accessoryType;
        [Export("setupWithPersona:accessoryType:")]
        void SetupWithPersona(MSPersona persona, MSTableViewCellAccessoryType accessoryType);

        // -(instancetype _Nonnull)initWithStyle:(UITableViewCellStyle)style reuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
        [Export("initWithStyle:reuseIdentifier:")]
        [DesignatedInitializer]
        IntPtr Constructor(UITableViewCellStyle style, [NullAllowed] string reuseIdentifier);
    }

    interface IMSPersona { }

    // @interface MSPersonaData : NSObject <MSPersona>
    [BaseType(typeof(NSObject))]
    [Protocol]
    [DisableDefaultCtor]
    interface MSPersonaData : MSPersona
    {
        // @property (nonatomic, strong) UIImage * _Nullable avatarImage;
        [NullAllowed, Export("avatarImage", ArgumentSemantic.Strong)]
        UIImage AvatarImage { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull email;
        [Export("email")]
        string Email { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull name;
        [Export("name")]
        string Name { get; set; }

        // @property (copy, nonatomic) NSString * _Nonnull subtitle;
        [Export("subtitle")]
        string Subtitle { get; set; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull primaryText;
        [Export("primaryText")]
        string PrimaryText { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull secondaryText;
        [Export("secondaryText")]
        string SecondaryText { get; }

        // @property (readonly, nonatomic, strong) UIImage * _Nullable image;
        [NullAllowed, Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; }

        // -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name email:(NSString * _Nonnull)email subtitle:(NSString * _Nonnull)subtitle avatarImage:(UIImage * _Nullable)avatarImage __attribute__((objc_designated_initializer));
        [Export("initWithName:email:subtitle:avatarImage:")]
        [DesignatedInitializer]
        IntPtr Constructor(string name, string email, string subtitle, [NullAllowed] UIImage avatarImage);
    }

    // @interface MSPersonaListView : UITableView
    [BaseType(typeof(UITableView))]
    [Protocol]
    interface MSPersonaListView
    {
        // @property (copy, nonatomic) NSArray<id<MSPersona>> * _Nonnull personaList;
        [Export("personaList", ArgumentSemantic.Copy)]
        MSPersona[] PersonaList { get; set; }

        // @property (nonatomic) enum MSTableViewCellAccessoryType accessoryType;
        [Export("accessoryType", ArgumentSemantic.Assign)]
        MSTableViewCellAccessoryType AccessoryType { get; set; }

        // @property (nonatomic) BOOL showsSearchDirectoryButton;
        [Export("showsSearchDirectoryButton")]
        bool ShowsSearchDirectoryButton { get; set; }

        [Wrap("WeakSearchDirectoryDelegate")]
        [NullAllowed]
        MSPersonaListViewSearchDirectoryDelegate SearchDirectoryDelegate { get; set; }

        // @property (nonatomic, weak) id<MSPersonaListViewSearchDirectoryDelegate> _Nullable searchDirectoryDelegate;
        [NullAllowed, Export("searchDirectoryDelegate", ArgumentSemantic.Weak)]
        NSObject WeakSearchDirectoryDelegate { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(id<MSPersona> _Nonnull) onPersonaSelected;
        [NullAllowed, Export("onPersonaSelected", ArgumentSemantic.Copy)]
        Action<MSPersona> OnPersonaSelected { get; set; }

        // -(void)pickPersona;
        [Export("pickPersona")]
        void PickPersona();

        // -(void)selectPersonaWithDirection:(enum MSPersonaListViewSelectionDirection)direction;
        [Export("selectPersonaWithDirection:")]
        void SelectPersonaWithDirection(MSPersonaListViewSelectionDirection direction);
    }

    // @interface MSPopupMenuController : MSDrawerController
    [BaseType(typeof(MSDrawerController))]
    [Protocol]
    interface MSPopupMenuController
    {
        // @property (nonatomic, strong) UIView * _Nullable contentView;
        [NullAllowed, Export("contentView", ArgumentSemantic.Strong)]
        UIView ContentView { get; set; }

        // @property (nonatomic) enum MSDrawerPresentationStyle presentationStyle;
        [Export("presentationStyle", ArgumentSemantic.Assign)]
        MSDrawerPresentationStyle PresentationStyle { get; set; }

        // @property (nonatomic) enum MSDrawerResizingBehavior resizingBehavior;
        [Export("resizingBehavior", ArgumentSemantic.Assign)]
        MSDrawerResizingBehavior ResizingBehavior { get; set; }

        // @property (nonatomic) CGSize preferredContentSize;
        [Export("preferredContentSize", ArgumentSemantic.Assign)]
        CGSize PreferredContentSize { get; set; }

        // @property (nonatomic, strong) MSPopupMenuItem * _Nullable headerItem;
        [NullAllowed, Export("headerItem", ArgumentSemantic.Strong)]
        MSPopupMenuItem HeaderItem { get; set; }

        // @property (copy, nonatomic) NSIndexPath * _Nullable selectedItemIndexPath;
        [NullAllowed, Export("selectedItemIndexPath", ArgumentSemantic.Copy)]
        NSIndexPath SelectedItemIndexPath { get; set; }

        // -(void)addItems:(NSArray<MSPopupMenuItem *> * _Nonnull)items;
        [Export("addItems:")]
        void AddItems(MSPopupMenuItem[] items);

        // -(void)addSection:(MSPopupMenuSection * _Nonnull)section;
        [Export("addSection:")]
        void AddSection(MSPopupMenuSection section);

        // -(void)addSections:(NSArray<MSPopupMenuSection *> * _Nonnull)sections;
        [Export("addSections:")]
        void AddSections(MSPopupMenuSection[] sections);

        // -(void)viewDidLoad;
        [Export("viewDidLoad")]
        void ViewDidLoad();

        // -(void)viewWillAppear:(BOOL)animated;
        [Export("viewWillAppear:")]
        void ViewWillAppear(bool animated);

        // -(void)viewDidLayoutSubviews;
        [Export("viewDidLayoutSubviews")]
        void ViewDidLayoutSubviews();

        // -(instancetype _Nonnull)initWithSourceView:(UIView * _Nonnull)sourceView sourceRect:(CGRect)sourceRect presentationOrigin:(CGFloat)presentationOrigin presentationDirection:(enum MSDrawerPresentationDirection)presentationDirection __attribute__((objc_designated_initializer));
        [Export("initWithSourceView:sourceRect:presentationOrigin:presentationDirection:")]
        [DesignatedInitializer]
        IntPtr Constructor(UIView sourceView, CGRect sourceRect, nfloat presentationOrigin, MSDrawerPresentationDirection presentationDirection);

        // -(instancetype _Nonnull)initWithBarButtonItem:(UIBarButtonItem * _Nonnull)barButtonItem presentationOrigin:(CGFloat)presentationOrigin presentationDirection:(enum MSDrawerPresentationDirection)presentationDirection __attribute__((objc_designated_initializer));
        [Export("initWithBarButtonItem:presentationOrigin:presentationDirection:")]
        [DesignatedInitializer]
        IntPtr Constructor(UIBarButtonItem barButtonItem, nfloat presentationOrigin, MSDrawerPresentationDirection presentationDirection);
    }

    // @interface MSPopupMenuItem : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    [DisableDefaultCtor]
    interface MSPopupMenuItem
    {
        // @property (readonly, nonatomic, strong) UIImage * _Nullable image;
        [NullAllowed, Export("image", ArgumentSemantic.Strong)]
        UIImage Image { get; }

        // @property (readonly, nonatomic, strong) UIImage * _Nullable selectedImage;
        [NullAllowed, Export("selectedImage", ArgumentSemantic.Strong)]
        UIImage SelectedImage { get; }

        // @property (readonly, nonatomic, strong) UIImage * _Nullable accessoryImage;
        [NullAllowed, Export("accessoryImage", ArgumentSemantic.Strong)]
        UIImage AccessoryImage { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nonnull title;
        [Export("title")]
        string Title { get; }

        // @property (readonly, copy, nonatomic) NSString * _Nullable subtitle;
        [NullAllowed, Export("subtitle")]
        string Subtitle { get; }

        // @property (readonly, nonatomic, strong) UIView * _Nullable accessoryView;
        [NullAllowed, Export("accessoryView", ArgumentSemantic.Strong)]
        UIView AccessoryView { get; }

        // @property (readonly, nonatomic) enum MSPopupMenuItemExecutionMode executionMode;
        [Export("executionMode")]
        MSPopupMenuItemExecutionMode ExecutionMode { get; }

        // @property (nonatomic) BOOL isEnabled;
        [Export("isEnabled")]
        bool IsEnabled { get; set; }

        // @property (nonatomic) BOOL isSelected;
        [Export("isSelected")]
        bool IsSelected { get; set; }

        // @property (readonly, copy, nonatomic) void (^ _Nullable)(void) onSelected;
        [NullAllowed, Export("onSelected", ArgumentSemantic.Copy)]
        Action OnSelected { get; }

        // -(instancetype _Nonnull)initWithImage:(UIImage * _Nullable)image selectedImage:(UIImage * _Nullable)selectedImage accessoryImage:(UIImage * _Nullable)accessoryImage title:(NSString * _Nonnull)title subtitle:(NSString * _Nullable)subtitle accessoryView:(UIView * _Nullable)accessoryView isEnabled:(BOOL)isEnabled isSelected:(BOOL)isSelected executes:(enum MSPopupMenuItemExecutionMode)executionMode onSelected:(void (^ _Nullable)(void))onSelected __attribute__((objc_designated_initializer));
        [Export("initWithImage:selectedImage:accessoryImage:title:subtitle:accessoryView:isEnabled:isSelected:executes:onSelected:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] UIImage image, [NullAllowed] UIImage selectedImage, [NullAllowed] UIImage accessoryImage, string title, [NullAllowed] string subtitle, [NullAllowed] UIView accessoryView, bool isEnabled, bool isSelected, MSPopupMenuItemExecutionMode executionMode, [NullAllowed] Action onSelected);

        // -(instancetype _Nonnull)initWithImageName:(NSString * _Nonnull)imageName generateSelectedImage:(BOOL)generateSelectedImage title:(NSString * _Nonnull)title subtitle:(NSString * _Nullable)subtitle isEnabled:(BOOL)isEnabled isSelected:(BOOL)isSelected executes:(enum MSPopupMenuItemExecutionMode)executionMode onSelected:(void (^ _Nullable)(void))onSelected;
        [Export("initWithImageName:generateSelectedImage:title:subtitle:isEnabled:isSelected:executes:onSelected:")]
        IntPtr Constructor(string imageName, bool generateSelectedImage, string title, [NullAllowed] string subtitle, bool isEnabled, bool isSelected, MSPopupMenuItemExecutionMode executionMode, [NullAllowed] Action onSelected);
    }

    // @interface MSPopupMenuSection : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    [DisableDefaultCtor]
    interface MSPopupMenuSection
    {
        // @property (readonly, copy, nonatomic) NSString * _Nullable title;
        [NullAllowed, Export("title")]
        string Title { get; }

        // @property (copy, nonatomic) NSArray<MSPopupMenuItem *> * _Nonnull items;
        [Export("items", ArgumentSemantic.Copy)]
        MSPopupMenuItem[] Items { get; set; }

        // -(instancetype _Nonnull)initWithTitle:(NSString * _Nullable)title items:(NSArray<MSPopupMenuItem *> * _Nonnull)items __attribute__((objc_designated_initializer));
        [Export("initWithTitle:items:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string title, MSPopupMenuItem[] items);
    }

    // @interface MSResizingHandleView : UIView
    [BaseType(typeof(UIView))]
    [Protocol]
    interface MSResizingHandleView
    {
        // @property (readonly, nonatomic, class) CGFloat height;
        [Static]
        [Export("height")]
        nfloat Height { get; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }

        // -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
        [Export("sizeThatFits:")]
        CGSize SizeThatFits(CGSize size);

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();
    }

    // @interface MSScrollView : UIScrollView
    //[Unavailable(PlatformName.iOSAppExtension)]
    [Unavailable(PlatformName.iOS)]
    [BaseType(typeof(UIScrollView))]
    interface MSScrollView
    {
        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // @property (nonatomic) CGSize contentSize;
        [Export("contentSize", ArgumentSemantic.Assign)]
        CGSize ContentSize { get; set; }

        // -(void)prepareForInterfaceBuilder;
        [Export("prepareForInterfaceBuilder")]
        void PrepareForInterfaceBuilder();
    }

    // @interface MSSearchBar : UIView
    [BaseType(typeof(UIView))]
    [Protocol]
    interface MSSearchBar
    {
        // @property (nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable placeholderText;
        [NullAllowed, Export("placeholderText")]
        string PlaceholderText { get; set; }

        // @property (nonatomic) enum MSSearchBarStyle style;
        [Export("style", ArgumentSemantic.Assign)]
        MSSearchBarStyle Style { get; set; }

        // @property (readonly, nonatomic) BOOL isActive;
        [Export("isActive")]
        bool IsActive { get; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MSSearchBarDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MSSearchBarDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // -(void)cancelSearch;
        [Export("cancelSearch")]
        void CancelSearch();

        // @property (copy, nonatomic) NSString * _Nullable searchText;
        [NullAllowed, Export("searchText")]
        string SearchText { get; set; }

        // -(BOOL)becomeFirstResponder __attribute__((warn_unused_result));
        [Export("becomeFirstResponder")]
        bool BecomeFirstResponder { get; }

        // -(BOOL)resignFirstResponder __attribute__((warn_unused_result));
        [Export("resignFirstResponder")]
        bool ResignFirstResponder { get; }

        // @property (readonly, nonatomic) BOOL isFirstResponder;
        [Export("isFirstResponder")]
        bool IsFirstResponder { get; }
    }

    // @protocol MSSearchBarDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MSSearchBarDelegate
    {
        // @required -(void)searchBarDidBeginEditing:(MSSearchBar * _Nonnull)searchBar;
        [Abstract]
        [Export("searchBarDidBeginEditing:")]
        void SearchBarDidBeginEditing(MSSearchBar searchBar);

        // @required -(void)searchBar:(MSSearchBar * _Nonnull)searchBar didUpdateSearchText:(NSString * _Nullable)newSearchText;
        [Abstract]
        [Export("searchBar:didUpdateSearchText:")]
        void SearchBar(MSSearchBar searchBar, [NullAllowed] string newSearchText);

        // @optional -(void)searchBarDidFinishEditing:(MSSearchBar * _Nonnull)searchBar;
        [Export("searchBarDidFinishEditing:")]
        void SearchBarDidFinishEditing(MSSearchBar searchBar);

        // @required -(void)searchBarDidCancel:(MSSearchBar * _Nonnull)searchBar;
        [Abstract]
        [Export("searchBarDidCancel:")]
        void SearchBarDidCancel(MSSearchBar searchBar);

        // @optional -(void)searchBarDidRequestSearch:(MSSearchBar * _Nonnull)searchBar;
        [Export("searchBarDidRequestSearch:")]
        void SearchBarDidRequestSearch(MSSearchBar searchBar);
    }

    // @interface MSSegmentedControl : UIControl
    [BaseType(typeof(UIControl))]
    [Protocol]
    interface MSSegmentedControl
    {
        // @property (getter = isEnabled, nonatomic) BOOL enabled;
        [Export("enabled")]
        bool Enabled
        {
            [Bind("isEnabled")]
            get; set;
        }

        // @property (nonatomic) BOOL isAnimated;
        [Export("isAnimated")]
        bool IsAnimated { get; set; }

        // @property (readonly, nonatomic) NSInteger numberOfSegments;
        [Export("numberOfSegments")]
        nint NumberOfSegments { get; }

        // @property (nonatomic) NSInteger selectedSegmentIndex;
        [Export("selectedSegmentIndex")]
        nint SelectedSegmentIndex { get; set; }

        // -(instancetype _Nonnull)initWithItems:(NSArray<NSString *> * _Nonnull)items __attribute__((objc_designated_initializer));
        [Export("initWithItems:")]
        [DesignatedInitializer]
        IntPtr Constructor(string[] items);

        // -(void)insertSegmentWithTitle:(NSString * _Nonnull)title at:(NSInteger)index;
        [Export("insertSegmentWithTitle:at:")]
        void InsertSegmentWithTitle(string title, nint index);

        // -(void)removeSegmentAt:(NSInteger)index;
        [Export("removeSegmentAt:")]
        void RemoveSegmentAt(nint index);

        // -(void)selectSegmentAt:(NSInteger)index animated:(BOOL)animated;
        [Export("selectSegmentAt:animated:")]
        void SelectSegmentAt(nint index, bool animated);

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }

        // -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
        [Export("sizeThatFits:")]
        CGSize SizeThatFits(CGSize size);
    }

    // @interface MSSeparator : UIView
    [BaseType(typeof(UIView))]
    [Protocol]
    interface MSSeparator
    {
        // @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
        [NullAllowed, Export("backgroundColor", ArgumentSemantic.Strong)]
        UIColor BackgroundColor { get; set; }

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }

        // -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
        [Export("sizeThatFits:")]
        CGSize SizeThatFits(CGSize size);
    }

    // @interface MSShimmerAppearance : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    [DisableDefaultCtor]
    interface MSShimmerAppearance
    {
        // @property (readonly, nonatomic) CGFloat alpha;
        [Export("alpha")]
        nfloat Alpha { get; }

        // @property (readonly, nonatomic) CGFloat width;
        [Export("width")]
        nfloat Width { get; }

        // @property (readonly, nonatomic) CGFloat angle;
        [Export("angle")]
        nfloat Angle { get; }

        // @property (readonly, nonatomic) CGFloat speed;
        [Export("speed")]
        nfloat Speed { get; }

        // @property (readonly, nonatomic) NSTimeInterval delay;
        [Export("delay")]
        double Delay { get; }

        // -(instancetype _Nonnull)initWithAlpha:(CGFloat)alpha width:(CGFloat)width angle:(CGFloat)angle speed:(CGFloat)speed delay:(NSTimeInterval)delay __attribute__((objc_designated_initializer));
        [Export("initWithAlpha:width:angle:speed:delay:")]
        [DesignatedInitializer]
        IntPtr Constructor(nfloat alpha, nfloat width, nfloat angle, nfloat speed, double delay);
    }

    // @interface MSShimmerView : UIView
    [BaseType(typeof(UIView))]
    [Protocol]
    interface MSShimmerView
    {
        // @property (nonatomic, strong) MSShimmerAppearance * _Nonnull shimmerAppearance;
        [Export("shimmerAppearance", ArgumentSemantic.Strong)]
        MSShimmerAppearance ShimmerAppearance { get; set; }

        //Todo: figure this out
        //// @property (nonatomic, strong) MSShimmerViewAppearence * _Nonnull appearance;
        //[Export("appearance", ArgumentSemantic.Strong)]
        //MSShimmerViewAppearence Appearance { get; set; }

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(void)syncAnimation;
        [Export("syncAnimation")]
        void SyncAnimation();
    }

    // @interface MSShimmerLinesView : MSShimmerView
    [BaseType(typeof(MSShimmerView))]
    [Protocol]
    interface MSShimmerLinesView
    {
        // +(CGSize)sizeThatFits:(CGSize)size appearance:(MSShimmerLinesViewAppearance * _Nonnull)appearance __attribute__((warn_unused_result));
        [Static]
        [Export("sizeThatFits:appearance:")]
        CGSize SizeThatFits(CGSize size, MSShimmerLinesViewAppearance appearance);

        // @property (nonatomic, strong) MSShimmerLinesViewAppearance * _Nonnull shimmerLinesViewAppearance;
        [Export("shimmerLinesViewAppearance", ArgumentSemantic.Strong)]
        MSShimmerLinesViewAppearance ShimmerLinesViewAppearance { get; set; }

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
        [Export("sizeThatFits:")]
        CGSize SizeThatFits(CGSize size);

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }
    }

    // @interface MSShimmerLinesViewAppearance : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    [DisableDefaultCtor]
    interface MSShimmerLinesViewAppearance
    {
        // @property (readonly, nonatomic) NSInteger lineCount;
        [Export("lineCount")]
        nint LineCount { get; }

        // @property (readonly, nonatomic) CGFloat lineHeight;
        [Export("lineHeight")]
        nfloat LineHeight { get; }

        // @property (readonly, nonatomic) CGFloat lineSpacing;
        [Export("lineSpacing")]
        nfloat LineSpacing { get; }

        // @property (readonly, nonatomic) CGFloat firstLineFillPercent;
        [Export("firstLineFillPercent")]
        nfloat FirstLineFillPercent { get; }

        // @property (readonly, nonatomic) CGFloat lastLineFillPercent;
        [Export("lastLineFillPercent")]
        nfloat LastLineFillPercent { get; }

        // -(instancetype _Nonnull)initWithLineCount:(NSInteger)lineCount lineHeight:(CGFloat)lineHeight lineSpacing:(CGFloat)lineSpacing firstLineFillPercent:(CGFloat)firstLineFillPercent lastLineFillPercent:(CGFloat)lastLineFillPercent __attribute__((objc_designated_initializer));
        [Export("initWithLineCount:lineHeight:lineSpacing:firstLineFillPercent:lastLineFillPercent:")]
        [DesignatedInitializer]
        IntPtr Constructor(nint lineCount, nfloat lineHeight, nfloat lineSpacing, nfloat firstLineFillPercent, nfloat lastLineFillPercent);
    }

    // @interface MSShimmerViewAppearence : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    [DisableDefaultCtor]
    interface MSShimmerViewAppearence
    {
        // @property (readonly, nonatomic, strong) UIColor * _Nonnull tintColor;
        [Export("tintColor", ArgumentSemantic.Strong)]
        UIColor TintColor { get; }

        // @property (readonly, nonatomic) CGFloat cornerRadius;
        [Export("cornerRadius")]
        nfloat CornerRadius { get; }

        // @property (readonly, nonatomic) CGFloat labelCornerRadius;
        [Export("labelCornerRadius")]
        nfloat LabelCornerRadius { get; }

        // @property (readonly, nonatomic) BOOL usesTextHeightForLabels;
        [Export("usesTextHeightForLabels")]
        bool UsesTextHeightForLabels { get; }

        // @property (readonly, nonatomic) CGFloat labelHeight;
        [Export("labelHeight")]
        nfloat LabelHeight { get; }

        // -(instancetype _Nonnull)initWithTintColor:(UIColor * _Nonnull)tintColor cornerRadius:(CGFloat)cornerRadius labelCornerRadius:(CGFloat)labelCornerRadius usesTextHeightForLabels:(BOOL)usesTextHeightForLabels labelHeight:(CGFloat)labelHeight __attribute__((objc_designated_initializer));
        [Export("initWithTintColor:cornerRadius:labelCornerRadius:usesTextHeightForLabels:labelHeight:")]
        [DesignatedInitializer]
        IntPtr Constructor(UIColor tintColor, nfloat cornerRadius, nfloat labelCornerRadius, bool usesTextHeightForLabels, nfloat labelHeight);
    }

    // @interface MSTabBarItem : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    [DisableDefaultCtor]
    interface MSTabBarItem
    {
        // @property (readonly, copy, nonatomic) NSString * _Nonnull title;
        [Export("title")]
        string Title { get; }

        // -(instancetype _Nonnull)initWithTitle:(NSString * _Nonnull)title image:(UIImage * _Nonnull)image selectedImage:(UIImage * _Nullable)selectedImage landscapeImage:(UIImage * _Nullable)landscapeImage landscapeSelectedImage:(UIImage * _Nullable)landscapeSelectedImage largeContentImage:(UIImage * _Nullable)largeContentImage __attribute__((objc_designated_initializer));
        [Export("initWithTitle:image:selectedImage:landscapeImage:landscapeSelectedImage:largeContentImage:")]
        [DesignatedInitializer]
        IntPtr Constructor(string title, UIImage image, [NullAllowed] UIImage selectedImage, [NullAllowed] UIImage landscapeImage, [NullAllowed] UIImage landscapeSelectedImage, [NullAllowed] UIImage largeContentImage);
    }

    // @interface MSTabBarView : UIView
    [BaseType(typeof(UIView))]
    [Protocol]
    interface MSTabBarView
    {
        // @property (copy, nonatomic) NSArray<MSTabBarItem *> * _Nonnull items;
        [Export("items", ArgumentSemantic.Copy)]
        MSTabBarItem[] Items { get; set; }

        // @property (nonatomic, strong) MSTabBarItem * _Nullable selectedItem;
        [NullAllowed, Export("selectedItem", ArgumentSemantic.Strong)]
        MSTabBarItem SelectedItem { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MSTabBarViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MSTabBarViewDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(instancetype _Nonnull)initWithShowsItemTitles:(BOOL)showsItemTitles __attribute__((objc_designated_initializer));
        [Export("initWithShowsItemTitles:")]
        [DesignatedInitializer]
        IntPtr Constructor(bool showsItemTitles);

        // -(void)traitCollectionDidChange:(UITraitCollection * _Nullable)previousTraitCollection;
        [Export("traitCollectionDidChange:")]
        void TraitCollectionDidChange([NullAllowed] UITraitCollection previousTraitCollection);
    }

    // @protocol MSTabBarViewDelegate
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MSTabBarViewDelegate
    {
        // @optional -(void)tabBarView:(MSTabBarView * _Nonnull)tabBarView didSelect:(MSTabBarItem * _Nonnull)item;
        [Export("tabBarView:didSelect:")]
        void DidSelect(MSTabBarView tabBarView, MSTabBarItem item);
    }

    // @interface MSTableViewHeaderFooterView : UITableViewHeaderFooterView
    [BaseType(typeof(UITableViewHeaderFooterView))]
    [Protocol]
    interface MSTableViewHeaderFooterView
    {
        // @property (readonly, copy, nonatomic, class) NSString * _Nonnull identifier;
        [Static]
        [Export("identifier")]
        string Identifier { get; }

        // +(CGFloat)heightWithStyle:(enum MSTableViewHeaderFooterViewStyle)style title:(NSString * _Nonnull)title titleNumberOfLines:(NSInteger)titleNumberOfLines containerWidth:(CGFloat)containerWidth __attribute__((warn_unused_result));
        [Static]
        [Export("heightWithStyle:title:titleNumberOfLines:containerWidth:")]
        nfloat HeightWithStyle(MSTableViewHeaderFooterViewStyle style, string title, nint titleNumberOfLines, nfloat containerWidth);

        // +(CGFloat)preferredWidthWithStyle:(enum MSTableViewHeaderFooterViewStyle)style title:(NSString * _Nonnull)title accessoryButton:(UIButton * _Nullable)accessoryButton __attribute__((warn_unused_result));
        [Static]
        [Export("preferredWidthWithStyle:title:accessoryButton:")]
        nfloat PreferredWidthWithStyle(MSTableViewHeaderFooterViewStyle style, string title, [NullAllowed] UIButton accessoryButton);

        // @property (nonatomic) enum MSTableViewHeaderFooterViewAccessoryButtonStyle accessoryButtonStyle;
        [Export("accessoryButtonStyle", ArgumentSemantic.Assign)]
        MSTableViewHeaderFooterViewAccessoryButtonStyle AccessoryButtonStyle { get; set; }

        // @property (nonatomic) NSInteger titleNumberOfLines;
        [Export("titleNumberOfLines")]
        nint TitleNumberOfLines { get; set; }

        // @property (copy, nonatomic) void (^ _Nullable)(void) onAccessoryButtonTapped;
        [NullAllowed, Export("onAccessoryButtonTapped", ArgumentSemantic.Copy)]
        Action OnAccessoryButtonTapped { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MSTableViewHeaderFooterViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MSTableViewHeaderFooterViewDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // @property (readonly, nonatomic) CGSize intrinsicContentSize;
        [Export("intrinsicContentSize")]
        CGSize IntrinsicContentSize { get; }

        // @property (nonatomic) CGRect bounds;
        [Export("bounds", ArgumentSemantic.Assign)]
        CGRect Bounds { get; set; }

        // @property (nonatomic) CGRect frame;
        [Export("frame", ArgumentSemantic.Assign)]
        CGRect Frame { get; set; }

        // -(instancetype _Nonnull)initWithReuseIdentifier:(NSString * _Nullable)reuseIdentifier __attribute__((objc_designated_initializer));
        [Export("initWithReuseIdentifier:")]
        [DesignatedInitializer]
        IntPtr Constructor([NullAllowed] string reuseIdentifier);

        // -(void)setupWithStyle:(enum MSTableViewHeaderFooterViewStyle)style title:(NSString * _Nonnull)title accessoryButtonTitle:(NSString * _Nonnull)accessoryButtonTitle;
        [Export("setupWithStyle:title:accessoryButtonTitle:")]
        void SetupWithStyle(MSTableViewHeaderFooterViewStyle style, string title, string accessoryButtonTitle);

        // -(void)setupWithStyle:(enum MSTableViewHeaderFooterViewStyle)style attributedTitle:(NSAttributedString * _Nonnull)attributedTitle accessoryButtonTitle:(NSString * _Nonnull)accessoryButtonTitle;
        [Export("setupWithStyle:attributedTitle:accessoryButtonTitle:")]
        void SetupWithStyle(MSTableViewHeaderFooterViewStyle style, NSAttributedString attributedTitle, string accessoryButtonTitle);

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // -(void)prepareForReuse __attribute__((objc_requires_super));
        [Export("prepareForReuse")]
        [RequiresSuper]
        void PrepareForReuse();

        // -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
        [Export("sizeThatFits:")]
        CGSize SizeThatFits(CGSize size);
    }

    // @protocol MSTableViewHeaderFooterViewDelegate
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MSTableViewHeaderFooterViewDelegate
    {
        // @optional -(BOOL)headerFooterView:(MSTableViewHeaderFooterView * _Nonnull)headerFooterView shouldInteractWith:(NSURL * _Nonnull)URL in:(NSRange)characterRange interaction:(UITextItemInteraction)interaction __attribute__((warn_unused_result));
        [Export("headerFooterView:shouldInteractWith:in:interaction:")]
        bool ShouldInteractWith(MSTableViewHeaderFooterView headerFooterView, NSUrl URL, NSRange characterRange, UITextItemInteraction interaction);
    }

    // @interface MSTooltip : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    [DisableDefaultCtor]
    interface MSTooltip
    {
        // @property (readonly, nonatomic, class) UIEdgeInsets defaultScreenMargins;
        [Static]
        [Export("defaultScreenMargins")]
        UIEdgeInsets DefaultScreenMargins { get; }

        // @property (readonly, nonatomic, strong, class) MSTooltip * _Nonnull shared;
        [Static]
        [Export("shared", ArgumentSemantic.Strong)]
        MSTooltip Shared { get; }

        // @property (nonatomic) NSTextAlignment textAlignment;
        [Export("textAlignment", ArgumentSemantic.Assign)]
        NSTextAlignment TextAlignment { get; set; }

        // @property (readonly, nonatomic) BOOL isShowing;
        [Export("isShowing")]
        bool IsShowing { get; }

        // -(void)showWith:(NSString * _Nonnull)message for:(UIView * _Nonnull)anchorView preferredArrowDirection:(enum MSTooltipArrowDirection)preferredArrowDirection offset:(CGPoint)offset screenMargins:(UIEdgeInsets)screenMargins dismissOn:(enum MSTooltipDismissMode)dismissMode onTap:(void (^ _Nullable)(void))onTap;
        [Export("showWith:for:preferredArrowDirection:offset:screenMargins:dismissOn:onTap:")]
        void ShowWith(string message, UIView anchorView, MSTooltipArrowDirection preferredArrowDirection, CGPoint offset, UIEdgeInsets screenMargins, MSTooltipDismissMode dismissMode, [NullAllowed] Action onTap);

        // -(void)hide;
        [Export("hide")]
        void Hide();
    }

    // @interface MSTouchForwardingView : UIView
    [BaseType(typeof(UIView))]
    [Protocol]
    interface MSTouchForwardingView
    {
        // -(BOOL)pointInside:(CGPoint)point withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result));
        [Export("pointInside:withEvent:")]
        bool PointInside(CGPoint point, [NullAllowed] UIEvent @event);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);
    }

    // @interface MSTwoLineTitleView : UIView
    [BaseType(typeof(UIView))]
    [Protocol]
    interface MSTwoLineTitleView
    {
        // @property (copy, nonatomic) NSString * _Nullable titleAccessibilityHint;
        [NullAllowed, Export("titleAccessibilityHint")]
        string TitleAccessibilityHint { get; set; }

        // @property (nonatomic) UIAccessibilityTraits titleAccessibilityTraits;
        [Export("titleAccessibilityTraits")]
        ulong TitleAccessibilityTraits { get; set; }

        // @property (copy, nonatomic) NSString * _Nullable subtitleAccessibilityHint;
        [NullAllowed, Export("subtitleAccessibilityHint")]
        string SubtitleAccessibilityHint { get; set; }

        // @property (nonatomic) UIAccessibilityTraits subtitleAccessibilityTraits;
        [Export("subtitleAccessibilityTraits")]
        ulong SubtitleAccessibilityTraits { get; set; }

        [Wrap("WeakDelegate")]
        [NullAllowed]
        MSTwoLineTitleViewDelegate Delegate { get; set; }

        // @property (nonatomic, weak) id<MSTwoLineTitleViewDelegate> _Nullable delegate;
        [NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
        NSObject WeakDelegate { get; set; }

        // -(instancetype _Nonnull)initWithStyle:(enum MSTwoLineTitleViewStyle)style;
        [Export("initWithStyle:")]
        IntPtr Constructor(MSTwoLineTitleViewStyle style);

        // -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
        [Export("initWithFrame:")]
        [DesignatedInitializer]
        IntPtr Constructor(CGRect frame);

        // -(void)setupWithTitle:(NSString * _Nonnull)title subtitle:(NSString * _Nullable)subtitle interactivePart:(enum MSTwoLineTitleViewInteractivePart)interactivePart accessoryType:(enum MSTwoLineTitleViewAccessoryType)accessoryType;
        [Export("setupWithTitle:subtitle:interactivePart:accessoryType:")]
        void SetupWithTitle(string title, [NullAllowed] string subtitle, MSTwoLineTitleViewInteractivePart interactivePart, MSTwoLineTitleViewAccessoryType accessoryType);

        // -(CGSize)sizeThatFits:(CGSize)size __attribute__((warn_unused_result));
        [Export("sizeThatFits:")]
        CGSize SizeThatFits(CGSize size);

        // -(void)layoutSubviews;
        [Export("layoutSubviews")]
        void LayoutSubviews();

        // @property (nonatomic) BOOL isAccessibilityElement;
        [Export("isAccessibilityElement")]
        bool IsAccessibilityElement { get; set; }

        // -(NSInteger)accessibilityElementCount __attribute__((warn_unused_result));
        [Export("accessibilityElementCount")]
        nint AccessibilityElementCount { get; }

        // -(id _Nullable)accessibilityElementAtIndex:(NSInteger)index __attribute__((warn_unused_result));
        [Export("accessibilityElementAtIndex:")]
        [
            return: NullAllowed
        ]
        NSObject AccessibilityElementAtIndex(nint index);

        // -(NSInteger)indexOfAccessibilityElement:(id _Nonnull)element __attribute__((warn_unused_result));
        [Export("indexOfAccessibilityElement:")]
        nint IndexOfAccessibilityElement(NSObject element);
    }

    // @protocol MSTwoLineTitleViewDelegate
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MSTwoLineTitleViewDelegate
    {
        // @required -(void)twoLineTitleViewDidTapOnTitle:(MSTwoLineTitleView * _Nonnull)twoLineTitleView;
        [Abstract]
        [Export("twoLineTitleViewDidTapOnTitle:")]
        void TwoLineTitleViewDidTapOnTitle(MSTwoLineTitleView twoLineTitleView);
    }

    // @interface OfficeUIFabricFramework : NSObject
    [BaseType(typeof(NSObject))]
    [Protocol]
    interface OfficeUIFabricFramework
    {
        // @property (readonly, nonatomic, strong, class) NSBundle * _Nonnull bundle;
        [Static]
        [Export("bundle", ArgumentSemantic.Strong)]
        NSBundle Bundle { get; }

        // @property (readonly, nonatomic, strong, class) NSBundle * _Nonnull resourceBundle;
        [Static]
        [Export("resourceBundle", ArgumentSemantic.Strong)]
        NSBundle ResourceBundle { get; }

        // @property (nonatomic, class) BOOL usesFluentIcons;
        [Static]
        [Export("usesFluentIcons")]
        bool UsesFluentIcons { get; set; }

        // +(void)initializeAppearance;
        [Static]
        [Export("initializeAppearance")]
        void InitializeAppearance();
    }
}