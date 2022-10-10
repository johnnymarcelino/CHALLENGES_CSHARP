using System;
using System.Globalization;


/*
CHALLENGE 08:
Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
(primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
para o aluno obter o mínimo para ser aprovado (que é 60 pontos). Você deve criar uma classe Aluno para resolver
este problema. 
*/


namespace CLG_08 {
    internal class Program {
        static void Main(string[] args) {

            Student student = new Student();
            
            Console.WriteLine("What is the name of the student ? ");
            student.Name = Console.ReadLine();
            Console.WriteLine("Enter with the three grades at the fisrt three trimesters in the school: ");
            student.Grade1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Grade2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            student.Grade3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"Final Grade is: {student.SumGrades().ToString("F2", CultureInfo.InvariantCulture)}");

            if (student.SumGrades() >= 60.0) {
                Console.WriteLine("Approved Student!");
            }
            else {
                Console.WriteLine("Reproved Student!");
                Console.WriteLine($"You need {student.TotalMissing()} points to pass!");
            }
        }
    }
}
