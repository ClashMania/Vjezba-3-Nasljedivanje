
using System;

namespace nasljedjivanje_3
{
    class Biljka
    {
    }

    class Stablo : Biljka
    {
        bool otpadajuListovi;
        public bool OtpadajuListovi { get => otpadajuListovi; set => otpadajuListovi = value; }
        public Stablo(bool otpadajuListovi)
        {
            OtpadajuListovi = otpadajuListovi;
        }
    }

    class Cvijet : Biljka
    {

    }

    class Crnogoricno : Stablo
    {
        public Crnogoricno() : base(true)
        {
        }
    }

    class Bjelogoricno : Stablo
    {
        public Bjelogoricno() : base(false)
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Crnogoricno Bor = new Crnogoricno();
            Bjelogoricno Hrast = new Bjelogoricno();

            Console.WriteLine("{0} {1}",
                Hrast.OtpadajuListovi, Bor.OtpadajuListovi);

            Console.ReadKey();
        }
    }
}