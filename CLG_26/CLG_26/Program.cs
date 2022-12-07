using System;
using System.Collections.Generic;


/*
CHALLENGE 26:
Em um portal de cursos online, cada usuário possui um código único, representado por um número inteiro.
Cada instrutor do portal pode ter vários cursos, sendo que um mesmo aluno pode se matricular em quantos
cursos quiser. Assim, o número total de alunos de um instrutor não é simplesmente a soma dos alunos de 
todos os cursos que ele possui, pois pode haver alunos repetidos em mais de um curso.
O instrutor Alex possui três cursos A, B e C, e deseja saber seu número total de alunos. Seu programa
deve ler os alunos dos cursos A, B e C do instrutor Alex, depois mostrar a quantidade total e alunos dele.
*/


namespace CLG_26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.WriteLine("How many students for course A:");
            int studentsQuantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= studentsQuantity; i++)
            {
                Console.Write($"Enter with the code of the {i}° student of the course A: ");
                int studentCode = int.Parse(Console.ReadLine());
                courseA.Add(studentCode);
            }

            Console.WriteLine("How many students for course B:");
            studentsQuantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= studentsQuantity; i++)
            {
                Console.Write($"Enter with the code of the {i}° student of the course B: ");
                int studentCode = int.Parse(Console.ReadLine());
                courseB.Add(studentCode);
            }

            Console.WriteLine("How many students for course C:");
            studentsQuantity = int.Parse(Console.ReadLine());

            for (int i = 1; i <= studentsQuantity; i++)
            {
                Console.Write($"Enter with the code of the {i}° student of the course C: ");
                int studentCode = int.Parse(Console.ReadLine());
                courseC.Add(studentCode);
            }

            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);
            Console.WriteLine("Total students: " + all.Count);
        }
    }
}
