using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira seu peso: (ex: 1,67)");
            float peso = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Insira sua altura: (ex: 1,79)");
            float altura = Convert.ToSingle(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("Nome: {0}, altura: {1} e peso: {2}", nome ,altura, peso);
            Console.WriteLine("O IMC é {0}", imc);
        }
    }
}
