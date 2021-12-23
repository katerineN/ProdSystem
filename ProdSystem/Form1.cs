using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdSystem
{
    public partial class Form1 : Form
    {
        public SortedDictionary<string, Facts> facts = new SortedDictionary<string, Facts>();
        public Dictionary<string, Rules> rules = new Dictionary<string, Rules>();
        public Form1()
        {
            InitializeComponent();
            facts = Helpers.FactsFromFile("facts.txt");
            rules = Helpers.RulesFromFile("rules.txt");
            LoadProdSystem();
        }

        public void LoadProdSystem()
        {
            foreach (var item in facts.Keys)
            {
                if (item.First() == 'T')
                    checkedListBoxT.Items.Add("" + item + ": " + facts[item]);
                if (item.First() == 'S')
                    checkedListBoxS.Items.Add("" + item + ": " + facts[item]);
                if (item.First() == 'P')
                    checkedListBoxP.Items.Add("" + item + ": " + facts[item]);
                if (item.First() == 'Z')
                    checkedListBoxZ.Items.Add("" + item + ": " + facts[item]);
                if (item.First() == 'C')
                    checkedListBoxС.Items.Add("" + item + ": " + facts[item]);
                if (item.First() == 'F'){
                    checkedListBoxF.Items.Add("" + item + ": " + facts[item]);
                    comboBox1.Items.Add("" + item + ": " + facts[item]);
                }
                if (item.First() == 'M')
                    checkedListBoxM.Items.Add("" + item + ": " + facts[item]);
            }
        
        }
        
        //кнопка заново запускает
        private void button1_Click(object sender, EventArgs e)
        {
            ErrorLabel.Text = "";
        }

        
    }
}