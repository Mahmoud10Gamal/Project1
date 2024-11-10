namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Smallcarpets, largecarpets;
            Console.WriteLine("Please enter your number of small carpets");
            Smallcarpets = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your number of large carpets");
            largecarpets = int.Parse(Console.ReadLine());
            Console.WriteLine("price per small carpets : 25$");
            Console.WriteLine("price per large carpets : 35$");
            Console.WriteLine("The cost: 110$ But there is a tax is 6.6$ ");
            Console.WriteLine("The Total estimate is 116.6$");
            Console.WriteLine("This estimate is valid for 30 days");


        }
    }
}
