// Declarar uma variável string e inserir uma palavra
Console.WriteLine("Digite uma palavra:");
String palavra = Console.ReadLine();

// Digitar uma letra
Console.WriteLine("Digite uma letra");
String letra = Console.ReadLine();
int cont = 0;

// Criar uma estrutura de repetição para percorrer o vetor de string
for (int i = 0; i < palavra.Length; i++)
{
    // Escrever letra por letra da palavra separado por espaço
    // Console.Write(palavra[i] + " ");
    if (letra[0] == palavra[i])
    {
        cont++;
    }
}
// Verificar se a palavra possui essa letra 
Console.WriteLine("A letra " + letra + " foi encontrada " + cont + " vezes.");