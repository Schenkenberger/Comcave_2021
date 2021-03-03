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
            Frau frau = new Frau();
            frau.name = "Cindy";
            frau.isInteressiert = true;
            mann.name = "Franz";
            //mann.Frau = frau;
            Console.WriteLine(mann.SprecheFrauAn(frau));
            Console.WriteLine(frau.GebeAntwort(mann));
            Console.ReadLine();
        }
    }
    class Mann
    {
        public string name;

        public string SprecheFrauAn(Frau frau)
        {
            return frau.isInteressiert ? $"Hi ich bin {name}. Kann ich dir einen Kaffee ausgeben" : "Mann sagt nichts und verlässt das Kaffee.";
        }
    }

    class Frau
    {
        public string name;
        public bool isInteressiert;

        public string GebeAntwort(Mann mann)
        {
            return isInteressiert ? $"Ya gerne {mann.name}" : $"Keine Interesse {mann.name}";
        }
    }
}
