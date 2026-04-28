/*
Um estacionamento deseja registrar a entrada de veículos durante o dia. 
Para cada veículo que entrar, o atendente deve informar a placa. 
O sistema deve continuar pedindo novas placas enquanto o 
operador desejar continuar o atendimento.

Ao final, o programa deve mostrar:
- a quantidade total de veículos registrados.

Regras da atividade
- o programa deve usar while para repetir o cadastro das placas;
- após cada tentativa de cadastro, o programa deve perguntar se o operador deseja continuar;
- ao final, exibir a quantidade de veículos registrados com sucesso.

*/
public static class Atv03R
{
    public static void Executar()
    {
        string placa;
        string continuar;
        int quantidadeVeiculos = 0;

        Console.Write("Deseja registrar um veículo? (s/n): ");
        continuar = Console.ReadLine()!;

        while (continuar == "s" || continuar == "S")
        {
            Console.Write("Digite a placa do veículo: ");
            placa = Console.ReadLine()!;

            quantidadeVeiculos = quantidadeVeiculos + 1;

            Console.WriteLine("Veículo registrado com sucesso.");
            Console.WriteLine();

            Console.Write("Deseja registrar outro veículo? (s/n): ");
            continuar = Console.ReadLine()!;
            Console.WriteLine();
        }

        Console.WriteLine($"Quantidade de veículos registrados: {quantidadeVeiculos}");
    }
}