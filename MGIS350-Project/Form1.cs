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

            int pizzaQty = Convert.ToInt32(numOrder.Value);

            if (chkSauce.Checked)
            {
                modDict["invSauce"] = modDict["invSauce"] - (Constants.reqSauce * pizzaQty);
            }

            if (chkCheese.Checked)
            {
                modDict["invCheese"] = modDict["invCheese"] - (Constants.reqCheese * pizzaQty);
            }

            modDict["invDough"] = modDict["invDough"] - (Constants.reqDough * pizzaQty);

            updateLabels(this, e);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to clear all inventory?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                foreach (var key in modDict.Keys.ToList())
                {
                    modDict[key] = 0;
                }
                updateLabels(this, e);
            }

        }


    }
}
