using Arrays_Listas.Models;

namespace Arrays_Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HotelReserve r = new();

            //Console.Write("How many rooms will be rented? ");
            //int v = int.Parse(Console.ReadLine());
            //Console.WriteLine("");

            //for (int i = 0; i < v; i++)
            //{
            //    Console.WriteLine($"Rent #{i + 1}:");
            //    Console.Write("Name:");
            //    string name = Console.ReadLine().ToString();
            //    Console.Write("Email: ");
            //    string email = Console.ReadLine().ToString();
            //    Console.Write("Room: ");
            //    int room = int.Parse(Console.ReadLine());
            //    Guest g = new Guest(room, name, email);
            //    r.AddReserve((room, g));
            //    Console.WriteLine("");
            //}

            //Console.WriteLine("Busy rooms: ");
            //Console.WriteLine("");
            //foreach (var item in r.Reserve)
            //{
            //    if(item != null)
            //        Console.WriteLine($"{item.Room}: {item.Name}, {item.Email}");
            //}

            Console.WriteLine("Create Matrix:");
            Console.Write("Row: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Column: ");
            int column = int.Parse(Console.ReadLine());

            int[,] matrix = new int[row, column];

            for (int i = 0; i < row; i++)
            {
                string[] r = Console.ReadLine().Split(" ");
                for (int j = 0; j < column; j++)
                {
                    matrix[i,j] = int.Parse(r[j]);
                }
            }

            Console.WriteLine("");
            Console.Write("Position: ");
            string[] v = Console.ReadLine().Split(",");
            int line = int.Parse(v[0]);
            int col = int.Parse(v[1]);
            
            if (matrix[line+1,col] >= 0)
            {
                Console.WriteLine($"Up: {matrix[line + 1, col]}");
            }
            if (matrix[line - 1, col] >= 0)
            {
                Console.WriteLine($"Down: {matrix[line - 1, col]}");
            }
            if (matrix[line, col + 1] >= 0)
            {
                Console.WriteLine($"Right: {matrix[line, col + 1]}");
            }
            if (matrix[line, col - 1] >= 0)
            {
                Console.WriteLine($"Left: {matrix[line, col - 1]}");
            }
        }
    }
}