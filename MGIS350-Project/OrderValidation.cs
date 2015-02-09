using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGIS350_Project
{
    class OrderValidation
    {
        public bool checkInv(Form1 F, Dictionary<string, int> modDict)
        {

            int pizzaQty = Convert.ToInt32(F.numOrder.Value);

            if (modDict["invDough"] < (Constants.reqDough * pizzaQty))
            {
                F.btnOrder.Enabled = false;
                return false;
            }

            if (F.chkSauce.Checked)
            {
                if (modDict["invSauce"] < (Constants.reqSauce * pizzaQty))
                {
                    F.btnOrder.Enabled = false;
                    return false;
                }

            }

            if (F.chkCheese.Checked)
            {
                if (modDict["invCheese"] < (Constants.reqCheese * pizzaQty))
                {
                    F.btnOrder.Enabled = false;
                    return false;
                }
            }

            F.btnOrder.Enabled = true;
            return true;

        }
    }
}
