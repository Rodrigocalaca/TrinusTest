using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Media;
using System.Threading.Tasks;
using System.Windows.Controls;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace TrinusTest
{
    public static class AttachedProperties
    {
        [AttachedPropertyBrowsableForType(typeof(Button))]
        public static CornerRadius GetCornerRadius(DependencyObject obj)
        {
            return (CornerRadius)obj.GetValue(CornerRadiusProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(Button))]
        public static void SetCornerRadius(DependencyObject obj, CornerRadius value)
        {
            obj.SetValue(CornerRadiusProperty, value);
        }
        
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.RegisterAttached("CornerRadius", typeof(CornerRadius), typeof(AttachedProperties), new PropertyMetadata(default(CornerRadius)));


        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static Brush GetFocusBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(FocusBorderBrushProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static void SetFocusBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(FocusBorderBrushProperty, value);
        }

        public static readonly DependencyProperty FocusBorderBrushProperty =
            DependencyProperty.RegisterAttached("FocusBorderBrush", typeof(Brush), typeof(AttachedProperties), new PropertyMetadata(null));


        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static Brush GetMouseOverBorderBrush(DependencyObject obj)
        {
            return (Brush)obj.GetValue(MouseOverBorderBrushProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static void SetMouseOverBorderBrush(DependencyObject obj, Brush value)
        {
            obj.SetValue(MouseOverBorderBrushProperty, value);
        }

        public static readonly DependencyProperty MouseOverBorderBrushProperty =
            DependencyProperty.RegisterAttached("MouseOverBorderBrush", typeof(Brush), typeof(AttachedProperties), new PropertyMetadata(null));


        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static Brush GetFocusBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(FocusBackgroundProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static void SetFocusBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(FocusBackgroundProperty, value);
        }

        public static readonly DependencyProperty FocusBackgroundProperty =
            DependencyProperty.RegisterAttached("FocusBackground", typeof(Brush), typeof(AttachedProperties), new PropertyMetadata(null));


        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static Brush GetMouseOverBackground(DependencyObject obj)
        {
            return (Brush)obj.GetValue(MouseOverBackgroundProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static void SetMouseOverBackground(DependencyObject obj, Brush value)
        {
            obj.SetValue(MouseOverBackgroundProperty, value);
        }

        public static readonly DependencyProperty MouseOverBackgroundProperty =
            DependencyProperty.RegisterAttached("MouseOverBackground", typeof(Brush), typeof(AttachedProperties), new PropertyMetadata(null));


        [AttachedPropertyBrowsableForType(typeof(Button))]
        public static double GetButtonFontSize(DependencyObject obj)
        {
            return (double)obj.GetValue(ButtonFontSizeProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(Button))]
        public static void SetButtonFontSize(DependencyObject obj, double value)
        {
            obj.SetValue(ButtonFontSizeProperty, value);
        }

        public static readonly DependencyProperty ButtonFontSizeProperty =
            DependencyProperty.RegisterAttached("ButtonFontSize", typeof(double), typeof(AttachedProperties), new PropertyMetadata(12.0));


        [AttachedPropertyBrowsableForType(typeof(Button))]
        public static double GetButtonWidth(DependencyObject obj)
        {
            return (double)obj.GetValue(ButtonWidthProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(Button))]
        public static void SetButtonWidth(DependencyObject obj, double value)
        {
            obj.SetValue(ButtonWidthProperty, value);
        }

        public static readonly DependencyProperty ButtonWidthProperty =
            DependencyProperty.RegisterAttached("ButtonWidth", typeof(double), typeof(AttachedProperties), new PropertyMetadata(default(double)));


        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static bool GetIsMonitoring(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsMonitoringProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static void SetIsMonitoring(DependencyObject obj, bool value)
        {
            obj.SetValue(IsMonitoringProperty, value);
        }

        public static readonly DependencyProperty IsMonitoringProperty =
            DependencyProperty.RegisterAttached("IsMonitoring", typeof(bool), typeof(AttachedProperties), new PropertyMetadata(default(bool)));


        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static bool GetIsSpellCheckContextMenuEnabled(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsSpellCheckContextMenuEnabledProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static void SetIsSpellCheckContextMenuEnabled(DependencyObject obj, bool value)
        {
            obj.SetValue(IsSpellCheckContextMenuEnabledProperty, value);
        }

        public static readonly DependencyProperty IsSpellCheckContextMenuEnabledProperty =
            DependencyProperty.RegisterAttached("IsSpellCheckContextMenuEnabled", typeof(bool), typeof(AttachedProperties), new PropertyMetadata(default(bool)));


        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static TextWrapping GetWatermarkWrapping(DependencyObject obj)
        {
            return (TextWrapping)obj.GetValue(WatermarkWrappingProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static void SetWatermarkWrapping(DependencyObject obj, TextWrapping value)
        {
            obj.SetValue(WatermarkWrappingProperty, value);
        }

        public static readonly DependencyProperty WatermarkWrappingProperty =
            DependencyProperty.RegisterAttached("WatermarkWrapping", typeof(TextWrapping), typeof(AttachedProperties), new PropertyMetadata(default(TextWrapping)));


        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static bool GetUsePrefix(DependencyObject obj)
        {
            return (bool)obj.GetValue(UsePrefixProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static void SetUsePrefix(DependencyObject obj, bool value)
        {
            obj.SetValue(UsePrefixProperty, value);
        }

        public static readonly DependencyProperty UsePrefixProperty =
            DependencyProperty.RegisterAttached("UsePrefix", typeof(bool), typeof(AttachedProperties), new PropertyMetadata(default(bool)));


        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static bool GetUseSuffix(DependencyObject obj)
        {
            return (bool)obj.GetValue(UseSuffixProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static void SetUseSuffix(DependencyObject obj, bool value)
        {
            obj.SetValue(UseSuffixProperty, value);
        }

        public static readonly DependencyProperty UseSuffixProperty =
            DependencyProperty.RegisterAttached("UseSuffix", typeof(bool), typeof(AttachedProperties), new PropertyMetadata(default(bool)));


        [AttachedPropertyBrowsableForType(typeof(Button))]
        public static bool GetClearTextButton(DependencyObject obj)
        {
            return (bool)obj.GetValue(ClearTextButtonProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(Button))]
        public static void SetClearTextButton(DependencyObject obj, bool value)
        {
            obj.SetValue(ClearTextButtonProperty, value);
        }

        public static readonly DependencyProperty ClearTextButtonProperty =
            DependencyProperty.RegisterAttached("ClearTextButton", typeof(bool), typeof(AttachedProperties), new PropertyMetadata(default(bool)));


        [AttachedPropertyBrowsableForType(typeof(Button))]
        public static bool GetIsClearTextButtonBehaviorEnabled(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsClearTextButtonBehaviorEnabledProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(Button))]
        public static void SetIsClearTextButtonBehaviorEnabled(DependencyObject obj, bool value)
        {
            obj.SetValue(IsClearTextButtonBehaviorEnabledProperty, value);
        }

        public static readonly DependencyProperty IsClearTextButtonBehaviorEnabledProperty =
            DependencyProperty.RegisterAttached("IsClearTextButtonBehaviorEnabled", typeof(bool), typeof(AttachedProperties), new PropertyMetadata(default(bool)));


        [AttachedPropertyBrowsableForType(typeof(Button))]
        public static bool GetDisabledVisualElementVisibility(DependencyObject obj)
        {
            return (bool)obj.GetValue(DisabledVisualElementVisibilityProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(Button))]
        public static void SetDisabledVisualElementVisibility(DependencyObject obj, bool value)
        {
            obj.SetValue(DisabledVisualElementVisibilityProperty, value);
        }

        public static readonly DependencyProperty DisabledVisualElementVisibilityProperty =
            DependencyProperty.RegisterAttached("DisabledVisualElementVisibility", typeof(bool), typeof(AttachedProperties), new PropertyMetadata(default(bool)));


        [AttachedPropertyBrowsableForType(typeof(Button))]
        public static bool GetHasText(DependencyObject obj)
        {
            return (bool)obj.GetValue(HasTextProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(Button))]
        public static void SetHasText(DependencyObject obj, bool value)
        {
            obj.SetValue(HasTextProperty, value);
        }

        public static readonly DependencyProperty HasTextProperty =
            DependencyProperty.RegisterAttached("HasText", typeof(bool), typeof(AttachedProperties), new PropertyMetadata(default(bool)));


        [AttachedPropertyBrowsableForType(typeof(Button))]
        public static HorizontalAlignment GetButtonsAlignment(DependencyObject obj)
        {
            return (HorizontalAlignment)obj.GetValue(ButtonsAlignmentProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(Button))]
        public static void SetButtonsAlignment(DependencyObject obj, HorizontalAlignment value)
        {
            obj.SetValue(ButtonsAlignmentProperty, value);
        }

        public static readonly DependencyProperty ButtonsAlignmentProperty =
            DependencyProperty.RegisterAttached("ButtonsAlignment", typeof(HorizontalAlignment), typeof(AttachedProperties), new PropertyMetadata(default(HorizontalAlignment)));


        [AttachedPropertyBrowsableForType(typeof(Button))]
        public static bool GetUseFloatingWatermark(DependencyObject obj)
        {
            return (bool)obj.GetValue(UseFloatingWatermarkProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(Button))]
        public static void SetUseFloatingWatermark(DependencyObject obj, bool value)
        {
            obj.SetValue(UseFloatingWatermarkProperty, value);
        }

        public static readonly DependencyProperty UseFloatingWatermarkProperty =
            DependencyProperty.RegisterAttached("UseFloatingWatermark", typeof(bool), typeof(AttachedProperties), new PropertyMetadata(default(bool)));


        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static bool GetIsWaitingForData(DependencyObject obj)
        {
            return (bool)obj.GetValue(IsWaitingForDataProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(TextBox))]
        public static void SetIsWaitingForData(DependencyObject obj, bool value)
        {
            obj.SetValue(IsWaitingForDataProperty, value);
        }

        public static readonly DependencyProperty IsWaitingForDataProperty =
            DependencyProperty.RegisterAttached("IsWaitingForData", typeof(bool), typeof(AttachedProperties), new PropertyMetadata(default(bool)));


        [AttachedPropertyBrowsableForType(typeof(TextBlock))]
        public static string GetPrefix(DependencyObject obj)
        {
            return (string)obj.GetValue(PrefixProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(TextBlock))]
        public static void SetPrefix(DependencyObject obj, string value)
        {
            obj.SetValue(PrefixProperty, value);
        }

        public static readonly DependencyProperty PrefixProperty =
            DependencyProperty.RegisterAttached("Prefix", typeof(string), typeof(AttachedProperties), new PropertyMetadata(default(string)));


        [AttachedPropertyBrowsableForType(typeof(TextBlock))]
        public static string GetSuffix(DependencyObject obj)
        {
            return (string)obj.GetValue(SuffixProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(TextBlock))]
        public static void SetSuffix(DependencyObject obj, string value)
        {
            obj.SetValue(SuffixProperty, value);
        }

        public static readonly DependencyProperty SuffixProperty =
            DependencyProperty.RegisterAttached("Suffix", typeof(string), typeof(AttachedProperties), new PropertyMetadata(default(string)));




        [AttachedPropertyBrowsableForType(typeof(TextBlock))]
        public static string GetWatermark(DependencyObject obj)
        {
            return (string)obj.GetValue(WatermarkProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(TextBlock))]
        public static void SetWatermark(DependencyObject obj, string value)
        {
            obj.SetValue(WatermarkProperty, value);
        }

        public static readonly DependencyProperty WatermarkProperty =
            DependencyProperty.RegisterAttached("Watermark", typeof(string), typeof(AttachedProperties), new PropertyMetadata(default(string)));


        [AttachedPropertyBrowsableForType(typeof(TextBlock))]
        public static HorizontalAlignment GetWatermarkAlignment(DependencyObject obj)
        {
            return (HorizontalAlignment)obj.GetValue(WatermarkAlignmentProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(TextBlock))]
        public static void SetWatermarkAlignment(DependencyObject obj, HorizontalAlignment value)
        {
            obj.SetValue(WatermarkAlignmentProperty, value);
        }

        public static readonly DependencyProperty WatermarkAlignmentProperty =
            DependencyProperty.RegisterAttached("WatermarkAlignment", typeof(HorizontalAlignment), typeof(AttachedProperties), new PropertyMetadata(default(HorizontalAlignment)));


        [AttachedPropertyBrowsableForType(typeof(TextBlock))]
        public static TextTrimming GetWatermarkTrimming(DependencyObject obj)
        {
            return (TextTrimming)obj.GetValue(WatermarkTrimmingProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(TextBlock))]
        public static void SetWatermarkTrimming(DependencyObject obj, TextTrimming value)
        {
            obj.SetValue(WatermarkTrimmingProperty, value);
        }

        public static readonly DependencyProperty WatermarkTrimmingProperty =
            DependencyProperty.RegisterAttached("WatermarkTrimming", typeof(TextTrimming), typeof(AttachedProperties), new PropertyMetadata(default(TextTrimming)));


        [AttachedPropertyBrowsableForType(typeof(Button))]
        public static string GetButtonContent(DependencyObject obj)
        {
            return (string)obj.GetValue(ButtonContentProperty);
        }

        [AttachedPropertyBrowsableForType(typeof(Button))]
        public static void SetButtonContent(DependencyObject obj, string value)
        {
            obj.SetValue(ButtonContentProperty, value);
        }

        public static readonly DependencyProperty ButtonContentProperty =
            DependencyProperty.RegisterAttached("ButtonContent", typeof(string), typeof(AttachedProperties), new PropertyMetadata(default(string)));


    }
}
