using ProjetoEstacionamentoDIO.Models;
Console.OutputEncoding = System.Text.Encoding.UTF8; // coloca para UTF-8

decimal precoInicial = 0;
decimal precoHora = 0;

Console.WriteLine("Seja bem vindo ao sistema de estacionamento! \n" + "Digite o preço inicial:");
precoInicial = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine("Agora digite o preço por hora:");
precoHora = Convert.ToDecimal(Console.ReadLine());

Estacionamento estacionar = new Estacionamento(precoInicial, precoHora);

string opcao = string.Empty;

bool exibirMenu = true; // menu interativo

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Selecione sua opção:");
    Console.WriteLine("1-Cadastrar veiculo");
    Console.WriteLine("2-Remover veiculo");
    Console.WriteLine("3-Listar veiculos");
    Console.WriteLine("4-Encerrar programa");

    switch (Console.ReadLine())
    {
        case "1":
            estacionar.AdicionarVeiculo();
            break;
        
        case "2":
            estacionar.RemoverVeiculo();
            break;
        
        case "3":
            estacionar.ListarVeiculos();
            break;
        
        case "4":
            exibirMenu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;
    }

    Console.WriteLine("Digite uma tecla para continuar");
    Console.ReadLine();
}

Console.WriteLine("Fechando o programa...\n "+ "Programa fechado!");