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

            Individuo i1 = new Individuo(nome, peso, altura);

            Console.WriteLine("Nome: {0}, altura: {1} e peso: {2}", i1.Nome , i1.Altura, i1.Peso);
            Console.WriteLine("O IMC é {0}", i1.CalcularIMC);

            Console.WriteLine(i1.Condicao());

            if(String.Equals(i1.SituacaoSaudavel(), "0"))
            {
                Console.WriteLine("Parabéns, sua situação está saudavél");
            }
            else
            {
                Console.WriteLine(i1.SituacaoSaudavel());
            }
        }
    }
}
