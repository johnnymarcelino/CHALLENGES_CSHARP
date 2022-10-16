using System;


/*
CHALLENGE 13:
Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de
N funcionários. Não deve haver repetição de id.

Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
conforme exemplos.

Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa
ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de
aumento por porcentagem dada.
*/


namespace CLG_13 {
    internal class Program {
        static void Main(string[] args) {

            int n = int.Parse(Console.ReadLine());
            //Console.WriteLine(n);

            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++) {
                string[] values = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);
        }
    }
}
