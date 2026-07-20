namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Islam's Carpet Cleaning Service");
            Console.Write("Please Enter number of your small Carpets: ");
            int small=Convert.ToInt32(Console.ReadLine());
            Console.Write("Please Enter number of your large Carpets: ");
            int large = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("price Per small carpets: $25");
            Console.WriteLine("price Per large carpets: $35");
            int cost = (small*25) + (large*35);
            Console.WriteLine($"Cost = {cost}");
            double tax = cost * .06; 
            Console.WriteLine($"Tax = {tax}");
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"Total cost = {cost+tax}");
        }
    }
}
