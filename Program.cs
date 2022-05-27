using System;

class Program
{
    static void Main()
    {
        int v1, v2, soma;
        string nome;
        double cpf;

        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();
        Console.WriteLine("Digite seu cpf: ");
        cpf = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite o primeiro valor: ");
        v1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine());
        soma = v1 + v2;
        Console.WriteLine("A operacao do(a) {3} que pertence ao cpf {4}: a soma dos numeros {0} e {1} é igual a {2}",v1,v2,soma, nome, cpf);

    }
}
