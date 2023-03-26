/*
Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. 

Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado esperado.

Entrada
O arquivo de entrada contém três valores inteiros.

Saída
Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".
*/
using System;

class Program {
    static void Main(string[] args) {

      int A = int.Parse(Console.ReadLine());
      int B = int.Parse(Console.ReadLine());
      int C = int.Parse(Console.ReadLine());

      int [] numeros = new int [3] {A, B, C};
      Array.Sort(numeros);

      Console.WriteLine($"{numeros[2]} eh o maior");
    }
}
