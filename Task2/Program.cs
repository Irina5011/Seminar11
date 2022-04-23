// Задача 2: Проверка на простое число:
// N = 13 -> "Это простое число"
// N = 12 -> “Это не простое число”

int A = Prompt("Введите ваше число на проверку = > ");

void Stepen(int A)
{
      bool prost = true;
    for (int i = 2; i <= A / 2; i++)
    {
        if (A % i == 0)
        {
            prost = false;
            break;
        }
    }
        if (prost)
        {
            Console.WriteLine("Ваше число слишком простое!!");
        }
        else
        {
            Console.WriteLine("Ваше число очень НЕ простое");
        }
}

int Prompt(string message)
{
    Console.Write(message);
    string strInput = Console.ReadLine();
    int answer = int.Parse(strInput);
    return answer;
}

Stepen(A);
