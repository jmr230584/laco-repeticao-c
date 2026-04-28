public static class Atv02R

{
    public static void Executar()
    {
        double valorCompra;
        double totalArrecadado = 0;
        double mediaCompras = 0;
        int quantidadeCompras = 0;
        string continuar;

        do
        {
            Console.Write("Digite o valor da compra: R$ ");
            valorCompra = double.Parse(Console.ReadLine()!);

            if (valorCompra > 0)
            {
                totalArrecadado = totalArrecadado + valorCompra;
                quantidadeCompras = quantidadeCompras + 1;
            }
            else
            {
                Console.WriteLine("Valor inválido. Digite um valor maior que zero.");
            }

            Console.Write("Deseja registrar outra compra? (s/n): ");
            continuar = Console.ReadLine()!;
            Console.WriteLine();

        } while (continuar == "s" || continuar == "S");

        Console.WriteLine($"Quantidade de compras registradas: {quantidadeCompras}");
        Console.WriteLine($"Total arrecadado: R$ {totalArrecadado}");

        if (quantidadeCompras > 0)
        {
            mediaCompras = totalArrecadado / quantidadeCompras;
            Console.WriteLine($"Valor médio das compras: R$ {mediaCompras}");
        }
        else
        {
            Console.WriteLine("Não há compras válidas para calcular a média.");
        }
    }
}