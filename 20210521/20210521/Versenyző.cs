using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210521
{
    class Versenyző
    {
        public string Név { get; private set; }
        public char Csoport { get; private set; }
        private string NemzetÉsKód { get; set; }
        public string Sorozat { get; set; }
        public double[] Dobások { get; private set; }
        public double Eredmény;
        public string Nemzet, Kód;
        public Versenyző(string sor)
        {
            string[] m = sor.Split(';');
            Név = m[0];
            Csoport = char.Parse(m[1]);
            NemzetÉsKód = m[2];
            Sorozat = $"{m[3]};{m[4]};{m[5]}";
            Dobások = new double[3];
            for (int i = 0; i < Dobások.Length; i++)
            {
                if (m[i + 3] == "X") Dobások[i] = -1.0; // érvénytelen kísérlet: -1.0
                else if (m[i + 3] == "-") Dobások[i] = -2.0; // már nem dobott, mert bejutott 78m feletti korábbi dobással: -2.0
                else Dobások[i] = double.Parse(m[i + 3]);
            }
            Eredmény = Dobások.Max();
            string[] n = NemzetÉsKód.Split('(');
            Nemzet = n[0].Trim();
            Kód = n[1].Trim(')');

        }
    }
}
