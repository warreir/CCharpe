﻿using System;
using ListaUm;

namespace CCharpe
{
    public class Program
    {
        static void Main(string[] args)
        {
            int op =0;
            do{
                Console.WriteLine("Digite a Lista");
                Console.WriteLine(
                    "1 ou 2-Lista um e dois\n"+
                    "3-Lista 3\n"+
                    "11-Sair \n"
                );
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:{
                        ListaUm.Program.ListaUm();
                        break;
                    }
                    case 2:{
                        ListaUm.Program.ListaUm();
                        break;
                    }
                    case 3:{
                        ListaTres.Program.ListaTres();
                        break;
                    }
                    case 11:{
                        break;
                    }
                    default:{
                        Console.WriteLine("numero inválido");
                        break;
                    }
                }
            }while(op!=11);
        }
    }
}
