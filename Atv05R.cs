/*
Melhore o programa do exercício 4 para que ele possa receber um número inteiro do usuário 
e mostrar a tabuada desse número. O programa deve continuar pedindo um número até que o 
usuário digite um número negativo, momento em que o programa deve ser encerrado.

Regras:
- utilizar do/while em um dos laços de repetição
- utilizar while em um dos laços de repetição
- apresentar cada operação de forma organizada
- mostrar a tabuada completa do número informado pelo usuário
*/
public static class Atv05R
{
    public static void Executar()
    {
        int numero;
        int contador;
        string opcao;

        do
        {
            Console.Write("Digite a tabuada desejada: ");
            numero = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Tabuada do {numero}:");
            contador = 0;

            while (contador <= 10)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                contador++;
            }
            Console.WriteLine();
            Console.Write("Deseja calcular outra tabuada? (s/n): ");
            opcao = Console.ReadLine()!;
            // Linha em branco para melhor organização
        } while (opcao != "n" && opcao != "N");

        Console.WriteLine("Programa encerrado. Obrigado por usar!");
    }
}
