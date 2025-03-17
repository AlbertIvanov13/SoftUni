using System.ComponentModel.DataAnnotations;

namespace _02._BombHasBeenPlanted
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            char[,] map = new char[rows, cols];

            int totalSeconds = 16;

            for (int row = 0; row < map.GetLength(0); row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < map.GetLength(1); col++)
                {
                    map[row, col] = line[col];
                }
            }

            int startingRow = 0;
            int startingCol = 0;

            int currentCounterRow = startingRow;
            int currentCounterCol = startingCol;

            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int col = 0; col < map.GetLength(1); col++)
                {
                    if (map[row, col] == 'C')
                    {
                        startingRow = row;
                        startingCol = col;
                        break;
                    }
                }
            }

            while (totalSeconds > 0)
            {
                string command = Console.ReadLine();
                if (command == "left")
                {
                    if (startingCol > 0)
                    {
                        totalSeconds--;
                        if (totalSeconds > 0)
                        {
                            if (map[startingRow, startingCol - 1] == '*')
                            {
                                startingCol--;
                            }
                            else if (map[startingRow, startingCol - 1] == 'B')
                            {
                                startingCol--;
                            }
                            else if (map[startingRow, startingCol - 1] == 'C')
                            {
                                startingCol--;
                            }
                            else if (map[startingRow, startingCol - 1] == 'T')
                            {
                                startingCol--;
                                map[startingRow, startingCol] = '*';
                                Console.WriteLine("Terrorists win!");
                                PrintMatrix(map);
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        totalSeconds--;
                    }
                }
                else if (command == "right")
                {
                    if (startingCol < map.GetLength(1) - 1)
                    {
                        totalSeconds--;
                        if (totalSeconds > 0)
                        {
                            if (map[startingRow, startingCol + 1] == '*')
                            {
                                startingCol++;
                            }
                            else if (map[startingRow, startingCol + 1] == 'B')
                            {
                                startingCol++;
                            }
                            else if (map[startingRow, startingCol + 1] == 'C')
                            {
                                startingCol++;
                            }
                            else if (map[startingRow, startingCol + 1] == 'T')
                            {
                                startingCol++;
                                map[startingRow, startingCol] = '*';
                                Console.WriteLine("Terrorists win!");
                                PrintMatrix(map);
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        totalSeconds--;
                    }
                }
                else if (command == "up")
                {
                    if (startingRow > 0)
                    {
                        totalSeconds--;
                        if (totalSeconds > 0)
                        {
                            if (map[startingRow - 1, startingCol] == '*')
                            {
                                startingRow--;
                            }
                            else if (map[startingRow - 1, startingCol] == 'B')
                            {
                                startingRow--;
                            }
                            else if (map[startingRow - 1, startingCol] == 'C')
                            {
                                startingRow--;
                            }
                            else if (map[startingRow - 1, startingCol] == 'T')
                            {
                                startingRow--;
                                map[startingRow, startingCol] = '*';
                                Console.WriteLine("Terrorists win!");
                                PrintMatrix(map);
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        totalSeconds--;
                    }
                }
                else if (command == "down")
                {
                    if (startingRow < map.GetLength(0) - 1)
                    {
                        totalSeconds--;
                        if (totalSeconds > 0)
                        {
                            if (map[startingRow + 1, startingCol] == '*')
                            {
                                startingRow++;
                            }
                            else if (map[startingRow + 1, startingCol] == 'B')
                            {
                                startingRow++;
                            }
                            else if (map[startingRow + 1, startingCol] == 'C')
                            {
                                startingRow++;
                            }
                            else if (map[startingRow + 1, startingCol] == 'T')
                            {
                                startingRow++;
                                map[startingRow, startingCol] = '*';
                                Console.WriteLine("Terrorists win!");
                                PrintMatrix(map);
                                Environment.Exit(0);
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        totalSeconds--;
                    }
                }
                else if (command == "defuse")
                {
                    if (map[startingRow, startingCol] == 'B')
                    {
                        if (totalSeconds - 4 >= 0)
                        {
                            totalSeconds -= 4;
                            map[startingRow, startingCol] = 'D';
                            Console.WriteLine("Counter-terrorist wins!");
                            Console.WriteLine($"Bomb has been defused: {totalSeconds} second/s remaining.");
                            PrintMatrix(map);
                            Environment.Exit(0);
                        }
                        else
                        {
                            map[startingRow, startingCol] = 'X';
                            Console.WriteLine("Terrorists win!");
                            Console.WriteLine("Bomb was not defused successfully!");
                            Console.WriteLine($"Time needed: {Math.Abs(4 - totalSeconds)} second/s.");
                            PrintMatrix(map);
                            Environment.Exit(0);
                        }
                    }
                    else
                    {
                        totalSeconds -= 2;
                    }
                }
            }

            if (totalSeconds <= 0)
            {
                Console.WriteLine("Terrorists win!");
                Console.WriteLine("Bomb was not defused successfully!");
                Console.WriteLine($"Time needed: 0 second/s.");
                PrintMatrix(map);
            }
        }

        static void PrintMatrix(char[,] map)
        {
            for (int row = 0; row < map.GetLength(0); row++)
            {
                for (int col = 0; col < map.GetLength(1); col++)
                {
                    Console.Write(map[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}