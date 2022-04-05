public class Individuo
{
    public string Nome { get; set; }
    public float Peso { get; set; }
    public float Altura { get; set; }
    private double Imc;
    public double CalcularIMC { 
        get {
            Imc = Peso / (Altura * Altura);
            return Imc;
            }
        }

    public Individuo(string nome, float peso, float altura)
    {
        Nome = nome;
        Peso = peso;
        Altura = altura;
    }

    public void Situacao()
    {
        if(Imc < 17.00)
        {
            Console.WriteLine("Situação: Muito abaixo do peso");
        }
        else if(Imc >= 17.00 && Imc < 18.50)
        {
            Console.WriteLine("Situação: Abaixo do peso");
        }
        else if(Imc >= 18.50 && Imc < 25.00)
        {
            Console.WriteLine("Situação: Peso normal");
        }
        else if(Imc >= 25.00 && Imc < 30.00)
        {
            Console.WriteLine("Situação: Acima do peso");
        }
        else if(Imc >= 30.00 && Imc < 35.00)
        {
            Console.WriteLine("Situação: Obesidade I");
        }
        else if(Imc >= 35.00 && Imc < 40.00)
        {
            Console.WriteLine("Situação: Obesidade II (severa)");
        }
        else
        {
            Console.WriteLine("Situação: Obesidade III (mórbida)");
        }

        double pesoIdealAbaixo = 18.50 * (Altura * Altura);
        double pesoIdealAcima = 24.99 * (Altura * Altura);

        if(Peso <= pesoIdealAbaixo)
        {
            Console.WriteLine("Você necessita ganhar {0} kg para chegar no ao peso 'ideal'", pesoIdealAbaixo - Peso);
        }
        else if(Peso >= pesoIdealAcima)
        {
            Console.WriteLine("Você necessita perder {0} kg para chegar no ao peso 'ideal'", Peso - pesoIdealAcima);
        }
    }
}