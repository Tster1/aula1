using System;

namespace Aula1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*AULA1conversão implicita entre tipo
            double a;
            int b;
            a = 5.1;
            b = (int)a;
            */

            /*AULA2 operações aritimeticas 
            ///int n1 = 3 + 4 * 2;
            double = a = 1, b = 2 c= 3;

            double delta = Math.Pow(delta) - 4.0 * a * c
            Console.WriteLine(n1);
            ///obs. se colocar cw e dar tab completa
            */


            /*SULA3string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

                                    Console.WriteLine("Você Digitou: " + frase + x + y + z);*/

            /* AQUI ELE SEPARA QUANDO O USUARIO COLOCAR ALGUM ESPAÇO
            string z1 = Console.ReadLine();
            string[] vet = z1.Split(' ');
            string p1 = vet[0]
            ///aqui se o usuario colocar string[] vet = Console.ReadLine.Split(' ');
            */
            /*Logica booleana 
             * bool c1 = 2 > 3 && 1 != 5;
             * Console.WriteLine(c1);
            */
            /*Console.WriteLine("Qual a Hora: ");
            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            if (hora >= 12 && hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            if (hora <= 18)
            {
                Console.WriteLine("Boa noite!");
            }
            */
            /*if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa Tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }

            Console.WriteLine();
            */

            /*Calculando o maior numero
             * Console.WriteLine("Digite 3 numeros");
             int n1 = int.Parse(Console.ReadLine());
             int n2 = int.Parse(Console.ReadLine());
             int n3 = int.Parse(Console.ReadLine());

             if ( n1 > n2 && n1 > n3)
             {
                 Console.WriteLine("Maior = "+ n1 );

             }
              else if (n2 > n3)
             {
                 Console.WriteLine("Maior = "+ n2);
             }
             else
             {
                 Console.WriteLine("Maior = " + n3);
             }
            */
            /*Codigo a cima porem mais "facil" de conseguir.
             * Console.WriteLine("Digite 3 numeros");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);

            Console.WriteLine("Maior =" + resultado);
        }
        static int Maior(int a, int b, int c)
        {
            double m;
            if (a < b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;
        }*/











        }
    }
}
