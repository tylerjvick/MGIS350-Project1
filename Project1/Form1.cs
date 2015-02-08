using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Dictionary<string, int> modDict = new Dictionary<string, int>();

        private void Form1_Load(object sender, EventArgs e)
        {
            //Properties.Settings.Default["invDough"] = 1;
            //Properties.Settings.Default.Save();
            //Console.WriteLine(Properties.Settings.Default["invDough"]);
            //int invDough = 0;
            //int invSauce = 0;
            //int invCheese = 0;

            Dictionary<string, int> invDict = new Dictionary<string, int>();
            
            invDict.Add("invDough", 0);
            invDict.Add("invSauce", 0);
            invDict.Add("invCheese", 0);

            foreach (KeyValuePair<string, int> entry in invDict)
            {

                var storedLabel = entry.Key.ToString();
                var storedValue = Properties.Settings.Default[storedLabel];
                Console.WriteLine(storedValue);
                modDict[entry.Key] = Convert.ToInt32(storedValue);
            }

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
