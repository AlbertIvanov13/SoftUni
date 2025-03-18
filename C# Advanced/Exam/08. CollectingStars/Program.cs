using System.Runtime.InteropServices;
using System.Text;

namespace _08._CollectingStars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] field = new char[n, n];

            int startingRow = 0;
            int startingCol = 0;

            int movingRow = 0;
            int movingCol = 0;

            for (int row = 0; row < field.GetLength(0); row++)
            {
                char[] elements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    field[row, col] = elements[col];
                    if (field[row, col] == 'P')
                    {
                        startingRow = row;
                        startingCol = col;
                        movingRow = row;
                        movingCol = col;
                    }
                }
            }

            int collectedStars = 2;

            while (true)
            {
                if (collectedStars == 10 || collectedStars == 0)
                {
                    field[movingRow, movingCol] = 'P';
                    if (collectedStars == 10)
                    {
                        Console.WriteLine("You won! You have collected 10 stars.");
                        Console.WriteLine($"Your final position is [{movingRow}, {movingCol}]");
                        Console.WriteLine(PrintMatrix(field));
                    }

                    if (collectedStars <= 0)
                    {
                        Console.WriteLine("Game over! You are out of any stars.");
                        Console.WriteLine($"Your final position is [{movingRow}, {movingCol}]");
                        Console.WriteLine(PrintMatrix(field));
                    }
                    Environment.Exit(0);
                }
                else
                {
                    string command = Console.ReadLine();
                    if (command == "up")
                    {
                        field[movingRow, movingCol] = '.';
                        if (movingRow > 0)
                        {
                            if (field[movingRow - 1, movingCol] == '*')
                            {
                                movingRow--;
                                field[movingRow, movingCol] = '.';
                                collectedStars++;
                            }
                            else if (field[movingRow - 1, movingCol] == '#')
                            {
                                collectedStars--;
                            }
                            else if (field[movingRow - 1, movingCol] == '.')
                            {
                                movingRow--;
                            }
                        }
                        else
                        {
                            movingRow = 0;
                            movingCol = 0;
                            if (field[movingRow, movingCol] == '*')
                            {
                                collectedStars++;
                                field[movingRow, movingCol] = 'P';
                            }
                        }
                    }
                    else if (command == "down")
                    {
                        field[movingRow, movingCol] = '.';
                        if (movingRow < field.GetLength(0) - 1)
                        {
                            if (field[movingRow + 1, movingCol] == '*')
                            {
                                movingRow++;
                                field[movingRow, movingCol] = '.';
                                collectedStars++;
                            }
                            else if (field[movingRow + 1, movingCol] == '#')
                            {
                                collectedStars--;
                            }
                            else if (field[movingRow + 1, movingCol] == '.')
                            {
                                movingRow++;
                            }
                        }
                        else
                        {
                            movingRow = 0;
                            movingCol = 0;
                            if (field[movingRow, movingCol] == '*')
                            {
                                collectedStars++;
                                field[movingRow, movingCol] = 'P';
                            }
                        }
                    }
                    else if (command == "left")
                    {
                        field[movingRow, movingCol] = '.';
                        if (movingCol > 0)
                        {
                            if (field[movingRow, movingCol - 1] == '*')
                            {
                                movingCol--;
                                field[movingRow, movingCol] = '.';
                                collectedStars++;
                            }
                            else if (field[movingRow, movingCol - 1] == '#')
                            {
                                collectedStars--;
                            }
                            else if (field[movingRow, movingCol - 1] == '.')
                            {
                                movingCol--;
                            }
                        }
                        else
                        {
                            movingRow = 0;
                            movingCol = 0;
                            if (field[movingRow, movingCol] == '*')
                            {
                                collectedStars++;
                                field[movingRow, movingCol] = 'P';
                            }
                        }
                    }
                    else if (command == "right")
                    {
                        field[movingRow, movingCol] = '.';
                        if (movingCol < field.GetLength(1) - 1)
                        {
                            if (field[movingRow, movingCol + 1] == '*')
                            {
                                movingCol++;
                                field[movingRow, movingCol] = '.';
                                collectedStars++;
                            }
                            else if (field[movingRow, movingCol + 1] == '#')
                            {
                                collectedStars--;
                            }
                            else if (field[movingRow, movingCol + 1] == '.')
                            {
                                movingCol++;
                            }
                        }
                        else
                        {
                            movingRow = 0;
                            movingCol = 0;
                            if (field[movingRow, movingCol] == '*')
                            {
                                collectedStars++;
                                field[movingRow, movingCol] = 'P';
                            }
                        }
                    }
                }

            }
        }

        static string PrintMatrix(char[,] field)
        {
            StringBuilder sb = new StringBuilder();
            for (int row = 0; row < field.GetLength(0); row++)
            {
                for (int col = 0; col < field.GetLength(1); col++)
                {
                    sb.Append(field[row, col] + " ").ToString().TrimEnd();
                }
                sb.AppendLine();
            }
            return sb.ToString().TrimEnd();
        }
    }
}