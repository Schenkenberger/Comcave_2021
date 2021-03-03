using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_02_03032021
{
    class Program
    {
        static void Main(string[] args)
        {
            Mann mann = new Mann();
            mann.name = "Franz";
            Frau frau = new Frau();
            frau.name = "Cindy";
        }
    }
    class Mann
    {
        public string name;
        //public
    }

    class Frau
    {
        public string name;
        public bool isInteressiert;
    }
}
