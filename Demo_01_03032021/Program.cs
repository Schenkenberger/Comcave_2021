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
            Console.WriteLine(test.getName());
            Console.ReadLine();
        }
    }
    class Mutter
    {
        private string name;
        private int alter;

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
