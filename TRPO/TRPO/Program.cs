// Задача 1 работа 13

/*int k = int.Parse(Console.ReadLine());

for (int i = 1; i <= 110; i++)
{
    string s = i.ToString();
    int len = s.Length;

    if (k > len)
    {
        k -= len;
    }
    else
    {
        Console.WriteLine(s[k - 1]);
        return;
    }
}

Console.WriteLine("-1");*/

// Задача 2 работа 13

/*string input = Console.ReadLine();
if (input != null && input.Length % 2 != 0)
{
    Console.WriteLine("Ошибка: длина слова должна быть чётной.");
    return;
}

if (input != null)
{
    char[] chars = input.ToCharArray();
    for (int i = 0; i < chars.Length; i += 2)
    {
        (chars[i], chars[i + 1]) = (chars[i + 1], chars[i]);
    }

    Console.WriteLine(new string(chars));
}*/


// Задача 3 работа 13

/*string text = Console.ReadLine();
if (!string.IsNullOrEmpty(text))
{
    int maxLen = 0;
    int currLen = 0;

    foreach (char c in text)
    {
        if (char.IsLetter(c))
        {
            currLen++;
            if (currLen > maxLen)
                maxLen = currLen;
        }
        else
        {
            currLen = 0;
        }
    }

    Console.WriteLine(maxLen);
}*/

// Задача 1 работа 14

/*string word = Console.ReadLine();
if (!string.IsNullOrEmpty(word))
{
    if (word.Length < 5)
    {
        Console.WriteLine("Ошибка: слово должно содержать не менее пяти букв.");
        return;
    }

    char[] chars = word.ToCharArray();

    (chars[1], chars[4]) = (chars[4], chars[1]);

    Console.WriteLine(new string(chars));
}*/

// Задача 2 работа 14

/*string word = Console.ReadLine();
if (!string.IsNullOrEmpty(word))
{
    word = word.Replace("с", "");
    word = word.Replace("С", "");
    Console.WriteLine(word);
}*/


// Задача 3 работа 14

/*string source = Console.ReadLine();
string target = Console.ReadLine();
if (!string.IsNullOrEmpty(source) && !string.IsNullOrEmpty(target))
{
    if (source.Length != target.Length)
    {
        Console.WriteLine("Ошибка: слова разной длины.");
        return;
    }

    List<char> letters = new List<char>(source);

    var operations = new List<string>();

    for (int i = 0; i < letters.Count; i++)
    {
        if (letters[i] == target[i])
            continue;

        int j = letters.IndexOf(target[i], i + 1);
        if (j == -1)
        {
            Console.WriteLine("Ошибка: невозможная перестановка.");
            return;
        }

        while (j > i)
        {
            (letters[j], letters[j - 1]) = (letters[j - 1], letters[j]);

            operations.Add($"swap positions {j - 1} ↔ {j}");
            j--;
        }
    }

    Console.WriteLine("Результат: " + new string(letters.ToArray()));
}*/

// Задача 1 работа 15
