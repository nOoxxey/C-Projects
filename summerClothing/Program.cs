namespace summerClothing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temp = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            string clothing = "";
            string shoes = "";

            if (timeOfDay == "Evening")
            {
                clothing = "Shirt";
                shoes = "Moccasins";
            }





            Console.WriteLine("It's {temp} degrees, get your {clothing} and {shoes}.");
        }
    }
}