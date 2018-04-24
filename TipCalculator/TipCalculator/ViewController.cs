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
            decimal? taxAmount = 0;
            decimal? tipAmount = 0;
            decimal? totalCheckAmount = 0;
            TipCalculator tc = new TipCalculator();
            if (sender.Text != "")
            {
                if(taxToggle.On)
                {
                    decimal? taxPercent = Convert.ToDecimal(taxPercentInputTextField.Text) / 100;
                    decimal? tipPercent = Convert.ToDecimal(tipPercetageOutputLabel.Text) / 100;
                    decimal? checkAmount = Convert.ToDecimal(checkAmountInputTextField.Text);
                    taxAmount = tc.GetTaxAmount(taxPercent, checkAmount);
                    tipAmount = tc.GetTipAmount(tipPercent, checkAmount);
                    totalCheckAmount = tc.GetTotalCheckAmount(tipAmount, taxAmount, checkAmount);

                    string tipMoneyValue = String.Format("{0:C}", tipAmount);
                    string taxMoneyValue = String.Format("{0:C}", taxAmount);
                    string totalCheckMoneyValue = String.Format("{0:C}", totalCheckAmount);

                    tipAmountOutputLabel.Text = tipMoneyValue.ToString();
                    totalCheckAmountOutputLabel.Text = totalCheckMoneyValue.ToString();
                    taxAmountOutputLabel.Text = taxMoneyValue.ToString();
                }
                else
                {
                    decimal? taxPercent = 0;
                    decimal? tipPercent = Convert.ToDecimal(tipPercetageOutputLabel.Text) / 100;
                    decimal? checkAmount = Convert.ToDecimal(checkAmountInputTextField.Text);
                    taxAmount = tc.GetTaxAmount(taxPercent, checkAmount);
                    tipAmount = tc.GetTipAmount(tipPercent, checkAmount);
                    totalCheckAmount = tc.GetTotalCheckAmount(tipAmount, taxAmount, checkAmount);

                    string tipMoneyValue = String.Format("{0:C}", tipAmount);
                    string taxMoneyValue = String.Format("{0:C}", taxAmount);
                    string totalCheckMoneyValue = String.Format("{0:C}", totalCheckAmount);

                    tipAmountOutputLabel.Text = tipMoneyValue.ToString();
                    totalCheckAmountOutputLabel.Text = totalCheckMoneyValue.ToString();
                    taxAmountOutputLabel.Text = taxMoneyValue.ToString();
                }
            }
        }

        partial void taxPercentInputTextField_ValueChanged(UITextField sender)
        {
            decimal? taxAmount = 0;
            decimal? tipAmount = 0;
            decimal? totalCheckAmount = 0;
            TipCalculator tc = new TipCalculator();
            if (sender.Text != "")
            {
                decimal? taxPercent = Convert.ToDecimal(taxPercentInputTextField.Text) / 100;
                decimal? tipPercent = Convert.ToDecimal(tipPercetageOutputLabel.Text) / 100;
                decimal? checkAmount = Convert.ToDecimal(checkAmountInputTextField.Text);
                taxAmount = tc.GetTaxAmount(taxPercent, checkAmount);
                tipAmount = tc.GetTipAmount(tipPercent, checkAmount);
                totalCheckAmount = tc.GetTotalCheckAmount(tipAmount, taxAmount, checkAmount);

                string tipMoneyValue = String.Format("{0:C}", tipAmount);
                string taxMoneyValue = String.Format("{0:C}", taxAmount);
                string totalCheckMoneyValue = String.Format("{0:C}", totalCheckAmount);

                tipAmountOutputLabel.Text = tipMoneyValue.ToString();
                totalCheckAmountOutputLabel.Text = totalCheckMoneyValue.ToString();
                taxAmountOutputLabel.Text = taxMoneyValue.ToString();
            }
        }

        partial void serviceSlider_ValueChanged(UISlider sender)
        {
            decimal? taxAmount = 0;
            decimal? tipAmount = 0;
            decimal? totalCheckAmount = 0;
            TipCalculator tc = new TipCalculator();
            int sValue = (int)sender.Value;
            tipPercetageOutputLabel.Text = sValue.ToString();

                if(taxToggle.On)
                {
                decimal? taxPercent = Convert.ToDecimal(taxPercentInputTextField.Text) / 100;
                decimal? tipPercent = Convert.ToDecimal(tipPercetageOutputLabel.Text) / 100;
                decimal? checkAmount = Convert.ToDecimal(checkAmountInputTextField.Text);
                taxAmount = tc.GetTaxAmount(taxPercent, checkAmount);
                tipAmount = tc.GetTipAmount(tipPercent, checkAmount);
                totalCheckAmount = tc.GetTotalCheckAmount(tipAmount, taxAmount, checkAmount);

                string tipMoneyValue = String.Format("{0:C}", tipAmount);
                string taxMoneyValue = String.Format("{0:C}", taxAmount);
                string totalCheckMoneyValue = String.Format("{0:C}", totalCheckAmount);

                tipAmountOutputLabel.Text = tipMoneyValue.ToString();
                totalCheckAmountOutputLabel.Text = totalCheckMoneyValue.ToString();
                taxAmountOutputLabel.Text = taxMoneyValue.ToString();
                }
                else
                {
                decimal? taxPercent = 0;
                decimal? tipPercent = Convert.ToDecimal(tipPercetageOutputLabel.Text) / 100;
                decimal? checkAmount = Convert.ToDecimal(checkAmountInputTextField.Text);
                taxAmount = tc.GetTaxAmount(taxPercent, checkAmount);
                tipAmount = tc.GetTipAmount(tipPercent, checkAmount);
                totalCheckAmount = tc.GetTotalCheckAmount(tipAmount, taxAmount, checkAmount);

                string tipMoneyValue = String.Format("{0:C}", tipAmount);
                string taxMoneyValue = String.Format("{0:C}", taxAmount);
                string totalCheckMoneyValue = String.Format("{0:C}", totalCheckAmount);

                tipAmountOutputLabel.Text = tipMoneyValue.ToString();
                totalCheckAmountOutputLabel.Text = totalCheckMoneyValue.ToString();
                taxAmountOutputLabel.Text = taxMoneyValue.ToString();
                }
        }

        partial void taxToggle_ValueChanged(UISwitch sender)
        {
            if(sender.On)
            {
                var controller = UIAlertController.Create("Turn on taxes?", null, UIAlertControllerStyle.ActionSheet);

                var yesAction = UIAlertAction.Create("Yes", UIAlertActionStyle.Default,(Action) =>
                {
                    taxAmountOutputLabel.Enabled = false;
                    taxPercentInputTextField.Enabled = false;
                });

                var noAction = UIAlertAction.Create("No", UIAlertActionStyle.Cancel, (Action) =>
                {
                    taxToggle.SetState(!taxToggle.On, true);
                });

                controller.AddAction(yesAction);
                controller.AddAction(noAction);

                PresentViewController(controller, true, null);

                taxPercentInputTextField.Enabled = true;
                taxPercentInputTextField.Text = "5";
            }
            else
            {
                var controller = UIAlertController.Create("Turn off taxes?", null, UIAlertControllerStyle.ActionSheet);

                var yesAction = UIAlertAction.Create("Yes", UIAlertActionStyle.Default, (Action) =>
                {
                    taxAmountOutputLabel.Enabled = false;
                    taxPercentInputTextField.Enabled = false;
                });

                var noAction = UIAlertAction.Create("No", UIAlertActionStyle.Cancel, (Action) =>
                {
                    taxToggle.SetState(!taxToggle.On, true);
                });

                controller.AddAction(yesAction);
                controller.AddAction(noAction);

                PresentViewController(controller, true, null);

                taxPercentInputTextField.Enabled = false;
                taxPercentInputTextField.Text = "";
                taxAmountOutputLabel.Text = "";
            }
        }
    }
}