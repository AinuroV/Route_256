using System;
namespace project
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            
            string ship = "4 3 3 2 2 2 1 1 1 1";
            var response = "";

            for (var i = 0; i < count; i++)
            {
                var ships = Console.ReadLine().Split().ToList();

                ships.Sort((a, b) => a.CompareTo(b) * -1);

                response += "\n" + (String.Join(" ", ships.ToArray()) == ship ? "YES" : "NO");
                
            }
            Console.WriteLine(response.Trim());
        }
    }

}