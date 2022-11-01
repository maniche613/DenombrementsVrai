using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denombrements
{
    class Program
    {
        static int calcul(int t, int n, int k2)
        {
            // calcul de r
            int r = 1;
            for (int k = (t - n + 1); k <= k2; k++)
                r *= k;
            return r;
        }
        static int Demande(string message)
        {

            Console.Write(message); // le nombre d'éléments à gérer
            int t = int.Parse(Console.ReadLine()); // saisir le nombre
            return t;
        }


        static void Main(string[] args)
        {
            int c = 1, a, b = 0, d = 0;
            while (c != 0)
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                c = int.Parse(Console.ReadLine());


                switch (c)
                {
                    case 0:
                        {
                            Environment.Exit(0);
                            break;
                        }

                    case 1:
                        {
                            b = Demande("nombre total d'éléments à gérer = ");
                            a = calcul(0, 0, b);
                            Console.WriteLine(b + "! = " + a);
                            break;
                        }



                    case 2:
                        {

                            b = Demande("nombre total d'éléments à gérer = ");
                            d = Demande("nombre d'element dans le sous ensemble = ");
                            a = calcul(b, d, b);
                            //Console.WriteLine("résultat = " + (r1 / r2));
                            Console.WriteLine("A(" + b + "/" + d + ") = " + a);
                            break;
                        }

                    case 3:
                        {
                            b = Demande("nombre total d'éléments à gérer = ");
                            d = Demande("nombre d'element dans le sous ensemble = ");
                            a = calcul(b, d, b);
                            // calcul de r2
                            int e = calcul(0, 0, d);
                            //Console.WriteLine("résultat = " + (r1 / r2));
                            Console.WriteLine("C(" + b + "/" + d + ") = " + (a / e));
                            break;
                        }
                }

            }
            Console.ReadLine();
        }
    }
}
