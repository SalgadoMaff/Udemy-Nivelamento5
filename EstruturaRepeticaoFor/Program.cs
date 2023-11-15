using System.ComponentModel;
using System.Globalization;

Console.WriteLine("1 : Numeros impares");
Console.WriteLine("2 : Numeros dentro do intervalo [10,20]");
Console.WriteLine("3 : Casos de Teste");
Console.WriteLine("4 : Divisão");
Console.WriteLine("5 : Fatorial");
Console.WriteLine("6 : Todos os divisores");
Console.WriteLine("7 : Cubo de numeros");
Console.Write("\nOpção:");
int op = int.Parse(Console.ReadLine());
Console.Clear();
switch (op) {
    case 1:
        Console.Write("Digite um numero de 1 até 1000: ");
        int impar = int.Parse(Console.ReadLine());
        for (int i = 1; i < impar; i++) {
            if (i % 2 != 0) {
                Console.WriteLine(i);
            }
        }
        break;
    case 2:
        Console.Write("Digite quantos numeros quer inserir: ");
        int qtd = int.Parse(Console.ReadLine());
        Console.Clear();
        int IN = 0;
        int OUT = 0;
        for (int i = 0; i < qtd; i++) {
            Console.Write("Digite numero: ");
            int numm = int.Parse(Console.ReadLine());
            if (numm >= 10 && numm <= 20) {
                IN++;
            }
            else {
                OUT++;
            }

        }
        Console.WriteLine($"{IN} in");
        Console.WriteLine($"{OUT} out");
        break;
    case 3:
        Console.Write("Digite numero de casos teste: ");
        int N = int.Parse(Console.ReadLine());
        for (int i = 0; i < N; i++) {
            Console.Write($"Digite valores: ");
            string[] teste = Console.ReadLine().Split(' ');
            float a = float.Parse(teste[0], CultureInfo.InvariantCulture);
            float b = float.Parse(teste[1], CultureInfo.InvariantCulture);
            float c = float.Parse(teste[2], CultureInfo.InvariantCulture);

            float media = ((a * 2) + (b * 3) + (c * 5)) / 10;
            Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));
        }
        
        break;
    case 4:
        Console.Write("Digite quantidade de casos: ");
        int Num = int.Parse(Console.ReadLine());
        for (int i = 0; i < Num; i++) {
            Console.Write("Digite par de numeros: ");
            string[] linha = Console.ReadLine().Split(' ');
            int a = int.Parse(linha[0]);
            int denominador = int.Parse(linha[1]);
            Console.WriteLine();
            if (denominador == 0) {
                Console.WriteLine("divisao impossivel");
            }
            else {
                Console.WriteLine((a/denominador).ToString("F1",CultureInfo.InvariantCulture));
            }
        }
        break;
    case 5:
        Console.Write("Digite valor para calcular fatorial: ");
        int fat = int.Parse(Console.ReadLine());
        int calc = 1;
        for (int i = 0; i < fat; i++) {
            calc *= (fat - i);
        }
        Console.WriteLine(calc);
        break;
    case 6:
        Console.Write("Digite numero para calcular divisores: ");
        int num = int.Parse(Console.ReadLine());
        for (int i = 1; i <= num; i++) {
            if (num % i == 0) {
                Console.WriteLine(i);
            }
        }
        break;
    case 7:
        Console.Write("Digite numero para calcular quadrados e cubos: ");
        int NUM = int.Parse(Console.ReadLine());
        for(int i = 1; i <= NUM; i++) {
            Console.WriteLine($"{i} {i*i} {i*i*i}");
        } 

        break;
    default:
        break;
}