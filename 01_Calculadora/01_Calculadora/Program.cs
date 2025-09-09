using System;

/*Calculadora
Objetivo: usando uma aplicação do tipo console do dotnet, criar uma calculadora simples que terá as operações de soma, subtração, multiplicação e divisão. Faça o controle de versionamento da sua aplicação com git e suba a mesma para o github.

Novos conceitos ou funcionalidades desse exercício
Nossa primeira aplicação é bem simples e, se você já tem conhecimentos em lógica de programação, algoritmos e alguma linguagem de programação não terá problemas para desenvolver a aplicação. Faremos uso de operadores condicionais, estrutura condicional 'switch', criação e chamada de métodos simples.

Requisitos para desenvolver a aplicação
Ao entrar na calculadora o usuário deverá ter um menu com as opções 1, 2, 3, 4 e 0. Sendo elas:

1 - Somar

2 - Subtrair

3 - Multiplicar

4 - Dividir

0 - Sair

Todas as operações devem solicitar que o usuário entre com dois valores e então estes valores devem ser utilizados para realizar a operação escolhida. Exemplo de fluxo da operação de Soma:

Aplicação solicita o primeiro valor;
Usuário digita valor e pressiona enter;
Aplicação solicita o segundo valor;
Usuário digita valor e pressiona enter;
Aplicação escreve em tela o resultado da soma;
Usuário pressiona Enter;
Aplicação retorna para o menu;
Para a operação de divisão, validar se o divisor é 0. Se verdadeiro deve ser exibida a mensagem "Não é possível dividir por zero."

Opcional

Fazer o controle de versionamento da sua aplicação usando git;
Subir a aplicação para um repositório do github.
Desafios
Crie uma nova opção na calculadora (opção número 5 do menu) que retorne o resto da divisão.
Crie uma nova opção na calculadora (opção número 6 do menu) que retorne o resultado da potenciação de uma determinada base pelo seu expoente. Exemplo 2³ = 8.

*/

namespace _01_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");

            bool continuar = true;

            do
            {
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Dividir");
                Console.WriteLine("5 - Resto da divisão");
                Console.WriteLine("6 - Expoente");
                Console.WriteLine("0 - Sair");

                Console.Write("Selecione uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                double valor1 = 0;
                double valor2 = 0;

                switch (opcao)
                {
                    case 0:
                        continuar = false;
                        break;
                    case 1: 
                        Console.Write("Valor 1: ");
                        valor1 = double.Parse(Console.ReadLine());
                        Console.Write("Valor 2: ");
                        valor2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {valor1 + valor2}");
                        break;
                    case 2:
                        Console.Write("Valor 1: ");
                        valor1 = double.Parse(Console.ReadLine());
                        Console.Write("Valor 2: ");
                        valor2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {valor1 - valor2}");
                        break;
                    case 3:
                        Console.Write("Valor 1: ");
                        valor1 = double.Parse(Console.ReadLine());
                        Console.Write("Valor 2: ");
                        valor2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {valor1 * valor2}");
                        break;
                    case 4:
                        Console.Write("Valor 1: ");
                        valor1 = double.Parse(Console.ReadLine());
                        Console.Write("Valor 2: ");
                        valor2 = double.Parse(Console.ReadLine());

                        if(valor2 == 0)
                        {
                            Console.WriteLine("Não é possível dividir por zero.");
                            break;
                        }
                        Console.WriteLine($"Resultado: {valor1 / valor2}");
                        break;
                    case 5:
                        Console.Write("Valor 1: ");
                        valor1 = double.Parse(Console.ReadLine());
                        Console.Write("Valor 2: ");
                        valor2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {valor1 % valor2}");
                        break;
                    case 6:
                        Console.Write("Valor 1: ");
                        valor1 = double.Parse(Console.ReadLine());
                        Console.Write("Valor 2: ");
                        valor2 = double.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado: {Math.Pow(valor1, valor2)}");
                        break;

                    default:
                        break;
                }
            } while (continuar);

            Console.WriteLine("Aberte qualquer tecla para finalizar");
            Console.ReadLine();
        }
    }
}
