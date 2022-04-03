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

            if(imc < 17.00)
            {
                Console.WriteLine("Situação: Muito abaixo do peso");
            }
            else if(imc >= 17.00 && imc < 18.50)
            {
                Console.WriteLine("Situação: Abaixo do peso");
            }
            else if(imc >= 18.50 && imc < 25.00)
            {
                Console.WriteLine("Situação: Peso normal");
            }
            else if(imc >= 25.00 && imc < 30.00)
            {
                Console.WriteLine("Situação: Acima do peso");
            }
            else if(imc >= 30.00 && imc < 35.00)
            {
                Console.WriteLine("Situação: Obesidade I");
            }
            else if(imc >= 35.00 && imc < 40.00)
            {
                Console.WriteLine("Situação: Obesidade II (severa)");
            }
            else
            {
                Console.WriteLine("Situação: Obesidade III (mórbida)");
            }

            double pesoIdealAbaixo = 18.50 * (altura * altura);
            double pesoIdealAcima = 24.99 * (altura * altura);

            if(peso <= pesoIdealAbaixo)
            {
                Console.WriteLine("Você necessita ganhar {0} kg para chegar no ao peso 'ideal'", pesoIdealAbaixo - peso);
            }
            else if(peso >= pesoIdealAcima)
            {
                Console.WriteLine("Você necessita perder {0} kg para chegar no ao peso 'ideal'", peso - pesoIdealAcima);
            }
        }
    }
}
