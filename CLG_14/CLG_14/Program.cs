using System;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace CLG_14 {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Enter the number of line and colums, respectively with a space.");
            string[] line = Console.ReadLine().Split(" ");
            //Console.WriteLine(line.Rank);
            Console.Write("You entered with the numbers: ");
            for (int i = 0; i < line.Length; i++) {
                if (i < 1) {
                    Console.Write(line[i] + " e ");
                }
                else {
                    Console.Write(line[i]);
                }
            }
            //Console.WriteLine("new");
            Console.WriteLine();
            int l = int.Parse(line[0]);
            int c = int.Parse(line[1]);

            Console.WriteLine();
            //for (int i = 0; i < line.Length; i++) {
            //    Console.Write(line[i] + ", ");
            //}
            //for (int i = 0; i < line.Length; i++) {
            //    Console.Write(line[i] + ", ");
            //}
            int[,] mat = new int[l, c];
            Console.WriteLine();
            //Console.WriteLine(mat.Rank);
            //Console.WriteLine(line.Rank);

            for (int i = 0; i < l; i++) {
                Console.WriteLine("Enter the numbers of the matrix at the line: " + (i+1));
                string[] values = Console.ReadLine().Split(" ");
                for (int j = 0; j < c; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Choose a number to know your references");
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++) {
                for (int j = 0; j < c; j++) {
                    if (mat[i, j] == x) {
                        Console.WriteLine("There is a choice at " + (i+1) + ", " + (j+1) + ":");
                        Console.WriteLine();
                        if (j > 0) {
                            Console.WriteLine("The number on the Left is: " + mat[i, j - 1]);
                        }
                        if (i > 0) {
                            Console.WriteLine("The number on Up is: " + mat[i - 1, j]);
                        }
                        if (j < c - 1) {
                            Console.WriteLine("The number on Right is: " + mat[i, j + 1]);
                        }
                        if (i < l - 1) {
                            Console.WriteLine("The number on Down is: " + mat[i + 1, j]);
                        }
                    }
                    else {
                        Console.WriteLine("This number wasn't select as a reference!: " + mat[i, j]);
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
