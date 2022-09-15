string[] CreateArrayNoMoreThreeChar(string[] firstArray)
{
    int countString = 0;
    int[] apprIndex = new int[firstArray.Length];
    for (int i = 0, j = 0; i < firstArray.Length; i++)
        if (firstArray[i].Length < 4)
        {
            countString++;
            apprIndex[j] = i;
            j++;
        }
    string[] resultArray = new string[countString];
    if (countString > 0)
    {
        resultArray[0] = firstArray[apprIndex[0]];
        for (int i = 1; i < firstArray.Length; i++)
        {
            if (apprIndex[i] > 0)
                resultArray[i] = firstArray[apprIndex[i]];
            else break;
        }
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
        if (str[i] != separator)
            result[j] += str[i];
        else
        {
            i++;
            j++;
        }
    return result;
}

string[] str = StringToArray(Console.ReadLine(), Convert.ToChar(Console.ReadLine()));
for (int i = 0; i < str.Length; i++)
    Console.WriteLine(str[i] + " ");
string[] aaa = CreateArrayNoMoreThreeChar(str);
for (int i = 0; i < aaa.Length; i++)
    Console.Write(aaa[i] + " ");