// Задача 1: Определите, является ли число степенью двойки:
// N = 16 -> "Является степень двойки"
// N = 12 -> “Не является степенью двойки”

int A = Prompt("Введите двойку = > ");
int B = Prompt("Введите Ваше число на проверку = > ");
int Stepen(int A)
{
    int i = 0;
    int ans = 1;
    for (A = 2; i < 10; i++)
    {  
        ans = ans * A;
        Console.Write(ans + " ");
        if (ans == B)
        Console.Write("Вот оно ваше число - это степень двойки ");
    }
    Console.Write("Ваше число не является степенью двойки ");
    return ans;
}

int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

Stepen(A);