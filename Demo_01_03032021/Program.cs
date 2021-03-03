using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_01_03032021
{
    class Program
    {
        static void Main(string[] args)
        {
            Kind test = new Kind();
            test.setName("Bla");
            test.nachname = "Test";
            Console.WriteLine(test.getName());
            Console.WriteLine(test.nachname);
            Console.ReadLine();
        }
    }
    class Mutter
    {
        private string name;
        private int alter;

        public string nachname { get; set; }

        public string getName()
        {
            return name;
        }
        public int getAlter()
        {
            return alter;
        }
        public void setAlter(int alter)
        {
            this.alter = alter;
        }
        public void setName(string name)
        {
            this.name = name;
        }
    }
    class Kind : Mutter
    {
    }
}
