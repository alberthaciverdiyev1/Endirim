namespace Endirim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mebleg = -6;
            if (mebleg>0 && mebleg < 100)
            {
                Console.WriteLine("5% endirim");

            }
            else if (mebleg < 1000 && mebleg > 100)
                       {
                Console.WriteLine("8% endirim");
            }
            else if (mebleg > 1000) { 

                Console.WriteLine("10% endirim");
            }
            else
            {
                Console.WriteLine("0% endirim");
            }
        }
    }
}