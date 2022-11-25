using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rettangolo
    {
        public int baseRettangolo;
        public int altezzaRettangolo;

        public int CalcolaArea()
        {
            int area = baseRettangolo * altezzaRettangolo;
            return area;
        }

        public int CalcolaPerimento()
        {
            int perimetro = (baseRettangolo + altezzaRettangolo) * 2;
            return perimetro;
        }
   
        public void StampaRetangolo(string nomeDelRetangolo)
        {

            Console.WriteLine($@" ----{nomeDelRetangolo}---- 
Base: {baseRettangolo}
Altezza: {altezzaRettangolo}
Perimetro: {CalcolaPerimento()}
Area:{CalcolaArea()}");

        }

        
    }
}
