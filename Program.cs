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
string[] firstArray = {"12", "34", "asfasf", "sf", "sfa", "12", "34", "asfasf", "sf", "sfa", "12", "34", "asfasf", "sf", "sfa", "12", "34", "asfasf", "sf", "sfa", "12", "34", "asfasf", "sf", "sfa", "12", "34", "asfasf", "sf", "sfa", "12", "34", "asfasf", "sf", "sfa", "12", "34", "asfasf", "sf", "sfa"};
string[] aaa = CreateArrayNoMoreThreeChar(firstArray);
for (int i = 0; i < aaa.Length; i++)
    Console.Write(aaa[i] + " ");