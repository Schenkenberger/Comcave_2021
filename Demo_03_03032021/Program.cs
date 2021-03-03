using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_03_03032021
{
    class Program
    {
        static void Main(string[] args)
        {
            Screen screen = new Screen();
            SpieleKonsole spieleKonsole = new SpieleKonsole();
            Receiver receiver = new Receiver();
            spieleKonsole.istAn = true;
            receiver.istAn = false;
            Console.WriteLine(screen.Channel(receiver, spieleKonsole));
            Console.ReadLine();

        }
    }
    class Screen
    {
        public string kanal;
        public bool istAn;

        public string Channel(Receiver r, SpieleKonsole s)
        {
            if (r.istAn == true)
            {
                kanal = "Reviever läuft läuft. Setze Kanal auf 1.";
                istAn = true;
            }
            if (s.istAn == true)
            {
                kanal = "Spielekonsole läuft. Setze Kanal auf 2.";
            }
            else
            {
                kanal = "Kein Signal";
            }
            return kanal;
        }
    }
    public class Receiver
    {
        public bool istAn;

    }
    class SpieleKonsole
    {
        public bool istAn;

    }
}
