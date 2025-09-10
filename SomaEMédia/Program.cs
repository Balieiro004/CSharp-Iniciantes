using System;

/*Soma e Média
Objetivo: usando uma aplicação do tipo console do dotnet, criar uma aplicação que lê 3 à 10 números e realiza a soma e a média deles. Faça o controle de versionamento da sua aplicação com git e suba a mesma para o github.

Novos conceitos ou funcionalidades desse exercício
Faremos uso de loops e arrays no exercício, tente fazer o mesmo usando ´for´ e o ´foreach´. Faça o possível também para criar métodos que recebam parâmetros e retornem valores, dessa forma teremos uma codificação mais limpa e de fácil leitura.

Estudar:

Criação de métodos
Receber parâmetros nos métodos
Retorno de valores nos métodos
Classe ´List´ do Dotnet
Loops ´for´ e ´foreach´
Requisitos para desenvolver a aplicação
Ao abrir a aplicação deverá ser solicitado a quantidade de números que o usuário deseja informar. O número de valores deve ser entre 3 e 10.

A aplicação deve aceitar números decimais, positivos e negativos.

A aplicação deve percorrer a lista de números, calcular a soma e a média dos valores informados e imprimir o resultado para o usuário.

Opcional

Fazer o controle de versionamento da sua aplicação usando git;
Subir a aplicação para um repositório do github.
Desafios
Validar se os números digitados pelo usuário são validos (estude o TryParse para fazer esse desafio).
Faça o uso da biblioteca "System.Linq" do Dotnet para fazer a soma (sum) e a média (average) da lista (array) de valores.*/

namespace SomaEMédia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Soma e Média");
            Console.Write("Informe quantos números quer digitar entre 3 e 10: ");
            int quantidadeDeValores = int.Parse(Console.ReadLine());
            double[] numeros = new double[quantidadeDeValores];

            if (quantidadeDeValores <= 2 || quantidadeDeValores > 10)
            {
                Console.WriteLine("Quantidade de valor insuficiente ou maior do que permitido");
            }
            else
            {
                for (int i = 0; i < quantidadeDeValores; i++)
                {
                    Console.Write($"Valor {i + 1}: ");
                    double valor = double.Parse(Console.ReadLine());
                    numeros[i] = valor;
                }
            }
            foreach (int i in numeros)
            {
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
