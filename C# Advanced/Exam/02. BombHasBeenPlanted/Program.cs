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

            bool isFound = false;
            for (int row = 0; row <= map.GetLength(0) - 1; row++)
            {
                for (int col = 0; col <= map.GetLength(1) - 1; col++)
                {
                    if (map[row, col] == 'C' && isFound == false)
                    {
                        startingRow = row;
                        startingCol = col;
                        isFound = true;
                        break;
                    }
                }
            }

            string command = Console.ReadLine();

            while (true)
            {
                if (command == "left")
                {
                    if (totalSeconds > 0)
                    {
                        totalSeconds--;
                        if (startingRow >= map.GetLength(0) || startingCol - 1 >= map.GetLength(1))
                        {
                            map[startingRow, startingCol] = map[map.GetLength(0) - 1, map.GetLength(1) - 1];
                            totalSeconds--;
                            command = Console.ReadLine();
                        }
                        else
                        {
                            if (map[startingRow, startingCol - 1] == '*')
                            {
                                map[startingRow, startingCol] = map[startingRow, startingCol--];
                                command = Console.ReadLine();
                                continue;
                            }
                            else if (map[startingRow, startingCol - 1] == 'B')
                            {
                                map[startingRow, startingCol] = map[startingRow, startingCol--];
                                command = Console.ReadLine();
                                if (command == "defuse")
                                {
                                    continue;
                                }
                            }
                            else if (map[startingRow, startingCol - 1] == 'T')
                            {
                                map[startingRow, startingCol - 1] = '*';
                                map[startingRow, startingCol] = '*';
                                Console.WriteLine("Terrorists win!");
                                PrintMatrix(map);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Terrorists win!");
                        Console.WriteLine("Bomb was not defused successfully!");
                        Console.WriteLine($"Time needed: 0 second/s.");
                        PrintMatrix(map);
                        break;
                    }
                }
                else if (command == "right")
                {
                    if (totalSeconds > 0)
                    {
                        totalSeconds--;
                        if (startingRow >= map.GetLength(0) || startingCol + 1 >= map.GetLength(1))
                        {
                            map[startingRow, startingCol] = map[map.GetLength(0) - 1, map.GetLength(1) - 1];
                            totalSeconds--;
                            command = Console.ReadLine();
                        }
                        else
                        {
                            if (map[startingRow, startingCol + 1] == '*')
                            {
                                map[startingRow, startingCol] = map[startingRow, startingCol++];
                                command = Console.ReadLine();
                                continue;
                            }
                            else if (map[startingRow, startingCol + 1] == 'B')
                            {
                                map[startingRow, startingCol] = map[startingRow, startingCol++];
                                command = Console.ReadLine();
                                if (command == "defuse")
                                {
                                    continue;
                                }
                            }
                            else if (map[startingRow, startingCol + 1] == 'T')
                            {
                                map[startingRow, startingCol + 1] = '*';
                                map[startingRow, startingCol] = '*';
                                Console.WriteLine("Terrorists win!");
                                PrintMatrix(map);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Terrorists win!");
                        Console.WriteLine("Bomb was not defused successfully!");
                        Console.WriteLine($"Time needed: 0 second/s.");
                        PrintMatrix(map);
                        break;
                    }
                }
                else if (command == "up")
                {
                    if (totalSeconds > 0)
                    {
                        totalSeconds--;
                        if (startingRow - 1 >= map.GetLength(0) || startingCol >= map.GetLength(1))
                        {
                            map[startingRow, startingCol] = map[map.GetLength(0) - 1, map.GetLength(1) - 1];
                            totalSeconds--;
                            command = Console.ReadLine();
                        }
                        else
                        {
                            if (map[startingRow - 1, startingCol] == '*')
                            {
                                map[startingRow, startingCol] = map[startingRow--, startingCol];
                                command = Console.ReadLine();
                                continue;
                            }
                            else if (map[startingRow - 1, startingCol] == 'B')
                            {
                                map[startingRow, startingCol] = map[startingRow--, startingCol];
                                command = Console.ReadLine();
                                if (command == "defuse")
                                {
                                    continue;
                                }
                            }
                            else if (map[startingRow - 1, startingCol] == 'T')
                            {
                                map[startingRow - 1, startingCol] = '*';
                                map[startingRow, startingCol] = '*';
                                Console.WriteLine("Terrorists win!");
                                PrintMatrix(map);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Terrorists win!");
                        Console.WriteLine("Bomb was not defused successfully!");
                        Console.WriteLine($"Time needed: 0 second/s.");
                        PrintMatrix(map);
                        break;
                    }
                }
                else if (command == "down")
                {
                    if (totalSeconds > 0)
                    {
                        totalSeconds--;
                        if (startingRow + 1 >= map.GetLength(0) || startingCol >= map.GetLength(1))
                        {
                            map[startingRow, startingCol] = map[map.GetLength(0) - 1, map.GetLength(1) - 1];
                            totalSeconds--;
                            command = Console.ReadLine();
                        }
                        else
                        {
                            if (map[startingRow + 1, startingCol] == '*')
                            {
                                map[startingRow, startingCol] = map[startingRow++, startingCol];
                                command = Console.ReadLine();
                                continue;
                            }
                            else if (map[startingRow + 1, startingCol] == 'B')
                            {
                                map[startingRow, startingCol] = map[startingRow++, startingCol];
                                command = Console.ReadLine();
                                if (command == "defuse")
                                {
                                    continue;
                                }
                            }
                            else if (map[startingRow + 1, startingCol] == 'T')
                            {
                                map[startingRow + 1, startingCol] = '*';
                                map[startingRow, startingCol] = '*';
                                Console.WriteLine("Terrorists win!");
                                PrintMatrix(map);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Terrorists win!");
                        Console.WriteLine("Bomb was not defused successfully!");
                        Console.WriteLine($"Time needed: 0 second/s.");
                        PrintMatrix(map);
                        break;
                    }
                }
                else if (command == "defuse")
                {
                    if (totalSeconds > 0)
                    {
                        if (map[startingRow, startingCol] != 'B')
                        {
                            totalSeconds -= 2;
                            command = Console.ReadLine();
                            continue;
                        }
                        else
                        {
                            if (totalSeconds - 4 >= 0)
                            {
                                totalSeconds -= 4;
                                map[startingRow, startingCol] = 'D';
                                Console.WriteLine("Counter-terrorist wins!");
                                Console.WriteLine($"Bomb has been defused: {totalSeconds} second/s remaining.");
                                PrintMatrix(map);
                                break;
                            }
                            else
                            {
                                map[startingRow, startingCol] = 'X';
                                Console.WriteLine("Terrorists win!");
                                Console.WriteLine("Bomb was not defused successfully!");
                                Console.WriteLine($"Time needed: {Math.Abs(totalSeconds - 4)} second/s.");
                                PrintMatrix(map);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Terrorists win!");
                        Console.WriteLine("Bomb was not defused successfully!");
                        Console.WriteLine($"Time needed: 0 second/s.");
                        PrintMatrix(map);
                        break;
                    }
                }
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