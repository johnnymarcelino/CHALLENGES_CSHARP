﻿using System;
using System.Collections.Generic;
using System.IO;
using CLG_25.Entities;


/*
CHALLENGE 25:
Um site de internet registra um log de acessos dos usuários. Um
registro de log consiste no nome de usuário e o instante em que o
usuário acessou o site no padrão ISO 8601, separados por espaço,
conforme exemplo. Fazer um programa que leia o log de acessos a
partir de um arquivo, e daí informe quantos usuários distintos
acessaram o site.
*/


namespace CLG_25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<LogRecord> records = new HashSet<LogRecord>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(" ");
                        string name = line[0];
                        DateTime instant = DateTime.Parse(line[1]);
                        records.Add(new LogRecord { Username = name, Instant = instant });
                    }
                    Console.WriteLine("Total users: " + records.Count);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
