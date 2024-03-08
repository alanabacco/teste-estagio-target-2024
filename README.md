# Teste para estágio da Target, Ribeirão Preto - 2024

Repositório criado para armazenar o código referente ao teste para estágio da Target, Ribeirão Preto - 2024. Abaixo seguem as questões e respostas do teste. O código das questões 1, 2 e 5 foi feito em [C#](https://learn.microsoft.com/pt-br/dotnet/csharp/).

## Questões

1- Observe o trecho de código abaixo:

```
int INDICE = 13, SOMA = 0, K = 0;
enquanto K < INDICE faça
{
  K = K + 1;
  SOMA = SOMA + K;
}
imprimir(SOMA);
```

Ao final do processamento, qual será o valor da variável SOMA?

Resposta: `91` </br>
Também disponível no código em `Program.cs`

```csharp
static void Question01()
{
    int indice = 13, soma = 0, k = 0;
    while (k < indice)
    {
        k++;
        soma += k;
    }
    Console.WriteLine($"O valor de soma é {soma}"); // 91
}
```

---

2- Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

Resposta também disponível no código em `Program.cs`

```csharp
static void Question02()
{
    Console.Write("Digite um número inteiro para saber se ele faz parte da sequência de Fibonacci: ");
    int number = Convert.ToInt16(Console.ReadLine());

    var isFibonacci = IsFibonacci(number);

    if (isFibonacci)
    {
        Console.WriteLine($"{number} pertence à sequência de Fibonacci.");
    }
    else
    {
        Console.WriteLine($"{number} não pertence à sequência de Fibonacci.");
    }

    static bool IsFibonacci(int number)
    {
        if (number < 0) return false;
        if (number == 0 | number == 1) return false;

        var a = 0;
        var b = 1;

        while (a <= number)
        {
            if (a == number) return true;
            int temp = a;
            a = b;
            b = temp + b;
        }

        return false;
    }
}
```

---

3- Descubra a lógica e complete o próximo elemento:

a. 1, 3, 5, 7, \_\_\_ </br>
Resposta: `9`. Incrementando de 2 em 2.

b. 2, 4, 8, 16, 32, 64, \_\_\_\_ </br>
Resposta: `128`. Multiplicando o número por 2.

c. 0, 1, 4, 9, 16, 25, 36, \_\_\_\_ </br>
Resposta: `49`. O número somado aumenta dois a cada iteração. Ex: 4-1=3, 9-4=5, 16-9=7...

d. 4, 16, 36, 64, \_\_\_\_ </br>
Resposta: `100`. O número somado aumenta 8, então 64-36=28, 28+8=36, 36+64=`100`.

e. 1, 1, 2, 3, 5, 8, \_\_\_\_ </br>
Resposta: `13`. O próximo número é a soma dos dois números anteriores.

f. 2,10, 12, 16, 17, 18, 19, \_\_\_\_ </br>
Resposta: `27`. Os números estão aumentando na sequência de 8,2,4,1,1,1. Então 19+8=`27`.

---

4- Você está em uma sala com três interruptores, cada um conectado a uma lâmpada em uma sala diferente. Você não pode ver as lâmpadas da sala em que está, mas pode ligar e desligar os interruptores quantas vezes quiser. Seu objetivo é descobrir qual interruptor controla qual lâmpada.

Como você faria para descobrir, usando apenas duas idas até uma das salas das lâmpadas, qual interruptor controla cada lâmpada?

Resposta:

1. Acendo dois interruptores e vou em uma sala
2. se a lâmpada estiver apagada, sei que o interruptor que não acendi pertence a ela, e as duas salas restantes estariam acesas
3. então, se eu apagar um dos dois interruptores e for em uma dessas duas salas, se estiver apagada, o interruptor que apaguei pertence a ela, se estiver acesa, o interruptor que apaguei pertence a outra sala e assim descubro qual interruptor pertence a qual sala.

---

5- Escreva um programa que inverta os caracteres de um string.

IMPORTANTE:

a. Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;

b. Evite usar funções prontas, como, por exemplo, reverse;

Resposta também disponível no código em `Program.cs`

```csharp
static void Question05()
{
    Console.Write("Escreva uma palavra que vou mostrar ela invertida: ");
    string word = Console.ReadLine()!;

    List<char> wordList = [];
    foreach (char item in word)
    {
        wordList.Add(item);
    }

    List<char> wordReversedList = [];
    int wordListLength = wordList.Count;
    for (var i = wordListLength - 1; i >= 0; i--)
    {
        wordReversedList.Add(wordList[i]);
    }

    string reversedWord = "";
    foreach (var item in wordReversedList)
    {
        reversedWord += item;
    }

    Console.Write(reversedWord);
}
```
