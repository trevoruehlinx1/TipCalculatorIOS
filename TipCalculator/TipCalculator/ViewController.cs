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
                if(taxToggle.On)
                {
                    decimal? taxPercent = Convert.ToDecimal(taxPercentInputTextField.Text) / 100;
                    decimal? tipPercent = Convert.ToDecimal(tipPercetageOutputLabel.Text) / 100;
                    decimal? checkAmount = Convert.ToDecimal(checkAmountInputTextField.Text);
                    decimal? taxAmount = taxPercent * checkAmount;
                    decimal? tipAmount = tipPercent * checkAmount;

                    string tipMoneyValue = String.Format("{0:C}", tipAmount);
                    string taxMoneyValue = String.Format("{0:C}", taxAmount);
                    string totalCheckMoneyValue = String.Format("{0:C}", checkAmount + tipAmount + taxAmount);

                    tipAmountOutputLabel.Text = tipMoneyValue.ToString();
                    totalCheckAmountOutputLabel.Text = totalCheckMoneyValue.ToString();
                    taxAmountOutputLabel.Text = taxMoneyValue.ToString();
                }
                else
                {
                    decimal? taxPercent = 0;
                    decimal? tipPercent = Convert.ToDecimal(tipPercetageOutputLabel.Text) / 100;
                    decimal? checkAmount = Convert.ToDecimal(checkAmountInputTextField.Text);
                    decimal? taxAmount = taxPercent * checkAmount;
                    decimal? tipAmount = tipPercent * checkAmount;

                    string tipMoneyValue = String.Format("{0:C}", tipAmount);
                    string taxMoneyValue = String.Format("{0:C}", taxAmount);
                    string totalCheckMoneyValue = String.Format("{0:C}", checkAmount + tipAmount + taxAmount);

                    tipAmountOutputLabel.Text = tipMoneyValue.ToString();
                    totalCheckAmountOutputLabel.Text = totalCheckMoneyValue.ToString();
                    taxAmountOutputLabel.Text = taxMoneyValue.ToString();
                }
            }
        }

        partial void taxPercentInputTextField_ValueChanged(UITextField sender)
        {
            if (sender.Text != "")
            {
                decimal? taxPercent = Convert.ToDecimal(checkAmountInputTextField.Text) / 100;
                decimal? tipPercent = Convert.ToDecimal(tipPercetageOutputLabel.Text) / 100;
                decimal? checkAmount = Convert.ToDecimal(checkAmountInputTextField.Text);
                decimal? taxAmount = taxPercent * checkAmount;
                decimal? tipAmount = tipPercent * checkAmount;
                tipAmountOutputLabel.Text = tipAmount.ToString();
                taxAmountOutputLabel.Text = (taxPercent * checkAmount).ToString();
                totalCheckAmountOutputLabel.Text = (checkAmount + tipAmount + taxAmount).ToString();
            }
        }

        partial void serviceSlider_ValueChanged(UISlider sender)
        {
            int sValue = (int)sender.Value;
            tipPercetageOutputLabel.Text = sValue.ToString();
                if(taxToggle.On)
                {
                    decimal? taxPercent = Convert.ToDecimal(taxPercentInputTextField.Text) / 100;
                    decimal? tipPercent = Convert.ToDecimal(tipPercetageOutputLabel.Text) / 100;
                    decimal? checkAmount = Convert.ToDecimal(checkAmountInputTextField.Text);
                    decimal? taxAmount = taxPercent * checkAmount;
                    decimal? tipAmount = tipPercent * checkAmount;

                    string tipMoneyValue = String.Format("{0:C}", tipAmount);
                    string taxMoneyValue = String.Format("{0:C}", taxAmount);
                    string totalCheckMoneyValue = String.Format("{0:C}", checkAmount + tipAmount + taxAmount);

                    tipAmountOutputLabel.Text = tipMoneyValue.ToString();
                    totalCheckAmountOutputLabel.Text = totalCheckMoneyValue.ToString();
                    taxAmountOutputLabel.Text = taxMoneyValue.ToString();
                }
                else
                {
                    decimal? taxPercent = 0;
                    decimal? tipPercent = Convert.ToDecimal(tipPercetageOutputLabel.Text) / 100;
                    decimal? checkAmount = Convert.ToDecimal(checkAmountInputTextField.Text);
                    decimal? taxAmount = taxPercent * checkAmount;
                    decimal? tipAmount = tipPercent * checkAmount;

                    string tipMoneyValue = String.Format("{0:C}", tipAmount);
                    string taxMoneyValue = String.Format("{0:C}", taxAmount);
                    string totalCheckMoneyValue = String.Format("{0:C}", checkAmount + tipAmount + taxAmount);

                    tipAmountOutputLabel.Text = tipMoneyValue.ToString();
                    totalCheckAmountOutputLabel.Text = totalCheckMoneyValue.ToString();
                    taxAmountOutputLabel.Text = taxMoneyValue.ToString();
                }
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