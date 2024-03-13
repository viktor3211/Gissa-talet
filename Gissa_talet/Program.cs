namespace Gissa_Talet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int talet = random.Next(1, 21);
            int gissning = 0;
            int gissningar = 0;
            Console.WriteLine("Gissa ett tal mellan 1-20");
            while (gissning != talet && gissningar <= 2)
            {
                gissning = Convert.ToInt32(Console.ReadLine());
                if (gissning == talet)
                {
                    Console.WriteLine("Bra jobbat! Talet var " + talet);
                    Console.ReadLine();
                }
                else if (gissning < talet)
                {
                    Console.WriteLine("För lågt!");

                }

                else if (gissning > talet)
                {
                    Console.WriteLine("För högt!");

                }
                gissningar++;

               
            }
            Console.WriteLine("Du gissade fel!");
        }
    }
}