using System.Text.RegularExpressions;

namespace ProdSystem
{
    public class Facts
    {
        public string Id;
        public string Text;

        public Facts(string id, string t)
        {
            Id = id;
            Text = t;
        }
    }
}