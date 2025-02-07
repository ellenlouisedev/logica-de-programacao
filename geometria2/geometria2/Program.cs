// Console.RedLine - Lê o valor digitado pelo usuário
// Convert.ToDOuble - Converte um valor para o tipo double

Console.WriteLine("Digite a largura do terreno: ");
double largura = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o comprimento do terreno: ");
double comprimento = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Largura: " + largura);
Console.WriteLine("Comprimento: " + comprimento);
double area = comprimento * largura;
Console.WriteLine("A área do terreno é: " +  area);

// Calcule o perímetro do terreno

double perimetro = 2 * (comprimento + largura);
Console.WriteLine("O perímetro do terreno é: " + perimetro);

// Calcule o preço do terreno, considere que cada metro quadrado vale R$100

double metro_quadrado = 100;
double valor = area * metro_quadrado;
Console.WriteLine("O valor do terreno é: " + valor);