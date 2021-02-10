using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


/*
 * Reduccion de fraciones por el metodo del Maximo Comun Divisor (Gcd en ingles)
 * */
namespace ConsoleAppSimplificaFraccion
{
    class Program
    {

        class fraccion
        {
            private int _numerador { get; set; }
            private int _denominador { get; set; }

            private int _red_numerador { get; set; }
            private int _red_denominador { get; set; }

            public bool IngresarFraccion() {
                
                Console.WriteLine("Introduzca la fraccion: Ejemplo: '10/100'");
                Console.WriteLine("o Introduzca 'S' o presione Enter para SALIR");
                try
                {
                    string fraccion = Console.ReadLine();

                    if (string.IsNullOrEmpty(fraccion))
                        throw new ArgumentNullException();

                    if(fraccion.IndexOf("S")>=0)
                        return true;

                    string[] pieces = fraccion.Split('/');
                    _numerador = _red_numerador =       int.Parse(pieces[0]);
                    _denominador = _red_denominador =   int.Parse(pieces[1]);
                    return false;

                }
                catch(Exception e)
                {
                    Console.WriteLine("mensaje");
                    Console.WriteLine(e.Message);
                }
                return true; 
            }

            public int Gcd(int n, int m)
            {

                if (n < m)
                {
                    int tmp = n;
                    n = m;
                    m = tmp;
                }

                while (m > 0)
                {
                    int tmp = n % m;
                    n = m;
                    m = tmp;
                }

                return n;

            }

            public void ReduceFraction()
            {
                int k = Gcd(_numerador, _denominador);
                _red_numerador = _numerador / k;
                _red_denominador = _denominador / k;
            }

            public void PrintResult()
            {
                Console.WriteLine("{0} / {1} = {2} / {3}", _numerador, _denominador, _red_numerador, _red_denominador);
                Console.WriteLine();
            }

        }


        static void Main(string[] args)
        {
            fraccion f = new fraccion();
            
            while (true)
            {
                if( f.IngresarFraccion() )
                    break;
                f.ReduceFraction();
                f.PrintResult();

            }
        }
    }
}
