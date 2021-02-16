using System;
using System.Globalization;
namespace Uri1160
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, pa, pb;

            double g1, g2, p,p1,anos;
            p = 0;
            anos = 0;
            p1 = 0;
            
            t = int.Parse(Console.ReadLine());

            for (int c = 0; c < t; c++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                pa = int.Parse(vetor[0]);

                while(pa > 1000000)
                {
                    vetor[0] = Console.ReadLine(); 
                    pa = int.Parse(vetor[0]);
                }
                pb = int.Parse(vetor[1]);

                while (pb > 1000000)
                {
                    vetor[1] = Console.ReadLine();
                    pb = int.Parse(vetor[1]);
                }
                g1 = double.Parse(vetor[2], CultureInfo.InvariantCulture);

                while (g1 > 10)
                {
                    vetor[2] = Console.ReadLine();
                    g1 = double.Parse(vetor[2], CultureInfo.InvariantCulture);
                }
                g2 = double.Parse(vetor[3], CultureInfo.InvariantCulture);

                while (g2 > 10)
                {
                    vetor[3] = Console.ReadLine();
                    g2 = double.Parse(vetor[3], CultureInfo.InvariantCulture);
                }

              
             


                while (pa <= pb)
                {
                    anos = anos + 1;

                    pa += (int)(pa * (g1 / 100));

                    pb += (int) (pb * (g2 / 100));
                }

                if(anos < 100)
                {
                    Console.WriteLine(anos);
                }
                else
                {
                    Console.WriteLine("Mais de um século");
                }

                anos = 0;

            }
        }
    }
}
