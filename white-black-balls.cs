namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int white = Convert.ToInt32(Console.ReadLine());
            int black = Convert.ToInt32(Console.ReadLine());
            int hight = 0;

            for (int i = 1; i < 100; i++)
            {
                if (white >= i)
                {
                    white = white - 1;
                    hight++;
                }
                     else { break;}

                if((i % 2)== 0)
                {
                    if(black >= i)
                    {
                        black = black - 1;
                        hight++;
                    }
                    else { break; }
                }
                
    
    
            }
            Console.WriteLine("hight is:"+ hight);





        }
    }
}
