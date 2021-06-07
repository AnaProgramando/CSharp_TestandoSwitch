using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio_TestandoSwitch
{
    class Programa
    {
        static void Main(String[] args)
        {
            int mes = 1;
    
            switch (mes)
            {
                case 1:
                    Console.WriteLine("O mês selecionado foi Janeiro.");
                    break;
                case 2:
                    Console.WriteLine("O mês selecionado foi Fevereiro.");
                    break;
                case 3:
                    Console.WriteLine("O mês selecionado foi Março.");
                    break;
                case 4:
                    Console.WriteLine("O mês selecionado foi Abril.");
                    break;
                case 5:
                    Console.WriteLine("O mês selecionado foi Maio.");
                    break;
                case 6:
                    Console.WriteLine("O mês selecionado foi Junho.");
                    break;
                case 7:
                    Console.WriteLine("O mês selecionado foi Julho.");
                    break;
                case 8:
                    Console.WriteLine("O mês selecionado foi Agosto.");
                    break;
                case 9:
                    Console.WriteLine("O mês selecionado foi Setembro.");
                    break;
                case 10:
                    Console.WriteLine("O mês selecionado foi Outubro.");
                    break;
                case 11:
                    Console.WriteLine("O mês selecionado foi Novembro.");
                    break;
                case 12:
                    Console.WriteLine("O mês selecionado foi Dezembro.");
                    break;
                default:
                    Console.WriteLine("O mês selecionado foi inválido.");
                    break;
            }
            Console.ReadLine();
        }
    }
}