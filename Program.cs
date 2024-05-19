Console.WriteLine("Calculadora\nInforme os valores");
int a = int.Parse(Console.ReadLine()!);
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("1-Somar");
string op = Console.ReadLine()!;

switch (op){
    case "1":
        Somar(a, b);
        break;
    case "0":
        return;
    default:
        Console.WriteLine("opcao nao encontrada");
        break;
}


static void Somar(int a, int b) =>
    Console.WriteLine($"Resultado: {a + b}");