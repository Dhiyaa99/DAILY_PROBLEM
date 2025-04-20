namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("check the menu: ");
            Console.WriteLine("1.Americano      $2.50 ");
            Console.WriteLine("2.Latte          $3.00 ");
            Console.WriteLine("3.Cappuccino     $3.50 ");

            int choice = Convert.ToInt32(Console.ReadLine());

            string coffee = "";
            double price = 0;

               if (choice == 1)
            {
                coffee = "Americano   ";
                price = 2.50;
                Console.WriteLine(coffee + price + "OMR");
            }
               else if (choice == 2)
            {
                coffee = "Latte    ";
                price = 3.00;
                Console.WriteLine(coffee + price + "OMR");

            }
            else if (choice == 3)
            {
                coffee = "Cappuccino   ";
                price = 3.5;
                Console.WriteLine(coffee + price+"OMR");

            }
            else
            {
                Console.WriteLine("No item");
            }
            Console.WriteLine();
            Console.WriteLine("Choose size (S/M/L):");

            string size = Console.ReadLine().ToUpper();
            double sizeCost = 0;

            if (size == "M")
            {
                sizeCost = 0.5;
                Console.WriteLine("+" + sizeCost);
            }
            else if(size == "L")
            {
                sizeCost = 0.5;
                Console.WriteLine("+" + sizeCost);

            }
            Console.WriteLine("Extra milk/sugar?: "); 
            string SugarMilk = Console.ReadLine().ToLower();
            {
                if(SugarMilk  == "yes")
                {
                    Console.WriteLine("add extra milk and sugar");
                    
                }
            }

            double Total = price + sizeCost;
            Console.WriteLine("your order is:  "+coffee+" "+size +" "+ $"add Milk and Sugar:{SugarMilk}");
            Console.WriteLine("the total:  " + Total);
            Console.WriteLine("Thank you for ordering " );
            
 

        }
    }
}
