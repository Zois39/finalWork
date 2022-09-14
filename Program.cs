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
    int countString = 0;
    int[] apprIndex = new int[str.Length];
    for (int i = 0, j = 0; i < str.Length; i++)
        if (str[i] == separator)
        {
            countString++;
            apprIndex[j] = i;
            j++;
        }
    string[] resultArray = new string[countString + 1];
    if (countString > 0)
    {
        if (apprIndex[0] > 0)
        {
            for (int i = 0; i < apprIndex[0]; i++)
                resultArray[0] += str[i];
        }
        else resultArray[0] = str;
        for (int i = 1; i < str.Length; i++)
            if (apprIndex[i] > 0)
                for (int j = apprIndex[i - 1] + 2; j < apprIndex[i]; j++)
                    resultArray[i] += str[j];
            else break;
    }
    return resultArray;
}

//string[] firstArray = {"12", "34", "asfasf", "sf", "sfa", "12", "34", "asfasf", "sf", "sfa", "12", "34", "asfasf", "sf", "sfa", "12", "34", "asfasf", "sf", "sfa", "12", "34", "asfasf", "sf", "sfa", "12", "34", "asfasf", "sf", "sfa", "12", "34", "asfasf", "sf", "sfa", "12", "34", "asfasf", "sf", "sfa"};
//string[] aaa = CreateArrayNoMoreThreeChar(firstArray);
//for (int i = 0; i < aaa.Length; i++)
//    Console.Write(aaa[i] + " ");
string[] str = StringToArray(Console.ReadLine(), Convert.ToChar(Console.ReadLine()));
for (int i = 0; i < str.Length; i++)
    Console.WriteLine(str[i] + " ");