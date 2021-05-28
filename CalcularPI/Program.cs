using System;

namespace CalcularPI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            int num_pontos;

            while (continuar)
            {
                Console.WriteLine("Com quantos numeros deseja calcular ?");
                try
                {
                    num_pontos = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Erro no valor indicado, escolha outro valor");
                    num_pontos = Convert.ToInt32(Console.ReadLine());
                }
               
                Console.WriteLine("\nValor aproximado de PI = "+calcularPI(num_pontos));
                Console.WriteLine("Calcular outra vez ? ( True / False )");
                try
                {
                    continuar = Convert.ToBoolean(Console.ReadLine());
                    if(continuar == true) { Console.Clear(); }
                }
                catch
                {
                    continuar = true;
                    Console.Clear();
                }
               
            }
            Console.Clear();
            

        }

        static double calcularPI(int n)
        {
            double num_circle = 0;
            double num_total = 0;

            for (int i = 1; i <= n; i++)
            {
                Random random = new Random();
                Random random1 = new Random();
                double x = random.NextDouble();
                double y = random.NextDouble();
                double distancia = (x * x) + (y * y);
                if(distancia <= 1)
                {
                    num_circle += 1;
                }
                num_total += 1;
            }
            return 4 * (num_circle/num_total);
        }
    }
}
