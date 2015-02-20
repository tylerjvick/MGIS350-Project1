using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MGIS350_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Create global dictionary to reference inventory values
        Dictionary<string, int> modDict = new Dictionary<string, int>();
        // array to store inventory names
        string[] invKeys = { "invDough", "invSauce", "invCheese" };

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load persistent values into modDict dictionary
            foreach (string i in invKeys)
            {

                var storedLabel = i;
                // Get individual value for each inventory
                var storedValue = Properties.Settings.Default[storedLabel];
                // write inventory to dictionary
                modDict[i] = Convert.ToInt32(storedValue);

            }

            updateLabels(this, e);
        }

        private void updateLabels(object sender, EventArgs e)
        {
            // Update forms labels to current values in modDict
            // and append units to string
            lblDough.Text = modDict["invDough"].ToString() + " lb(s)";

            lblSauce.Text = modDict["invSauce"].ToString() + " oz";

            lblCheese.Text = modDict["invCheese"].ToString() + " oz";
            // Save all values from modDict to persistent storage
            foreach (string s in invKeys)
            {
                Properties.Settings.Default[s] = modDict[s];
                Properties.Settings.Default.Save();
            }

            // Initialize OrderValidation class
            var outside = new OrderValidation();
            // Verify inventory is adequate
            outside.checkInv(this, modDict);

        }

        private void btnAddInv_Click(object sender, EventArgs e)
        {
            // find checked radio button
            var checkedButton = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            // Create identifying key for modDict
            var dictId = "inv" + checkedButton;
            // get value of number selector numAddInv
            int addInv = Convert.ToInt32(numAddInv.Value);
            // Add new value to selected inventory
            modDict[dictId] = modDict[dictId] + addInv;
            // Prevent negative value in inventory, 
            // but allow decrement of inventory if negative value is entered
            if (modDict[dictId] < 0)
            {
                modDict[dictId] = 0;
            }

            updateLabels(this, e);

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
                modDict["invSauce"] = modDict["invSauce"] - (Constants.reqSauce * pizzaQty);
            }
            // If "cheese" is checked, subtract the amount needed from cheese inventory
            // (constant cheese val * number of pizzas ordered)
            if (chkCheese.Checked)
            {
                modDict["invCheese"] = modDict["invCheese"] - (Constants.reqCheese * pizzaQty);
            }
            // Subtract the amount of dough required from the dough inventory
            // (constant dough val times number of pizzas ordered)
            modDict["invDough"] = modDict["invDough"] - (Constants.reqDough * pizzaQty);
            // Update inventory labels, grey out place order btn if requirements aren't met
            updateLabels(this, e);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Prompt user for confirmation of zeroing out inventory
            DialogResult result = MessageBox.Show("Are you sure you want to clear all inventory?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            // If user confirms reset, set each modDict value to 0
            if (result == DialogResult.Yes)
            {
                foreach (var key in modDict.Keys.ToList())
                {
                    modDict[key] = 0;
                }
                // Update inventory labels (to 0) and grey out place order button
                updateLabels(this, e);
            }

        }


    }
}
