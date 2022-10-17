using System;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace CLG_14 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter the number of line and colums, respectively with a space.");
            string[] line = Console.ReadLine().Split(" ");
            Console.WriteLine(line.Rank);
            for (int i = 0; i < line.Length; i++) {
                Console.Write(line[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("new");
            int m = int.Parse(line[0]);
            int n = int.Parse(line[1]);

            Console.WriteLine();
            //for (int i = 0; i < line.Length; i++) {
            //    Console.Write(line[i] + ", ");
            //}
            //for (int i = 0; i < line.Length; i++) {
            //    Console.Write(line[i] + ", ");
            //}
            int[,] mat = new int[m, n];
            Console.WriteLine();
            //Console.WriteLine(mat.Rank);
            //Console.WriteLine(line.Rank);

            for (int i = 0; i < m; i++) {
                Console.WriteLine("Enter the numbers of the matrix at the line: " + (i+1));
                string[] values = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Choose a number to know your references");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] == x) {
                        Console.WriteLine("Position " + i + ", " + j + ":");
                        if (j > 0) {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j < n - 1) {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i < m - 1) {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                    else {
                        Console.WriteLine("This number wasn't in the matrix!: " + mat[i, j]);
                    }
                }
            }
        }
    }
}
