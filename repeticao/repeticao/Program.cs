Console.WriteLine("Digite o 1° número");
int n1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a razão");
int r = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a quantidade de números");
int qtd = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < qtd; i++)
{
    Console.Write(n1 + " ");
    n1 = n1 + r;
    
}