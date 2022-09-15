string[] CreateArrayNoMore(string[] firstArray, int leng)
{
    int countString = 0;
    int[] apprIndex = new int[firstArray.Length];
    for (int i = 0, j = 0; i < firstArray.Length; i++)
    {
        if (String.IsNullOrEmpty(firstArray[i]) == true)
        {
            countString++;
            apprIndex[j] = i;
            j++;
        }
        else if (firstArray[i].Length <= leng)
        {
            countString++;
            apprIndex[j] = i;
            j++;
        }
    }
    string[] resultArray = new string[countString];
    if (countString > 0)
    {
        for (int i = 0; i < countString; i++)
                resultArray[i] = firstArray[apprIndex[i]];
    }
    return resultArray;
}

string[] StringToArray(string str, char separator)
{
    int countString = 1;
    for (int i = 0; i < str.Length; i++)
        if (str[i] == separator)
            countString++;
    string[] result = new string[countString];
    for (int i = 0, j = 0; i < str.Length; i++)
    {
        if (str[i] != separator)
            result[j] += str[i];
        else
        {
            i++;
            j++;
        }
    }
    return result;
}

string DeclareStringInput (string str)
{
    Console.Write(str);
    return Console.ReadLine();
}

void ShowArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.WriteLine(arr[i] + " ");
}

string inputString = DeclareStringInput("Введите массив в формате: a, bc, def, ...: ");
int countChar = 3;
char separ = ',';

Console.Write("Массив из строк не превышающих длину 3 символа:");
Console.WriteLine();
ShowArray(CreateArrayNoMore(StringToArray(inputString, separ), countChar));