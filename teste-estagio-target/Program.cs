class Program
{
    static void Main()
    {
        ShowMenu();
    }

    private static void ShowMenu()
    {
        Console.WriteLine("\n\n===== Menu =====");
        Console.WriteLine("Digite 1 para rodar a questão 1");
        Console.WriteLine("Digite 2 para rodar a questão 2");
        Console.WriteLine("Digite 5 para rodar a questão 5");
        Console.WriteLine("Digite -1 para sair");

        Console.Write("\nDigite a sua opção: ");
        int option = Convert.ToInt16(Console.ReadLine());

        switch (option)
        {
            case 1:
                Question01();
                break;
            case 2:
                Question02();
                break;
            case 5:
                Question05();
                break;
            case -1:
                break;
            default:
                Console.WriteLine("Opção inválida");
                ShowMenu();
                break;
        }
    }

    private static void Question01()
    {
        int indice = 13, soma = 0, k = 0;

        while (k < indice)
        {
            k++;
            soma += k;
        }

        Console.WriteLine($"O valor de soma é {soma}"); // 91
        ShowMenu();
    }

    private static void Question02()
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
        ShowMenu();
    }

    private static void Question05()
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
        ShowMenu();
    }
}
