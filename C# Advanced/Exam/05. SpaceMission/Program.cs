using System.Text;

namespace _05._SpaceMission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] space = new char[n, n];
            int spaceshipRow = 0;
            int spaceshipCol = 0;

            int planetRow = 0;
            int planetCol = 0;

            for (int row = 0; row < space.GetLength(0); row++)
            {
                char[] elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < space.GetLength(1); col++)
                {
                    space[row, col] = elements[col];
                    if (space[row, col] == 'S')
                    {
                        spaceshipRow = row;
                        spaceshipCol = col;
                    }
                    if (space[row, col] == 'P')
                    {
                        planetRow = row;
                        planetCol = col;
                    }
                }
            }

            int units = 100;


            space[spaceshipRow, spaceshipCol] = '.';
            while (units >= 5)
            {
                string command = Console.ReadLine();
                if (command == "up")
                {
                    if (spaceshipRow > 0)
                    {
                        if (space[spaceshipRow - 1, spaceshipCol] == '.')
                        {
                            units -= 5;
                            spaceshipRow--;
                        }
                        else if (space[spaceshipRow - 1, spaceshipCol] == 'R')
                        {
                            units -= 5;
                            spaceshipRow--;
                            units += 10;
                            if (units > 100)
                            {
                                units = 100;
                            }
                        }
                        else if (space[spaceshipRow - 1, spaceshipCol] == 'M')
                        {
                            space[spaceshipRow - 1, spaceshipCol] = '.';
                            units -= 10;
                            spaceshipRow--;
                        }
                        else if (space[spaceshipRow - 1, spaceshipCol] == 'P')
                        {
                            spaceshipRow--;
                            units -= 5;
                            Console.WriteLine($"Mission accomplished! The spaceship reached Planet Eryndor with {units} resources left.");
                            Console.WriteLine(PrintMatrix(space));
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        space[spaceshipRow, spaceshipCol] = 'S';
                        Console.WriteLine("Mission failed! The spaceship was lost in space.");
                        Console.WriteLine(PrintMatrix(space));
                        Environment.Exit(0);
                    }
                }
                else if (command == "down")
                {
                    if (spaceshipRow < space.GetLength(0) - 1)
                    {
                        if (space[spaceshipRow + 1, spaceshipCol] == '.')
                        {
                            units -= 5;
                            spaceshipRow++;
                        }
                        else if (space[spaceshipRow + 1, spaceshipCol] == 'R')
                        {
                            units -= 5;
                            spaceshipRow++;
                            units += 10;
                            if (units > 100)
                            {
                                units = 100;
                            }
                        }
                        else if (space[spaceshipRow + 1, spaceshipCol] == 'M')
                        {
                            space[spaceshipRow + 1, spaceshipCol] = '.';
                            units -= 10;
                            spaceshipRow++;
                        }
                        else if (space[spaceshipRow + 1, spaceshipCol] == 'P')
                        {
                            spaceshipRow++;
                            units -= 5;
                            Console.WriteLine($"Mission accomplished! The spaceship reached Planet Eryndor with {units} resources left.");
                            Console.WriteLine(PrintMatrix(space));
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        space[spaceshipRow, spaceshipCol] = 'S';
                        Console.WriteLine("Mission failed! The spaceship was lost in space.");
                        Console.WriteLine(PrintMatrix(space));
                        Environment.Exit(0);
                    }
                }
                else if (command == "left")
                {
                    if (spaceshipCol > 0)
                    {
                        if (space[spaceshipRow, spaceshipCol - 1] == '.')
                        {
                            units -= 5;
                            spaceshipCol--;
                        }
                        else if (space[spaceshipRow, spaceshipCol - 1] == 'R')
                        {
                            units -= 5;
                            spaceshipCol--;
                            units += 10;
                            if (units > 100)
                            {
                                units = 100;
                            }
                        }
                        else if (space[spaceshipRow, spaceshipCol - 1] == 'M')
                        {
                            space[spaceshipRow, spaceshipCol - 1] = '.';
                            units -= 10;
                            spaceshipCol--;
                        }
                        else if (space[spaceshipRow, spaceshipCol - 1] == 'P')
                        {
                            spaceshipCol--;
                            units -= 5;
                            Console.WriteLine($"Mission accomplished! The spaceship reached Planet Eryndor with {units} resources left.");
                            Console.WriteLine(PrintMatrix(space));
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        space[spaceshipRow, spaceshipCol] = 'S';
                        Console.WriteLine("Mission failed! The spaceship was lost in space.");
                        Console.WriteLine(PrintMatrix(space));
                        Environment.Exit(0);
                    }
                }
                else if (command == "right")
                {
                    if (spaceshipCol < space.GetLength(1) - 1)
                    {
                        if (space[spaceshipRow, spaceshipCol + 1] == '.')
                        {
                            units -= 5;
                            spaceshipCol++;
                        }
                        else if (space[spaceshipRow, spaceshipCol + 1] == 'R')
                        {
                            units -= 5;
                            spaceshipCol++;
                            units += 10;
                            if (units > 100)
                            {
                                units = 100;
                            }
                        }
                        else if (space[spaceshipRow, spaceshipCol + 1] == 'M')
                        {
                            space[spaceshipRow, spaceshipCol + 1] = '.';
                            units -= 10;
                            spaceshipCol++;
                        }
                        else if (space[spaceshipRow, spaceshipCol + 1] == 'P')
                        {
                            spaceshipCol++;
                            units -= 5;
                            Console.WriteLine($"Mission accomplished! The spaceship reached Planet Eryndor with {units} resources left.");
                            Console.WriteLine(PrintMatrix(space));
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        space[spaceshipRow, spaceshipCol] = 'S';
                        Console.WriteLine("Mission failed! The spaceship was lost in space.");
                        Console.WriteLine(PrintMatrix(space));
                        Environment.Exit(0);
                    }
                }
            }

            if (units == 0)
            {
                space[spaceshipRow, spaceshipCol] = 'S';
                Console.WriteLine("Mission failed! The spaceship was stranded in space.");
                Console.WriteLine(PrintMatrix(space));
            }
        }

        static string PrintMatrix(char[,] space)
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < space.GetLength(0); row++)
            {
                for (int col = 0; col < space.GetLength(1); col++)
                {
                    sb.Append(space[row, col] + " ").ToString().TrimEnd();
                }
                sb.AppendLine();
            }
            return sb.ToString().TrimEnd();
        }
    }
}