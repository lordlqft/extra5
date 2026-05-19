
/*
Um professor deseja criar um programa para ajudar alunos do ensino fundamental a 
estudar tabuada. O sistema deve permitir que o usuário escolha um número e exibir 
a tabuada de 1 até 10.
*/

/*
static int LerNumero(string mensagem)
{
    Console.Write(mensagem);
    int numero = int.Parse(Console.ReadLine()!);
    return numero;
}

static void ExibirTabuada(int numero)
{
    Console.WriteLine($"Tabuada do {numero}:");
    int tabuada = 0;
    while (tabuada <= 10)
    {
        Console.WriteLine($"{numero} x {tabuada} = {numero * tabuada}");
        tabuada++;
    }
    Console.WriteLine("Espere: 3");
    Task.Delay(1000).Wait();
    Console.WriteLine("Espere: 2");
    Task.Delay(1000).Wait();
    Console.WriteLine("Espere: 1");
    Task.Delay(1000).Wait();
    Console.Clear();
}

static string LerContinuacao()
{
    Console.Write("Deseja ver outra tabuada? (s/n): ");
    string continuar = Console.ReadLine()!;
    return continuar;
}

static bool DesejaContinuar(string resposta)
{
    if (resposta == "s" || resposta == "S")
    {
        return true;
    }
    else
    {
        return false;
    }
}

ExecutarSistema();
*/