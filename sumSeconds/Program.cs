namespace sumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ath1 = int.Parse(Console.ReadLine());
            int ath2 = int.Parse(Console.ReadLine());
            int ath3 = int.Parse(Console.ReadLine());

            int sumTime = ath1 + ath2 + ath3;
            int mins = sumTime / 60;
            int secs = sumTime % 60;
            string leadingZero = "";

            if (secs < 10)
            {
                leadingZero = "0";
            }
            
            Console.WriteLine($"{mins}:{leadingZero}{secs}");


        }
    }
}