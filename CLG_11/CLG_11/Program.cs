using System;

/*
CHALLENGE 11:
A dona de um pensionato possui dez quartos para alugar para estudantes,
sendo esses quartos identificados pelos números 0 a 9.

Quando um estudante deseja alugar um quarto, deve-se registrar o nome
e email deste estudante.

Fazer um programa que inicie com todos os dez quartos vazios, e depois
leia uma quantidade N representando o número de estudantes que vão
alugar quartos (N pode ser de 1 a 10). Em seguida, registre o aluguel dos
N estudantes. Para cada registro de aluguel, informar o nome e email do
estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha
que seja escolhido um quarto vago. Ao final, seu programa deve imprimir
um relatório de todas ocupações do pensionato, por ordem de quarto.
*/

namespace CLG_11 {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("How many rooms are avaliables: ");
            int quantityRooms = int.Parse(Console.ReadLine());

            BoardingSchool[] roomsAvaliable = new BoardingSchool[quantityRooms];

            Console.WriteLine("How many rooms will be rented ?");
            Console.Write("Type here: ");
            int quantityRent = int.Parse(Console.ReadLine());
            //BoardingSchool[] renter = new BoardingSchool[quantityRent];

            Console.WriteLine("The rooms avalibles are ?");
            for (int i = 0; i < quantityRooms; i++) {
                roomsAvaliable[i] = new BoardingSchool();
                Console.WriteLine("Room0" + i);
            }
            Console.WriteLine();

            string name;
            string email;
            int room;
            //BoardingSchool[] nameRenter = new BoardingSchool();

            for (int i = 0; i < quantityRent; i++) {
                Console.WriteLine();
                Console.WriteLine("Room #0" + (i + 1));
                Console.WriteLine("What are the datas of the student will rent this room ?");
                Console.Write("Name: ");
                name = Console.ReadLine();
                Console.Write("E-mail: ");
                email = Console.ReadLine();
                Console.Write("Room: ");
                room = int.Parse(Console.ReadLine());
                roomsAvaliable[room] = new BoardingSchool { Renter = name, Email = email, Rooms = room};

                //boardingSchool.ToString();
            }

            Console.WriteLine("Busy rooms: ");
            for (int i = 0; i < quantityRooms; i++) {
                //if (roomsAvaliable[i] != null) {
                Console.WriteLine(roomsAvaliable[i].Rooms + ": " 
                + roomsAvaliable[i].Renter + ", " + roomsAvaliable[i].Email);
                //}
                //else {
                //    Console.WriteLine();
                //}
                //else {
                //    Console.WriteLine(roomsAvaliable[i].Rooms + ": " + roomsAvaliable[i].Renter + ", " + roomsAvaliable[i].Email + ", ");
            }
        }
    }
}
