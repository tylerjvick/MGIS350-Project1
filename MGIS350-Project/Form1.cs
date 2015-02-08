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
            //Properties.Settings.Default["invSauce"] = 1;
            //Properties.Settings.Default.Save();
            //Console.WriteLine(Properties.Settings.Default["invDough"]);

            foreach (string i in invKeys)
            {

                var storedLabel = i;
                var storedValue = Properties.Settings.Default[storedLabel];
                Console.WriteLine(storedValue);
                modDict[i] = Convert.ToInt32(storedValue);

            }

            // prints updated dictionary, can be removed
            foreach (KeyValuePair<string, int> kvp in modDict)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }

            updateLabels();
        }

        private void updateLabels()
        {
            // Update forms labels to current values in modDict
            lblDough.Text = modDict["invDough"].ToString();

            lblSauce.Text = modDict["invSauce"].ToString();

            lblCheese.Text = modDict["invCheese"].ToString();

            foreach (string s in invKeys)
            {
                Properties.Settings.Default[s] = modDict[s];
                Properties.Settings.Default.Save();
            }

        }

        private void btnAddInv_Click(object sender, EventArgs e)
        {
            //find checked radio button
            var checkedButton = Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            //Create identifying key for modDict
            var dictId = "inv" + checkedButton;
            //get value of number selector numAddInv
            int addInv = Convert.ToInt32(numAddInv.Value);
            // Add new value to selected inventory
            modDict[dictId] = modDict[dictId] + addInv;

            updateLabels();
        }


    }
}
