using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using MGIS350_Project.Properties;

namespace MGIS350_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Create global dictionary to reference inventory values
        Dictionary<string, int> _modDict = new Dictionary<string, int>();
        // array to store inventory names
        string[] _invKeys = { "invDough", "invSauce", "invCheese" };

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load persistent values into modDict dictionary
            foreach (string i in _invKeys)
            {

                var storedLabel = i;
                // Get individual value for each inventory
                var storedValue = Settings.Default[storedLabel];
                // write inventory to dictionary
                _modDict[i] = Convert.ToInt32(storedValue);

            }

            UpdateLabels(this, e);
        }

        private void UpdateLabels(object sender, EventArgs e)
        {
            // Update forms labels to current values in modDict
            // and append units to string
            lblDough.Text = _modDict["invDough"] + Resources.Form1_UpdateLabels__lb_s_;

            lblSauce.Text = _modDict["invSauce"] + Resources.Form1_UpdateLabels__oz;

            lblCheese.Text = _modDict["invCheese"] + Resources.Form1_UpdateLabels__oz;
            // Save all values from modDict to persistent storage
            foreach (string s in _invKeys)
            {
                Settings.Default[s] = _modDict[s];
                Settings.Default.Save();
            }

            // Initialize OrderValidation class
            var outside = new OrderValidation();
            // Verify inventory is adequate
            outside.CheckInv(this, _modDict);

        }

        private void btnAddInv_Click(object sender, EventArgs e)
        {
            // find checked radio button
            var firstOrDefault = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            if (firstOrDefault != null)
            {
                var checkedButton = firstOrDefault.Text;
                // Create identifying key for modDict
                var dictId = "inv" + checkedButton;
                // get value of number selector numAddInv
                int addInv = Convert.ToInt32(numAddInv.Value);
                // Add new value to selected inventory
                _modDict[dictId] = _modDict[dictId] + addInv;
                // Prevent negative value in inventory, 
                // but allow decrement of inventory if negative value is entered
                if (_modDict[dictId] < 0)
                {
                    _modDict[dictId] = 0;
                }
            }

            UpdateLabels(this, e);

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            // Get desired number of pizzas to order, and convert to int
            // when "Place Order" is clicked
            int pizzaQty = Convert.ToInt32(numOrder.Value);
            // If "sauce" is checked, subtract the amount needed from sauce inventory
            // (constant sauce val * number of pizzas ordered)
            if (chkSauce.Checked)
            {
                _modDict["invSauce"] = _modDict["invSauce"] - (Constants.ReqSauce * pizzaQty);
            }
            // If "cheese" is checked, subtract the amount needed from cheese inventory
            // (constant cheese val * number of pizzas ordered)
            if (chkCheese.Checked)
            {
                _modDict["invCheese"] = _modDict["invCheese"] - (Constants.ReqCheese * pizzaQty);
            }
            // Subtract the amount of dough required from the dough inventory
            // (constant dough val times number of pizzas ordered)
            _modDict["invDough"] = _modDict["invDough"] - (Constants.ReqDough * pizzaQty);
            // Update inventory labels, grey out place order btn if requirements aren't met
            UpdateLabels(this, e);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Prompt user for confirmation of zeroing out inventory
            DialogResult result = MessageBox.Show(Resources.Form1_btnReset_Click_Are_you_sure_you_want_to_clear_all_inventory_, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            // If user confirms reset, set each modDict value to 0
            if (result == DialogResult.Yes)
            {
                foreach (var key in _modDict.Keys.ToList())
                {
                    _modDict[key] = 0;
                }
                // Update inventory labels (to 0) and grey out place order button
                UpdateLabels(this, e);
            }

        }


    }
}
