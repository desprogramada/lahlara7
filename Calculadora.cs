using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetosC_
{
    public class Program
    {
        static void Main(string[] args){
            int num1, num2, resultado = 0;
            string operacao;

            Console.WriteLine("Digite o primeiro número: ");
            num1 = int.Parse(Console.ReadLine());

             Console.WriteLine("Digite a operação: ");
            operacao = Console.ReadLine();

             Console.WriteLine("Digite o segundo número: ");
            num2 = int.Parse(Console.ReadLine());

            switch(operacao){
                case "+":
                resultado = num1 + num2;
                break;

                case "-":
                resultado = num1 - num2;
                break;

                case "*":
                resultado = num1 * num2;
                break;

                case "/":
                resultado = num1 / num2;
                break;

                default:
                Console.WriteLine("Operação inválida");
                break;

            }

            Console.WriteLine("{0} {1} {2} = {3}", num1,operacao,num2,resultado);

            Console.ReadKey(true);
        }
    } 
}

 
