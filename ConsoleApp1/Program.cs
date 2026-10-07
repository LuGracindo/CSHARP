/* Crie um programa em que o usuário precisa digitar um nome e uma mensagem de boas vindas personalizada com o nome dele é exibida:  Olá, Welisson! Seja muito bem-vindo!

Console.WriteLine("Digite seu Nome: ");

string nome = Console.ReadLine() ?? "";

Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo");
*/

/* Crie um programa que concatene um nome e um sobrenome inseridos pelo usuário e ao final exiba o nome completo.
Console.WriteLine("Digite seu Nome: ");

string nome = Console.ReadLine() ?? "";

Console.WriteLine("Digite seu Sobrenome: ");

string sobrenome = Console.ReadLine() ?? "";

Console.WriteLine($"Olá, {nome} {sobrenome}! Seja muito bem-vindo");
*/

/* 1. Crie um programa com 2 valores do tipo double já declarados que retorne:
    - A soma entre esses dois números;
    - A subtração entre os dois números;
    - A multiplicação entre os dois números;
    - A divisão entre os dois números (vale uma verificação se o segundo número é 0!);
    - A média entre os dois números.

Console.WriteLine("Digite o primeiro valor: ");

double num1 = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo valor: ");

double num2 = int.Parse(Console.ReadLine());

if (num2 == 0)
    Console.WriteLine($"A divisão por 0 não pode ser feita");

Console.WriteLine($"A soma entre os números é: {num1 + num2}");
Console.WriteLine($"A subtração entre os números é: {num1 - num2}");
Console.WriteLine($"A multiplicação entre os números é: {num1 * num2}");

if (num2 > 0)
    Console.WriteLine($"A divisão entre os números é: {num1 / num2}");


Console.WriteLine($"A média entre os números é: {(num1 + num2) / 2}");
*/


/* Crie um programa em que o usuário digita uma ou mais palavras e é exibido a quantidade de caracteres que a palavra inserida tem. 
Console.Write("Digite uma ou mais palavras: ");
string texto = Console.ReadLine() ?? "";

int contador = 0;

foreach (char caractere in texto)
{
    if (caractere != ' ')
    {
        contador++;
    }
}

Console.WriteLine($"Quantidade de caracteres: {contador}");
 */

/* 1. Crie um programa em que o usuário precisa digitar a placa de um veículo e o programa verifica se a placa é válida, seguindo o padrão brasileiro válido até 2018:
    - A placa deve ter 7 caracteres alfanuméricos;
    - Os três primeiros caracteres são letras (maiúsculas ou minúsculas);
    - Os quatro últimos caracteres são números;
    
    Ao final, o programa deve exibir ***Verdadeiro*** se a placa for válida e ***Falso*** caso contrário 

Console.WriteLine("Digite a placa do seu carro: ");

string placa = Console.ReadLine() ?? "";

bool placaValida = true;

if (placa.Length != 7)
{
    placaValida = false;
} else
{
    for (int i = 0; i < 3; i++)
    {
        if (!char.IsLetter(placa[i]))
        {
            placaValida = false;
        }
    }
    
    for (int i = 3; i < 7; i++)
    {
        if (!char.IsDigit(placa[i]))
        {
            placaValida = false;
        }
    }
}

Console.WriteLine(placaValida ? "Verdadeiro" : "Falso");



 */


/* 1. Crie um programa que solicita ao usuário a exibição da data atual em diferentes formatos:
    - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).
    - Apenas a data no formato "01/03/2024".
    - Apenas a hora no formato de 24 horas.
    - A data com o mês por extenso. 

DateTime dataAtual = DateTime.Now;

Console.WriteLine($"Data completa: {dataAtual:dddd, dd 'de' MMMM 'de' yyyy HH:mm:ss}");
Console.WriteLine($"Apenas a data: {dataAtual:dd/MM/yyyy}");
Console.WriteLine($"Apenas a hora: {dataAtual:HH:mm}");
Console.WriteLine($"Data com mês por extenso: {dataAtual:dd 'de' MMMM 'de' yyyy}");

 */