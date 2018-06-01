// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace TipCalculator
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel CheckAmountDenomLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField checkAmountInputTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider serviceSlider { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SettingsButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel taxAmountOutputLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField taxPercentInputTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch taxToggle { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel tipAmountOutputLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel tipPercetageOutputLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel totalCheckAmountOutputLabel { get; set; }

        [Action ("checkAmountInputTextField_ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void checkAmountInputTextField_ValueChanged (UIKit.UITextField sender);

        [Action ("serviceSlider_ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void serviceSlider_ValueChanged (UIKit.UISlider sender);

        [Action ("SettingsButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SettingsButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("taxPercentInputTextField_ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void taxPercentInputTextField_ValueChanged (UIKit.UITextField sender);

        [Action ("taxToggle_ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void taxToggle_ValueChanged (UIKit.UISwitch sender);

        void ReleaseDesignerOutlets ()
        {
            if (CheckAmountDenomLabel != null) {
                CheckAmountDenomLabel.Dispose ();
                CheckAmountDenomLabel = null;
            }

            if (checkAmountInputTextField != null) {
                checkAmountInputTextField.Dispose ();
                checkAmountInputTextField = null;
            }

            if (serviceSlider != null) {
                serviceSlider.Dispose ();
                serviceSlider = null;
            }

            if (SettingsButton != null) {
                SettingsButton.Dispose ();
                SettingsButton = null;
            }

            if (taxAmountOutputLabel != null) {
                taxAmountOutputLabel.Dispose ();
                taxAmountOutputLabel = null;
            }

            if (taxPercentInputTextField != null) {
                taxPercentInputTextField.Dispose ();
                taxPercentInputTextField = null;
            }

            if (taxToggle != null) {
                taxToggle.Dispose ();
                taxToggle = null;
            }

            if (tipAmountOutputLabel != null) {
                tipAmountOutputLabel.Dispose ();
                tipAmountOutputLabel = null;
            }

            if (tipPercetageOutputLabel != null) {
                tipPercetageOutputLabel.Dispose ();
                tipPercetageOutputLabel = null;
            }

            if (totalCheckAmountOutputLabel != null) {
                totalCheckAmountOutputLabel.Dispose ();
                totalCheckAmountOutputLabel = null;
            }
        }
    }
}