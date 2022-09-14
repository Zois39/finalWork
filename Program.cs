string[] CreateArrayNoMoreThreeChar(string[] firstArray)
{
    int countString = 0;
    for (int i = 0; i < firstArray.Length; i++)
        if (firstArray[i].Length < 4)
            countString++;
    string[] resultArray = new string[countString];
    for (int i = 0, j = 0; i < firstArray.Length; i++)
        if (firstArray[i].Length < 4)
        {
            resultArray[j] = firstArray[i];
            j++;
        }
    return resultArray;
}
string[] firstArray = {"12", "34", "asfasf", "sf", "sfa"};
string[] aaa = CreateArrayNoMoreThreeChar(firstArray);
for (int i = 0; i < aaa.Length; i++)
    Console.Write(aaa[i] + " ");