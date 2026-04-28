int opcao;

do
{
    Console.Clear();

    Console.WriteLine("Escolha a atividade:");
    Console.WriteLine("1 - Atividade 01");
    Console.WriteLine("2 - Atividade 02");
    Console.WriteLine("3 - Atividade 03");
    Console.WriteLine("4 - Atividade 04");
    Console.WriteLine("5 - Atividade 05");
    Console.WriteLine("6 - Aula");
    Console.WriteLine("0 - Para sair");
    Console.Write("Digite a opção desejada: ");

    /*
    Quando usamos o ReadLine, o compilador aguarda o usuário
    digitar algo e pressionar Enter para retornar a string digitada.
    */
    opcao = int.Parse(Console.ReadLine()!);
    Console.WriteLine();

    switch (opcao)
    {
        case 1:
            Atv01.Executar();
            break;

        case 2:
            Atv02.Executar();
            break;

        case 3:
            Atv03.Executar();
            break;

        case 4:
            Atv04.Executar();
            break;

        case 5:
            Atv05R.Executar();
            break;

        case 6:
            Aula.Executar();
            break;

        case 0:
            Console.WriteLine("Saindo...");
            break;

        default:
            Console.WriteLine("Opção inválida.");
            break;
    }

    if (opcao != 0)
    {
        Console.WriteLine();
        Console.WriteLine("Pressione uma tecla para voltar ao menu...");
        Console.ReadKey(); // O compilador aguarda o usuário pressionar uma tecla para continuar. 
    }

} while (opcao != 0);

Console.WriteLine("Fim de programa!!");