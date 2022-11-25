using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometriaBonus
{
    public class Rettangolo
    {
        public int baseRettangolo;
        public int altezzaRettangolo;

        public void Disegna()
        {
 
            for (int i = 0; i < altezzaRettangolo+2; i++)
            {
              for(int j = 0; j<baseRettangolo; j++)
                {
                    if(i == 0 || i== altezzaRettangolo+1)
                    {
                        Console.Write("-");
                    } else
                    {
                        if (j == 0 || j == baseRettangolo-1)
                        {
                            Console.Write("|");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    } 

                }

                Console.Write("\n");
            }


        }

    }
}

