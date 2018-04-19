using System;

using UIKit;

namespace TipCalculator
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            int sValue = (int)serviceSlider.Value;
            tipPercetageOutputLabel.Text = sValue.ToString();
            taxToggle.On = false;
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void checkAmountInputTextField_ValueChanged(UITextField sender)
        {
            if (sender.Text != "")
            {
                decimal? taxPercent = Convert.ToDecimal (sender.Text) / 100;
                decimal? tipPercent = Convert.ToDecimal (tipPercetageOutputLabel.Text) / 100;
                decimal? checkAmount = Convert.ToDecimal (checkAmountInputTextField.Text);
                decimal? taxAmount = taxPercent * checkAmount;
                decimal? tipAmount = tipPercent * checkAmount;
                tipAmountOutputLabel.Text = tipAmount.ToString();
                taxAmountOutputLabel.Text = (taxPercent * checkAmount).ToString();
                totalCheckAmountOutputLabel.Text = (checkAmount + tipAmount + taxAmount).ToString();
            }
        }

        partial void taxPercentInputTextField_ValueChanged(UITextField sender)
        {
            if(sender.Text != "")
            {
                int? taxPercent = Convert.ToInt32(sender.Text) / 100;
                int? tipPercent = Convert.ToInt32(tipPercetageOutputLabel.Text) / 100;
                int? checkAmount = Convert.ToInt32(checkAmountInputTextField.Text);
                int? taxAmount = taxPercent * checkAmount;
                int? tipAmount = tipPercent * checkAmount;
                tipAmountOutputLabel.Text = tipAmount.ToString();
                taxAmountOutputLabel.Text = (taxPercent * checkAmount).ToString();
                totalCheckAmountOutputLabel.Text = checkAmount + tipAmount + taxAmount.ToString();
            }
        }

        partial void serviceSlider_ValueChanged(UISlider sender)
        {
            int sValue = (int)sender.Value;
            tipPercetageOutputLabel.Text = sValue.ToString();
        }

        partial void taxToggle_ValueChanged(UISwitch sender)
        {
            if(sender.On)
            {
                taxPercentInputTextField.Enabled = true;
                taxPercentInputTextField.Text = "5";
            }
            else
            {
                taxPercentInputTextField.Enabled = false;
                taxPercentInputTextField.Text = "";
                taxAmountOutputLabel.Text = "";
            }
        }
    }
}