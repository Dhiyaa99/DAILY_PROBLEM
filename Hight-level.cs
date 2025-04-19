int hieght = Convert.ToInt32(Console.ReadLine());
for (int i =1; i <= hieght; i++)
{
    int num = 1;
    //Console.WriteLine(num);

    for (int j = 1; j <= i; j++)
    {
        Console.Write(num);
        num *= 2;
    }
    num /= 4;

    for(int j =1; j<i; j++)
    {
        
        Console.Write(num);
        

        num /= 2;
        

    }
    Console.WriteLine();

}
