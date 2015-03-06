using System;
using System.Collections.Generic;

namespace MGIS350_Project
{
    class OrderValidation
    {
        public bool CheckInv(Form1 f, Dictionary<string, int> modDict)
        {

            int pizzaQty = Convert.ToInt32(f.numOrder.Value);

            if (modDict["invDough"] < (Constants.ReqDough * pizzaQty))
            {
                f.btnOrder.Enabled = false;
                return false;
            }

            if (f.chkSauce.Checked)
            {
                if (modDict["invSauce"] < (Constants.ReqSauce * pizzaQty))
                {
                    f.btnOrder.Enabled = false;
                    return false;
                }

            }

            if (f.chkCheese.Checked)
            {
                if (modDict["invCheese"] < (Constants.ReqCheese * pizzaQty))
                {
                    f.btnOrder.Enabled = false;
                    return false;
                }
            }

            f.btnOrder.Enabled = true;
            return true;

        }
    }
}
