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

    public string Condicao()
    {
        if(Imc < 17.00)
        {
            return "Situação: Muito abaixo do peso";
        }
        else if(Imc >= 17.00 && Imc < 18.50)
        {
            return "Situação: Abaixo do peso";
        }
        else if(Imc >= 18.50 && Imc < 25.00)
        {
            return "Situação: Peso normal";
        }
        else if(Imc >= 25.00 && Imc < 30.00)
        {
            return "Situação: Acima do peso";
        }
        else if(Imc >= 30.00 && Imc < 35.00)
        {
            return "Situação: Obesidade I";
        }
        else if(Imc >= 35.00 && Imc < 40.00)
        {
            return "Situação: Obesidade II (severa)";
        }
        else
        {
            return "Situação: Obesidade III (mórbida)";
        }
    }

    public string SituacaoSaudavel()
    {
        if(Peso <= (18.50 * (Altura * Altura)))
        {
            return ($"Você necessita ganhar {(18.50 * (Altura * Altura)) - Peso} kg para chegar no ao peso 'ideal'");
        }
        else if(Peso >= (24.99 * (Altura * Altura)))
        {
            return ($"Você necessita perder {Peso - (24.99 * (Altura * Altura))} kg para chegar no ao peso 'ideal'");
        }
        return "0";
    }
}