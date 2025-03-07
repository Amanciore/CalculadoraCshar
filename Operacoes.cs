using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

class Program
{
    private static void GetV()
    {
        Console.WriteLine("Erro: não é possível dividir por zero.");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora Simples em C#");
        Console.WriteLine("-------------------------");

        while (true)
        {
            Console.WriteLine("=== Escolha uma operação ===");
            Console.WriteLine("1 - Soma (+)");
            Console.WriteLine("2 - Subtração (-)");
            Console.WriteLine("3 - Multiplicação (*)");
            Console.WriteLine("4 - Divisão (/)");
            Console.WriteLine("5 - Sair");

            Console.Write("Opção: ");
            if (!int.TryParse(Console.ReadLine(), out int escolha) || (escolha < 1 || escolha > 5))
            {
                Console.WriteLine("Opção inválida! Escolha um número de 1 a 5.");
                continue;
            }

            if (escolha == 5)
            {
                Console.WriteLine("Saindo...");
                break;
            }

            Console.Write("Digite o primeiro número: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Número inválido!");
                continue;
            }

            Console.Write("Digite o segundo número: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Número inválido!");
                continue;
            }

            if (escolha == 4 && num2 == 0)
            {
                GetV();
                continue;
            }

            double resultado = 0;
            switch (escolha)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = num1 / num2;
                    break;
            }

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
                

 