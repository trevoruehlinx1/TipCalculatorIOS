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
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void checkAmountInputTextField_ValueChanged(UITextField sender)
        {
            string checkAmount = sender.Text;
        }

        partial void taxPercentInputTextField_ValueChanged(UITextField sender)
        {
            throw new NotImplementedException();
        }

        partial void serviceSlider_ValueChanged(UISlider sender)
        {
            int sValue = (int)sender.Value;
            tipPercetageOutputLabel.Text = sValue.ToString();
        }

        partial void taxToggle_ValueChanged(UISwitch sender)
        {
            throw new NotImplementedException();
        }
    }
}