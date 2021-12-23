using System.CodeDom;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace ProdSystem
{
    public class Helpers
    {
        public static SortedDictionary<string, Facts> FactsFromFile(string fname)
        {
            Form1 f1 = new Form1();
            string[] lines = File.ReadAllLines(fname);
            SortedDictionary<string, Facts> res = new SortedDictionary<string, Facts>();
            foreach (var fact in lines)
            {
                string[] temp = fact.Split(';');
                if (temp.Length != 2)
                {
                    f1.ErrorLabel.Text = "Error with parsing file of facts";
                    f1.ErrorLabel.ForeColor = Color.Red;
                }
                res.Add(temp[0], new Facts(temp[0], temp[1]));
            }

            return res;
        }
        
        public static Dictionary<string, Rules> RulesFromFile(string fname)
        {
            Form1 f1 = new Form1();
            string[] lines = File.ReadAllLines(fname);
            Dictionary<string, Rules> res = new Dictionary<string, Rules>();
            foreach (var fact in lines)
            {
                string[] temp = fact.Split(':');
                if (temp.Length != 2)
                {
                    f1.ErrorLabel.Text = "Error with parsing file of rules";
                    f1.ErrorLabel.ForeColor = Color.Red;
                }
                res.Add(temp[0], new Rules(temp[1]));
            }

            return res;
        }
    }
}