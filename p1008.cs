/*
Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora e calcula o salário desse funcionário. 
A seguir, mostre o número e o salário do funcionário, com duas casas decimais.

Entrada
O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o número, 
quantidade de horas trabalhadas e o valor que o funcionário recebe por hora trabalhada, respectivamente.

Saída
Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço em branco antes e depois da igualdade. 
No caso do salário, também deve haver um espaço em branco após o $.
*/
using System;

class Program {
    static void Main(string[] args) {
      int NUMBER = int.Parse(Console.ReadLine());
      double HORAS_TRAB = double.Parse(Console.ReadLine());
      double VALOR_HR = double.Parse(Console.ReadLine());

      double SALARY = HORAS_TRAB * VALOR_HR;

      Console.WriteLine("NUMBER = " +NUMBER);
      Console.WriteLine("SALARY = U$ " +Math.Round(SALARY, 2));
    }
}
