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
        UIKit.UITextField checkAmountInputTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider serviceSlider { get; set; }

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

        void ReleaseDesignerOutlets ()
        {
            if (checkAmountInputTextField != null) {
                checkAmountInputTextField.Dispose ();
                checkAmountInputTextField = null;
            }

            if (serviceSlider != null) {
                serviceSlider.Dispose ();
                serviceSlider = null;
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